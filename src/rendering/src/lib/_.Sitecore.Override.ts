/**
 * This file is actually not auto-generated, but is used to override Sitecore base interfaces
 */

import { Field, Item } from '@sitecore-jss/sitecore-jss-nextjs';

export type ItemExtFieldValue = Field | Item | Item[] | ItemExt | ItemExt[] | undefined;

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
