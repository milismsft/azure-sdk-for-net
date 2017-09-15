// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerInstance.Fluent
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OS type.
    /// </summary>
    public enum OSTypeName
    {
        [EnumMember(Value = "Linux")]
        Linux,
        [EnumMember(Value = "Windows")]
        Windows
    }
    [JsonConverter(typeof(StringEnumConverter))]
    internal static class OSTypeEnumExtension
    {
        internal static string ToSerializedValue(this OSTypeName? value) =>
            value == null ? null : ((OSTypeName)value).ToSerializedValue();

        internal static string ToSerializedValue(this OSTypeName value)
        {
            switch (value)
            {
                case OSTypeName.Linux:
                    return "Linux";
                case OSTypeName.Windows:
                    return "Windows";
            }
            return null;
        }

        internal static OSTypeName? ParseSkuName(this string value)
        {
            switch (value)
            {
                case "Linux":
                    return OSTypeName.Linux;
                case "Windows":
                    return OSTypeName.Windows;
            }
            return null;
        }
    }
}
