// Generates Typescript models
using System.Linq;
using System.Collections.Generic;

// Leprechaun provides the following:
// ConfigurationName - The @name from the Leprechaun element, or the "namespace" if not defined, from the Sitecore serialization config file
// GenericRootNamespace - The "rootNamespace" from the Leprechaun config file
// Templates - The templates from Sitecore
// Code - The output file writer
// Log - Logger to use during generation, output appears in the console

// Template information provided:
// TemplateInfo - Path, Id, Name, HelpText, BaseTemplateIds, OwnFields (Shouldn't need to be using this)
// RootNamespace - ???
// Path - Path from TemplateInfo
// Id - ID from TemplateInfo
// Name - Name from TemplateInfo
// HelpText - HelpText from TemplateInfo if defined, otherwise 'Represents the {Name} field ({Id}).'
// CodeName - A unique name for this template, usable as a name for a C# class. e.g. for "Foo Bar" this would be "FooBar"
// RelativeNamespace - Gets a namespace-formatted relative path from the root template path to this template
//                      e.g. if root is /Foo, and this template's path is /Foo/Bar/Baz/Quux, this would be "Bar.Baz"
// Namespace - Gets the full namespace for the template (e.g. RootNamespace.RelativeNamespace)
// FullTypeName - Gets the full type name, qualified by namespace, of this template
//                  e.g. RootNamespace.RelativeNamespace.CodeName
// OwnFields - The template's fields that should get passed to code generation
// BaseTemplates - All known immediate templates implemented by this type (transitive inheritance is not included eg a -> b -> c, will have b but not c for a)
// AllFields - All fields that make up this template, including all base templates' fields

// If true, all fields will be nullable and will force a null check.  
// This is recommended because it forces the developer to add null checks to 
// ensure that even if a template changed or an incorrect template was selected
// the page will not break completely.
const bool FORCE_FIELD_NULL_CHECK = true;

Log.Debug($"Emitting TypeScript interfaces for {ConfigurationName}...");

