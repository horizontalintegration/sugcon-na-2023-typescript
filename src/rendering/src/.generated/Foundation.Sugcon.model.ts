
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

export namespace Foundation.Sugcon.Base {
    export class BaseRenderingParamsClass  {
            constructor(public params: Record<string, string>) {
                
            }
        
    }
}
export namespace Foundation.Sugcon.Utility {
    export type RenderWithChildren =  {
        fields?: { 
            /**
            * Child items
            */
            children : ItemExt[];
        }

    }
}
// Namespace aliases.  If this doesn't work, ensure `"isolatedModules": false` is set in `tsconfig.json`. 
export import Base = Foundation.Sugcon.Base;


