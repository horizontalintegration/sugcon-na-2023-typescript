// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Platform.Models.Generated.Foundation.Sugcon.Utility
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IRenderWithChildrenItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class RenderWithChildren : CustomItem, IRenderWithChildrenItem
	{
		public RenderWithChildren(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "_RenderWithChildren";
		public static ID ItemTemplateId => new ID("{75848221-862F-48ED-83D1-AF13ED1C2CD7}");
		
		public static implicit operator RenderWithChildren(Item item) => item != null ? new RenderWithChildren(item) : null;
		public static implicit operator Item(RenderWithChildren customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}


