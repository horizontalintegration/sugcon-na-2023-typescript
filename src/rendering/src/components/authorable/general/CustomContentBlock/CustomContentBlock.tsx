import React from 'react';
import { Link, RichText } from '@sitecore-jss/sitecore-jss-nextjs';
import { General } from 'src/.generated/Feature.Sugcon.model';

import { ComponentProps } from 'lib/component-props';

export type CustomContentBlockProps = ComponentProps &
  General.CustomContentBlock.CustomContentBlock;

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
          <RichText field={props.fields?.content} />
        </div>

        {props.fields?.cta ? (
          <div>
            <Link field={props.fields?.cta} />
          </div>
        ) : null}
      </div>
    </div>
  );
};
