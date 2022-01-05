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
    /// Collection
    /// </summary>
    [DataContract(Name = "Collection")]
    public partial class Collection : IEquatable<Collection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Collection" /> class.
        /// </summary>
        /// <param name="coverPhoto">coverPhoto.</param>
        /// <param name="description">description.</param>
        /// <param name="featured">featured.</param>
        /// <param name="id">id.</param>
        /// <param name="lastCollectedAt">lastCollectedAt.</param>
        /// <param name="links">links.</param>
        /// <param name="_private">_private.</param>
        /// <param name="publishedAt">publishedAt.</param>
        /// <param name="shareKey">shareKey.</param>
        /// <param name="title">title.</param>
        /// <param name="totalPhotos">totalPhotos.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="user">user.</param>
        public Collection(Photo coverPhoto = default(Photo), string description = default(string), bool featured = default(bool), int id = default(int), DateTime lastCollectedAt = default(DateTime), CollectionLinks links = default(CollectionLinks), bool _private = default(bool), DateTime publishedAt = default(DateTime), string shareKey = default(string), string title = default(string), bool totalPhotos = default(bool), DateTime updatedAt = default(DateTime), User user = default(User))
        {
            this.CoverPhoto = coverPhoto;
            this.Description = description;
            this.Featured = featured;
            this.Id = id;
            this.LastCollectedAt = lastCollectedAt;
            this.Links = links;
            this.Private = _private;
            this.PublishedAt = publishedAt;
            this.ShareKey = shareKey;
            this.Title = title;
            this.TotalPhotos = totalPhotos;
            this.UpdatedAt = updatedAt;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets CoverPhoto
        /// </summary>
        [DataMember(Name = "cover_photo", EmitDefaultValue = false)]
        public Photo CoverPhoto { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Featured
        /// </summary>
        [DataMember(Name = "featured", EmitDefaultValue = true)]
        public bool Featured { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets LastCollectedAt
        /// </summary>
        [DataMember(Name = "last_collected_at", EmitDefaultValue = false)]
        public DateTime LastCollectedAt { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public CollectionLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Private
        /// </summary>
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Gets or Sets PublishedAt
        /// </summary>
        [DataMember(Name = "published_at", EmitDefaultValue = false)]
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Gets or Sets ShareKey
        /// </summary>
        [DataMember(Name = "share_key", EmitDefaultValue = false)]
        public string ShareKey { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TotalPhotos
        /// </summary>
        [DataMember(Name = "total_photos", EmitDefaultValue = true)]
        public bool TotalPhotos { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Collection {\n");
            sb.Append("  CoverPhoto: ").Append(CoverPhoto).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastCollectedAt: ").Append(LastCollectedAt).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
            sb.Append("  ShareKey: ").Append(ShareKey).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TotalPhotos: ").Append(TotalPhotos).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as Collection);
        }

        /// <summary>
        /// Returns true if Collection instances are equal
        /// </summary>
        /// <param name="input">Instance of Collection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Collection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CoverPhoto == input.CoverPhoto ||
                    (this.CoverPhoto != null &&
                    this.CoverPhoto.Equals(input.CoverPhoto))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Featured == input.Featured ||
                    this.Featured.Equals(input.Featured)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.LastCollectedAt == input.LastCollectedAt ||
                    (this.LastCollectedAt != null &&
                    this.LastCollectedAt.Equals(input.LastCollectedAt))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Private == input.Private ||
                    this.Private.Equals(input.Private)
                ) && 
                (
                    this.PublishedAt == input.PublishedAt ||
                    (this.PublishedAt != null &&
                    this.PublishedAt.Equals(input.PublishedAt))
                ) && 
                (
                    this.ShareKey == input.ShareKey ||
                    (this.ShareKey != null &&
                    this.ShareKey.Equals(input.ShareKey))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TotalPhotos == input.TotalPhotos ||
                    this.TotalPhotos.Equals(input.TotalPhotos)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.CoverPhoto != null)
                {
                    hashCode = (hashCode * 59) + this.CoverPhoto.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Featured.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.LastCollectedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastCollectedAt.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Private.GetHashCode();
                if (this.PublishedAt != null)
                {
                    hashCode = (hashCode * 59) + this.PublishedAt.GetHashCode();
                }
                if (this.ShareKey != null)
                {
                    hashCode = (hashCode * 59) + this.ShareKey.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPhotos.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
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