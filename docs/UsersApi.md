# OASPlash.Core.Api.UsersApi

All URIs are relative to *https://api.unsplash.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{username} | Get a user&#39;s public profile
[**GetUserCollections**](UsersApi.md#getusercollections) | **GET** /users/{username}/collections | List a user&#39;s collections
[**GetUserLikedPhotos**](UsersApi.md#getuserlikedphotos) | **GET** /users/{username}/likes | List a user&#39;s liked photos
[**GetUserPhotos**](UsersApi.md#getuserphotos) | **GET** /users/{username}/photos | List a user&#39;s photos
[**GetUserPortfolioLink**](UsersApi.md#getuserportfoliolink) | **GET** /users/{username}/portfolio | Get a user&#39;s portfolio link
[**GetUserStatistics**](UsersApi.md#getuserstatistics) | **GET** /users/{username}/statistics | Get a user&#39;s statistics


<a name="getuser"></a>
# **GetUser**
> User GetUser (string username)

Get a user's public profile

Retrieve public details on a given user.

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
    public class GetUserExample
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
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var username = username_example;  // string | The user's username.

            try
            {
                // Get a user's public profile
                User result = apiInstance.GetUser(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
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
 **username** | **string**| The user&#39;s username. | 

### Return type

[**User**](User.md)

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

<a name="getusercollections"></a>
# **GetUserCollections**
> List&lt;Collection&gt; GetUserCollections (string username, int? page = null, int? perPage = null)

List a user's collections

Get a list of collections created by the user.

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
    public class GetUserCollectionsExample
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
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var username = username_example;  // string | The user's username.
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 

            try
            {
                // List a user's collections
                List<Collection> result = apiInstance.GetUserCollections(username, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserCollections: " + e.Message );
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
 **username** | **string**| The user&#39;s username. | 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 

### Return type

**List<Collection>**

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

<a name="getuserlikedphotos"></a>
# **GetUserLikedPhotos**
> List&lt;Photo&gt; GetUserLikedPhotos (string username, int? page = null, int? perPage = null, OrderBy? orderBy = null, Orientation? orientation = null)

List a user's liked photos

Get a list of photos liked by a user.

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
    public class GetUserLikedPhotosExample
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
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var username = username_example;  // string | The user's username. 
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 
            var orderBy = ;  // OrderBy? | How to sort the photos. Optional. (Valid values: latest, oldest, popular; default: latest)  (optional) 
            var orientation = ;  // Orientation? | Filter by photo orientation. Optional. (Valid values: landscape, portrait, squarish)  (optional) 

            try
            {
                // List a user's liked photos
                List<Photo> result = apiInstance.GetUserLikedPhotos(username, page, perPage, orderBy, orientation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserLikedPhotos: " + e.Message );
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
 **username** | **string**| The user&#39;s username.  | 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 
 **orderBy** | **OrderBy?**| How to sort the photos. Optional. (Valid values: latest, oldest, popular; default: latest)  | [optional] 
 **orientation** | **Orientation?**| Filter by photo orientation. Optional. (Valid values: landscape, portrait, squarish)  | [optional] 

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

<a name="getuserphotos"></a>
# **GetUserPhotos**
> List&lt;Photo&gt; GetUserPhotos (string username, int? page = null, int? perPage = null, OrderBy? orderBy = null, bool? stats = null, StatResolution? resolution = null, int? quantity = null, Orientation? orientation = null)

List a user's photos

Get a list of photos uploaded by a user.

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
    public class GetUserPhotosExample
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
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var username = username_example;  // string | The user's username.
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 
            var orderBy = ;  // OrderBy? | How to sort the photos. Optional. (Valid values: latest, oldest, popular; default: latest)  (optional) 
            var stats = true;  // bool? | Show the stats for each user's photo. (Optional; default: false)  (optional) 
            var resolution = ;  // StatResolution? | The frequency of the stats. (Optional; default: “days”)  (optional) 
            var quantity = 56;  // int? | The amount of for each stat. (Optional; default: 30)  (optional) 
            var orientation = ;  // Orientation? | Filter by photo orientation. Optional. (Valid values: landscape, portrait, squarish)  (optional) 

            try
            {
                // List a user's photos
                List<Photo> result = apiInstance.GetUserPhotos(username, page, perPage, orderBy, stats, resolution, quantity, orientation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserPhotos: " + e.Message );
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
 **username** | **string**| The user&#39;s username. | 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 
 **orderBy** | **OrderBy?**| How to sort the photos. Optional. (Valid values: latest, oldest, popular; default: latest)  | [optional] 
 **stats** | **bool?**| Show the stats for each user&#39;s photo. (Optional; default: false)  | [optional] 
 **resolution** | **StatResolution?**| The frequency of the stats. (Optional; default: “days”)  | [optional] 
 **quantity** | **int?**| The amount of for each stat. (Optional; default: 30)  | [optional] 
 **orientation** | **Orientation?**| Filter by photo orientation. Optional. (Valid values: landscape, portrait, squarish)  | [optional] 

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

<a name="getuserportfoliolink"></a>
# **GetUserPortfolioLink**
> PortfolioLink GetUserPortfolioLink (string username)

Get a user's portfolio link

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
    public class GetUserPortfolioLinkExample
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
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var username = username_example;  // string | The user's username.

            try
            {
                // Get a user's portfolio link
                PortfolioLink result = apiInstance.GetUserPortfolioLink(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserPortfolioLink: " + e.Message );
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
 **username** | **string**| The user&#39;s username. | 

### Return type

[**PortfolioLink**](PortfolioLink.md)

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

<a name="getuserstatistics"></a>
# **GetUserStatistics**
> UserStatistics GetUserStatistics (string username, StatResolution? resolution = null, int? quantity = null)

Get a user's statistics

Retrieve the consolidated number of downloads, views and likes of all user's photos, as well as the historical breakdown and average of these stats in a specific timeframe (default is 30 days).

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
    public class GetUserStatisticsExample
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
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var username = username_example;  // string | The user's username.
            var resolution = ;  // StatResolution? | The frequency of the stats. (Optional; default: “days”)  (optional) 
            var quantity = 56;  // int? |  The amount of for each stat. (Optional; default: 30)  (optional) 

            try
            {
                // Get a user's statistics
                UserStatistics result = apiInstance.GetUserStatistics(username, resolution, quantity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserStatistics: " + e.Message );
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
 **username** | **string**| The user&#39;s username. | 
 **resolution** | **StatResolution?**| The frequency of the stats. (Optional; default: “days”)  | [optional] 
 **quantity** | **int?**|  The amount of for each stat. (Optional; default: 30)  | [optional] 

### Return type

[**UserStatistics**](UserStatistics.md)

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

