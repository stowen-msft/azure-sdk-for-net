// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    internal class TextAnalyticsCancelHealthJobHeaders
    {
        private readonly Response _response;
        public TextAnalyticsCancelHealthJobHeaders(Response response)
        {
            _response = response;
        }
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
