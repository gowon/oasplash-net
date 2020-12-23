using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OASplash.Client.Models;

// ReSharper disable once CheckNamespace
namespace OASplash.Client
{
    public static partial class UnsplashClientExtensions
    {
        /// <summary>
        ///     Get a random photo
        /// </summary>
        /// <remarks>
        ///     Retrieve a single random photo, given optional filters.
        ///     You can’t use the collections and query parameters in the same request
        ///     When supplying a count parameter - and only then - the response will be an
        ///     array of photos, even if the value of count is 1.
        /// </remarks>
        /// <param name='operations'>
        ///     The operations group for this extension method.
        /// </param>
        /// <param name='collections'>
        ///     Public collection ID(‘s) to filter selection. If multiple, comma-separated
        /// </param>
        /// <param name='featured'>
        ///     Limit selection to featured photos.
        /// </param>
        /// <param name='username'>
        ///     Limit selection to a single user.
        /// </param>
        /// <param name='query'>
        ///     Limit selection to photos matching a search term.
        /// </param>
        /// <param name='orientation'>
        ///     Filter by photo orientation. (Valid values: landscape, portrait, squarish)
        ///     . Possible values include: 'landscape', 'portrait', 'squarish'
        /// </param>
        /// <param name='contentFilter'>
        ///     Limit results by content safety. Default: low. Valid values are low and
        ///     high.
        ///     . Possible values include: 'low', 'high'
        /// </param>
        /// <param name='count'>
        ///     The number of photos to return. (Default: 1; max: 30)
        /// </param>
        public static Photo GetSingleRandomPhoto(this IUnsplashClient operations, string collections = default,
            bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default, int? count = default)
        {
            return operations
                .GetSingleRandomPhotoAsync(collections, featured, username, query, orientation, contentFilter, count)
                .GetAwaiter().GetResult();
        }


        /// <summary>
        ///     Get a random photo
        /// </summary>
        /// <remarks>
        ///     Retrieve a single random photo, given optional filters.
        ///     You can’t use the collections and query parameters in the same request
        ///     When supplying a count parameter - and only then - the response will be an
        ///     array of photos, even if the value of count is 1.
        /// </remarks>
        /// <param name='operations'>
        ///     The operations group for this extension method.
        /// </param>
        /// <param name='collections'>
        ///     Public collection ID(‘s) to filter selection. If multiple, comma-separated
        /// </param>
        /// <param name='featured'>
        ///     Limit selection to featured photos.
        /// </param>
        /// <param name='username'>
        ///     Limit selection to a single user.
        /// </param>
        /// <param name='query'>
        ///     Limit selection to photos matching a search term.
        /// </param>
        /// <param name='orientation'>
        ///     Filter by photo orientation. (Valid values: landscape, portrait, squarish)
        ///     . Possible values include: 'landscape', 'portrait', 'squarish'
        /// </param>
        /// <param name='contentFilter'>
        ///     Limit results by content safety. Default: low. Valid values are low and
        ///     high.
        ///     . Possible values include: 'low', 'high'
        /// </param>
        /// <param name='count'>
        ///     The number of photos to return. (Default: 1; max: 30)
        /// </param>
        /// <param name='cancellationToken'>
        ///     The cancellation token.
        /// </param>
        public static async Task<Photo> GetSingleRandomPhotoAsync(this IUnsplashClient operations,
            string collections = default, bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default, int? count = default,
            CancellationToken cancellationToken = default)
        {
            using (var _result = await operations.GetSingleRandomPhotoWithHttpMessagesAsync(collections, featured,
                username,
                query, orientation, contentFilter, count, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        ///     Get random photos
        /// </summary>
        /// <remarks>
        ///     Retrieve a single random photo, given optional filters.
        ///     You can’t use the collections and query parameters in the same request
        ///     When supplying a count parameter - and only then - the response will be an
        ///     array of photos, even if the value of count is 1.
        /// </remarks>
        /// <param name='operations'>
        ///     The operations group for this extension method.
        /// </param>
        /// <param name='collections'>
        ///     Public collection ID(‘s) to filter selection. If multiple, comma-separated
        /// </param>
        /// <param name='featured'>
        ///     Limit selection to featured photos.
        /// </param>
        /// <param name='username'>
        ///     Limit selection to a single user.
        /// </param>
        /// <param name='query'>
        ///     Limit selection to photos matching a search term.
        /// </param>
        /// <param name='orientation'>
        ///     Filter by photo orientation. (Valid values: landscape, portrait, squarish)
        ///     . Possible values include: 'landscape', 'portrait', 'squarish'
        /// </param>
        /// <param name='contentFilter'>
        ///     Limit results by content safety. Default: low. Valid values are low and
        ///     high.
        ///     . Possible values include: 'low', 'high'
        /// </param>
        /// <param name='count'>
        ///     The number of photos to return. (Default: 1; max: 30)
        /// </param>
        public static IList<Photo> GetRandomPhotos(this IUnsplashClient operations, string collections = default,
            bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default, int? count = default)
        {
            return operations
                .GetRandomPhotosAsync(collections, featured, username, query, orientation, contentFilter, count)
                .GetAwaiter().GetResult();
        }

        /// <summary>
        ///     Get random photos
        /// </summary>
        /// <remarks>
        ///     Retrieve a single random photo, given optional filters.
        ///     You can’t use the collections and query parameters in the same request
        ///     When supplying a count parameter - and only then - the response will be an
        ///     array of photos, even if the value of count is 1.
        /// </remarks>
        /// <param name='operations'>
        ///     The operations group for this extension method.
        /// </param>
        /// <param name='collections'>
        ///     Public collection ID(‘s) to filter selection. If multiple, comma-separated
        /// </param>
        /// <param name='featured'>
        ///     Limit selection to featured photos.
        /// </param>
        /// <param name='username'>
        ///     Limit selection to a single user.
        /// </param>
        /// <param name='query'>
        ///     Limit selection to photos matching a search term.
        /// </param>
        /// <param name='orientation'>
        ///     Filter by photo orientation. (Valid values: landscape, portrait, squarish)
        ///     . Possible values include: 'landscape', 'portrait', 'squarish'
        /// </param>
        /// <param name='contentFilter'>
        ///     Limit results by content safety. Default: low. Valid values are low and
        ///     high.
        ///     . Possible values include: 'low', 'high'
        /// </param>
        /// <param name='count'>
        ///     The number of photos to return. (Default: 1; max: 30)
        /// </param>
        /// <param name='cancellationToken'>
        ///     The cancellation token.
        /// </param>
        public static async Task<IList<Photo>> GetRandomPhotosAsync(this IUnsplashClient operations,
            string collections = default, bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default, int? count = default,
            CancellationToken cancellationToken = default)
        {
            using (var _result = await operations.GetRandomPhotosWithHttpMessagesAsync(collections, featured, username,
                query, orientation, contentFilter, count, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}