# OASPlash.Core.Api.PhotosApi

All URIs are relative to *https://api.unsplash.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPhotoById**](PhotosApi.md#getphotobyid) | **GET** /photos/{id} | Get a photo
[**GetPhotoStatistics**](PhotosApi.md#getphotostatistics) | **GET** /photos/{id}/statistics | Get a photo&#39;s statistics
[**GetPhotos**](PhotosApi.md#getphotos) | **GET** /photos | List photos
[**GetRandomPhoto**](PhotosApi.md#getrandomphoto) | **GET** /photos/random | Get a random photo
[**LikePhoto**](PhotosApi.md#likephoto) | **POST** /photos/{id}/like | Like a photo on behalf of the logged-in user.
[**TrackPhotoDownload**](PhotosApi.md#trackphotodownload) | **GET** /photos/{id}/download | Track a photo download
[**UnlikePhoto**](PhotosApi.md#unlikephoto) | **DELETE** /photos/{id}/like | Remove a user&#39;s like of a photo.
[**UpdatePhoto**](PhotosApi.md#updatephoto) | **PUT** /photos/{id} | Update a photo


<a name="getphotobyid"></a>
# **GetPhotoById**
> Photo GetPhotoById (string id)

Get a photo

Retrieve a single photo.

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
    public class GetPhotoByIdExample
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
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The photo's ID.

            try
            {
                // Get a photo
                Photo result = apiInstance.GetPhotoById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.GetPhotoById: " + e.Message );
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
 **id** | **string**| The photo&#39;s ID. | 

### Return type

[**Photo**](Photo.md)

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

<a name="getphotostatistics"></a>
# **GetPhotoStatistics**
> PhotoStatistics GetPhotoStatistics (string id, StatResolution? resolution = null, int? quantity = null)

Get a photo's statistics

Retrieve total number of downloads, views and likes of a single photo, as well as the historical breakdown of these stats in a specific timeframe (default is 30 days). 

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
    public class GetPhotoStatisticsExample
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
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The public id of the photo.
            var resolution = ;  // StatResolution? | The frequency of the stats. (Optional; default: “days”)  (optional) 
            var quantity = 56;  // int? | The amount of for each stat. (Optional; default: 30)  (optional) 

            try
            {
                // Get a photo's statistics
                PhotoStatistics result = apiInstance.GetPhotoStatistics(id, resolution, quantity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.GetPhotoStatistics: " + e.Message );
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
 **id** | **string**| The public id of the photo. | 
 **resolution** | **StatResolution?**| The frequency of the stats. (Optional; default: “days”)  | [optional] 
 **quantity** | **int?**| The amount of for each stat. (Optional; default: 30)  | [optional] 

### Return type

[**PhotoStatistics**](PhotoStatistics.md)

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

<a name="getphotos"></a>
# **GetPhotos**
> List&lt;Photo&gt; GetPhotos (int? page = null, int? perPage = null, OrderBy? orderBy = null)

List photos

Get a single page from the list of all photos.

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
    public class GetPhotosExample
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
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 
            var orderBy = ;  // OrderBy? | How to sort the photos. Optional. (Valid values: latest, oldest, popular; default: latest)  (optional) 

            try
            {
                // List photos
                List<Photo> result = apiInstance.GetPhotos(page, perPage, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.GetPhotos: " + e.Message );
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
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 
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

<a name="getrandomphoto"></a>
# **GetRandomPhoto**
> List&lt;Photo&gt; GetRandomPhoto (int count, string collections = null, bool? featured = null, string username = null, string query = null, Orientation? orientation = null, ContentFilter? contentFilter = null)

Get a random photo

Retrieve a single random photo, given optional filters. You can't use the collections and query parameters in the same request When supplying a count parameter - and only then - the response will be an array of photos, even if the value of count is 1. 

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
    public class GetRandomPhotoExample
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
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var count = 56;  // int | The number of photos to return. (Default: 1; max: 30) 
            var collections = collections_example;  // string | Public collection ID(‘s) to filter selection. If multiple, comma-separated (optional) 
            var featured = true;  // bool? | Limit selection to featured photos. (optional) 
            var username = username_example;  // string | Limit selection to a single user. (optional) 
            var query = query_example;  // string | Limit selection to photos matching a search term. (optional) 
            var orientation = ;  // Orientation? | Filter by photo orientation. (Valid values: landscape, portrait, squarish)  (optional) 
            var contentFilter = ;  // ContentFilter? | Limit results by content safety. Default: low. Valid values are low and high.  (optional) 

            try
            {
                // Get a random photo
                List<Photo> result = apiInstance.GetRandomPhoto(count, collections, featured, username, query, orientation, contentFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.GetRandomPhoto: " + e.Message );
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
 **count** | **int**| The number of photos to return. (Default: 1; max: 30)  | 
 **collections** | **string**| Public collection ID(‘s) to filter selection. If multiple, comma-separated | [optional] 
 **featured** | **bool?**| Limit selection to featured photos. | [optional] 
 **username** | **string**| Limit selection to a single user. | [optional] 
 **query** | **string**| Limit selection to photos matching a search term. | [optional] 
 **orientation** | **Orientation?**| Filter by photo orientation. (Valid values: landscape, portrait, squarish)  | [optional] 
 **contentFilter** | **ContentFilter?**| Limit results by content safety. Default: low. Valid values are low and high.  | [optional] 

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

<a name="likephoto"></a>
# **LikePhoto**
> Photo LikePhoto (string id)

Like a photo on behalf of the logged-in user.

This action is idempotent; sending the POST request to a single photo multiple times has no additional effect. 

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
    public class LikePhotoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.unsplash.com";
            // Configure Bearer token for authorization: userAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The photo's ID.

            try
            {
                // Like a photo on behalf of the logged-in user.
                Photo result = apiInstance.LikePhoto(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.LikePhoto: " + e.Message );
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
 **id** | **string**| The photo&#39;s ID. | 

### Return type

[**Photo**](Photo.md)

### Authorization

[userAuth](../README.md#userAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackphotodownload"></a>
# **TrackPhotoDownload**
> Photo TrackPhotoDownload (string id)

Track a photo download

To abide by the API guidelines, you need to trigger a GET request to this endpoint every time your application performs a download of a photo. To understand what constitutes a download, please refer to the ‘Triggering a download' guideline. 

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
    public class TrackPhotoDownloadExample
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
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The photo's ID.

            try
            {
                // Track a photo download
                Photo result = apiInstance.TrackPhotoDownload(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.TrackPhotoDownload: " + e.Message );
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
 **id** | **string**| The photo&#39;s ID. | 

### Return type

[**Photo**](Photo.md)

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

<a name="unlikephoto"></a>
# **UnlikePhoto**
> Photo UnlikePhoto (string id)

Remove a user's like of a photo.

This action is idempotent; sending the DELETE request to a single photo multiple times has no additional effect. 

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
    public class UnlikePhotoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.unsplash.com";
            // Configure Bearer token for authorization: userAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The photo's ID.

            try
            {
                // Remove a user's like of a photo.
                Photo result = apiInstance.UnlikePhoto(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.UnlikePhoto: " + e.Message );
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
 **id** | **string**| The photo&#39;s ID. | 

### Return type

[**Photo**](Photo.md)

### Authorization

[userAuth](../README.md#userAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatephoto"></a>
# **UpdatePhoto**
> Photo UpdatePhoto (string id, string description = null, bool? showOnProfile = null, string tags = null, double? locationLatitude = null, double? locationLongitude = null, string locationName = null, string locationCity = null, string locationCountry = null, string exifMake = null, string exifModel = null, string exifExposureTime = null, string exifApertureValue = null, string exifFocalLength = null, string exifIsoSpeedRatings = null)

Update a photo

Update a photo on behalf of the logged-in user. This requires the write_photos scope.

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
    public class UpdatePhotoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.unsplash.com";
            // Configure Bearer token for authorization: userAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PhotosApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The photo's ID.
            var description = description_example;  // string | The photo's description (Optional). (optional) 
            var showOnProfile = true;  // bool? | The photo's visibility (Optional). (optional) 
            var tags = tags_example;  // string | The photo's tags (Optional). (optional) 
            var locationLatitude = 1.2D;  // double? | The photo location's latitude rounded to 6 decimals. (Optional) (optional) 
            var locationLongitude = 1.2D;  // double? | The photo location's longitude rounded to 6 decimals. (Optional) (optional) 
            var locationName = locationName_example;  // string | The photo's full location string (including city and country) (Optional) (optional) 
            var locationCity = locationCity_example;  // string | The photo location's city (Optional) (optional) 
            var locationCountry = locationCountry_example;  // string | The photo location's country (Optional) (optional) 
            var exifMake = exifMake_example;  // string | Camera's brand (Optional) (optional) 
            var exifModel = exifModel_example;  // string | Camera's model (Optional) (optional) 
            var exifExposureTime = exifExposureTime_example;  // string | Camera's exposure time (Optional) (optional) 
            var exifApertureValue = exifApertureValue_example;  // string | Camera's aperture value (Optional) (optional) 
            var exifFocalLength = exifFocalLength_example;  // string | Camera's focal length (Optional) (optional) 
            var exifIsoSpeedRatings = exifIsoSpeedRatings_example;  // string | Camera's iso (Optional) (optional) 

            try
            {
                // Update a photo
                Photo result = apiInstance.UpdatePhoto(id, description, showOnProfile, tags, locationLatitude, locationLongitude, locationName, locationCity, locationCountry, exifMake, exifModel, exifExposureTime, exifApertureValue, exifFocalLength, exifIsoSpeedRatings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhotosApi.UpdatePhoto: " + e.Message );
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
 **id** | **string**| The photo&#39;s ID. | 
 **description** | **string**| The photo&#39;s description (Optional). | [optional] 
 **showOnProfile** | **bool?**| The photo&#39;s visibility (Optional). | [optional] 
 **tags** | **string**| The photo&#39;s tags (Optional). | [optional] 
 **locationLatitude** | **double?**| The photo location&#39;s latitude rounded to 6 decimals. (Optional) | [optional] 
 **locationLongitude** | **double?**| The photo location&#39;s longitude rounded to 6 decimals. (Optional) | [optional] 
 **locationName** | **string**| The photo&#39;s full location string (including city and country) (Optional) | [optional] 
 **locationCity** | **string**| The photo location&#39;s city (Optional) | [optional] 
 **locationCountry** | **string**| The photo location&#39;s country (Optional) | [optional] 
 **exifMake** | **string**| Camera&#39;s brand (Optional) | [optional] 
 **exifModel** | **string**| Camera&#39;s model (Optional) | [optional] 
 **exifExposureTime** | **string**| Camera&#39;s exposure time (Optional) | [optional] 
 **exifApertureValue** | **string**| Camera&#39;s aperture value (Optional) | [optional] 
 **exifFocalLength** | **string**| Camera&#39;s focal length (Optional) | [optional] 
 **exifIsoSpeedRatings** | **string**| Camera&#39;s iso (Optional) | [optional] 

### Return type

[**Photo**](Photo.md)

### Authorization

[userAuth](../README.md#userAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

