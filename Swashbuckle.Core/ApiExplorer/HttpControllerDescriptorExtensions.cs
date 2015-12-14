// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Web.Http.Controllers;

namespace Swashbuckle.ApiExplorer
{
    internal static class HttpControllerDescriptorExtensions
    {
        private const string AttributeRoutedPropertyKey = "MS_IsAttributeRouted";

        public static bool IsAttributeRouted(this HttpControllerDescriptor controllerDescriptor)
        {
            if (controllerDescriptor == null)
            {
                throw new ArgumentNullException("controllerDescriptor");
            }

            object value;
            controllerDescriptor.Properties.TryGetValue(AttributeRoutedPropertyKey, out value);
            return value as bool? ?? false;
        }

        public static void SetIsAttributeRouted(this HttpControllerDescriptor controllerDescriptor, bool value)
        {
            if (controllerDescriptor == null)
            {
                throw new ArgumentNullException("controllerDescriptor");
            }

            controllerDescriptor.Properties[AttributeRoutedPropertyKey] = value;
        }
    }


// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

    internal static class HttpActionDescriptorExtensions
    {
        private const string AttributeRoutedPropertyKey = "MS_IsAttributeRouted";

        public static bool IsAttributeRouted(this HttpActionDescriptor actionDescriptor)
        {
            if (actionDescriptor == null)
            {
                throw new ArgumentNullException("actionDescriptor");
            }

            object value;
            actionDescriptor.Properties.TryGetValue(AttributeRoutedPropertyKey, out value);
            return value as bool? ?? false;
        }

        public static void SetIsAttributeRouted(this HttpActionDescriptor actionDescriptor, bool value)
        {
            if (actionDescriptor == null)
            {
                throw new ArgumentNullException("actionDescriptor");
            }

            actionDescriptor.Properties[AttributeRoutedPropertyKey] = value;
        }
    }
}