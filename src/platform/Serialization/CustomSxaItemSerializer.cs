using System.Linq;
using Newtonsoft.Json.Linq;
using Platform.Models.Generated.Foundation.Sugcon.Utility;
using Sitecore.Data.Items;
using Sitecore.LayoutService.Helpers;
using Sitecore.LayoutService.Serialization;
using Sitecore.LayoutService.Serialization.ItemSerializers;
using Sitecore.LayoutService.Serialization.Pipelines.GetFieldSerializer;
using Sitecore.Links;
using Sitecore.XA.Foundation.SitecoreExtensions.Extensions;
using Sitecore.XA.JSS.Foundation.Presentation.Serialization;

namespace Platform.Serialization
{
    public class CustomSxaItemSerializer : SxaItemSerializer
    {
        public CustomSxaItemSerializer(IGetFieldSerializerPipeline getFieldSerializerPipeline) : base(getFieldSerializerPipeline)
        {
        }
        protected override string SerializeItem(Item item, SerializationOptions options)
        {
            var baseResult = base.SerializeItem(item, options);
            if (item.InheritsFrom(RenderWithChildren.ItemTemplateId))
            {
                var baseJObject = JObject.Parse(baseResult);
                var childrenJObjects = item.Children.Select(x => GetItemJson(x, options));
                baseJObject["children"] = new JArray(childrenJObjects);
                return baseJObject.ToString();
            }

            return baseResult;
        }
        public JObject GetItemJson(Item item, SerializationOptions options)
        {
            var fields = JObject.Parse(SerializeItem(item, options));
            var obj = new JObject
            {
                ["id"] = item.ID.Guid.ToString(),
                ["templateId"] = item.TemplateID.Guid.ToString(),
                ["url"] = LinkManager.GetItemUrl(item, ItemUrlHelper.GetLayoutServiceUrlOptions()),
                ["name"] = item.Name,
                ["displayName"] = item.DisplayName,
                ["fields"] = fields
            };
            

            return obj;
        }
    }
}