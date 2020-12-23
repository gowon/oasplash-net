using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using OASplash.Client.Models;

// ReSharper disable once CheckNamespace
namespace OASplash.Client
{
    public partial class UnsplashClient
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
        /// <param name='customHeaders'>
        ///     Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        ///     The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        ///     Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        ///     Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        ///     A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Photo>> GetSingleRandomPhotoWithHttpMessagesAsync(
            string collections = default, bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            // Tracing
            var _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                var tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("collections", collections);
                tracingParameters.Add("featured", featured);
                tracingParameters.Add("username", username);
                tracingParameters.Add("query", query);
                tracingParameters.Add("orientation", orientation);
                tracingParameters.Add("contentFilter", contentFilter);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetRandomPhoto", tracingParameters);
            }

            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "photos/random").ToString();
            var _queryParameters = new List<string>();
            if (collections != null)
                _queryParameters.Add(string.Format("collections={0}", Uri.EscapeDataString(collections)));
            if (featured != null)
                _queryParameters.Add(string.Format("featured={0}",
                    Uri.EscapeDataString(SafeJsonConvert.SerializeObject(featured, SerializationSettings).Trim('"'))));
            if (username != null) _queryParameters.Add(string.Format("username={0}", Uri.EscapeDataString(username)));
            if (query != null) _queryParameters.Add(string.Format("query={0}", Uri.EscapeDataString(query)));
            if (orientation != null)
                _queryParameters.Add(string.Format("orientation={0}",
                    Uri.EscapeDataString(SafeJsonConvert.SerializeObject(orientation, SerializationSettings)
                        .Trim('"'))));
            if (contentFilter != null)
                _queryParameters.Add(string.Format("content_filter={0}",
                    Uri.EscapeDataString(
                        SafeJsonConvert.SerializeObject(contentFilter, SerializationSettings).Trim('"'))));
            if (_queryParameters.Count > 0) _url += "?" + string.Join("&", _queryParameters);
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new Uri(_url);
            // Set Headers


            if (customHeaders != null)
                foreach (var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key)) _httpRequest.Headers.Remove(_header.Key);
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }

            // Send Request
            if (_shouldTrace) ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace) ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            var _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int) _statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'",
                    _statusCode));
                if (_httpResponse.Content != null)
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                else
                    _responseContent = string.Empty;
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace) ServiceClientTracing.Error(_invocationId, ex);
                _httpRequest.Dispose();
                if (_httpResponse != null) _httpResponse.Dispose();
                throw ex;
            }

            // Create Result
            var _result = new HttpOperationResponse<Photo>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int) _statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<Photo>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null) _httpResponse.Dispose();
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }

            if (_shouldTrace) ServiceClientTracing.Exit(_invocationId, _result);
            return _result;
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
        /// <param name='customHeaders'>
        ///     Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        ///     The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        ///     Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        ///     Thrown when unable to deserialize the response
        /// </exception>
        /// <return>
        ///     A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<IList<Photo>>> GetRandomPhotosWithHttpMessagesAsync(
            string collections = default, bool? featured = default, string username = default, string query = default,
            Orientation? orientation = default, ContentFilter? contentFilter = default, int? count = default,
            Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default)
        {
            count ??= 1;
            
            // Tracing
            var _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                var tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("collections", collections);
                tracingParameters.Add("featured", featured);
                tracingParameters.Add("username", username);
                tracingParameters.Add("query", query);
                tracingParameters.Add("orientation", orientation);
                tracingParameters.Add("contentFilter", contentFilter);
                tracingParameters.Add("count", count);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetRandomPhoto", tracingParameters);
            }

            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "photos/random").ToString();
            var _queryParameters = new List<string>();
            if (collections != null)
                _queryParameters.Add(string.Format("collections={0}", Uri.EscapeDataString(collections)));
            if (featured != null)
                _queryParameters.Add(string.Format("featured={0}",
                    Uri.EscapeDataString(SafeJsonConvert.SerializeObject(featured, SerializationSettings).Trim('"'))));
            if (username != null) _queryParameters.Add(string.Format("username={0}", Uri.EscapeDataString(username)));
            if (query != null) _queryParameters.Add(string.Format("query={0}", Uri.EscapeDataString(query)));
            if (orientation != null)
                _queryParameters.Add(string.Format("orientation={0}",
                    Uri.EscapeDataString(SafeJsonConvert.SerializeObject(orientation, SerializationSettings)
                        .Trim('"'))));
            if (contentFilter != null)
                _queryParameters.Add(string.Format("content_filter={0}",
                    Uri.EscapeDataString(
                        SafeJsonConvert.SerializeObject(contentFilter, SerializationSettings).Trim('"'))));
            if (count != null)
                _queryParameters.Add(string.Format("count={0}",
                    Uri.EscapeDataString(SafeJsonConvert.SerializeObject(count, SerializationSettings).Trim('"'))));
            if (_queryParameters.Count > 0) _url += "?" + string.Join("&", _queryParameters);
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new Uri(_url);
            // Set Headers


            if (customHeaders != null)
                foreach (var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key)) _httpRequest.Headers.Remove(_header.Key);
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }

            // Send Request
            if (_shouldTrace) ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace) ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            var _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int) _statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'",
                    _statusCode));
                if (_httpResponse.Content != null)
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                else
                    _responseContent = string.Empty;
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace) ServiceClientTracing.Error(_invocationId, ex);
                _httpRequest.Dispose();
                if (_httpResponse != null) _httpResponse.Dispose();
                throw ex;
            }

            // Create Result
            var _result = new HttpOperationResponse<IList<Photo>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int) _statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body =
                        SafeJsonConvert.DeserializeObject<IList<Photo>>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null) _httpResponse.Dispose();
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }

            if (_shouldTrace) ServiceClientTracing.Exit(_invocationId, _result);
            return _result;
        }
    }
}