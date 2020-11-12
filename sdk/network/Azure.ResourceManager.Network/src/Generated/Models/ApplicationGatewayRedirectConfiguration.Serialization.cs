// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRedirectConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RedirectType))
            {
                writer.WritePropertyName("redirectType");
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (Optional.IsDefined(TargetListener))
            {
                writer.WritePropertyName("targetListener");
                writer.WriteObjectValue(TargetListener);
            }
            if (Optional.IsDefined(TargetUrl))
            {
                writer.WritePropertyName("targetUrl");
                writer.WriteStringValue(TargetUrl);
            }
            if (Optional.IsDefined(IncludePath))
            {
                writer.WritePropertyName("includePath");
                writer.WriteBooleanValue(IncludePath.Value);
            }
            if (Optional.IsDefined(IncludeQueryString))
            {
                writer.WritePropertyName("includeQueryString");
                writer.WriteBooleanValue(IncludeQueryString.Value);
            }
            if (Optional.IsCollectionDefined(RequestRoutingRules))
            {
                writer.WritePropertyName("requestRoutingRules");
                writer.WriteStartArray();
                foreach (var item in RequestRoutingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UrlPathMaps))
            {
                writer.WritePropertyName("urlPathMaps");
                writer.WriteStartArray();
                foreach (var item in UrlPathMaps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PathRules))
            {
                writer.WritePropertyName("pathRules");
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayRedirectConfiguration DeserializeApplicationGatewayRedirectConfiguration(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<ApplicationGatewayRedirectType> redirectType = default;
            Optional<SubResource> targetListener = default;
            Optional<string> targetUrl = default;
            Optional<bool> includePath = default;
            Optional<bool> includeQueryString = default;
            Optional<IList<SubResource>> requestRoutingRules = default;
            Optional<IList<SubResource>> urlPathMaps = default;
            Optional<IList<SubResource>> pathRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("redirectType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            redirectType = new ApplicationGatewayRedirectType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetListener"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetListener = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetUrl"))
                        {
                            targetUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("includePath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            includePath = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("includeQueryString"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            includeQueryString = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requestRoutingRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            requestRoutingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("urlPathMaps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            urlPathMaps = array;
                            continue;
                        }
                        if (property0.NameEquals("pathRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            pathRules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayRedirectConfiguration(id.Value, name.Value, etag.Value, type.Value, Optional.ToNullable(redirectType), targetListener.Value, targetUrl.Value, Optional.ToNullable(includePath), Optional.ToNullable(includeQueryString), Optional.ToList(requestRoutingRules), Optional.ToList(urlPathMaps), Optional.ToList(pathRules));
        }
    }
}
