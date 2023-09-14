import React from 'react';
import {
  ComponentFields,
  ComponentParams,
  Field,
  Link,
  LinkField,
  RichText,
} from '@sitecore-jss/sitecore-jss-nextjs';

import { ComponentProps } from 'lib/component-props';

export type CustomContentBlockProps = ComponentProps & {
  fields?: ComponentFields;
  params?: ComponentParams;
};
export const Default = (props: CustomContentBlockProps): JSX.Element => {
  const id = props.params?.RenderingIdentifier;

  // const params = parseParams<General.CustomContentBlock.CustomContentBlockParams>(props.params);

  return (
    <div
      className={`component card-listing ${props.params?.styles?.trimEnd()}`}
      id={id ? id : undefined}
    >
      <pre>Custom Content Block</pre>
      <div className="component-content">
        <div>
          <RichText field={props.fields?.content as Field<string>} />
        </div>

        {props.fields?.cta ? (
          <div>
            <Link field={props.fields?.cta as LinkField} />
          </div>
        ) : null}
      </div>
    </div>
  );
};
