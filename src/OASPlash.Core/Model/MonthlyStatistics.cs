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
    /// MonthlyStatistics
    /// </summary>
    [DataContract(Name = "MonthlyStatistics")]
    public partial class MonthlyStatistics : IEquatable<MonthlyStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyStatistics" /> class.
        /// </summary>
        /// <param name="downloads">downloads.</param>
        /// <param name="likes">likes.</param>
        /// <param name="newApplications">newApplications.</param>
        /// <param name="newDevelopers">newDevelopers.</param>
        /// <param name="newPhotographers">newPhotographers.</param>
        /// <param name="newPhotos">newPhotos.</param>
        /// <param name="newPixels">newPixels.</param>
        /// <param name="newRequests">newRequests.</param>
        /// <param name="views">views.</param>
        public MonthlyStatistics(int downloads = default(int), int likes = default(int), int newApplications = default(int), int newDevelopers = default(int), int newPhotographers = default(int), int newPhotos = default(int), int newPixels = default(int), int newRequests = default(int), int views = default(int))
        {
            this.Downloads = downloads;
            this.Likes = likes;
            this.NewApplications = newApplications;
            this.NewDevelopers = newDevelopers;
            this.NewPhotographers = newPhotographers;
            this.NewPhotos = newPhotos;
            this.NewPixels = newPixels;
            this.NewRequests = newRequests;
            this.Views = views;
        }

        /// <summary>
        /// Gets or Sets Downloads
        /// </summary>
        [DataMember(Name = "downloads", EmitDefaultValue = false)]
        public int Downloads { get; set; }

        /// <summary>
        /// Gets or Sets Likes
        /// </summary>
        [DataMember(Name = "likes", EmitDefaultValue = false)]
        public int Likes { get; set; }

        /// <summary>
        /// Gets or Sets NewApplications
        /// </summary>
        [DataMember(Name = "new_applications", EmitDefaultValue = false)]
        public int NewApplications { get; set; }

        /// <summary>
        /// Gets or Sets NewDevelopers
        /// </summary>
        [DataMember(Name = "new_developers", EmitDefaultValue = false)]
        public int NewDevelopers { get; set; }

        /// <summary>
        /// Gets or Sets NewPhotographers
        /// </summary>
        [DataMember(Name = "new_photographers", EmitDefaultValue = false)]
        public int NewPhotographers { get; set; }

        /// <summary>
        /// Gets or Sets NewPhotos
        /// </summary>
        [DataMember(Name = "new_photos", EmitDefaultValue = false)]
        public int NewPhotos { get; set; }

        /// <summary>
        /// Gets or Sets NewPixels
        /// </summary>
        [DataMember(Name = "new_pixels", EmitDefaultValue = false)]
        public int NewPixels { get; set; }

        /// <summary>
        /// Gets or Sets NewRequests
        /// </summary>
        [DataMember(Name = "new_requests", EmitDefaultValue = false)]
        public int NewRequests { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name = "views", EmitDefaultValue = false)]
        public int Views { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonthlyStatistics {\n");
            sb.Append("  Downloads: ").Append(Downloads).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  NewApplications: ").Append(NewApplications).Append("\n");
            sb.Append("  NewDevelopers: ").Append(NewDevelopers).Append("\n");
            sb.Append("  NewPhotographers: ").Append(NewPhotographers).Append("\n");
            sb.Append("  NewPhotos: ").Append(NewPhotos).Append("\n");
            sb.Append("  NewPixels: ").Append(NewPixels).Append("\n");
            sb.Append("  NewRequests: ").Append(NewRequests).Append("\n");
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
            return this.Equals(input as MonthlyStatistics);
        }

        /// <summary>
        /// Returns true if MonthlyStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlyStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyStatistics input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Downloads == input.Downloads ||
                    this.Downloads.Equals(input.Downloads)
                ) && 
                (
                    this.Likes == input.Likes ||
                    this.Likes.Equals(input.Likes)
                ) && 
                (
                    this.NewApplications == input.NewApplications ||
                    this.NewApplications.Equals(input.NewApplications)
                ) && 
                (
                    this.NewDevelopers == input.NewDevelopers ||
                    this.NewDevelopers.Equals(input.NewDevelopers)
                ) && 
                (
                    this.NewPhotographers == input.NewPhotographers ||
                    this.NewPhotographers.Equals(input.NewPhotographers)
                ) && 
                (
                    this.NewPhotos == input.NewPhotos ||
                    this.NewPhotos.Equals(input.NewPhotos)
                ) && 
                (
                    this.NewPixels == input.NewPixels ||
                    this.NewPixels.Equals(input.NewPixels)
                ) && 
                (
                    this.NewRequests == input.NewRequests ||
                    this.NewRequests.Equals(input.NewRequests)
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views.Equals(input.Views)
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
                hashCode = (hashCode * 59) + this.Downloads.GetHashCode();
                hashCode = (hashCode * 59) + this.Likes.GetHashCode();
                hashCode = (hashCode * 59) + this.NewApplications.GetHashCode();
                hashCode = (hashCode * 59) + this.NewDevelopers.GetHashCode();
                hashCode = (hashCode * 59) + this.NewPhotographers.GetHashCode();
                hashCode = (hashCode * 59) + this.NewPhotos.GetHashCode();
                hashCode = (hashCode * 59) + this.NewPixels.GetHashCode();
                hashCode = (hashCode * 59) + this.NewRequests.GetHashCode();
                hashCode = (hashCode * 59) + this.Views.GetHashCode();
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