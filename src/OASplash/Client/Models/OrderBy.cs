// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace OASplash.Client.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OrderBy.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderBy
    {
        [EnumMember(Value = "latest")]
        Latest,
        [EnumMember(Value = "oldest")]
        Oldest,
        [EnumMember(Value = "popular")]
        Popular
    }
    internal static class OrderByEnumExtension
    {
        internal static string ToSerializedValue(this OrderBy? value)
        {
            return value == null ? null : ((OrderBy)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OrderBy value)
        {
            switch( value )
            {
                case OrderBy.Latest:
                    return "latest";
                case OrderBy.Oldest:
                    return "oldest";
                case OrderBy.Popular:
                    return "popular";
            }
            return null;
        }

        internal static OrderBy? ParseOrderBy(this string value)
        {
            switch( value )
            {
                case "latest":
                    return OrderBy.Latest;
                case "oldest":
                    return OrderBy.Oldest;
                case "popular":
                    return OrderBy.Popular;
            }
            return null;
        }
    }
}
