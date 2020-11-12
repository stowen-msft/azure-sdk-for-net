// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class Topology
    {
        internal static Topology DeserializeTopology(JsonElement element)
        {
            Optional<string> id = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<IReadOnlyList<TopologyResource>> resources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"))
                {
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resources"))
                {
                    List<TopologyResource> array = new List<TopologyResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologyResource.DeserializeTopologyResource(item));
                    }
                    resources = array;
                    continue;
                }
            }
            return new Topology(id.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(lastModified), Optional.ToList(resources));
        }
    }
}
