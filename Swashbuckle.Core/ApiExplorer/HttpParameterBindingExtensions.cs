﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;

namespace Swashbuckle.ApiExplorer
{
    internal static class HttpParameterBindingExtensions
    {
        public static bool WillReadUri(this HttpParameterBinding parameterBinding)
        {
            if (parameterBinding == null)
            {
                throw Error.ArgumentNull("parameterBinding");
            }

            IValueProviderParameterBinding valueProviderParameterBinding = parameterBinding as IValueProviderParameterBinding;
            if (valueProviderParameterBinding != null)
            {
                IEnumerable<ValueProviderFactory> valueProviderFactories = valueProviderParameterBinding.ValueProviderFactories;
                if (valueProviderFactories.Any() && valueProviderFactories.All(factory => factory.GetType().Name == "QueryStringValueProviderFactory" || factory.GetType().Name == "RouteDataValueProviderFactory"))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
