
/**
 * <auto-generated>
 *     This code was generated by a tool.
 *
 *     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 * </auto-generated>
 */

// @ts-ignore 
import { Field, ImageField, FileField, LinkField, Item } from '@sitecore-jss/sitecore-jss-nextjs';
// @ts-ignore 
import { ComponentProps } from '../lib/component-props';
// @ts-ignore 
import { PageStructure as FeatureJssExperienceAcceleratorPageStructure } from "./Feature.JssExperienceAccelerator.model"
// @ts-ignore 
import { Presentation as FoundationJssExperienceAcceleratorPresentation } from "./Foundation.JssExperienceAccelerator.model"
// @ts-ignore 
import { Media as FeatureJssExperienceAcceleratorMedia } from "./Feature.JssExperienceAccelerator.model"
// @ts-ignore 
import { Navigation as FeatureJssExperienceAcceleratorNavigation } from "./Feature.JssExperienceAccelerator.model"
// @ts-ignore 
import { PageContent as FeatureJssExperienceAcceleratorPageContent } from "./Feature.JssExperienceAccelerator.model"

export namespace PageStructure.RenderingParameters {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Structure/Rendering Parameters/Container
    */
    export type Container = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: { 
            /**
            * Represents the Background image field (6845679d-e298-4e94-96eb-230cb7c3baae).
            */
            BackgroundImage?: ImageField;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Structure/Rendering Parameters/Container
    */
    export type ContainerJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        
            /**
            * Represents the Background image field (6845679d-e298-4e94-96eb-230cb7c3baae).
            */
            BackgroundImage?: {
                jsonValue: ImageField
            };


    }
}
export namespace Media {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Media/Image
    */
    export type Image =  {
        fields?: { 
            /**
            * Represents the Image field (57caf172-ce57-4e48-b3a1-46f8aea71c08).
            */
            Image?: ImageField;

            /**
            * Represents the Caption field (4d7b05d0-0300-486f-8f87-57de34a9b793).
            */
            ImageCaption?: Field<string>;

            /**
            * Represents the URL field (75fbf1b1-e7c5-494b-9633-693909f79425).
            */
            TargetUrl?: LinkField;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Media/Image
    */
    export type ImageJson =  {
        
            /**
            * Represents the Image field (57caf172-ce57-4e48-b3a1-46f8aea71c08).
            */
            Image?: {
                jsonValue: ImageField
            };

            /**
            * Represents the Caption field (4d7b05d0-0300-486f-8f87-57de34a9b793).
            */
            ImageCaption?: {
                jsonValue: Field<string>
            };

            /**
            * Represents the URL field (75fbf1b1-e7c5-494b-9633-693909f79425).
            */
            TargetUrl?: {
                jsonValue: LinkField
            };


    }
}
export namespace Media.RenderingParameters {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Media/Rendering Parameters/Image
    */
    export type Image = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Media/Rendering Parameters/Image
    */
    export type ImageJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        

    }
}
export namespace Media {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Media/Image Folder
    */
    export type ImageFolder =  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Media/Image Folder
    */
    export type ImageFolderJson =  {
        

    }
}
export namespace Navigation.Datasource {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Datasource/Link
    */
    export type Link =  {
        fields?: { 
            /**
            * Represents the Link field (68c2a603-f98e-42a3-be2d-dd70598c2a63).
            */
            Link?: LinkField;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Datasource/Link
    */
    export type LinkJson =  {
        
            /**
            * Represents the Link field (68c2a603-f98e-42a3-be2d-dd70598c2a63).
            */
            Link?: {
                jsonValue: LinkField
            };


    }

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Datasource/Link List
    */
    export type LinkList =  {
        fields?: { 
            /**
            * Represents the Title field (dc9aaee9-fc44-458d-a9fb-bac61d8b0234).
            */
            Title?: Field<string>;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Datasource/Link List
    */
    export type LinkListJson =  {
        
            /**
            * Represents the Title field (dc9aaee9-fc44-458d-a9fb-bac61d8b0234).
            */
            Title?: {
                jsonValue: Field<string>
            };


    }

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Datasource/Link List Folder
    */
    export type LinkListFolder =  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Datasource/Link List Folder
    */
    export type LinkListFolderJson =  {
        

    }
}
export namespace Navigation.RenderingParameters {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Rendering Parameters/LinkList
    */
    export type LinkList = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Rendering Parameters/LinkList
    */
    export type LinkListJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        

    }

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Rendering Parameters/Navigation
    */
    export type Navigation = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Navigation/Rendering Parameters/Navigation
    */
    export type NavigationJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        

    }
}
export namespace PageContent.RenderingParameters {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Page Content
    */
    export type PageContent = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Page Content
    */
    export type PageContentJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        

    }
}
export namespace PageContent {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Promo
    */
    export type Promo =  {
        fields?: { 
            /**
            * Represents the Image field (f94b9858-c439-4291-863b-757b536c8b65).
            */
            PromoIcon?: ImageField;

            /**
            * Represents the Image 2 field (739c6cc2-0031-463d-9599-13478fd50ee3).
            */
            PromoIcon2?: ImageField;

            /**
            * Represents the Link field (ef24bed2-46ab-4d53-ad1a-1019935a4e89).
            */
            PromoLink?: LinkField;

            /**
            * Represents the Text field (28079f3a-896b-4273-be5f-59d0ebb7cd7d).
            */
            PromoText?: Field<string>;

            /**
            * Represents the Text 2 field (1f66862d-a5e3-405f-8e3e-b787b4c39b12).
            */
            PromoText2?: Field<string>;

            /**
            * Represents the Text 3 field (c6e604c3-5371-4e67-83df-a09a5ea66249).
            */
            PromoText3?: Field<string>;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Promo
    */
    export type PromoJson =  {
        
            /**
            * Represents the Image field (f94b9858-c439-4291-863b-757b536c8b65).
            */
            PromoIcon?: {
                jsonValue: ImageField
            };

            /**
            * Represents the Image 2 field (739c6cc2-0031-463d-9599-13478fd50ee3).
            */
            PromoIcon2?: {
                jsonValue: ImageField
            };

            /**
            * Represents the Link field (ef24bed2-46ab-4d53-ad1a-1019935a4e89).
            */
            PromoLink?: {
                jsonValue: LinkField
            };

            /**
            * Represents the Text field (28079f3a-896b-4273-be5f-59d0ebb7cd7d).
            */
            PromoText?: {
                jsonValue: Field<string>
            };

            /**
            * Represents the Text 2 field (1f66862d-a5e3-405f-8e3e-b787b4c39b12).
            */
            PromoText2?: {
                jsonValue: Field<string>
            };

            /**
            * Represents the Text 3 field (c6e604c3-5371-4e67-83df-a09a5ea66249).
            */
            PromoText3?: {
                jsonValue: Field<string>
            };


    }
}
export namespace PageContent.RenderingParameters {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Promo
    */
    export type Promo = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Promo
    */
    export type PromoJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        

    }
}
export namespace PageContent {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Promo Folder
    */
    export type PromoFolder =  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Promo Folder
    */
    export type PromoFolderJson =  {
        

    }
}
export namespace PageContent.RenderingParameters {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Rich Text
    */
    export type RichText = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Rich Text
    */
    export type RichTextJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        

    }
}
export namespace PageContent {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Text
    */
    export type Text =  {
        fields?: { 
            /**
            * Represents the Text field (729034fc-24f3-40b7-8fa4-fb49d7de20dd).
            */
            Text?: Field<string>;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Text
    */
    export type TextJson =  {
        
            /**
            * Represents the Text field (729034fc-24f3-40b7-8fa4-fb49d7de20dd).
            */
            Text?: {
                jsonValue: Field<string>
            };


    }

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Text Folder
    */
    export type TextFolder =  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Text Folder
    */
    export type TextFolderJson =  {
        

    }
}
export namespace PageContent.RenderingParameters {

    /**
    * Represents the template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Title
    */
    export type Title = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParameters &  {
        fields?: {         }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/JSS Experience Accelerator/Page Content/Rendering Parameters/Title
    */
    export type TitleJson = FoundationJssExperienceAcceleratorPresentation.RenderingParameters.BaseRenderingParametersJson &  {
        

    }
}




/**
 * <auto-generated>
 *     This code was generated by a tool.
 *
 *     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 * </auto-generated>
 */ 

export namespace PageStructure.RenderingParameters.Constants {

    export const Container = {
        TemplateId: "45130bdb-bae3-4edc-aea8-7b68b9d94c7f",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
}
export namespace Media.Constants {

    export const Image = {
        TemplateId: "d885df8c-b2d6-4007-b34b-2bbafb527304",
    
        BaseTemplateIds: [
        ]
    }
}
export namespace Media.RenderingParameters.Constants {

    export const Image = {
        TemplateId: "15185b0e-6418-4449-9f93-4ff03b7ee032",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
}
export namespace Media.Constants {

    export const ImageFolder = {
        TemplateId: "f7a45276-87f1-4ea5-bf25-e3c7cb7aa993",
    
        BaseTemplateIds: [
        ]
    }
}
export namespace Navigation.Datasource.Constants {

    export const Link = {
        TemplateId: "6f108e3c-5d57-42f8-a910-c22920269b0a",
    
        BaseTemplateIds: [
        ]
    }
    export const LinkList = {
        TemplateId: "60c9ac62-4227-443e-8980-92c97e483832",
    
        BaseTemplateIds: [
        ]
    }
    export const LinkListFolder = {
        TemplateId: "c237d144-647a-4afe-aa7b-1570f3e3f139",
    
        BaseTemplateIds: [
        ]
    }
}
export namespace Navigation.RenderingParameters.Constants {

    export const LinkList = {
        TemplateId: "33c9207e-3b04-4606-8ef5-4ca99a97c776",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
    export const Navigation = {
        TemplateId: "9ce34bf9-5c93-4dff-841d-8f649c2bd6c8",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
}
export namespace PageContent.RenderingParameters.Constants {

    export const PageContent = {
        TemplateId: "ef87e73b-c7ff-49a2-ac59-9b0be83755c3",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
}
export namespace PageContent.Constants {

    export const Promo = {
        TemplateId: "dfed4457-d760-457a-bec1-c0dccdc44381",
    
        BaseTemplateIds: [
        ]
    }
}
export namespace PageContent.RenderingParameters.Constants {

    export const Promo = {
        TemplateId: "881869ca-7f58-45ea-8b34-ad1bfd3551a8",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
}
export namespace PageContent.Constants {

    export const PromoFolder = {
        TemplateId: "8fe7f8dc-cb5d-42c2-99f8-76608c243f10",
    
        BaseTemplateIds: [
        ]
    }
}
export namespace PageContent.RenderingParameters.Constants {

    export const RichText = {
        TemplateId: "0f3b7336-6112-418c-8bba-b0526f3887ce",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
}
export namespace PageContent.Constants {

    export const Text = {
        TemplateId: "0a7aa373-5ed1-4e9b-9678-22d3c5faf6df",
    
        BaseTemplateIds: [
        ]
    }
    export const TextFolder = {
        TemplateId: "b762d567-87f5-493c-bb48-0c455d834457",
    
        BaseTemplateIds: [
        ]
    }
}
export namespace PageContent.RenderingParameters.Constants {

    export const Title = {
        TemplateId: "a82e8931-0575-4175-917d-e904ef7e6dbe",
    
        BaseTemplateIds: [
            "4247aad4-ebde-4994-998f-e067a51b1fe4", 
        ]
    }
}    


