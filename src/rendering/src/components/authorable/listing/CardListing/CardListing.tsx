import React from 'react';
import {
  ComponentFields,
  ComponentParams,
  Image,
  ImageField,
  Item,
  Link,
  LinkField,
  Text,
  TextField,
} from '@sitecore-jss/sitecore-jss-nextjs';

import { ComponentProps } from 'lib/component-props';

export type CardListingProps = ComponentProps & {
  fields?: ComponentFields & {
    children: Item[];
  };
  params?: ComponentParams;
};
export const Default = (props: CardListingProps): JSX.Element => {
  const id = props.params?.RenderingIdentifier;

  return (
    <div
      className={`component card-listing ${props.params?.styles?.trimEnd()}`}
      id={id ? id : undefined}
    >
      <pre>Card Listing</pre>
      <div className="component-content">
        <h2>
          <Text field={props.fields?.headline as TextField} />
        </h2>
        <ul
          style={{
            display: 'grid',
            gridTemplateColumns: `repeat(${props.params?.cardsPerRow ?? 1}, minmax(0, 1fr))`,
          }}
        >
          {props.fields?.children?.map((x) => {
            const card = x;
            // Styling for illustrutive purposes only
            return (
              <li key={x.id} style={{ border: '1px solid black', padding: ' 15px' }}>
                <div style={{ objectFit: 'contain' }}>
                  <Image
                    field={card.fields?.image as ImageField}
                    style={{
                      objectFit: 'contain',
                      maxWidth: '500px',
                    }}
                  />
                </div>
                <Text field={card.fields?.headline as TextField} />
                <div>
                  {card.fields?.cta ? <Link field={card.fields?.cta as LinkField} /> : null}
                </div>
              </li>
            );
          })}
        </ul>
      </div>
    </div>
  );
};
