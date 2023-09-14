/**
 * This file is actually not auto-generated, but is used to override Sitecore base interfaces
 */

import { Field, ImageField, Item } from '@sitecore-jss/sitecore-jss-nextjs';

export type ItemExtFieldValue =
  | ImageField
  | Field
  | Item
  | Item[]
  | ItemExt
  | ItemExt[]
  | undefined;

export type ItemExtFields = {
  [name: string]: ItemExtFieldValue;
};

export type ItemExt = Item & {
  id: string;
  url: string;
  templateId?: string;
  templateName?: string;
  fields?: ItemExtFields;
};

/**
 * All fields are optional because we don't know if they are being pulled in.
 */
export type GqlItemExt = {
  id?: string;
  url?: { path?: string };
  templateId?: string;
  templateName?: string;
};

export type GqlChildren<T> = {
  children: {
    results: T[];
  };
};
