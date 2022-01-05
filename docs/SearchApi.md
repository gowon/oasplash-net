# OASPlash.Core.Api.SearchApi

All URIs are relative to *https://api.unsplash.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchCollections**](SearchApi.md#searchcollections) | **GET** /search/collections | Search collections
[**SearchPhotos**](SearchApi.md#searchphotos) | **GET** /search/photos | Search photos
[**SearchUsers**](SearchApi.md#searchusers) | **GET** /search/users | Search users


<a name="searchcollections"></a>
# **SearchCollections**
> CollectionSearchResults SearchCollections (string query, int? page = null, int? perPage = null)

Search collections

Get a single page of collection results for a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OASPlash.Core.Api;
using OASPlash.Core.Client;
using OASPlash.Core.Model;

namespace Example
{
    public class SearchCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.unsplash.com";
            // Configure API key authorization: publicAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var query = query_example;  // string | Search terms.
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 

            try
            {
                // Search collections
                CollectionSearchResults result = apiInstance.SearchCollections(query, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCollections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search terms. | 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 

### Return type

[**CollectionSearchResults**](CollectionSearchResults.md)

### Authorization

[publicAuth](../README.md#publicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchphotos"></a>
# **SearchPhotos**
> PhotoSearchResults SearchPhotos (string query, int? page = null, int? perPage = null, OrderBy? orderBy = null, string collections = null, ContentFilter? contentFilter = null, Color? color = null, Orientation? orientation = null)

Search photos

Get a single page of photo results for a query. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OASPlash.Core.Api;
using OASPlash.Core.Client;
using OASPlash.Core.Model;

namespace Example
{
    public class SearchPhotosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.unsplash.com";
            // Configure API key authorization: publicAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var query = query_example;  // string | Search terms.
            var page = 56;  // int? | Page number to retrieve. (Optional; default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 
            var orderBy = ;  // OrderBy? | How to sort the photos. (Optional; default: relevant). Valid values are latest and relevant.  (optional) 
            var collections = collections_example;  // string | Collection ID(‘s) to narrow search. Optional. If multiple, comma-separated.  (optional) 
            var contentFilter = ;  // ContentFilter? | Limit results by content safety. (Optional; default: low). Valid values are low and high.  (optional) 
            var color = ;  // Color? | Filter results by color. Optional. Valid values are: black_and_white, black, white, yellow, orange, red, purple, magenta, green, teal, and blue.  (optional) 
            var orientation = ;  // Orientation? | Filter by photo orientation. Optional. (Valid values: landscape, portrait, squarish)  (optional) 

            try
            {
                // Search photos
                PhotoSearchResults result = apiInstance.SearchPhotos(query, page, perPage, orderBy, collections, contentFilter, color, orientation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchPhotos: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search terms. | 
 **page** | **int?**| Page number to retrieve. (Optional; default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 
 **orderBy** | **OrderBy?**| How to sort the photos. (Optional; default: relevant). Valid values are latest and relevant.  | [optional] 
 **collections** | **string**| Collection ID(‘s) to narrow search. Optional. If multiple, comma-separated.  | [optional] 
 **contentFilter** | **ContentFilter?**| Limit results by content safety. (Optional; default: low). Valid values are low and high.  | [optional] 
 **color** | **Color?**| Filter results by color. Optional. Valid values are: black_and_white, black, white, yellow, orange, red, purple, magenta, green, teal, and blue.  | [optional] 
 **orientation** | **Orientation?**| Filter by photo orientation. Optional. (Valid values: landscape, portrait, squarish)  | [optional] 

### Return type

[**PhotoSearchResults**](PhotoSearchResults.md)

### Authorization

[publicAuth](../README.md#publicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchusers"></a>
# **SearchUsers**
> UserSearchResults SearchUsers (string query, int? page = null, int? perPage = null)

Search users

Get a single page of user results for a query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OASPlash.Core.Api;
using OASPlash.Core.Client;
using OASPlash.Core.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.unsplash.com";
            // Configure API key authorization: publicAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var query = query_example;  // string | Search terms.
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 

            try
            {
                // Search users
                UserSearchResults result = apiInstance.SearchUsers(query, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search terms. | 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 

### Return type

[**UserSearchResults**](UserSearchResults.md)

### Authorization

[publicAuth](../README.md#publicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

