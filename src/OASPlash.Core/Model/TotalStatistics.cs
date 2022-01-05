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
    /// TotalStatistics
    /// </summary>
    [DataContract(Name = "TotalStatistics")]
    public partial class TotalStatistics : IEquatable<TotalStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalStatistics" /> class.
        /// </summary>
        /// <param name="applications">applications.</param>
        /// <param name="developers">developers.</param>
        /// <param name="downloads">downloads.</param>
        /// <param name="downloadsPerSecond">downloadsPerSecond.</param>
        /// <param name="likes">likes.</param>
        /// <param name="photographers">photographers.</param>
        /// <param name="photos">photos.</param>
        /// <param name="pixels">pixels.</param>
        /// <param name="requests">requests.</param>
        /// <param name="views">views.</param>
        /// <param name="viewsPerSecond">viewsPerSecond.</param>
        public TotalStatistics(int applications = default(int), int developers = default(int), int downloads = default(int), int downloadsPerSecond = default(int), int likes = default(int), int photographers = default(int), int photos = default(int), int pixels = default(int), int requests = default(int), int views = default(int), int viewsPerSecond = default(int))
        {
            this.Applications = applications;
            this.Developers = developers;
            this.Downloads = downloads;
            this.DownloadsPerSecond = downloadsPerSecond;
            this.Likes = likes;
            this.Photographers = photographers;
            this.Photos = photos;
            this.Pixels = pixels;
            this.Requests = requests;
            this.Views = views;
            this.ViewsPerSecond = viewsPerSecond;
        }

        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name = "applications", EmitDefaultValue = false)]
        public int Applications { get; set; }

        /// <summary>
        /// Gets or Sets Developers
        /// </summary>
        [DataMember(Name = "developers", EmitDefaultValue = false)]
        public int Developers { get; set; }

        /// <summary>
        /// Gets or Sets Downloads
        /// </summary>
        [DataMember(Name = "downloads", EmitDefaultValue = false)]
        public int Downloads { get; set; }

        /// <summary>
        /// Gets or Sets DownloadsPerSecond
        /// </summary>
        [DataMember(Name = "downloads_per_second", EmitDefaultValue = false)]
        public int DownloadsPerSecond { get; set; }

        /// <summary>
        /// Gets or Sets Likes
        /// </summary>
        [DataMember(Name = "likes", EmitDefaultValue = false)]
        public int Likes { get; set; }

        /// <summary>
        /// Gets or Sets Photographers
        /// </summary>
        [DataMember(Name = "photographers", EmitDefaultValue = false)]
        public int Photographers { get; set; }

        /// <summary>
        /// Gets or Sets Photos
        /// </summary>
        [DataMember(Name = "photos", EmitDefaultValue = false)]
        public int Photos { get; set; }

        /// <summary>
        /// Gets or Sets Pixels
        /// </summary>
        [DataMember(Name = "pixels", EmitDefaultValue = false)]
        public int Pixels { get; set; }

        /// <summary>
        /// Gets or Sets Requests
        /// </summary>
        [DataMember(Name = "requests", EmitDefaultValue = false)]
        public int Requests { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name = "views", EmitDefaultValue = false)]
        public int Views { get; set; }

        /// <summary>
        /// Gets or Sets ViewsPerSecond
        /// </summary>
        [DataMember(Name = "views_per_second", EmitDefaultValue = false)]
        public int ViewsPerSecond { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TotalStatistics {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Developers: ").Append(Developers).Append("\n");
            sb.Append("  Downloads: ").Append(Downloads).Append("\n");
            sb.Append("  DownloadsPerSecond: ").Append(DownloadsPerSecond).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  Photographers: ").Append(Photographers).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Pixels: ").Append(Pixels).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  ViewsPerSecond: ").Append(ViewsPerSecond).Append("\n");
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
            return this.Equals(input as TotalStatistics);
        }

        /// <summary>
        /// Returns true if TotalStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalStatistics input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications.Equals(input.Applications)
                ) && 
                (
                    this.Developers == input.Developers ||
                    this.Developers.Equals(input.Developers)
                ) && 
                (
                    this.Downloads == input.Downloads ||
                    this.Downloads.Equals(input.Downloads)
                ) && 
                (
                    this.DownloadsPerSecond == input.DownloadsPerSecond ||
                    this.DownloadsPerSecond.Equals(input.DownloadsPerSecond)
                ) && 
                (
                    this.Likes == input.Likes ||
                    this.Likes.Equals(input.Likes)
                ) && 
                (
                    this.Photographers == input.Photographers ||
                    this.Photographers.Equals(input.Photographers)
                ) && 
                (
                    this.Photos == input.Photos ||
                    this.Photos.Equals(input.Photos)
                ) && 
                (
                    this.Pixels == input.Pixels ||
                    this.Pixels.Equals(input.Pixels)
                ) && 
                (
                    this.Requests == input.Requests ||
                    this.Requests.Equals(input.Requests)
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views.Equals(input.Views)
                ) && 
                (
                    this.ViewsPerSecond == input.ViewsPerSecond ||
                    this.ViewsPerSecond.Equals(input.ViewsPerSecond)
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
                hashCode = (hashCode * 59) + this.Applications.GetHashCode();
                hashCode = (hashCode * 59) + this.Developers.GetHashCode();
                hashCode = (hashCode * 59) + this.Downloads.GetHashCode();
                hashCode = (hashCode * 59) + this.DownloadsPerSecond.GetHashCode();
                hashCode = (hashCode * 59) + this.Likes.GetHashCode();
                hashCode = (hashCode * 59) + this.Photographers.GetHashCode();
                hashCode = (hashCode * 59) + this.Photos.GetHashCode();
                hashCode = (hashCode * 59) + this.Pixels.GetHashCode();
                hashCode = (hashCode * 59) + this.Requests.GetHashCode();
                hashCode = (hashCode * 59) + this.Views.GetHashCode();
                hashCode = (hashCode * 59) + this.ViewsPerSecond.GetHashCode();
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