Code.AppendLine($@"
/**
 * <auto-generated>
 *     This code was generated by a tool.
 *
 *     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 * </auto-generated>
 */

{RenderImportStatements()}
{RenderTemplates()}
");
public string RenderImportStatements()
{
    var localCode = new System.Text.StringBuilder();

    var foundModules = new System.Collections.Generic.HashSet<string>();

    // localCode.AppendLine($@"// @ts-ignore ");
    // localCode.AppendLine(@"import { ItemExt } from '../lib/_.Sitecore.Override'");
    localCode.AppendLine($@"// @ts-ignore ");
    localCode.AppendLine($@"import {{ Field, ImageField, FileField, LinkField, Item }} from '@sitecore-jss/sitecore-jss-nextjs';");
    localCode.AppendLine($@"// @ts-ignore ");
    localCode.AppendLine($@"import {{ ComponentProps }} from '../lib/component-props';");

    foreach (var template in GetBaseTemplates(Templates))
    {
        var shortNameSpaceRoot = GetShortNameSpaceRoot(template);
        if (!foundModules.Contains(shortNameSpaceRoot))
        {
            foundModules.Add(shortNameSpaceRoot);
            var split = template.RootNamespace.Split('.');
            var layer = split[0];
            var module = split[1];
            localCode.AppendLine($@"// @ts-ignore ");
            localCode.AppendLine($@"import {{ {shortNameSpaceRoot} as {GetNameSpaceAlias(template)} }} from ""./{layer}.{module}.model""");
        }
    }

    return localCode.ToString();
}

public string RenderTemplates()
{
    var localCode = new System.Text.StringBuilder();

    var rootNs = Templates.FirstOrDefault()?.RootNamespace;
    // Render the Item mappings
    var oldNamespace = "";
    foreach (var template in Templates)
    {
        if (template.Namespace != oldNamespace)
        {
            // Close the old namespace so we can start a new one.
            if (!string.IsNullOrWhiteSpace(oldNamespace))
            {
                localCode.AppendLine($@"}}");
            }

            localCode.AppendLine($@"export namespace {GetShortNameSpace(template)} {{");
            oldNamespace = template.Namespace;
        }


        localCode.AppendLine($@"
    /**
    * Represents the template {template.Path}
    */
    export type {template.CodeName} = {RenderBaseInterfaces(template)} {{");
        localCode.AppendLine($@"        {RenderInterfaceFields(template)}");
        localCode.AppendLine($@"    }}");

        localCode.AppendLine($@"
    /**
    * Represents the GraphQL template {template.Path}
    */
    export type {template.CodeName}Json = {RenderBaseInterfaces(template, "Json")} {{");
        localCode.AppendLine($@"        {RenderInterfaceFields(template, true)}");
        localCode.AppendLine($@"    }}");


    }
    if (Templates.Any())
    {
        localCode.AppendLine($@"}}");
    }

    return localCode.ToString();
}

public string RenderBaseInterfaces(TemplateCodeGenerationMetadata template, string suffix = "")
{
    var bases = new System.Collections.Generic.List<string>(template.BaseTemplates.Count);

    foreach (var baseTemplate in template.BaseTemplates)
    {
        bases.Add(GetAliasedFullCodeName(baseTemplate, suffix));
    }

    return bases.Any() ? $"{string.Join(" & " + System.Environment.NewLine, bases)} & " : "";
}

public string RenderBaseClasses(TemplateCodeGenerationMetadata template)
{
    var bases = new System.Collections.Generic.List<string>(template.BaseTemplates.Count);

    foreach (var baseTemplate in template.BaseTemplates)
    {
        bases.Add(GetAliasedFullCodeName(baseTemplate, "Class"));
    }

    return bases.Any() ? $"extends {string.Join(", " + System.Environment.NewLine, bases)}" : "";
}
public string RenderInterfaceFields(TemplateCodeGenerationMetadata template, bool useJsonValue = false)
{
    var localCode = new System.Text.StringBuilder();

    var fieldsCode = new System.Text.StringBuilder();
    foreach (var field in template.OwnFields)
    {
        var fieldType = GetFieldType(field);

        if (useJsonValue)
        {
            fieldType = $@"{{
                jsonValue: {fieldType}
            }}";
        }
        fieldsCode.AppendLine($@"
            /**
            * {field.HelpText}
            */
            {GetFieldCodeName(field)}{GetNullable(field)}: {fieldType};");
    }
    if (IncludeChildren(template))
    {
        fieldsCode.AppendLine($@"
            /**
            * Child items
            */
            children? : Item[];");
    }
    if (useJsonValue)
    {
        localCode.AppendLine($@"{fieldsCode}");
    }
    else
    {
        localCode.AppendLine($@"fields?: {{ {fieldsCode}        }}");
    }


    return localCode.ToString();
}


public string RenderParamsFields(TemplateCodeGenerationMetadata template)
{
    var localCode = new System.Text.StringBuilder();

    // Rendering parameters are always strings
    foreach (var field in template.OwnFields)
    {
        localCode.AppendLine($@"
            /**
            * {field.HelpText}
            */
            public get {GetFieldCodeName(field)}() {{
                const value = this.params.{GetFieldCodeName(field)};
                if (!value) {{
                    return null;
                }}
                return {GetParseMethod(field)};
            }}");
    }

    return localCode.ToString();
}

public string GetAliasedFullCodeName(TemplateCodeGenerationMetadata template, string suffix = "")
{
    var nameSpace = template.RelativeNamespace.Replace(GetShortNameSpaceRoot(template), GetNameSpaceAlias(template));
    return $@"{nameSpace}.{template.CodeName}{suffix}";
}

public string GetFieldCodeName(TemplateFieldCodeGenerationMetadata field, string suffix = "")
{
    // Check if field name needs to be quoted and add quotes as needed
    var name = System.Text.RegularExpressions.Regex.IsMatch(field.Name, "[ -]+") ? $"\"{field.Name}{suffix}\"" : field.Name + suffix;
    return name;
}

public string GetNullable(TemplateFieldCodeGenerationMetadata field)
{
    // Item reference fields will return null if it is blank, but all other types will not be null    
    if (GetFieldType(field) == "Item" || FORCE_FIELD_NULL_CHECK)
    {
        return "?";
    }
    return "";
}

public string GetFieldType(TemplateFieldCodeGenerationMetadata field)
{
    switch (field.Type.ToLower())
    {
        //case "tristate":
        //    return "TriState";
        case "checkbox":
            return "Field<boolean>";

        case "date":
        case "datetime":
            return "Field<string>";

        case "number":
            return "Field<number>";

        case "integer":
            return "Field<number>";

        case "multiroot treelist":
        case "multilist with search":
        case "treelist":
        case "treelistex":
        case "treelist descriptive":
        case "checklist":
        case "multilist":
            return "Item[]";
        case "grouped droplink":
        case "droplink":
        case "lookup":
        case "droptree":
        case "reference":
        case "tree":
            return "Item";

        case "file":
            return "FileField";

        case "image":
            return "ImageField";

        case "rich text":
        case "html":
            return "Field<string>";

        case "general link":
            return "LinkField";

        case "single-line text":
        case "multi-line text":
        case "frame":
        case "text":
        case "memo":
        case "droplist":
        case "grouped droplist":
        case "valuelookup":
            return "Field<string>";
        default:
            return "Field<string>";
    }
}


public string GetParseMethod(TemplateFieldCodeGenerationMetadata field)
{
    switch (field.Type.ToLower())
    {
        //case "tristate":
        //    return "TriState";
        case "checkbox":
            return "value?.toLowerCase() === 'true' || value?.toLowerCase() === '1'";
        case "date":
        case "datetime":
            return $@"new Date(value.substring(0, 4) 
    + '-' + value.substring(4, 6)
    + '-' + value.substring(6, 11)
    + ':' + value.substring(11, 13)
    + ':' + value.substring(13, 16))";

        case "number":
            return "parseFloat(value)";

        case "integer":
            return "parseInt(value)";

        case "multiroot treelist":
        case "multilist with search":
        case "treelist":
        case "treelistex":
        case "treelist descriptive":
        case "checklist":
        case "multilist":
            return "value.split('|')";
        case "grouped droplink":
        case "droplink":
        case "lookup":
        case "droptree":
        case "reference":
        case "tree":
        case "file":
        case "image":
        case "rich text":
        case "html":
        case "general link":
        case "single-line text":
        case "multi-line text":
        case "frame":
        case "text":
        case "memo":
        case "droplist":
        case "grouped droplist":
        case "valuelookup":
        default:
            return "value";
    }
}

public string GetNameSpaceAlias(TemplateCodeGenerationMetadata template)
{
    var split = template.RootNamespace.Split('.');
    var layer = split[0];
    var module = split[1];

    var currNamespace = GetShortNameSpaceRoot(template);

    return $@"{layer}{module}{currNamespace}";
}

public string GetShortNameSpaceRoot(TemplateCodeGenerationMetadata template)
{
    var currNamespace = GetShortNameSpace(template).Split('.').First();
    return currNamespace;
}

public string GetShortNameSpace(TemplateCodeGenerationMetadata template)
{
    var shortNameSpace = template.RelativeNamespace;

    if (string.IsNullOrWhiteSpace(shortNameSpace))
    {
        return template.Namespace;
    }
    return shortNameSpace;
}

public bool IsOrInheritsFromTemplate(TemplateCodeGenerationMetadata template, string templateId)
{
    var isTemplate = template.Id == System.Guid.Parse(templateId);

    if (isTemplate)
    {
        return true;
    }

    foreach (var baseTemplate in template.BaseTemplates)
    {
        if (IsOrInheritsFromTemplate(baseTemplate, templateId))
        {
            return true;
        }
    }

    return false;
}

public List<TemplateCodeGenerationMetadata> GetBaseTemplates(IEnumerable<TemplateCodeGenerationMetadata> templates, List<TemplateCodeGenerationMetadata> foundTemplates = null)
{
    if (foundTemplates == null)
    {
        foundTemplates = new List<TemplateCodeGenerationMetadata>();
    }

    foreach (var template in templates)
    {
        if (!foundTemplates.Any(_ => _.Id == template.Id))
        {
            foundTemplates.Add(template);
            GetBaseTemplates(template.BaseTemplates, foundTemplates);
        }
    }

    return foundTemplates;
}

/// <summary>
/// We are using a custom base template "_RenderWithChildren" to indicate that this template
/// should include the children when being rendered.  When using this on your own project
/// replace the GUID with your GUID.
/// </summary>
public bool IncludeChildren(TemplateCodeGenerationMetadata template)
{
    return template.Id == System.Guid.Parse("{75848221-862F-48ED-83D1-AF13ED1C2CD7}");
}