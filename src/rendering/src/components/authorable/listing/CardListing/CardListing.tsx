import React from 'react';
import { Image, Link, Text } from '@sitecore-jss/sitecore-jss-nextjs';

import { Listing } from 'src/.generated/Feature.Sugcon.model';
import { ComponentProps } from 'lib/component-props';
import { parseParams } from 'lib/utils/rendering-params';

export type CardListingProps = ComponentProps & Listing.CardListing.CardListing;

export const Default = (props: CardListingProps): JSX.Element => {
  const id = props.params?.RenderingIdentifier;

  const params = parseParams<Listing.CardListing.CardListingParams>(props.params);

  return (
    <div
      className={`component card-listing ${props.params?.styles?.trimEnd()}`}
      id={id ? id : undefined}
    >
      <pre>Card Listing</pre>
      <div className="component-content">
        <h2>
          <Text field={props.fields?.headline} />
        </h2>
        <ul
          style={{
            display: 'grid',
            gridTemplateColumns: `repeat(${
              params?.fields?.cardsPerRow?.value ?? 1
            }, minmax(0, 1fr))`,
          }}
        >
          {props.fields?.children?.map((x) => {
            const card = x as Listing.CardListing.CardItem;
            // Styling for illustrutive purposes only
            return (
              <li key={x.id} style={{ border: '1px solid black', padding: ' 15px' }}>
                <div style={{ objectFit: 'contain' }}>
                  <Image
                    field={card.fields?.image}
                    style={{
                      objectFit: 'contain',
                      maxWidth: '500px',
                    }}
                  />
                </div>
                <Text field={card.fields?.headline} />
                <div>{card.fields?.cta ? <Link field={card.fields?.cta} /> : null}</div>
              </li>
            );
          })}
        </ul>
      </div>
    </div>
  );
};
