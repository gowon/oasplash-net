// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace OASplash.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PhotoStatisticsLikes
    {
        /// <summary>
        /// Initializes a new instance of the PhotoStatisticsLikes class.
        /// </summary>
        public PhotoStatisticsLikes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhotoStatisticsLikes class.
        /// </summary>
        public PhotoStatisticsLikes(int? total = default(int?), PhotoHistoricalData historical = default(PhotoHistoricalData))
        {
            Total = total;
            Historical = historical;
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
        [JsonProperty(PropertyName = "historical")]
        public PhotoHistoricalData Historical { get; set; }

    }
}
