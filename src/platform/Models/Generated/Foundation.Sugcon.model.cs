// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Platform.Models.Generated.Foundation.Sugcon.Base
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IBaseRenderingParamsItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class BaseRenderingParams : CustomItem, IBaseRenderingParamsItem
	{
		public BaseRenderingParams(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "_Base Rendering Params";
		public static ID ItemTemplateId => new ID("{0CD007DD-B31D-4E56-91D7-FBD7D55330B3}");
		
		public static implicit operator BaseRenderingParams(Item item) => item != null ? new BaseRenderingParams(item) : null;
		public static implicit operator Item(BaseRenderingParams customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

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


