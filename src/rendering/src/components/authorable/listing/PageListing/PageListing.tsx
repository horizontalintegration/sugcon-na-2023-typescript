import jssConfig from 'temp/config';
import React from 'react';
import {
  ComponentFields,
  ComponentParams,
  ComponentRendering,
  GetStaticComponentProps,
  GraphQLRequestClient,
  Item,
  RichText,
  RichTextField,
  Text,
  TextField,
} from '@sitecore-jss/sitecore-jss-nextjs';

import Link from 'next/link';

// These can be moved to a reusable helper file
export type GqlItemExt = {
  id?: string;
  url?: { path?: string };
  templateId?: string;
};

export type GqlChildren<T> = {
  children: {
    results: T[];
  };
};

interface PageListingPage extends GqlItemExt, GqlChildren<PageListingPage> {
  Title: {
    jsonValue: TextField;
  };
  Content: {
    jsonValue: RichTextField;
  };
}

export type PageListingProps = ComponentRendering & {
  item?: PageListingPage;
};
export type PageListingRendering = ComponentRendering & {
  fields?: ComponentFields;
  params?: ComponentParams;
};
export const Default = (props: PageListingProps): JSX.Element => {
  const id = props.params?.RenderingIdentifier;

  return (
    <div
      className={`component page-listing ${props.params?.styles?.trimEnd()}`}
      id={id ? id : undefined}
    >
      <pre>Page Listing</pre>
      <div className="component-content">
        <ul
          style={{
            paddingLeft: '5px',
          }}
        >
          {props.item?.children.results.map((x) => {
            // Styling for illustrutive purposes only
            return (
              <li key={x.id}>
                <Link href={x.url?.path as string}>
                  <Text field={x.Title?.jsonValue} />
                </Link>
                <RichText field={x.Content?.jsonValue} />
                <ul
                  style={{
                    paddingLeft: '10px',
                  }}
                >
                  {x?.children.results.map((x) => {
                    // Styling for illustrutive purposes only

                    return (
                      <li key={x.id}>
                        <Link href={x.url?.path as string}>
                          <Text field={x.Title?.jsonValue} />
                        </Link>
                        <RichText field={x.Content?.jsonValue} />
                      </li>
                    );
                  })}
                </ul>
              </li>
            );
          })}
        </ul>
      </div>
    </div>
  );
};

const query = /* GraphQL */ `
  query PageListing($rootItem: String!, $language: String!) {
    item(path: $rootItem, language: $language) {
      path
      children(hasLayout: true) {
        results {
          ...pageFragment
          children(hasLayout: true) {
            results {
              ...pageFragment
            }
          }
        }
      }
    }
  }
  fragment pageFragment on SugconPage {
    id
    url {
      path
    }
    templateId
    Title: title {
      jsonValue
    }
    Content: content {
      jsonValue
    }
  }
`;
/**
 * Will be called during SSG
 * @param {ComponentRendering} rendering
 * @param {LayoutServiceData} layoutData
 * @param {GetStaticPropsContext} context
 */
export const getStaticProps: GetStaticComponentProps = async (rendering, layoutData) => {
  const graphQLClient = new GraphQLRequestClient(jssConfig.graphQLEndpoint, {
    apiKey: jssConfig.sitecoreApiKey,
  });

  const rootPage = rendering.fields?.rootPage as Item;

  const result = await graphQLClient.request<PageListingProps>(query, {
    rootItem: rootPage?.id,
    language: layoutData.sitecore.route?.itemLanguage,
  });
  return {
    ...rendering,
    ...result,
  };
};
