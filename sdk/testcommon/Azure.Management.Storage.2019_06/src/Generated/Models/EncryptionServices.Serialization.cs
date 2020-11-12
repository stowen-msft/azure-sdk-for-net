// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class EncryptionServices : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Blob))
            {
                writer.WritePropertyName("blob");
                writer.WriteObjectValue(Blob);
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file");
                writer.WriteObjectValue(File);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table");
                writer.WriteObjectValue(Table);
            }
            if (Optional.IsDefined(Queue))
            {
                writer.WritePropertyName("queue");
                writer.WriteObjectValue(Queue);
            }
            writer.WriteEndObject();
        }

        internal static EncryptionServices DeserializeEncryptionServices(JsonElement element)
        {
            Optional<EncryptionService> blob = default;
            Optional<EncryptionService> file = default;
            Optional<EncryptionService> table = default;
            Optional<EncryptionService> queue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"))
                {
                    blob = EncryptionService.DeserializeEncryptionService(property.Value);
                    continue;
                }
                if (property.NameEquals("file"))
                {
                    file = EncryptionService.DeserializeEncryptionService(property.Value);
                    continue;
                }
                if (property.NameEquals("table"))
                {
                    table = EncryptionService.DeserializeEncryptionService(property.Value);
                    continue;
                }
                if (property.NameEquals("queue"))
                {
                    queue = EncryptionService.DeserializeEncryptionService(property.Value);
                    continue;
                }
            }
            return new EncryptionServices(blob.Value, file.Value, table.Value, queue.Value);
        }
    }
}
