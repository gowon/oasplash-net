/*
 * Unsplash API
 *
 * This document describes the resources that make up the official Unsplash JSON API. 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = OASPlash.Core.Client.FileParameter;
using OpenAPIDateConverter = OASPlash.Core.Client.OpenAPIDateConverter;

namespace OASPlash.Core.Model
{
    /// <summary>
    /// Defines TopicsOrderBy
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TopicsOrderBy
    {
        /// <summary>
        /// Enum Featured for value: featured
        /// </summary>
        [EnumMember(Value = "featured")]
        Featured = 1,

        /// <summary>
        /// Enum Latest for value: latest
        /// </summary>
        [EnumMember(Value = "latest")]
        Latest = 2,

        /// <summary>
        /// Enum Oldest for value: oldest
        /// </summary>
        [EnumMember(Value = "oldest")]
        Oldest = 3,

        /// <summary>
        /// Enum Position for value: position
        /// </summary>
        [EnumMember(Value = "position")]
        Position = 4

    }

}