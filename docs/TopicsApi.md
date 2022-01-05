# OASPlash.Core.Api.TopicsApi

All URIs are relative to *https://api.unsplash.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTopicPhotos**](TopicsApi.md#gettopicphotos) | **GET** /topics/{id_or_slug}/photos | Get a topic&#39;s photos
[**ListTopics**](TopicsApi.md#listtopics) | **GET** /topics | List topics


<a name="gettopicphotos"></a>
# **GetTopicPhotos**
> List&lt;Photo&gt; GetTopicPhotos (string idOrSlug, int? page = null, int? perPage = null, Orientation? orientation = null, OrderBy? orderBy = null)

Get a topic's photos

Retrieve a topic's photos.

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
    public class GetTopicPhotosExample
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
            var apiInstance = new TopicsApi(httpClient, config, httpClientHandler);
            var idOrSlug = idOrSlug_example;  // string | The topics's ID or slug.
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 
            var orientation = ;  // Orientation? | Filter by photo orientation. (Optional; Valid values: landscape, portrait, squarish)  (optional) 
            var orderBy = ;  // OrderBy? | How to sort the photos. Optional. (Valid values: latest, oldest, popular; default: latest)  (optional) 

            try
            {
                // Get a topic's photos
                List<Photo> result = apiInstance.GetTopicPhotos(idOrSlug, page, perPage, orientation, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopicsApi.GetTopicPhotos: " + e.Message );
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
 **idOrSlug** | **string**| The topics&#39;s ID or slug. | 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 
 **orientation** | **Orientation?**| Filter by photo orientation. (Optional; Valid values: landscape, portrait, squarish)  | [optional] 
 **orderBy** | **OrderBy?**| How to sort the photos. Optional. (Valid values: latest, oldest, popular; default: latest)  | [optional] 

### Return type

[**List&lt;Photo&gt;**](Photo.md)

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

<a name="listtopics"></a>
# **ListTopics**
> List&lt;Topic&gt; ListTopics (string ids = null, int? page = null, int? perPage = null, TopicsOrderBy? orderBy = null)

List topics

Get a single page from the list of all topics.

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
    public class ListTopicsExample
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
            var apiInstance = new TopicsApi(httpClient, config, httpClientHandler);
            var ids = ids_example;  // string | Limit to only matching topic ids or slugs. (Optional; Comma separated string) (optional) 
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 
            var orderBy = ;  // TopicsOrderBy? | How to sort the photos. Optional. (Valid values: featured, latest, oldest, position; default: position)  (optional) 

            try
            {
                // List topics
                List<Topic> result = apiInstance.ListTopics(ids, page, perPage, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopicsApi.ListTopics: " + e.Message );
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
 **ids** | **string**| Limit to only matching topic ids or slugs. (Optional; Comma separated string) | [optional] 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 
 **orderBy** | **TopicsOrderBy?**| How to sort the photos. Optional. (Valid values: featured, latest, oldest, position; default: position)  | [optional] 

### Return type

[**List&lt;Topic&gt;**](Topic.md)

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

