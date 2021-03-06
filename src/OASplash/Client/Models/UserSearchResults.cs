// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace OASplash.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UserSearchResults
    {
        /// <summary>
        /// Initializes a new instance of the UserSearchResults class.
        /// </summary>
        public UserSearchResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserSearchResults class.
        /// </summary>
        public UserSearchResults(int? total = default(int?), int? totalPages = default(int?), IList<User> results = default(IList<User>))
        {
            Total = total;
            TotalPages = totalPages;
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<User> Results { get; set; }

    }
}
