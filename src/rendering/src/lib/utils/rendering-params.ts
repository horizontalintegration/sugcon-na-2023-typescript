import { ComponentParams, Item } from '@sitecore-jss/sitecore-jss-nextjs';

/**
 * Parses the rendering parameters into the specified type `T`.
 * Note: This requires the corresponsing Sitecore code to serialize the rendering parameters.
 * @param componentParams
 * @returns The parsed parameter object
 */
export const parseParams = <T extends { fields?: Item['fields'] }>(
  componentParams: ComponentParams
): T | null => {
  if (!componentParams) {
    return null;
  }
  const res = { fields: {} as Item['fields'] } as T;
  for (const key in componentParams) {
    if (Object.prototype.hasOwnProperty.call(componentParams, key)) {
      // Only parameters on our templates are serialized as objects
      // If it's a custom property or comes from SXA it won't be a JSON string.
      const isJson = componentParams[key].startsWith('{') && componentParams[key].endsWith('}');
      if (res.fields && isJson) {
        try {
          res.fields[key] = JSON.parse(componentParams[key]);
        } catch {
          console.error(componentParams);
        }
      }
    }
  }
  return res;
};
