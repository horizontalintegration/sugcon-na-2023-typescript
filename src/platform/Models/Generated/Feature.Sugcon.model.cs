// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Platform.Models.Generated.Feature.Sugcon.Listing.CardListing
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ICardItemItem
	{
		LinkField CtaField { get; }
		TextField HeadlineField { get; }
		ImageField ImageField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class CardItem : CustomItem, ICardItemItem
	{
		public CardItem(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Card Item";
		public static ID ItemTemplateId => new ID("{DBAEEFBE-0C61-423B-BA96-98B58614C2A2}");
		
		public LinkField CtaField => new LinkField(InnerItem.Fields[FieldConstants.Cta.Id]);
		public TextField HeadlineField => new TextField(InnerItem.Fields[FieldConstants.Headline.Id]);
		public ImageField ImageField => new ImageField(InnerItem.Fields[FieldConstants.Image.Id]);
		public static implicit operator CardItem(Item item) => item != null ? new CardItem(item) : null;
		public static implicit operator Item(CardItem customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Cta
            {
		        public const string FieldName = "cta";
		        public static readonly ID Id = new ID("{7A5B4674-7A28-42FE-8F8E-E86C5DCBD049}");
            }
            public struct Headline
            {
		        public const string FieldName = "headline";
		        public static readonly ID Id = new ID("{9CAFA07D-4FDB-4741-90DA-F7B1392458C8}");
            }
            public struct Image
            {
		        public const string FieldName = "image";
		        public static readonly ID Id = new ID("{AF087590-B739-434A-B9C2-954BD816AE59}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.Sugcon.Listing.CardListing
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ICardListingItem : global::Platform.Models.Generated.Foundation.Sugcon.Utility.IRenderWithChildrenItem
	{
		TextField HeadlineField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class CardListing : CustomItem, ICardListingItem
	{
		public CardListing(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Card Listing";
		public static ID ItemTemplateId => new ID("{10138CF5-9AC5-4992-95A6-23A9B4CC98B0}");
		
		public TextField HeadlineField => new TextField(InnerItem.Fields[FieldConstants.Headline.Id]);
		public static implicit operator CardListing(Item item) => item != null ? new CardListing(item) : null;
		public static implicit operator Item(CardListing customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Headline
            {
		        public const string FieldName = "headline";
		        public static readonly ID Id = new ID("{639981F4-6EB4-4F0C-B309-50476EE79B3E}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.Sugcon.Listing.CardListing
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ICardListingParamsItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
		TextField CardsPerRowField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class CardListingParams : CustomItem, ICardListingParamsItem
	{
		public CardListingParams(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Card Listing Params";
		public static ID ItemTemplateId => new ID("{2F4B70D0-231D-4B39-9B6B-F4D82F6EF4AE}");
		
		public TextField CardsPerRowField => new TextField(InnerItem.Fields[FieldConstants.CardsPerRow.Id]);
		public static implicit operator CardListingParams(Item item) => item != null ? new CardListingParams(item) : null;
		public static implicit operator Item(CardListingParams customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct CardsPerRow
            {
		        public const string FieldName = "cardsPerRow";
		        public static readonly ID Id = new ID("{E3688FD5-09AB-4913-963E-1D9D6EF7D86C}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.Sugcon.General.CustomContentBlock
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ICustomContentBlockItem
	{
		TextField ContentField { get; }
		LinkField CtaField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class CustomContentBlock : CustomItem, ICustomContentBlockItem
	{
		public CustomContentBlock(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Custom Content Block";
		public static ID ItemTemplateId => new ID("{2B9CADF2-A466-44AF-909F-D49D10C57BF5}");
		
		public TextField ContentField => new TextField(InnerItem.Fields[FieldConstants.Content.Id]);
		public LinkField CtaField => new LinkField(InnerItem.Fields[FieldConstants.Cta.Id]);
		public static implicit operator CustomContentBlock(Item item) => item != null ? new CustomContentBlock(item) : null;
		public static implicit operator Item(CustomContentBlock customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Content
            {
		        public const string FieldName = "content";
		        public static readonly ID Id = new ID("{071C1B0A-C007-4DB9-8C80-59142A7B98EC}");
            }
            public struct Cta
            {
		        public const string FieldName = "cta";
		        public static readonly ID Id = new ID("{5F226AFD-DF82-425B-9F57-8C3DB9B6F488}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.Sugcon.General.CustomContentBlock
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ICustomContentBlockParamsItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
		DateField TestDateField { get; }
		ImageField TestImageField { get; }
		LinkField TestLinkField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class CustomContentBlockParams : CustomItem, ICustomContentBlockParamsItem
	{
		public CustomContentBlockParams(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Custom Content Block Params";
		public static ID ItemTemplateId => new ID("{3228313E-325F-4ADF-AFD3-B16C5C3DA60D}");
		
		public DateField TestDateField => new DateField(InnerItem.Fields[FieldConstants.TestDate.Id]);
		public ImageField TestImageField => new ImageField(InnerItem.Fields[FieldConstants.TestImage.Id]);
		public LinkField TestLinkField => new LinkField(InnerItem.Fields[FieldConstants.TestLink.Id]);
		public static implicit operator CustomContentBlockParams(Item item) => item != null ? new CustomContentBlockParams(item) : null;
		public static implicit operator Item(CustomContentBlockParams customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct TestDate
            {
		        public const string FieldName = "testDate";
		        public static readonly ID Id = new ID("{2A1145FF-4E62-4569-89C4-3AB23029BD17}");
            }
            public struct TestImage
            {
		        public const string FieldName = "testImage";
		        public static readonly ID Id = new ID("{AFE4EC52-A73B-4B07-BA75-D52E3D9EE891}");
            }
            public struct TestLink
            {
		        public const string FieldName = "testLink";
		        public static readonly ID Id = new ID("{1EB6AFE8-B764-4D5C-979A-27C1D5B4583C}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.Sugcon.Listing.PageListing
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPageListingItem
	{
		TextField LevelsField { get; }
		ReferenceField RootPageField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PageListing : CustomItem, IPageListingItem
	{
		public PageListing(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Page Listing";
		public static ID ItemTemplateId => new ID("{424A1312-E34E-44EA-AF8D-0910572EFDAC}");
		
		public TextField LevelsField => new TextField(InnerItem.Fields[FieldConstants.Levels.Id]);
		public ReferenceField RootPageField => new ReferenceField(InnerItem.Fields[FieldConstants.RootPage.Id]);
		public static implicit operator PageListing(Item item) => item != null ? new PageListing(item) : null;
		public static implicit operator Item(PageListing customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Levels
            {
		        public const string FieldName = "levels";
		        public static readonly ID Id = new ID("{CE387C4E-2018-4D19-BA73-D043825B0F74}");
            }
            public struct RootPage
            {
		        public const string FieldName = "rootPage";
		        public static readonly ID Id = new ID("{E74C3459-D157-4210-AD64-978D04A5FA3F}");
            }
            
		}
	}
}


