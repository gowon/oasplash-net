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
    /// UserStatistics
    /// </summary>
    [DataContract(Name = "UserStatistics")]
    public partial class UserStatistics : IEquatable<UserStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatistics" /> class.
        /// </summary>
        /// <param name="downloads">downloads.</param>
        /// <param name="likes">likes.</param>
        /// <param name="username">username.</param>
        /// <param name="views">views.</param>
        public UserStatistics(UserStatisticsDownloads downloads = default(UserStatisticsDownloads), UserStatisticsDownloads likes = default(UserStatisticsDownloads), string username = default(string), UserStatisticsDownloads views = default(UserStatisticsDownloads))
        {
            this.Downloads = downloads;
            this.Likes = likes;
            this.Username = username;
            this.Views = views;
        }

        /// <summary>
        /// Gets or Sets Downloads
        /// </summary>
        [DataMember(Name = "downloads", EmitDefaultValue = false)]
        public UserStatisticsDownloads Downloads { get; set; }

        /// <summary>
        /// Gets or Sets Likes
        /// </summary>
        [DataMember(Name = "likes", EmitDefaultValue = false)]
        public UserStatisticsDownloads Likes { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name = "views", EmitDefaultValue = false)]
        public UserStatisticsDownloads Views { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserStatistics {\n");
            sb.Append("  Downloads: ").Append(Downloads).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserStatistics);
        }

        /// <summary>
        /// Returns true if UserStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of UserStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStatistics input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Downloads == input.Downloads ||
                    (this.Downloads != null &&
                    this.Downloads.Equals(input.Downloads))
                ) && 
                (
                    this.Likes == input.Likes ||
                    (this.Likes != null &&
                    this.Likes.Equals(input.Likes))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Views == input.Views ||
                    (this.Views != null &&
                    this.Views.Equals(input.Views))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Downloads != null)
                {
                    hashCode = (hashCode * 59) + this.Downloads.GetHashCode();
                }
                if (this.Likes != null)
                {
                    hashCode = (hashCode * 59) + this.Likes.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Views != null)
                {
                    hashCode = (hashCode * 59) + this.Views.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}