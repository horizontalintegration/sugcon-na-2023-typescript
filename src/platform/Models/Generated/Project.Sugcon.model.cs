// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessSiteItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite.IHeadlessSiteItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class HeadlessSite : CustomItem, IHeadlessSiteItem
	{
		public HeadlessSite(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Headless Site";
		public static ID ItemTemplateId => new ID("{0B72BF90-867B-421F-806F-34F5EE4E9C85}");
		
		public static implicit operator HeadlessSite(Item item) => item != null ? new HeadlessSite(item) : null;
		public static implicit operator Item(HeadlessSite customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessTenantItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite.IHeadlessTenantItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class HeadlessTenant : CustomItem, IHeadlessTenantItem
	{
		public HeadlessTenant(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Headless Tenant";
		public static ID ItemTemplateId => new ID("{66377999-0398-449B-BBEC-4886A0FE5703}");
		
		public ReferenceField PlaceholderSettingsFolderField => new ReferenceField(InnerItem.Fields[FieldConstants.PlaceholderSettingsFolder.Id]);
		public ReferenceField RenderingsFolderField => new ReferenceField(InnerItem.Fields[FieldConstants.RenderingsFolder.Id]);
		public static implicit operator HeadlessTenant(Item item) => item != null ? new HeadlessTenant(item) : null;
		public static implicit operator Item(HeadlessTenant customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct PlaceholderSettingsFolder
            {
		        public const string FieldName = "PlaceholderSettingsFolder";
		        public static readonly ID Id = new ID("{102B58DA-2A86-4953-B3CD-C9F91256B657}");
            }
            public struct RenderingsFolder
            {
		        public const string FieldName = "RenderingsFolder";
		        public static readonly ID Id = new ID("{853B245F-53E4-4EBE-BAB5-299F9DE314B6}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IJssSettingsItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite.IJssSettingsItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class JssSettings : CustomItem, IJssSettingsItem
	{
		public JssSettings(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "JSS Settings";
		public static ID ItemTemplateId => new ID("{7D3C4134-CB52-4DD8-931C-E3EF741F12A4}");
		
		public CheckboxField AnalyzeAllowedControlsField => new CheckboxField(InnerItem.Fields[FieldConstants.AnalyzeAllowedControls.Id]);
		public ReferenceField AppDatasourcesPathField => new ReferenceField(InnerItem.Fields[FieldConstants.AppDatasourcesPath.Id]);
		public ReferenceField AppTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.AppTemplate.Id]);
		public TextField DatasourceStrategyField => new TextField(InnerItem.Fields[FieldConstants.DatasourceStrategy.Id]);
		public CheckboxField DebugSecurityField => new CheckboxField(InnerItem.Fields[FieldConstants.DebugSecurity.Id]);
		public ReferenceField DefaultWorkflowField => new ReferenceField(InnerItem.Fields[FieldConstants.DefaultWorkflow.Id]);
		public TextField DeploymentSecretField => new TextField(InnerItem.Fields[FieldConstants.DeploymentSecret.Id]);
		public ReferenceField DictionaryDomainField => new ReferenceField(InnerItem.Fields[FieldConstants.DictionaryDomain.Id]);
		public ReferenceField DictionaryPathField => new ReferenceField(InnerItem.Fields[FieldConstants.DictionaryPath.Id]);
		public TextField FilesystemPathField => new TextField(InnerItem.Fields[FieldConstants.FilesystemPath.Id]);
		public ReferenceField FolderTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.FolderTemplate.Id]);
		public TextField GraphQlendpointField => new TextField(InnerItem.Fields[FieldConstants.GraphQlendpoint.Id]);
		public TextField ImportDatabaseField => new TextField(InnerItem.Fields[FieldConstants.ImportDatabase.Id]);
		public ReferenceField ImportDeviceField => new ReferenceField(InnerItem.Fields[FieldConstants.ImportDevice.Id]);
		public TextField ImportLanguageField => new TextField(InnerItem.Fields[FieldConstants.ImportLanguage.Id]);
		public TextField ImportUserField => new TextField(InnerItem.Fields[FieldConstants.ImportUser.Id]);
		public ReferenceField LayoutFolderTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.LayoutFolderTemplate.Id]);
		public ReferenceField LayoutPathField => new ReferenceField(InnerItem.Fields[FieldConstants.LayoutPath.Id]);
		public TextField LayoutServiceConfigurationField => new TextField(InnerItem.Fields[FieldConstants.LayoutServiceConfiguration.Id]);
		public ReferenceField LayoutTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.LayoutTemplate.Id]);
		public ReferenceField MediaLibraryFolderTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.MediaLibraryFolderTemplate.Id]);
		public TextField NameField => new TextField(InnerItem.Fields[FieldConstants.Name.Id]);
		public CheckboxField OptimizeImportIndexingField => new CheckboxField(InnerItem.Fields[FieldConstants.OptimizeImportIndexing.Id]);
		public ReferenceField PlaceholderSettingsFolderTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.PlaceholderSettingsFolderTemplate.Id]);
		public ReferenceField PlaceholdersPathField => new ReferenceField(InnerItem.Fields[FieldConstants.PlaceholdersPath.Id]);
		public CheckboxField ProtectDeveloperItemsField => new CheckboxField(InnerItem.Fields[FieldConstants.ProtectDeveloperItems.Id]);
		public ReferenceField RenderingsFolderTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.RenderingsFolderTemplate.Id]);
		public ReferenceField RenderingsPathField => new ReferenceField(InnerItem.Fields[FieldConstants.RenderingsPath.Id]);
		public ReferenceField RouteBaseTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.RouteBaseTemplate.Id]);
		public TextField RouteDatasourcesPathField => new TextField(InnerItem.Fields[FieldConstants.RouteDatasourcesPath.Id]);
		public TextField RouteTemplateNameField => new TextField(InnerItem.Fields[FieldConstants.RouteTemplateName.Id]);
		public TextField ServerBundleField => new TextField(InnerItem.Fields[FieldConstants.ServerBundle.Id]);
		public TextField ServerSideRenderingEngineField => new TextField(InnerItem.Fields[FieldConstants.ServerSideRenderingEngine.Id]);
		public TextField ServerSideRenderingEngineApplicationUrlField => new TextField(InnerItem.Fields[FieldConstants.ServerSideRenderingEngineApplicationUrl.Id]);
		public CheckboxField ServerSideRenderingEngineEditOnlyField => new CheckboxField(InnerItem.Fields[FieldConstants.ServerSideRenderingEngineEditOnly.Id]);
		public TextField ServerSideRenderingEngineEndpointUrlField => new TextField(InnerItem.Fields[FieldConstants.ServerSideRenderingEngineEndpointUrl.Id]);
		public TextField ServerSideRenderingFunctionNameField => new TextField(InnerItem.Fields[FieldConstants.ServerSideRenderingFunctionName.Id]);
		public TextField ServerSideRenderingWorkerProcessesField => new TextField(InnerItem.Fields[FieldConstants.ServerSideRenderingWorkerProcesses.Id]);
		public ReferenceField TemplateFolderTemplateField => new ReferenceField(InnerItem.Fields[FieldConstants.TemplateFolderTemplate.Id]);
		public CheckboxField UseLanguageSpecificLayoutField => new CheckboxField(InnerItem.Fields[FieldConstants.UseLanguageSpecificLayout.Id]);
		public static implicit operator JssSettings(Item item) => item != null ? new JssSettings(item) : null;
		public static implicit operator Item(JssSettings customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct AnalyzeAllowedControls
            {
		        public const string FieldName = "AnalyzeAllowedControls";
		        public static readonly ID Id = new ID("{812DEDEB-C5BD-471C-9F48-B1CE75D0D4A9}");
            }
            public struct AppDatasourcesPath
            {
		        public const string FieldName = "AppDatasourcesPath";
		        public static readonly ID Id = new ID("{5764D2D4-724D-4313-A81B-9246C911FAFF}");
            }
            public struct AppTemplate
            {
		        public const string FieldName = "AppTemplate";
		        public static readonly ID Id = new ID("{32CE6BBE-4217-46E5-9335-42793884CBE3}");
            }
            public struct DatasourceStrategy
            {
		        public const string FieldName = "DatasourceStrategy";
		        public static readonly ID Id = new ID("{F7C6ACFB-63F0-4ACA-9E44-3133B2B94A5B}");
            }
            public struct DebugSecurity
            {
		        public const string FieldName = "DebugSecurity";
		        public static readonly ID Id = new ID("{A5C4B74E-993A-40D6-AEAB-23BB12ABCF0A}");
            }
            public struct DefaultWorkflow
            {
		        public const string FieldName = "DefaultWorkflow";
		        public static readonly ID Id = new ID("{3AF0E329-6D5E-4D8F-9F82-F48265658A3E}");
            }
            public struct DeploymentSecret
            {
		        public const string FieldName = "DeploymentSecret";
		        public static readonly ID Id = new ID("{797D2F63-D5C4-4C4C-B21F-D3E250E2AB12}");
            }
            public struct DictionaryDomain
            {
		        public const string FieldName = "DictionaryDomain";
		        public static readonly ID Id = new ID("{0129DA3F-8C86-4591-AE32-6EC923413923}");
            }
            public struct DictionaryPath
            {
		        public const string FieldName = "DictionaryPath";
		        public static readonly ID Id = new ID("{A7BBAD73-B933-49FF-95C8-1C269CB35E7C}");
            }
            public struct FilesystemPath
            {
		        public const string FieldName = "FilesystemPath";
		        public static readonly ID Id = new ID("{72E83C8D-3578-4E50-B4C0-93A78A1729F2}");
            }
            public struct FolderTemplate
            {
		        public const string FieldName = "FolderTemplate";
		        public static readonly ID Id = new ID("{BDE120A5-4CC2-4340-9B63-562A139BF197}");
            }
            public struct GraphQlendpoint
            {
		        public const string FieldName = "GraphQLEndpoint";
		        public static readonly ID Id = new ID("{30E0A829-637E-478C-A136-66ADB568398D}");
            }
            public struct ImportDatabase
            {
		        public const string FieldName = "ImportDatabase";
		        public static readonly ID Id = new ID("{DF376030-46E9-4C77-BC05-DEBEFC86E3D5}");
            }
            public struct ImportDevice
            {
		        public const string FieldName = "ImportDevice";
		        public static readonly ID Id = new ID("{1F14AA04-2868-481F-9247-30DC5C65672C}");
            }
            public struct ImportLanguage
            {
		        public const string FieldName = "ImportLanguage";
		        public static readonly ID Id = new ID("{04E6B1F3-AE47-4D95-A154-2271075869A9}");
            }
            public struct ImportUser
            {
		        public const string FieldName = "ImportUser";
		        public static readonly ID Id = new ID("{F87F0D81-C32C-4C1D-8CAF-67856C3AB06E}");
            }
            public struct LayoutFolderTemplate
            {
		        public const string FieldName = "LayoutFolderTemplate";
		        public static readonly ID Id = new ID("{466902A9-6B16-41B1-9D33-7C55094A2713}");
            }
            public struct LayoutPath
            {
		        public const string FieldName = "LayoutPath";
		        public static readonly ID Id = new ID("{C8D002F9-9518-4C5E-9BAA-6617E13F0797}");
            }
            public struct LayoutServiceConfiguration
            {
		        public const string FieldName = "LayoutServiceConfiguration";
		        public static readonly ID Id = new ID("{E3259313-387A-41F0-B113-962F14B1AA2B}");
            }
            public struct LayoutTemplate
            {
		        public const string FieldName = "LayoutTemplate";
		        public static readonly ID Id = new ID("{E13C1A83-9D60-4530-B318-3A5EFFCC6338}");
            }
            public struct MediaLibraryFolderTemplate
            {
		        public const string FieldName = "MediaLibraryFolderTemplate";
		        public static readonly ID Id = new ID("{1CC82067-2B48-442A-A352-453D56A49D93}");
            }
            public struct Name
            {
		        public const string FieldName = "Name";
		        public static readonly ID Id = new ID("{3E4F559F-8E59-4405-B50D-619811371F6C}");
            }
            public struct OptimizeImportIndexing
            {
		        public const string FieldName = "OptimizeImportIndexing";
		        public static readonly ID Id = new ID("{4088F63E-09E5-43FA-AE99-829BD9BDC114}");
            }
            public struct PlaceholderSettingsFolderTemplate
            {
		        public const string FieldName = "PlaceholderSettingsFolderTemplate";
		        public static readonly ID Id = new ID("{F5594251-F757-429E-A9BD-07F65F6875B9}");
            }
            public struct PlaceholdersPath
            {
		        public const string FieldName = "PlaceholdersPath";
		        public static readonly ID Id = new ID("{5CA117EB-8782-4A4F-9F2F-30DE31FC2E34}");
            }
            public struct ProtectDeveloperItems
            {
		        public const string FieldName = "ProtectDeveloperItems";
		        public static readonly ID Id = new ID("{B0711DF7-724A-4C6C-8D4D-BE846DE6124C}");
            }
            public struct RenderingsFolderTemplate
            {
		        public const string FieldName = "RenderingsFolderTemplate";
		        public static readonly ID Id = new ID("{F5821C4C-226E-4953-8213-C0243826F85F}");
            }
            public struct RenderingsPath
            {
		        public const string FieldName = "RenderingsPath";
		        public static readonly ID Id = new ID("{F29428D5-1285-48B8-A884-44057965829A}");
            }
            public struct RouteBaseTemplate
            {
		        public const string FieldName = "RouteBaseTemplate";
		        public static readonly ID Id = new ID("{396AF2F6-FE48-4FD4-A7E2-3DA13EF977EB}");
            }
            public struct RouteDatasourcesPath
            {
		        public const string FieldName = "RouteDatasourcesPath";
		        public static readonly ID Id = new ID("{414F61DD-02C2-47D1-BA83-DCFBC3071E52}");
            }
            public struct RouteTemplateName
            {
		        public const string FieldName = "RouteTemplateName";
		        public static readonly ID Id = new ID("{300FB7A0-B27F-44DD-9AF0-B37A19723E0E}");
            }
            public struct ServerBundle
            {
		        public const string FieldName = "ServerBundle";
		        public static readonly ID Id = new ID("{4A3EEBA3-A250-44F4-BD97-6E863CC6F0D5}");
            }
            public struct ServerSideRenderingEngine
            {
		        public const string FieldName = "ServerSideRenderingEngine";
		        public static readonly ID Id = new ID("{9016141C-FF51-40F2-9135-40F5161B9784}");
            }
            public struct ServerSideRenderingEngineApplicationUrl
            {
		        public const string FieldName = "ServerSideRenderingEngineApplicationUrl";
		        public static readonly ID Id = new ID("{5E8ED724-126A-4BB7-8106-85C2D1042C9E}");
            }
            public struct ServerSideRenderingEngineEditOnly
            {
		        public const string FieldName = "ServerSideRenderingEngineEditOnly";
		        public static readonly ID Id = new ID("{557D5F36-6F2D-4EB6-A8CE-25F30F7B9397}");
            }
            public struct ServerSideRenderingEngineEndpointUrl
            {
		        public const string FieldName = "ServerSideRenderingEngineEndpointUrl";
		        public static readonly ID Id = new ID("{89849738-34EE-46BC-B525-825F1153189E}");
            }
            public struct ServerSideRenderingFunctionName
            {
		        public const string FieldName = "ServerSideRenderingFunctionName";
		        public static readonly ID Id = new ID("{7975673A-AAFD-4C5B-96A5-CBCAAC500A44}");
            }
            public struct ServerSideRenderingWorkerProcesses
            {
		        public const string FieldName = "ServerSideRenderingWorkerProcesses";
		        public static readonly ID Id = new ID("{6224A1CE-D964-4EE8-8E09-AD2F81E0A2B6}");
            }
            public struct TemplateFolderTemplate
            {
		        public const string FieldName = "TemplateFolderTemplate";
		        public static readonly ID Id = new ID("{218760C0-8001-4C2D-A8B0-61C128276F96}");
            }
            public struct UseLanguageSpecificLayout
            {
		        public const string FieldName = "UseLanguageSpecificLayout";
		        public static readonly ID Id = new ID("{1864E99D-C29A-40BF-96E0-B3E7896A013B}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPageDesignFolderItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.Folders.IPageDesignFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PageDesignFolder : CustomItem, IPageDesignFolderItem
	{
		public PageDesignFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Page Design Folder";
		public static ID ItemTemplateId => new ID("{38E4778C-018F-4C25-B0D3-A8696BFBC1EC}");
		
		public static implicit operator PageDesignFolder(Item item) => item != null ? new PageDesignFolder(item) : null;
		public static implicit operator Item(PageDesignFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPageDesignsItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.IPageDesignsItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PageDesigns : CustomItem, IPageDesignsItem
	{
		public PageDesigns(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Page Designs";
		public static ID ItemTemplateId => new ID("{99977167-F6EC-4DCB-B179-39065E1E59C6}");
		
		public static implicit operator PageDesigns(Item item) => item != null ? new PageDesigns(item) : null;
		public static implicit operator Item(PageDesigns customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPartialDesignFolderItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.Folders.IPartialDesignFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PartialDesignFolder : CustomItem, IPartialDesignFolderItem
	{
		public PartialDesignFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Partial Design Folder";
		public static ID ItemTemplateId => new ID("{1FF41E39-E31B-4C48-957B-9BE8CFD8471B}");
		
		public static implicit operator PartialDesignFolder(Item item) => item != null ? new PartialDesignFolder(item) : null;
		public static implicit operator Item(PartialDesignFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPartialDesignsItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.IPartialDesignsItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PartialDesigns : CustomItem, IPartialDesignsItem
	{
		public PartialDesigns(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Partial Designs";
		public static ID ItemTemplateId => new ID("{025BDD7B-554A-4B93-A30B-B83A6B5894A0}");
		
		public static implicit operator PartialDesigns(Item item) => item != null ? new PartialDesigns(item) : null;
		public static implicit operator Item(PartialDesigns customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Project.Sugcon
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ISugconPageItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite.IBasePageItem
	{
		TextField ContentField { get; }
		TextField TitleField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class SugconPage : CustomItem, ISugconPageItem
	{
		public SugconPage(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Sugcon Page";
		public static ID ItemTemplateId => new ID("{4A51367F-BFF4-4468-93C0-9227AE60C4A5}");
		
		public TextField ContentField => new TextField(InnerItem.Fields[FieldConstants.Content.Id]);
		public TextField TitleField => new TextField(InnerItem.Fields[FieldConstants.Title.Id]);
		public static implicit operator SugconPage(Item item) => item != null ? new SugconPage(item) : null;
		public static implicit operator Item(SugconPage customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Content
            {
		        public const string FieldName = "Content";
		        public static readonly ID Id = new ID("{1BD4F07A-DFA4-463D-B01B-F9C13FF596FD}");
            }
            public struct Title
            {
		        public const string FieldName = "Title";
		        public static readonly ID Id = new ID("{4DA86130-8D6B-4D4F-8E61-3426AB49905D}");
            }
            
		}
	}
}


