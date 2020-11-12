// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class CreateSearchOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("description");
            writer.WriteStringValue(Description);
            writer.WritePropertyName("phonePlanIds");
            writer.WriteStartArray();
            foreach (var item in PhonePlanIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("areaCode");
            writer.WriteStringValue(AreaCode);
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity");
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Optional.IsCollectionDefined(LocationOptions))
            {
                writer.WritePropertyName("locationOptions");
                writer.WriteStartArray();
                foreach (var item in LocationOptions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
