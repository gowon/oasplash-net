using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OASplash.Extensible
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthorizationScope
    {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "read_user")]
        ReadUser,
        [EnumMember(Value = "write_user")]
        WriteUser,
        [EnumMember(Value = "read_photos")]
        ReadPhotos,
        [EnumMember(Value = "write_photos")]
        WritePhotos,
        [EnumMember(Value = "write_likes")]
        WriteLikes,
        [EnumMember(Value = "write_followers")]
        WriteFollowers,
        [EnumMember(Value = "read_collections")]
        ReadCollections,
        [EnumMember(Value = "write_collections")]
        WriteCollections,
    }
    internal static class AuthorizationScopeEnumExtension
    {
        internal static string ToSerializedValue(this AuthorizationScope? value)
        {
            return value == null ? null : ((AuthorizationScope)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuthorizationScope value)
        {
            switch (value)
            {
                case AuthorizationScope.Public:
                    return "public";
                case AuthorizationScope.ReadUser:
                    return "read_user";
                case AuthorizationScope.WriteUser:
                    return "write_user";
                case AuthorizationScope.ReadPhotos:
                    return "read_photos";
                case AuthorizationScope.WritePhotos:
                    return "write_photos";
                case AuthorizationScope.WriteLikes:
                    return "write_likes";
                case AuthorizationScope.WriteFollowers:
                    return "write_followers";
                case AuthorizationScope.ReadCollections:
                    return "read_collections";
                case AuthorizationScope.WriteCollections:
                    return "write_collections";
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

        internal static AuthorizationScope? ParseAuthorizationScope(this string value)
        {
            switch( value )
            {
                case "public":
                    return AuthorizationScope.Public;
                case "read_user":
                    return AuthorizationScope.ReadUser;
                case "write_user":
                    return AuthorizationScope.WriteUser;
                case "read_photos":
                    return AuthorizationScope.ReadPhotos;
                case "write_photos":
                    return AuthorizationScope.WritePhotos;
                case "write_likes":
                    return AuthorizationScope.WriteLikes;
                case "write_followers":
                    return AuthorizationScope.WriteFollowers;
                case "read_collections":
                    return AuthorizationScope.ReadCollections;
                case "write_collections":
                    return AuthorizationScope.WriteCollections;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}
