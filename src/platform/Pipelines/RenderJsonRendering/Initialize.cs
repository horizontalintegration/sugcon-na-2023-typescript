using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Platform.Serialization;
using Sitecore.Abstractions;
using Sitecore.Collections;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering;
using Sitecore.LayoutService.Presentation.Pipelines.RenderJsonRendering;
using Sitecore.LayoutService.Serialization;
using Sitecore.Mvc.Presentation;
using Version = Sitecore.Data.Version;

namespace Platform.Pipelines.RenderJsonRendering
{
    // ReSharper disable once UnusedMember.Global
    public class Initialize : Sitecore.XA.Feature.LayoutServices.Integration.Pipelines.RenderJsonRendering.Initialize
    {
        private const string StandardRenderingParametersTemplateId = "{8CA06D6A-B353-44E8-BC31-B528C7306971}";
        IRenderingConfiguration _renderingConfiguration;

        public Initialize(IConfiguration configuration, BaseCorePipelineManager pipelineManager) : base(configuration, pipelineManager) { }

        protected override RenderedJsonRendering CreateResultInstance(RenderJsonRenderingArgs args)
        {
            _renderingConfiguration = args.RenderingConfiguration;

            var result = base.CreateResultInstance(args);

            result.RenderingParams = SerializeRenderingParams(args.Rendering);

            return result;
        }


        protected virtual IDictionary<string, string> SerializeRenderingParams(Rendering rendering)
        {
            // To serialize our rendering parameters we first need to create a fake item out of the parameters
            // So we can serialize that item.

            // Get the params as a dictionary.
            var paramDictionary = rendering.Parameters.ToDictionary(pair => pair.Key, pair => pair.Value);

            // Get the template of the rendering parameters for the item
            var template = GetRenderingParametersTemplate(rendering.RenderingItem.InnerItem);

            // Create a list of fields for our fake item.
            var fieldList = new FieldList();

            // Create a fake item because it's needed to create a fake field.
            var fakeParamItem = GetFakeParamItem(template, fieldList, rendering.RenderingItem.Database);

            // Rendering parameters can't be editing inline.
            var serializationOptions = new SerializationOptions { DisableEditing = true };

            // Loop through each parameter
            foreach (var kvp in paramDictionary.ToList())
            {
                var fieldName = kvp.Key;
                var fieldValue = kvp.Value;

                // Does the field exist on the template?  We need a field in order to get a type.
                var templateFieldItem = template.GetField(fieldName);
                if (templateFieldItem == null)
                {
                    // If not, go to the next parameter
                    continue;
                }

                // Create a field based on the template and our fake item
                var field = new Field(templateFieldItem.ID, fakeParamItem);

                // Add the field data to that item's field list.
                // We can't add to the item directly but we can add to the field list we passed when creating the item
                fieldList.Add(field.ID, fieldValue);

                // If we're using our custom serializer, we exposed a `SerializeField` method that's normally protected.
                if (_renderingConfiguration.ItemSerializer is CustomSxaItemSerializer customSxaItemSerializer)
                {
                    var parametersField = new ParametersField(field, false);
                    
                    // Serialize the field
                    var serializedField = customSxaItemSerializer.SerializeField(parametersField, serializationOptions);

                    var obj = JObject.Parse(serializedField);

                    paramDictionary[fieldName] = obj[fieldName]?.ToString();
                }
                // Otherwise if this field is a guid,
                else if (ID.TryParse(fieldValue, out var itemId))
                {
                    var item = rendering.RenderingItem.Database.GetItem(itemId);

                    paramDictionary[fieldName] = _renderingConfiguration.ItemSerializer.Serialize(item, serializationOptions);
                }
                else
                {
                    try
                    {
                        var ids = IdList.Parse(fieldValue);
                        var data = ids.Select(rendering.RenderingItem.Database.GetItem)
                            .Select(x => _renderingConfiguration.ItemSerializer.Serialize(x, serializationOptions))
                            .ToList();
                        paramDictionary[fieldName] = $"[{string.Join(", ", data)}]";
                    }
                    catch (InvalidCastException)
                    {
                        // Do nothing
                    }
                }
            }
            return paramDictionary;
        }

        private static Item GetFakeParamItem(TemplateItem template, FieldList fieldList, Database database)
        {
            var itemDefinition = new ItemDefinition(ID.Undefined, "temp", template.ID, ID.Undefined);

            var itemData = new ItemData(itemDefinition, Language.Current, Version.First, fieldList);

            var fakeParamItem = new Item(ID.NewID, itemData, database);

            return fakeParamItem;
        }

        /// <summary>
        /// Gets the standard values item from parameters template.
        /// </summary>
        /// <param name="renderingItem">The rendering item.</param>
        /// <returns>The standard values item from parameters template.</returns>
        public static TemplateItem GetRenderingParametersTemplate(Item renderingItem)
        {
            var id = renderingItem["Parameters Template"];
            if (string.IsNullOrEmpty(id))
            {
                id = StandardRenderingParametersTemplateId;
            }

            TemplateItem templateItem = renderingItem.Database.GetItem(new ID(id), renderingItem.Language);

            return templateItem;
        }
    }
}
