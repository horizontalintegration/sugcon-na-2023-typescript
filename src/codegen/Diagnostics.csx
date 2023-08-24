// Generates Constants for TemplateIDs

using System;
using System.Linq;
using System.Collections.Generic;

Log.Debug($"Emitting Debug for {ConfigurationName}...");

readonly Guid BaseWorkflowId = Guid.Parse("2FBA75FE88DC45E8A63A0C99B1E58356");

var failedTemplates = new List<TemplateCodeGenerationMetadata>();

foreach (var template in Templates)
{
    var dict = new Dictionary<Guid, TemplateCodeGenerationMetadata>();
    AddAllBaseTemplates(template, dict);
    
    if (dict.ContainsKey(BaseWorkflowId))
    {
        if (TemplateShouldNotInheritBaseWorkflow(template))
        {
            Code.AppendLine($@"
CodeGenCheckFailed_SeeCommentBelowForErrorDetails

// {template.Name} ({template.Id}) SHOULD NOT inherit from Base Workflow. See TemplateShouldNotInheritBaseWorkflow method in `bed\Horizontal.Jss\CodeGen\Diagnostics.csx`.
");
        }
    }
    else
    {
        if (!IsExemptedTemplate(template))
        {
            failedTemplates.Add(template);
        }
    }
}


if (failedTemplates.Any())
{
    Code.AppendLine($@"

ForceTypeScriptCompileFail

// Templates must inherit from `/sitecore/templates/Foundation/Horizontal/Jss/Core/Workflow/_Base Workflow` (Either directly or indirectly)
// Ensure that all templates have the correct inheritance.
// Components (generally templates in `/sitecore/templates/Feature/Horizontal/Jss/Components`) should inherit from `_Base Component`.
// Data (generally templates in `/sitecore/templates/Feature/Horizontal/Jss/Data`) should inherit from `_Base Data`.
// Pages (generally templates in `/sitecore/templates/Project/Horizontal/Jss/Routes`) should inherit from `_Base Page`.
//
// If the template intentionally does not inherit from Base Workflow, add it to the IsExemptedTemplate method in `bed\Horizontal.Jss\CodeGen\Diagnostics.csx`.
//
// The following templates do not inherit from Base Workflow: 
");

    foreach (var failedTemplate in failedTemplates)
    {
        Code.AppendLine($@"// {failedTemplate.Path} ({failedTemplate.Id})");
    }
    
}



public bool TemplateShouldNotInheritBaseWorkflow(TemplateCodeGenerationMetadata template)
{
    // Flags and Folders should not go through workflow
    return template.CodeName.EndsWith("Folder") ||
           template.CodeName.EndsWith("Flag") ||
           template.CodeName.EndsWith("Type") ||
           template.CodeName.EndsWith("Settings");
}
public bool IsExemptedTemplate(TemplateCodeGenerationMetadata template)
{
    // Base templates may optionally inherit from Base Workflow
    return TemplateShouldNotInheritBaseWorkflow(template) ||
           template.CodeName.StartsWith("Base");
}

public void AddAllBaseTemplates(TemplateCodeGenerationMetadata template, Dictionary<Guid, TemplateCodeGenerationMetadata> currentDictionary)
{
    currentDictionary[template.Id] = template;
    foreach (var baseTemplate in template.BaseTemplates)
    {
        AddAllBaseTemplates(baseTemplate, currentDictionary);
    }
}