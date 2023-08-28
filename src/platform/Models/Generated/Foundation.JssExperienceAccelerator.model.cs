// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IAddItemItem
	{
		MultilistField LocationField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class AddItem : CustomItem, IAddItemItem
	{
		public AddItem(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "AddItem";
		public static ID ItemTemplateId => new ID("{3AEA335C-D06D-45B1-841A-CBC8D2D1CE40}");
		
		public MultilistField LocationField => new MultilistField(InnerItem.Fields[FieldConstants.Location.Id]);
		public static implicit operator AddItem(Item item) => item != null ? new AddItem(item) : null;
		public static implicit operator Item(AddItem customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Location
            {
		        public const string FieldName = "Location";
		        public static readonly ID Id = new ID("{52C91C75-6698-4701-A8A2-242ACE59A8D6}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IAddItemItem
	{
		MultilistField LocationField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class AddItem : CustomItem, IAddItemItem
	{
		public AddItem(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "AddItem";
		public static ID ItemTemplateId => new ID("{1E1B739E-C378-4909-941D-171ACA7362E5}");
		
		public MultilistField LocationField => new MultilistField(InnerItem.Fields[FieldConstants.Location.Id]);
		public static implicit operator AddItem(Item item) => item != null ? new AddItem(item) : null;
		public static implicit operator Item(AddItem customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Location
            {
		        public const string FieldName = "Location";
		        public static readonly ID Id = new ID("{49ED6C70-37BD-4A23-AF04-209806605B7F}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.AvailableRenderings
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IAvailableRenderingsFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class AvailableRenderingsFolder : CustomItem, IAvailableRenderingsFolderItem
	{
		public AvailableRenderingsFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Available Renderings Folder";
		public static ID ItemTemplateId => new ID("{26EC1D18-11B2-4DD9-8326-F6115F4FD7EB}");
		
		public static implicit operator AvailableRenderingsFolder(Item item) => item != null ? new AvailableRenderingsFolder(item) : null;
		public static implicit operator Item(AvailableRenderingsFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IBasePageItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class BasePage : CustomItem, IBasePageItem
	{
		public BasePage(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Base Page";
		public static ID ItemTemplateId => new ID("{47151711-26CA-434E-8132-D3E0B7D26683}");
		
		public static implicit operator BasePage(Item item) => item != null ? new BasePage(item) : null;
		public static implicit operator Item(BasePage customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.RenderingParameters
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IBaseRenderingParametersItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class BaseRenderingParameters : CustomItem, IBaseRenderingParametersItem
	{
		public BaseRenderingParameters(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "BaseRenderingParameters";
		public static ID ItemTemplateId => new ID("{4247AAD4-EBDE-4994-998F-E067A51B1FE4}");
		
		public static implicit operator BaseRenderingParameters(Item item) => item != null ? new BaseRenderingParameters(item) : null;
		public static implicit operator Item(BaseRenderingParameters customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IEditSiteItemItem
	{
		MultilistField TemplateField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class EditSiteItem : CustomItem, IEditSiteItemItem
	{
		public EditSiteItem(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "EditSiteItem";
		public static ID ItemTemplateId => new ID("{F040DB03-87FE-4E10-AE40-53C63175E31B}");
		
		public MultilistField TemplateField => new MultilistField(InnerItem.Fields[FieldConstants.Template.Id]);
		public static implicit operator EditSiteItem(Item item) => item != null ? new EditSiteItem(item) : null;
		public static implicit operator Item(EditSiteItem customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Template
            {
		        public const string FieldName = "Template";
		        public static readonly ID Id = new ID("{0916832D-459E-463C-852B-C538476A422D}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IEditTenantTemplateItem
	{
		MultilistField TemplateField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class EditTenantTemplate : CustomItem, IEditTenantTemplateItem
	{
		public EditTenantTemplate(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "EditTenantTemplate";
		public static ID ItemTemplateId => new ID("{88752F77-9109-424C-B1D8-AF91E6369A2E}");
		
		public MultilistField TemplateField => new MultilistField(InnerItem.Fields[FieldConstants.Template.Id]);
		public static implicit operator EditTenantTemplate(Item item) => item != null ? new EditTenantTemplate(item) : null;
		public static implicit operator Item(EditTenantTemplate customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Template
            {
		        public const string FieldName = "Template";
		        public static readonly ID Id = new ID("{67B6641E-309D-4C1E-8E97-63965C7E2C5F}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IExecuteScriptItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class ExecuteScript : CustomItem, IExecuteScriptItem
	{
		public ExecuteScript(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "ExecuteScript";
		public static ID ItemTemplateId => new ID("{BC9BB684-36DF-4285-888B-D8B4D87B10DE}");
		
		public static implicit operator ExecuteScript(Item item) => item != null ? new ExecuteScript(item) : null;
		public static implicit operator Item(ExecuteScript customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IExecuteScriptItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class ExecuteScript : CustomItem, IExecuteScriptItem
	{
		public ExecuteScript(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "ExecuteScript";
		public static ID ItemTemplateId => new ID("{3A385B25-DF9B-47AC-9F6B-39C8534E81F1}");
		
		public static implicit operator ExecuteScript(Item item) => item != null ? new ExecuteScript(item) : null;
		public static implicit operator Item(ExecuteScript customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessSiteItem
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
		public static ID ItemTemplateId => new ID("{9ED66404-64C9-4122-90E1-869CB3CEA566}");
		
		public static implicit operator HeadlessSite(Item item) => item != null ? new HeadlessSite(item) : null;
		public static implicit operator Item(HeadlessSite customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessTenantItem : global::Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite.Base.IBaseJssTenantItem
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
		public static ID ItemTemplateId => new ID("{B91811F1-FA8B-47F8-B131-BD2C6D5EC805}");
		
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

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Roots
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessSiteSetupRootItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class HeadlessSiteSetupRoot : CustomItem, IHeadlessSiteSetupRootItem
	{
		public HeadlessSiteSetupRoot(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "HeadlessSiteSetupRoot";
		public static ID ItemTemplateId => new ID("{BED31D6F-D968-45A9-B54E-12D7F977D861}");
		
		public static implicit operator HeadlessSiteSetupRoot(Item item) => item != null ? new HeadlessSiteSetupRoot(item) : null;
		public static implicit operator Item(HeadlessSiteSetupRoot customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Roots
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessTenantSetupRootItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class HeadlessTenantSetupRoot : CustomItem, IHeadlessTenantSetupRootItem
	{
		public HeadlessTenantSetupRoot(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "HeadlessTenantSetupRoot";
		public static ID ItemTemplateId => new ID("{F036B5E0-37FB-4537-9D36-EF84E5BD41B7}");
		
		public static implicit operator HeadlessTenantSetupRoot(Item item) => item != null ? new HeadlessTenantSetupRoot(item) : null;
		public static implicit operator Item(HeadlessTenantSetupRoot customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.HeadlessVariants
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessVariantsItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class HeadlessVariants : CustomItem, IHeadlessVariantsItem
	{
		public HeadlessVariants(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "HeadlessVariants";
		public static ID ItemTemplateId => new ID("{49C111D0-6867-4798-A724-1F103166E6E9}");
		
		public static implicit operator HeadlessVariants(Item item) => item != null ? new HeadlessVariants(item) : null;
		public static implicit operator Item(HeadlessVariants customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.HeadlessVariants
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IHeadlessVariantsGroupingItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class HeadlessVariantsGrouping : CustomItem, IHeadlessVariantsGroupingItem
	{
		public HeadlessVariantsGrouping(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "HeadlessVariantsGrouping";
		public static ID ItemTemplateId => new ID("{DA26C636-96E1-45E4-88D6-3FCEC70D5699}");
		
		public static implicit operator HeadlessVariantsGrouping(Item item) => item != null ? new HeadlessVariantsGrouping(item) : null;
		public static implicit operator Item(HeadlessVariantsGrouping customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IInputValidationStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class InputValidationStep : CustomItem, IInputValidationStepItem
	{
		public InputValidationStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "InputValidationStep";
		public static ID ItemTemplateId => new ID("{9EDED2F7-F847-4893-8A0B-F69E7FCF3593}");
		
		public static implicit operator InputValidationStep(Item item) => item != null ? new InputValidationStep(item) : null;
		public static implicit operator Item(InputValidationStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IInputValidationStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class InputValidationStep : CustomItem, IInputValidationStepItem
	{
		public InputValidationStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "InputValidationStep";
		public static ID ItemTemplateId => new ID("{D028FEF2-BABF-4AD1-BBE7-4D62A977992F}");
		
		public static implicit operator InputValidationStep(Item item) => item != null ? new InputValidationStep(item) : null;
		public static implicit operator Item(InputValidationStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IJssDataItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class JssData : CustomItem, IJssDataItem
	{
		public JssData(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "JSS Data";
		public static ID ItemTemplateId => new ID("{A29D272E-9D48-453C-9E9D-B47585FA7F20}");
		
		public static implicit operator JssData(Item item) => item != null ? new JssData(item) : null;
		public static implicit operator Item(JssData customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IJssSettingsItem
	{
		CheckboxField AnalyzeAllowedControlsField { get; }
		ReferenceField AppDatasourcesPathField { get; }
		ReferenceField AppTemplateField { get; }
		TextField DatasourceStrategyField { get; }
		CheckboxField DebugSecurityField { get; }
		ReferenceField DefaultWorkflowField { get; }
		TextField DeploymentSecretField { get; }
		ReferenceField DictionaryDomainField { get; }
		ReferenceField DictionaryPathField { get; }
		TextField FilesystemPathField { get; }
		ReferenceField FolderTemplateField { get; }
		TextField GraphQlendpointField { get; }
		TextField ImportDatabaseField { get; }
		ReferenceField ImportDeviceField { get; }
		TextField ImportLanguageField { get; }
		TextField ImportUserField { get; }
		ReferenceField LayoutFolderTemplateField { get; }
		ReferenceField LayoutPathField { get; }
		TextField LayoutServiceConfigurationField { get; }
		ReferenceField LayoutTemplateField { get; }
		ReferenceField MediaLibraryFolderTemplateField { get; }
		TextField NameField { get; }
		CheckboxField OptimizeImportIndexingField { get; }
		ReferenceField PlaceholderSettingsFolderTemplateField { get; }
		ReferenceField PlaceholdersPathField { get; }
		CheckboxField ProtectDeveloperItemsField { get; }
		ReferenceField RenderingsFolderTemplateField { get; }
		ReferenceField RenderingsPathField { get; }
		ReferenceField RouteBaseTemplateField { get; }
		TextField RouteDatasourcesPathField { get; }
		TextField RouteTemplateNameField { get; }
		TextField ServerBundleField { get; }
		TextField ServerSideRenderingEngineField { get; }
		TextField ServerSideRenderingEngineApplicationUrlField { get; }
		CheckboxField ServerSideRenderingEngineEditOnlyField { get; }
		TextField ServerSideRenderingEngineEndpointUrlField { get; }
		TextField ServerSideRenderingFunctionNameField { get; }
		TextField ServerSideRenderingWorkerProcessesField { get; }
		ReferenceField TemplateFolderTemplateField { get; }
		CheckboxField UseLanguageSpecificLayoutField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class JssSettings : CustomItem, IJssSettingsItem
	{
		public JssSettings(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "JSS Settings";
		public static ID ItemTemplateId => new ID("{EC848505-D30C-4BDC-A0AA-7CC9D320085E}");
		
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

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IJssSiteFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class JssSiteFolder : CustomItem, IJssSiteFolderItem
	{
		public JssSiteFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "JSS Site Folder";
		public static ID ItemTemplateId => new ID("{CE91FBD6-4D89-42C9-B5BC-2A670439E1FF}");
		
		public static implicit operator JssSiteFolder(Item item) => item != null ? new JssSiteFolder(item) : null;
		public static implicit operator Item(JssSiteFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IJssSiteGroupingItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class JssSiteGrouping : CustomItem, IJssSiteGroupingItem
	{
		public JssSiteGrouping(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "JSS Site Grouping";
		public static ID ItemTemplateId => new ID("{8357F958-9AAA-46DB-8898-36448A96356F}");
		
		public static implicit operator JssSiteGrouping(Item item) => item != null ? new JssSiteGrouping(item) : null;
		public static implicit operator Item(JssSiteGrouping customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IJssTenantFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class JssTenantFolder : CustomItem, IJssTenantFolderItem
	{
		public JssTenantFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "JSS Tenant Folder";
		public static ID ItemTemplateId => new ID("{CA170F6F-5EC2-4E0C-B4BB-C77B7931B168}");
		
		public static implicit operator JssTenantFolder(Item item) => item != null ? new JssTenantFolder(item) : null;
		public static implicit operator Item(JssTenantFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPageDesignItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PageDesign : CustomItem, IPageDesignItem
	{
		public PageDesign(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Page Design";
		public static ID ItemTemplateId => new ID("{1105B8F8-1E00-426B-BF1F-C840742D827B}");
		
		public static implicit operator PageDesign(Item item) => item != null ? new PageDesign(item) : null;
		public static implicit operator Item(PageDesign customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.Folders
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPageDesignFolderItem
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
		public static ID ItemTemplateId => new ID("{023F5D48-979D-4381-BC5E-149E36ABD3BD}");
		
		public static implicit operator PageDesignFolder(Item item) => item != null ? new PageDesignFolder(item) : null;
		public static implicit operator Item(PageDesignFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPageDesignsItem
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
		public static ID ItemTemplateId => new ID("{DAAF41FD-96DB-4892-BE99-F62F16D036C4}");
		
		public static implicit operator PageDesigns(Item item) => item != null ? new PageDesigns(item) : null;
		public static implicit operator Item(PageDesigns customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPartialDesignItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PartialDesign : CustomItem, IPartialDesignItem
	{
		public PartialDesign(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Partial Design";
		public static ID ItemTemplateId => new ID("{FD2059FD-6043-4DFE-8C04-E2437CE87634}");
		
		public static implicit operator PartialDesign(Item item) => item != null ? new PartialDesign(item) : null;
		public static implicit operator Item(PartialDesign customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation.Folders
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPartialDesignFolderItem
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
		public static ID ItemTemplateId => new ID("{25F01F50-5534-44F9-B1BA-BCBB60B2D13D}");
		
		public static implicit operator PartialDesignFolder(Item item) => item != null ? new PartialDesignFolder(item) : null;
		public static implicit operator Item(PartialDesignFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPartialDesignsItem
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
		public static ID ItemTemplateId => new ID("{79C9FA01-5F6A-48B2-B459-05BBAA826A9D}");
		
		public static implicit operator PartialDesigns(Item item) => item != null ? new PartialDesigns(item) : null;
		public static implicit operator Item(PartialDesigns customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.PlaceholderSettings
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPlaceholderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Placeholder : CustomItem, IPlaceholderItem
	{
		public Placeholder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Placeholder";
		public static ID ItemTemplateId => new ID("{D2A6884C-04D5-4089-A64E-D27CA9D68D4C}");
		
		public static implicit operator Placeholder(Item item) => item != null ? new Placeholder(item) : null;
		public static implicit operator Item(Placeholder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.PlaceholderSettings
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPlaceholderSettingsFolderItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PlaceholderSettingsFolder : CustomItem, IPlaceholderSettingsFolderItem
	{
		public PlaceholderSettingsFolder(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Placeholder Settings Folder";
		public static ID ItemTemplateId => new ID("{52288E39-7830-4694-B62D-32A54C6EF7BA}");
		
		public static implicit operator PlaceholderSettingsFolder(Item item) => item != null ? new PlaceholderSettingsFolder(item) : null;
		public static implicit operator Item(PlaceholderSettingsFolder customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPostDeleteStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PostDeleteStep : CustomItem, IPostDeleteStepItem
	{
		public PostDeleteStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PostDeleteStep";
		public static ID ItemTemplateId => new ID("{B2085789-5385-4138-83F0-96F3767CB156}");
		
		public static implicit operator PostDeleteStep(Item item) => item != null ? new PostDeleteStep(item) : null;
		public static implicit operator Item(PostDeleteStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPostDeleteStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PostDeleteStep : CustomItem, IPostDeleteStepItem
	{
		public PostDeleteStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PostDeleteStep";
		public static ID ItemTemplateId => new ID("{78D6EC9B-66E3-4763-9870-03CF314EE37A}");
		
		public static implicit operator PostDeleteStep(Item item) => item != null ? new PostDeleteStep(item) : null;
		public static implicit operator Item(PostDeleteStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPostSetupStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PostSetupStep : CustomItem, IPostSetupStepItem
	{
		public PostSetupStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PostSetupStep";
		public static ID ItemTemplateId => new ID("{8FF2FEBF-F6D2-461D-9ED3-8B0CB5D9D86F}");
		
		public static implicit operator PostSetupStep(Item item) => item != null ? new PostSetupStep(item) : null;
		public static implicit operator Item(PostSetupStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPostSetupStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PostSetupStep : CustomItem, IPostSetupStepItem
	{
		public PostSetupStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PostSetupStep";
		public static ID ItemTemplateId => new ID("{0C602893-2BE9-4020-912D-56AF21DEFF73}");
		
		public static implicit operator PostSetupStep(Item item) => item != null ? new PostSetupStep(item) : null;
		public static implicit operator Item(PostSetupStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPreDeleteStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PreDeleteStep : CustomItem, IPreDeleteStepItem
	{
		public PreDeleteStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PreDeleteStep";
		public static ID ItemTemplateId => new ID("{52510F54-9EC5-464C-B075-EF44B5C2F96B}");
		
		public static implicit operator PreDeleteStep(Item item) => item != null ? new PreDeleteStep(item) : null;
		public static implicit operator Item(PreDeleteStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPreDeleteStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PreDeleteStep : CustomItem, IPreDeleteStepItem
	{
		public PreDeleteStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PreDeleteStep";
		public static ID ItemTemplateId => new ID("{ADB13651-2EB9-494F-ADA0-0DFDA0B2EBBF}");
		
		public static implicit operator PreDeleteStep(Item item) => item != null ? new PreDeleteStep(item) : null;
		public static implicit operator Item(PreDeleteStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Site
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPreDeleteValidationStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PreDeleteValidationStep : CustomItem, IPreDeleteValidationStepItem
	{
		public PreDeleteValidationStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PreDeleteValidationStep";
		public static ID ItemTemplateId => new ID("{408FD8AB-1667-440B-A605-1370DDF0A51F}");
		
		public static implicit operator PreDeleteValidationStep(Item item) => item != null ? new PreDeleteValidationStep(item) : null;
		public static implicit operator Item(PreDeleteValidationStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding.Actions.Tenant
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPreDeleteValidationStepItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class PreDeleteValidationStep : CustomItem, IPreDeleteValidationStepItem
	{
		public PreDeleteValidationStep(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "PreDeleteValidationStep";
		public static ID ItemTemplateId => new ID("{EDF1FA42-06C4-4703-AB1A-F23495BC6D8F}");
		
		public static implicit operator PreDeleteValidationStep(Item item) => item != null ? new PreDeleteValidationStep(item) : null;
		public static implicit operator Item(PreDeleteValidationStep customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IPresentationItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Presentation : CustomItem, IPresentationItem
	{
		public Presentation(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Presentation";
		public static ID ItemTemplateId => new ID("{0A70FA73-8923-4A6E-ABF3-4134F25F3221}");
		
		public static implicit operator Presentation(Item item) => item != null ? new Presentation(item) : null;
		public static implicit operator Item(Presentation customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IRenderingHostItem
	{
		TextField AppNameField { get; }
		TextField ServerSideRenderingEngineApplicationUrlField { get; }
		TextField ServerSideRenderingEngineEndpointUrlField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class RenderingHost : CustomItem, IRenderingHostItem
	{
		public RenderingHost(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "RenderingHost";
		public static ID ItemTemplateId => new ID("{BC71D442-3E4F-46BA-887C-746E54F9BB83}");
		
		public TextField AppNameField => new TextField(InnerItem.Fields[FieldConstants.AppName.Id]);
		public TextField ServerSideRenderingEngineApplicationUrlField => new TextField(InnerItem.Fields[FieldConstants.ServerSideRenderingEngineApplicationUrl.Id]);
		public TextField ServerSideRenderingEngineEndpointUrlField => new TextField(InnerItem.Fields[FieldConstants.ServerSideRenderingEngineEndpointUrl.Id]);
		public static implicit operator RenderingHost(Item item) => item != null ? new RenderingHost(item) : null;
		public static implicit operator Item(RenderingHost customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct AppName
            {
		        public const string FieldName = "AppName";
		        public static readonly ID Id = new ID("{3121C257-53CF-464A-B736-98B418876057}");
            }
            public struct ServerSideRenderingEngineApplicationUrl
            {
		        public const string FieldName = "ServerSideRenderingEngineApplicationUrl";
		        public static readonly ID Id = new ID("{E32C1801-79B3-4FC1-A9C4-3C6E6C2968AE}");
            }
            public struct ServerSideRenderingEngineEndpointUrl
            {
		        public const string FieldName = "ServerSideRenderingEngineEndpointUrl";
		        public static readonly ID Id = new ID("{FC76919B-0D7C-4732-865D-2AF795FB38A4}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Presentation
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ISxaJssLayoutItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class SxaJssLayout : CustomItem, ISxaJssLayoutItem
	{
		public SxaJssLayout(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "SXA JSS Layout";
		public static ID ItemTemplateId => new ID("{E4E11508-04A4-4B0B-A263-5201F811C9CD}");
		
		public static implicit operator SxaJssLayout(Item item) => item != null ? new SxaJssLayout(item) : null;
		public static implicit operator Item(SxaJssLayout customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ISharedSitesSettingsItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class SharedSitesSettings : CustomItem, ISharedSitesSettingsItem
	{
		public SharedSitesSettings(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Shared Sites Settings";
		public static ID ItemTemplateId => new ID("{C14BF746-030F-4E59-8594-395F6D299E61}");
		
		public static implicit operator SharedSitesSettings(Item item) => item != null ? new SharedSitesSettings(item) : null;
		public static implicit operator Item(SharedSitesSettings customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ISiteItem
	{
		TextField RenderingHostField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Site : CustomItem, ISiteItem
	{
		public Site(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Site";
		public static ID ItemTemplateId => new ID("{E46F3AF2-39FA-4866-A157-7017C4B2A40C}");
		
		public TextField RenderingHostField => new TextField(InnerItem.Fields[FieldConstants.RenderingHost.Id]);
		public static implicit operator Site(Item item) => item != null ? new Site(item) : null;
		public static implicit operator Item(Site customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct RenderingHost
            {
		        public const string FieldName = "RenderingHost";
		        public static readonly ID Id = new ID("{F57099A3-526A-49F2-AEBD-635453E48875}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.SiteMetadata
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ISitemapSettingsItem
	{
		CheckboxField GenerateSitemapMediaItemsField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class SitemapSettings : CustomItem, ISitemapSettingsItem
	{
		public SitemapSettings(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Sitemap Settings";
		public static ID ItemTemplateId => new ID("{C71D8566-35C8-49B7-A84D-9D176E9CBD05}");
		
		public CheckboxField GenerateSitemapMediaItemsField => new CheckboxField(InnerItem.Fields[FieldConstants.GenerateSitemapMediaItems.Id]);
		public static implicit operator SitemapSettings(Item item) => item != null ? new SitemapSettings(item) : null;
		public static implicit operator Item(SitemapSettings customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct GenerateSitemapMediaItems
            {
		        public const string FieldName = "GenerateSitemapMediaItems";
		        public static readonly ID Id = new ID("{7F070BC5-5CD4-474F-AA2F-AB2A0A128F00}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Scaffolding
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ISolutionTemplateItem
	{
		CheckboxField EnabledField { get; }
		TextField NameField { get; }
		MultilistField SiteModulesField { get; }
		MultilistField TenantModulesField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class SolutionTemplate : CustomItem, ISolutionTemplateItem
	{
		public SolutionTemplate(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Solution template";
		public static ID ItemTemplateId => new ID("{1B2DFD3B-F2F2-4F40-A75C-F6C2490919C4}");
		
		public CheckboxField EnabledField => new CheckboxField(InnerItem.Fields[FieldConstants.Enabled.Id]);
		public TextField NameField => new TextField(InnerItem.Fields[FieldConstants.Name.Id]);
		public MultilistField SiteModulesField => new MultilistField(InnerItem.Fields[FieldConstants.SiteModules.Id]);
		public MultilistField TenantModulesField => new MultilistField(InnerItem.Fields[FieldConstants.TenantModules.Id]);
		public static implicit operator SolutionTemplate(Item item) => item != null ? new SolutionTemplate(item) : null;
		public static implicit operator Item(SolutionTemplate customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct Enabled
            {
		        public const string FieldName = "Enabled";
		        public static readonly ID Id = new ID("{0D21F818-1938-4CD8-B0A8-A44F73D69367}");
            }
            public struct Name
            {
		        public const string FieldName = "Name";
		        public static readonly ID Id = new ID("{82E64B52-0B8A-4A38-8C78-530C5493814E}");
            }
            public struct SiteModules
            {
		        public const string FieldName = "Site Modules";
		        public static readonly ID Id = new ID("{C262443B-653D-461D-96C8-7CFAA0EF2B2D}");
            }
            public struct TenantModules
            {
		        public const string FieldName = "Tenant Modules";
		        public static readonly ID Id = new ID("{41AC536A-923A-43F9-AC87-F3993F638125}");
            }
            
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.HeadlessVariants
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IVariantDefinitionItem
	{
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class VariantDefinition : CustomItem, IVariantDefinitionItem
	{
		public VariantDefinition(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Variant Definition";
		public static ID ItemTemplateId => new ID("{4D50CDAE-C2D9-4DE8-B080-8F992BFB1B55}");
		
		public static implicit operator VariantDefinition(Item item) => item != null ? new VariantDefinition(item) : null;
		public static implicit operator Item(VariantDefinition customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			
		}
	}
}

namespace Platform.Models.Generated.Foundation.JssExperienceAccelerator.Multisite.Base
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IBaseJssTenantItem
	{
		ReferenceField PlaceholderSettingsFolderField { get; }
		ReferenceField RenderingsFolderField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class BaseJssTenant : CustomItem, IBaseJssTenantItem
	{
		public BaseJssTenant(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "_Base JSS Tenant";
		public static ID ItemTemplateId => new ID("{053E9155-3993-42F3-9182-5854DC5355B3}");
		
		public ReferenceField PlaceholderSettingsFolderField => new ReferenceField(InnerItem.Fields[FieldConstants.PlaceholderSettingsFolder.Id]);
		public ReferenceField RenderingsFolderField => new ReferenceField(InnerItem.Fields[FieldConstants.RenderingsFolder.Id]);
		public static implicit operator BaseJssTenant(Item item) => item != null ? new BaseJssTenant(item) : null;
		public static implicit operator Item(BaseJssTenant customItem) => customItem?.InnerItem;
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


