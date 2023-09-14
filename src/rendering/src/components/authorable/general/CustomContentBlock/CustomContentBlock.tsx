import React from 'react';
import { Image, Link, Text } from '@sitecore-jss/sitecore-jss-nextjs';

import { General } from 'src/.generated/Feature.Sugcon.model';
import { ComponentProps } from 'lib/component-props';
import { parseParams } from 'lib/utils/rendering-params';

export type CustomContentBlockProps = ComponentProps &
  General.CustomContentBlock.CustomContentBlock;

export const Default = (props: CustomContentBlockProps): JSX.Element => {
  const id = props.params?.RenderingIdentifier;

  const params = parseParams<General.CustomContentBlock.CustomContentBlockParams>(props.params);

  return (
    <div
      className={`component card-listing ${props.params?.styles?.trimEnd()}`}
      id={id ? id : undefined}
    >
      <div className="component-content">
        <div>
          <Text field={props.fields?.content} />
        </div>

        {props.fields?.cta ? (
          <div>
            <Link field={props.fields?.cta} />
          </div>
        ) : null}

        <div>
          <h2>Rendering parameter test</h2>
          {params?.fields?.testDate?.value ? (
            <p>Test date param: {new Date(params.fields.testDate.value).toLocaleDateString()}</p>
          ) : (
            <></>
          )}
          {params?.fields?.testImage ? <Image field={params.fields?.testImage} /> : <></>}
          {params?.fields?.testLink ? (
            <div>
              <Link field={params?.fields?.testLink} />
            </div>
          ) : null}
        </div>
      </div>
    </div>
  );
};
