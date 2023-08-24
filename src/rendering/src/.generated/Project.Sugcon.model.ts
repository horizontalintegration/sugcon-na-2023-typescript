
/**
 * <auto-generated>
 *     This code was generated by a tool.
 *
 *     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 * </auto-generated>
 */

// @ts-ignore Prevent noUnusedLocals from triggering an error, we import all core field types to minimize changing to code generation.
import { ItemExt } from "lib/_.Sitecore.Override"
// @ts-ignore Prevent noUnusedLocals from triggering an error, we import all core field types to minimize changing to code generation.
import { ComponentRendering, RouteData, Field, ImageField, FileField, LinkField } from '@sitecore-jss/sitecore-jss-nextjs';
// @ts-ignore Prevent noUnusedLocals from triggering an error, we import all core field types to minimize changing to code generation.
import { ComponentProps } from '@/lib/component-props';
import { Foundation } from "./Foundation.JssExperienceAccelerator.model"

export namespace Project.Sugcon {
    export type HeadlessSite = 
        Foundation.JssExperienceAccelerator.Multisite.HeadlessSite & {
        fields?: {         }

    }
    export type HeadlessTenant = 
        Foundation.JssExperienceAccelerator.Multisite.HeadlessTenant & {
        fields?: {         }

    }
    export type JssSettings = 
        Foundation.JssExperienceAccelerator.Multisite.JssSettings & {
        fields?: {         }

    }
    export type Page = 
        Foundation.JssExperienceAccelerator.Multisite.BasePage & {
        fields?: { 
            /**
            * Represents the Content field (1bd4f07a-dfa4-463d-b01b-f9c13ff596fd).
            */
            Content: Field<string>;

            /**
            * Represents the Title field (4da86130-8d6b-4d4f-8e61-3426ab49905d).
            */
            Title: Field<string>;
        }

    }
    export type PageDesignFolder = 
        Foundation.JssExperienceAccelerator.Presentation.Folders.PageDesignFolder & {
        fields?: {         }

    }
    export type PageDesigns = 
        Foundation.JssExperienceAccelerator.Presentation.PageDesigns & {
        fields?: {         }

    }
    export type PartialDesignFolder = 
        Foundation.JssExperienceAccelerator.Presentation.Folders.PartialDesignFolder & {
        fields?: {         }

    }
    export type PartialDesigns = 
        Foundation.JssExperienceAccelerator.Presentation.PartialDesigns & {
        fields?: {         }

    }
}


