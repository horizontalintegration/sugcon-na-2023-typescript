
/**
 * <auto-generated>
 *     This code was generated by a tool.
 *
 *     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 * </auto-generated>
 */

// @ts-ignore 
import { ItemExt } from '../lib/_.Sitecore.Override'
// @ts-ignore 
import { Field, ImageField, FileField, LinkField } from '@sitecore-jss/sitecore-jss-nextjs';
// @ts-ignore 
import { ComponentProps } from '../lib/component-props';
// @ts-ignore 
import { Listing as FeatureSugconListing } from "./Feature.Sugcon.model"
// @ts-ignore 
import { Utility as FoundationSugconUtility } from "./Foundation.Sugcon.model"
// @ts-ignore 
import { Base as FoundationSugconBase } from "./Foundation.Sugcon.model"

export namespace Listing.CardListing {

    /**
    * Represents the template /sitecore/templates/Feature/SUGCON/Listing/Card Listing/Card Item
    */
    export type CardItem =  {
        fields?: { 
            /**
            * Represents the CTA field (7a5b4674-7a28-42fe-8f8e-e86c5dcbd049).
            */
            cta?: LinkField;

            /**
            * Represents the Headline field (9cafa07d-4fdb-4741-90da-f7b1392458c8).
            */
            headline?: Field<string>;

            /**
            * Represents the Image field (af087590-b739-434a-b9c2-954bd816ae59).
            */
            image?: ImageField;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/SUGCON/Listing/Card Listing/Card Item
    */
    export type CardItemJson =  {
        
            /**
            * Represents the CTA field (7a5b4674-7a28-42fe-8f8e-e86c5dcbd049).
            */
            cta?: {
                jsonValue: LinkField
            };

            /**
            * Represents the Headline field (9cafa07d-4fdb-4741-90da-f7b1392458c8).
            */
            headline?: {
                jsonValue: Field<string>
            };

            /**
            * Represents the Image field (af087590-b739-434a-b9c2-954bd816ae59).
            */
            image?: {
                jsonValue: ImageField
            };


    }

    /**
    * Represents the template /sitecore/templates/Feature/SUGCON/Listing/Card Listing/Card Listing
    */
    export type CardListing = FoundationSugconUtility.RenderWithChildren &  {
        fields?: { 
            /**
            * Represents the Headline field (639981f4-6eb4-4f0c-b309-50476ee79b3e).
            */
            headline?: Field<string>;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/SUGCON/Listing/Card Listing/Card Listing
    */
    export type CardListingJson = FoundationSugconUtility.RenderWithChildrenJson &  {
        
            /**
            * Represents the Headline field (639981f4-6eb4-4f0c-b309-50476ee79b3e).
            */
            headline?: {
                jsonValue: Field<string>
            };


    }

    /**
    * Class to wrap the rendering parameter /sitecore/templates/Feature/SUGCON/Listing/Card Listing/Card Listing Params
    * This will automatically parse the string rendering parameters into the appropriate types (where possible)
    */
    export class CardListingParamsClass extends FoundationSugconBase.BaseRenderingParamsClass {
            constructor(public params: Record<string, string>) {
                super(params);
            }
        
            /**
            * Represents the Cards Per Row field (e3688fd5-09ab-4913-963e-1d9d6ef7d86c).
            */
            public get cardsPerRow() {
                const value = this.params.cardsPerRow;
                if (!value) {
                    return null;
                }
                return parseInt(value);
            }

            /**
            * Represents the testDate field (2a1145ff-4e62-4569-89c4-3ab23029bd17).
            */
            public get testDate() {
                const value = this.params.testDate;
                if (!value) {
                    return null;
                }
                return new Date(value.substring(0, 4) 
    + '-' + value.substring(4, 6)
    + '-' + value.substring(6, 11)
    + ':' + value.substring(11, 13)
    + ':' + value.substring(13, 16));
            }

            /**
            * Represents the testImage field (afe4ec52-a73b-4b07-ba75-d52e3d9ee891).
            */
            public get testImage() {
                const value = this.params.testImage;
                if (!value) {
                    return null;
                }
                return value;
            }

    }
}
export namespace Listing.PageListing {

    /**
    * Represents the template /sitecore/templates/Feature/SUGCON/Listing/Page Listing/Page Listing
    */
    export type PageListing =  {
        fields?: { 
            /**
            * Represents the levels field (ce387c4e-2018-4d19-ba73-d043825b0f74).
            */
            levels?: Field<number>;

            /**
            * Represents the Root Page field (e74c3459-d157-4210-ad64-978d04a5fa3f).
            */
            rootPage?: ItemExt;
        }

    }

    /**
    * Represents the GraphQL template /sitecore/templates/Feature/SUGCON/Listing/Page Listing/Page Listing
    */
    export type PageListingJson =  {
        
            /**
            * Represents the levels field (ce387c4e-2018-4d19-ba73-d043825b0f74).
            */
            levels?: {
                jsonValue: Field<number>
            };

            /**
            * Represents the Root Page field (e74c3459-d157-4210-ad64-978d04a5fa3f).
            */
            rootPage?: {
                jsonValue: ItemExt
            };


    }
}


