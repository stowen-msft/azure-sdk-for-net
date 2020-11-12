// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntityRecognitionPiiTasksItemProperties
    {
        internal static EntityRecognitionPiiTasksItemProperties DeserializeEntityRecognitionPiiTasksItemProperties(JsonElement element)
        {
            Optional<PiiEntitiesResult> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = PiiEntitiesResult.DeserializePiiEntitiesResult(property.Value);
                    continue;
                }
            }
            return new EntityRecognitionPiiTasksItemProperties(results.Value);
        }
    }
}
