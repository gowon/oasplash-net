# OASPlash.Core.Api.CollectionsApi

All URIs are relative to *https://api.unsplash.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPhotoToCollection**](CollectionsApi.md#addphototocollection) | **POST** /collections/{collection_id}/add | Add a photo to a collection
[**CreateNewCollection**](CollectionsApi.md#createnewcollection) | **POST** /collections | Create a new collection
[**DeleteCollectionById**](CollectionsApi.md#deletecollectionbyid) | **DELETE** /collections/{id} | Delete a collection
[**GetCollectionById**](CollectionsApi.md#getcollectionbyid) | **GET** /collections/{id} | Get a collection
[**GetCollectionPhotos**](CollectionsApi.md#getcollectionphotos) | **GET** /collections/{id}/photos | Get a collection&#39;s photos
[**GetCollections**](CollectionsApi.md#getcollections) | **GET** /collections | List collections
[**GetRelatedCollections**](CollectionsApi.md#getrelatedcollections) | **GET** /collections/{id}/related | List a collection&#39;s related collections
[**RemovePhotoFromCollection**](CollectionsApi.md#removephotofromcollection) | **DELETE** /collections/{collection_id}/remove | Remove a photo from a collection
[**UpdateCollection**](CollectionsApi.md#updatecollection) | **PUT** /collections/{id} | Update an existing collection


<a name="addphototocollection"></a>
# **AddPhotoToCollection**
> OperationResponse AddPhotoToCollection (string collectionId, string photoId)

Add a photo to a collection

Add a photo to one of the logged-in user's collections. Requires the write_collections scope. If the photo is already in the collection, this action has no effect.

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
    public class AddPhotoToCollectionExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var collectionId = collectionId_example;  // string | The collection's ID.
            var photoId = photoId_example;  // string | The photo's ID.

            try
            {
                // Add a photo to a collection
                OperationResponse result = apiInstance.AddPhotoToCollection(collectionId, photoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddPhotoToCollection: " + e.Message );
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
 **collectionId** | **string**| The collection&#39;s ID. | 
 **photoId** | **string**| The photo&#39;s ID. | 

### Return type

[**OperationResponse**](OperationResponse.md)

### Authorization

[userAuth](../README.md#userAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnewcollection"></a>
# **CreateNewCollection**
> Collection CreateNewCollection (string title, string description = null, bool? _private = null)

Create a new collection

Create a new collection. This requires the write_collections scope.

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
    public class CreateNewCollectionExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var title = title_example;  // string | The title of the collection.
            var description = description_example;  // string | The collection's description. (Optional.) (optional) 
            var _private = true;  // bool? | Whether to make this collection private. (Optional; default false). (optional) 

            try
            {
                // Create a new collection
                Collection result = apiInstance.CreateNewCollection(title, description, _private);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateNewCollection: " + e.Message );
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
 **title** | **string**| The title of the collection. | 
 **description** | **string**| The collection&#39;s description. (Optional.) | [optional] 
 **_private** | **bool?**| Whether to make this collection private. (Optional; default false). | [optional] 

### Return type

**Collection**

### Authorization

[userAuth](../README.md#userAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollectionbyid"></a>
# **DeleteCollectionById**
> void DeleteCollectionById (string id)

Delete a collection

Delete a collection belonging to the logged-in user. This requires the write_collections scope.

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
    public class DeleteCollectionByIdExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The collection's ID.

            try
            {
                // Delete a collection
                apiInstance.DeleteCollectionById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteCollectionById: " + e.Message );
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
 **id** | **string**| The collection&#39;s ID. | 

### Return type

void (empty response body)

### Authorization

[userAuth](../README.md#userAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionbyid"></a>
# **GetCollectionById**
> Collection GetCollectionById (string id)

Get a collection

Retrieve a single collection. To view a user's private collections, the read_collections scope is required.

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
    public class GetCollectionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.unsplash.com";
            // Configure API key authorization: publicAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: userAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The collections's ID.

            try
            {
                // Get a collection
                Collection result = apiInstance.GetCollectionById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetCollectionById: " + e.Message );
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
 **id** | **string**| The collections&#39;s ID. | 

### Return type

**Collection**

### Authorization

[publicAuth](../README.md#publicAuth), [userAuth](../README.md#userAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionphotos"></a>
# **GetCollectionPhotos**
> List&lt;Photo&gt; GetCollectionPhotos (string id, int? page = null, int? perPage = null, Orientation? orientation = null)

Get a collection's photos

Retrieve a collection's photos.

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
    public class GetCollectionPhotosExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The collection's ID.
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 
            var orientation = ;  // Orientation? | Filter by photo orientation. Optional. (Valid values: landscape, portrait, squarish)  (optional) 

            try
            {
                // Get a collection's photos
                List<Photo> result = apiInstance.GetCollectionPhotos(id, page, perPage, orientation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetCollectionPhotos: " + e.Message );
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
 **id** | **string**| The collection&#39;s ID. | 
 **page** | **int?**| Page number to retrieve. (Optional, default: 1)  | [optional] 
 **perPage** | **int?**| Number of items per page. (Optional; default: 10)  | [optional] 
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

<a name="getcollections"></a>
# **GetCollections**
> List&lt;Collection&gt; GetCollections (int? page = null, int? perPage = null)

List collections

Get a single page from the list of all collections.

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
    public class GetCollectionsExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var page = 56;  // int? | Page number to retrieve. (Optional, default: 1)  (optional) 
            var perPage = 56;  // int? | Number of items per page. (Optional; default: 10)  (optional) 

            try
            {
                // List collections
                List<Collection> result = apiInstance.GetCollections(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetCollections: " + e.Message );
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

<a name="getrelatedcollections"></a>
# **GetRelatedCollections**
> List&lt;Collection&gt; GetRelatedCollections (string id)

List a collection's related collections

Retrieve a list of collections related to this one.

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
    public class GetRelatedCollectionsExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The collection's ID.

            try
            {
                // List a collection's related collections
                List<Collection> result = apiInstance.GetRelatedCollections(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetRelatedCollections: " + e.Message );
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
 **id** | **string**| The collection&#39;s ID. | 

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

<a name="removephotofromcollection"></a>
# **RemovePhotoFromCollection**
> OperationResponse RemovePhotoFromCollection (string collectionId, string photoId)

Remove a photo from a collection

Remove a photo from one of the logged-in user's collections. Requires the write_collections scope.

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
    public class RemovePhotoFromCollectionExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var collectionId = collectionId_example;  // string | The collection's ID.
            var photoId = photoId_example;  // string | The photo's ID.

            try
            {
                // Remove a photo from a collection
                OperationResponse result = apiInstance.RemovePhotoFromCollection(collectionId, photoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemovePhotoFromCollection: " + e.Message );
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
 **collectionId** | **string**| The collection&#39;s ID. | 
 **photoId** | **string**| The photo&#39;s ID. | 

### Return type

[**OperationResponse**](OperationResponse.md)

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

<a name="updatecollection"></a>
# **UpdateCollection**
> Collection UpdateCollection (string id, string title = null, string description = null, bool? _private = null)

Update an existing collection

Update an existing collection belonging to the logged-in user. This requires the write_collections scope.

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
    public class UpdateCollectionExample
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
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var id = id_example;  // string | The collection's ID.
            var title = title_example;  // string | The title of the collection. (Optional.) (optional) 
            var description = description_example;  // string | The collection's description. (Optional.) (optional) 
            var _private = true;  // bool? | Whether to make this collection private. (Optional.) (optional) 

            try
            {
                // Update an existing collection
                Collection result = apiInstance.UpdateCollection(id, title, description, _private);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.UpdateCollection: " + e.Message );
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
 **id** | **string**| The collection&#39;s ID. | 
 **title** | **string**| The title of the collection. (Optional.) | [optional] 
 **description** | **string**| The collection&#39;s description. (Optional.) | [optional] 
 **_private** | **bool?**| Whether to make this collection private. (Optional.) | [optional] 

### Return type

**Collection**

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

