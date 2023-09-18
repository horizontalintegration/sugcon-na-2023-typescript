/**
 * This file is actually not auto-generated, but is used to override Sitecore base interfaces
 */

import { Field, ImageField, Item } from '@sitecore-jss/sitecore-jss-nextjs';

declare module '@sitecore-jss/sitecore-jss-nextjs' {
  export interface Item {
    // We're adding this in our code
    templateId?: string;
    // Make nullable
    fields?: {
      [name: string]: Field | ImageField | Item | Item[] | undefined;
    };
  }
}
