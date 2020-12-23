using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using OASplash.Client.Models;

// ReSharper disable once CheckNamespace
namespace OASplash.Client
{
    public partial interface IUnsplashClient
    {
        Task<HttpOperationResponse<Photo>> GetSingleRandomPhotoWithHttpMessagesAsync(
            string collections = default, bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default, int? count = default,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);

        Task<HttpOperationResponse<IList<Photo>>> GetRandomPhotosWithHttpMessagesAsync(
            string collections = default, bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default, int? count = default,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default);
    }
}