// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageStructure.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IContainerItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
		ImageField BackgroundImageField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Container : CustomItem, IContainerItem
	{
		public Container(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Container";
		public static ID ItemTemplateId => new ID("{45130BDB-BAE3-4EDC-AEA8-7B68B9D94C7F}");
		
		public ImageField BackgroundImageField => new ImageField(InnerItem.Fields[FieldConstants.BackgroundImage.Id]);
		public static implicit operator Container(Item item) => item != null ? new Container(item) : null;
		public static implicit operator Item(Container customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct BackgroundImage
            {
		        public const string FieldName = "BackgroundImage";
		        public static readonly ID Id = new ID("{6845679D-E298-4E94-96EB-230CB7C3BAAE}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Media
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IImageItem
	{
		ImageField ImageField { get; }
		TextField ImageCaptionField { get; }
		LinkField TargetUrlField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Image : CustomItem, IImageItem
	{
		public Image(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Image";
		public static ID ItemTemplateId => new ID("{D885DF8C-B2D6-4007-B34B-2BBAFB527304}");
		
		public ImageField ImageField => new ImageField(InnerItem.Fields[FieldConstants.Image.Id]);
		public TextField ImageCaptionField => new TextField(InnerItem.Fields[FieldConstants.ImageCaption.Id]);
		public LinkField TargetUrlField => new LinkField(InnerItem.Fields[FieldConstants.TargetUrl.Id]);
		public static implicit operator Image(Item item) => item != null ? new Image(item) : null;
		public static implicit operator Item(Image customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Image
            {
		        public const string FieldName = "Image";
		        public static readonly ID Id = new ID("{57CAF172-CE57-4E48-B3A1-46F8AEA71C08}");
            }
            public struct ImageCaption
            {
		        public const string FieldName = "ImageCaption";
		        public static readonly ID Id = new ID("{4D7B05D0-0300-486F-8F87-57DE34A9B793}");
            }
            public struct TargetUrl
            {
		        public const string FieldName = "TargetUrl";
		        public static readonly ID Id = new ID("{75FBF1B1-E7C5-494B-9633-693909F79425}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Media.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IImageItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Image : CustomItem, IImageItem
	{
		public Image(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Image";
		public static ID ItemTemplateId => new ID("{15185B0E-6418-4449-9F93-4FF03B7EE032}");
		
		public static implicit operator Image(Item item) => item != null ? new Image(item) : null;
		public static implicit operator Item(Image customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Media
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IImageFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class ImageFolder : CustomItem, IImageFolderItem
	{
		public ImageFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Image Folder";
		public static ID ItemTemplateId => new ID("{F7A45276-87F1-4EA5-BF25-E3C7CB7AA993}");
		
		public static implicit operator ImageFolder(Item item) => item != null ? new ImageFolder(item) : null;
		public static implicit operator Item(ImageFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Navigation.Datasource
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ILinkItem
	{
		LinkField LinkField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Link : CustomItem, ILinkItem
	{
		public Link(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Link";
		public static ID ItemTemplateId => new ID("{6F108E3C-5D57-42F8-A910-C22920269B0A}");
		
		public LinkField LinkField => new LinkField(InnerItem.Fields[FieldConstants.Link.Id]);
		public static implicit operator Link(Item item) => item != null ? new Link(item) : null;
		public static implicit operator Item(Link customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Link
            {
		        public const string FieldName = "Link";
		        public static readonly ID Id = new ID("{68C2A603-F98E-42A3-BE2D-DD70598C2A63}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Navigation.Datasource
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ILinkListItem
	{
		TextField TitleField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class LinkList : CustomItem, ILinkListItem
	{
		public LinkList(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Link List";
		public static ID ItemTemplateId => new ID("{60C9AC62-4227-443E-8980-92C97E483832}");
		
		public TextField TitleField => new TextField(InnerItem.Fields[FieldConstants.Title.Id]);
		public static implicit operator LinkList(Item item) => item != null ? new LinkList(item) : null;
		public static implicit operator Item(LinkList customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Title
            {
		        public const string FieldName = "Title";
		        public static readonly ID Id = new ID("{DC9AAEE9-FC44-458D-A9FB-BAC61D8B0234}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Navigation.Datasource
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ILinkListFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class LinkListFolder : CustomItem, ILinkListFolderItem
	{
		public LinkListFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Link List Folder";
		public static ID ItemTemplateId => new ID("{C237D144-647A-4AFE-AA7B-1570F3E3F139}");
		
		public static implicit operator LinkListFolder(Item item) => item != null ? new LinkListFolder(item) : null;
		public static implicit operator Item(LinkListFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Navigation.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ILinkListItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class LinkList : CustomItem, ILinkListItem
	{
		public LinkList(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "LinkList";
		public static ID ItemTemplateId => new ID("{33C9207E-3B04-4606-8EF5-4CA99A97C776}");
		
		public static implicit operator LinkList(Item item) => item != null ? new LinkList(item) : null;
		public static implicit operator Item(LinkList customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.Navigation.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface INavigationItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Navigation : CustomItem, INavigationItem
	{
		public Navigation(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Navigation";
		public static ID ItemTemplateId => new ID("{9CE34BF9-5C93-4DFF-841D-8F649C2BD6C8}");
		
		public static implicit operator Navigation(Item item) => item != null ? new Navigation(item) : null;
		public static implicit operator Item(Navigation customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPageContentItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PageContent : CustomItem, IPageContentItem
	{
		public PageContent(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Page Content";
		public static ID ItemTemplateId => new ID("{EF87E73B-C7FF-49A2-AC59-9B0BE83755C3}");
		
		public static implicit operator PageContent(Item item) => item != null ? new PageContent(item) : null;
		public static implicit operator Item(PageContent customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPromoItem
	{
		ImageField PromoIconField { get; }
		ImageField PromoIcon2Field { get; }
		LinkField PromoLinkField { get; }
		TextField PromoTextField { get; }
		TextField PromoText2Field { get; }
		TextField PromoText3Field { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Promo : CustomItem, IPromoItem
	{
		public Promo(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Promo";
		public static ID ItemTemplateId => new ID("{DFED4457-D760-457A-BEC1-C0DCCDC44381}");
		
		public ImageField PromoIconField => new ImageField(InnerItem.Fields[FieldConstants.PromoIcon.Id]);
		public ImageField PromoIcon2Field => new ImageField(InnerItem.Fields[FieldConstants.PromoIcon2.Id]);
		public LinkField PromoLinkField => new LinkField(InnerItem.Fields[FieldConstants.PromoLink.Id]);
		public TextField PromoTextField => new TextField(InnerItem.Fields[FieldConstants.PromoText.Id]);
		public TextField PromoText2Field => new TextField(InnerItem.Fields[FieldConstants.PromoText2.Id]);
		public TextField PromoText3Field => new TextField(InnerItem.Fields[FieldConstants.PromoText3.Id]);
		public static implicit operator Promo(Item item) => item != null ? new Promo(item) : null;
		public static implicit operator Item(Promo customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct PromoIcon
            {
		        public const string FieldName = "PromoIcon";
		        public static readonly ID Id = new ID("{F94B9858-C439-4291-863B-757B536C8B65}");
            }
            public struct PromoIcon2
            {
		        public const string FieldName = "PromoIcon2";
		        public static readonly ID Id = new ID("{739C6CC2-0031-463D-9599-13478FD50EE3}");
            }
            public struct PromoLink
            {
		        public const string FieldName = "PromoLink";
		        public static readonly ID Id = new ID("{EF24BED2-46AB-4D53-AD1A-1019935A4E89}");
            }
            public struct PromoText
            {
		        public const string FieldName = "PromoText";
		        public static readonly ID Id = new ID("{28079F3A-896B-4273-BE5F-59D0EBB7CD7D}");
            }
            public struct PromoText2
            {
		        public const string FieldName = "PromoText2";
		        public static readonly ID Id = new ID("{1F66862D-A5E3-405F-8E3E-B787B4C39B12}");
            }
            public struct PromoText3
            {
		        public const string FieldName = "PromoText3";
		        public static readonly ID Id = new ID("{C6E604C3-5371-4E67-83DF-A09A5EA66249}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPromoItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Promo : CustomItem, IPromoItem
	{
		public Promo(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Promo";
		public static ID ItemTemplateId => new ID("{881869CA-7F58-45EA-8B34-AD1BFD3551A8}");
		
		public static implicit operator Promo(Item item) => item != null ? new Promo(item) : null;
		public static implicit operator Item(Promo customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPromoFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PromoFolder : CustomItem, IPromoFolderItem
	{
		public PromoFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Promo Folder";
		public static ID ItemTemplateId => new ID("{8FE7F8DC-CB5D-42C2-99F8-76608C243F10}");
		
		public static implicit operator PromoFolder(Item item) => item != null ? new PromoFolder(item) : null;
		public static implicit operator Item(PromoFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IRichTextItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class RichText : CustomItem, IRichTextItem
	{
		public RichText(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Rich Text";
		public static ID ItemTemplateId => new ID("{0F3B7336-6112-418C-8BBA-B0526F3887CE}");
		
		public static implicit operator RichText(Item item) => item != null ? new RichText(item) : null;
		public static implicit operator Item(RichText customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ITextItem
	{
		TextField TextField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Text : CustomItem, ITextItem
	{
		public Text(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Text";
		public static ID ItemTemplateId => new ID("{0A7AA373-5ED1-4E9B-9678-22D3C5FAF6DF}");
		
		public TextField TextField => new TextField(InnerItem.Fields[FieldConstants.Text.Id]);
		public static implicit operator Text(Item item) => item != null ? new Text(item) : null;
		public static implicit operator Item(Text customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Text
            {
		        public const string FieldName = "Text";
		        public static readonly ID Id = new ID("{729034FC-24F3-40B7-8FA4-FB49D7DE20DD}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ITextFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class TextFolder : CustomItem, ITextFolderItem
	{
		public TextFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Text Folder";
		public static ID ItemTemplateId => new ID("{B762D567-87F5-493C-BB48-0C455D834457}");
		
		public static implicit operator TextFolder(Item item) => item != null ? new TextFolder(item) : null;
		public static implicit operator Item(TextFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Feature.JssExperienceAccelerator.PageContent.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ITitleItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters.IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Title : CustomItem, ITitleItem
	{
		public Title(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Title";
		public static ID ItemTemplateId => new ID("{A82E8931-0575-4175-917D-E904EF7E6DBE}");
		
		public static implicit operator Title(Item item) => item != null ? new Title(item) : null;
		public static implicit operator Item(Title customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}


