
/**
 * <auto-generated>
 *     This code was generated by a tool.
 *
 *     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 * </auto-generated>
 */

// eslint-disable-next-line @typescript-eslint/no-unused-vars 
import { ItemExt } from '../lib/_.Sitecore.Override'
// eslint-disable-next-line @typescript-eslint/no-unused-vars 
import { Field, ImageField, FileField, LinkField } from '@sitecore-jss/sitecore-jss-nextjs';
// eslint-disable-next-line @typescript-eslint/no-unused-vars 
import { ComponentProps } from '../lib/component-props';
import { Foundation } from "./Foundation.JssExperienceAccelerator.model"

export namespace Project.Sugcon {
    export type HeadlessSite = 
        Foundation.JssExperienceAccelerator.Multisite.HeadlessSite &  {
        fields?: {         }

    }
    export type HeadlessSiteJson = 
        Foundation.JssExperienceAccelerator.Multisite.HeadlessSiteJson &  {
        

    }
    export type HeadlessTenant = 
        Foundation.JssExperienceAccelerator.Multisite.HeadlessTenant &  {
        fields?: {         }

    }
    export type HeadlessTenantJson = 
        Foundation.JssExperienceAccelerator.Multisite.HeadlessTenantJson &  {
        

    }
    export type JssSettings = 
        Foundation.JssExperienceAccelerator.Multisite.JssSettings &  {
        fields?: {         }

    }
    export type JssSettingsJson = 
        Foundation.JssExperienceAccelerator.Multisite.JssSettingsJson &  {
        

    }
    export type PageDesignFolder = 
        Foundation.JssExperienceAccelerator.Presentation.Folders.PageDesignFolder &  {
        fields?: {         }

    }
    export type PageDesignFolderJson = 
        Foundation.JssExperienceAccelerator.Presentation.Folders.PageDesignFolderJson &  {
        

    }
    export type PageDesigns = 
        Foundation.JssExperienceAccelerator.Presentation.PageDesigns &  {
        fields?: {         }

    }
    export type PageDesignsJson = 
        Foundation.JssExperienceAccelerator.Presentation.PageDesignsJson &  {
        

    }
    export type PartialDesignFolder = 
        Foundation.JssExperienceAccelerator.Presentation.Folders.PartialDesignFolder &  {
        fields?: {         }

    }
    export type PartialDesignFolderJson = 
        Foundation.JssExperienceAccelerator.Presentation.Folders.PartialDesignFolderJson &  {
        

    }
    export type PartialDesigns = 
        Foundation.JssExperienceAccelerator.Presentation.PartialDesigns &  {
        fields?: {         }

    }
    export type PartialDesignsJson = 
        Foundation.JssExperienceAccelerator.Presentation.PartialDesignsJson &  {
        

    }
    export type SugconPage = 
        Foundation.JssExperienceAccelerator.Multisite.BasePage &  {
        fields?: { 
            /**
            * Represents the Content field (1bd4f07a-dfa4-463d-b01b-f9c13ff596fd).
            */
            Content?: Field<string>;

            /**
            * Represents the Title field (4da86130-8d6b-4d4f-8e61-3426ab49905d).
            */
            Title?: Field<string>;
        }

    }
    export type SugconPageJson = 
        Foundation.JssExperienceAccelerator.Multisite.BasePageJson &  {
        
            /**
            * Represents the Content field (1bd4f07a-dfa4-463d-b01b-f9c13ff596fd).
            */
            Content?: {
                jsonValue: Field<string>
            };

            /**
            * Represents the Title field (4da86130-8d6b-4d4f-8e61-3426ab49905d).
            */
            Title?: {
                jsonValue: Field<string>
            };


    }
}
// Namespace aliases.  If this doesn't work, ensure `"isolatedModules": false` is set in `tsconfig.json`. 


