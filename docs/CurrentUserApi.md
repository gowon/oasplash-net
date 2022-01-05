# OASPlash.Core.Api.CurrentUserApi

All URIs are relative to *https://api.unsplash.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCurrentUser**](CurrentUserApi.md#getcurrentuser) | **GET** /me | Get the user&#39;s profile
[**UpdateCurrentUser**](CurrentUserApi.md#updatecurrentuser) | **PUT** /me | Update the current user&#39;s profile


<a name="getcurrentuser"></a>
# **GetCurrentUser**
> CurrentUser GetCurrentUser ()

Get the user's profile

Note: To access a user's private data, the user is required to authorize the read_user scope. Without a Bearer token (i.e. using a Client-ID token) this request will return a 401 Unauthorized response. 

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
    public class GetCurrentUserExample
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
            var apiInstance = new CurrentUserApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the user's profile
                CurrentUser result = apiInstance.GetCurrentUser();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrentUserApi.GetCurrentUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrentUser**](CurrentUser.md)

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

<a name="updatecurrentuser"></a>
# **UpdateCurrentUser**
> CurrentUser UpdateCurrentUser (string bio, string username = null, string firstName = null, string lastName = null, string email = null, string url = null, string location = null, string instagramUsername = null)

Update the current user's profile

Note: This action requires the write_user scope. Without it, it will return a 403 Forbidden response. 

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
    public class UpdateCurrentUserExample
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
            var apiInstance = new CurrentUserApi(httpClient, config, httpClientHandler);
            var bio = bio_example;  // string | About/bio.
            var username = username_example;  // string | Username. (optional) 
            var firstName = firstName_example;  // string | First name. (optional) 
            var lastName = lastName_example;  // string | Last name. (optional) 
            var email = email_example;  // string | Email. (optional) 
            var url = url_example;  // string | Portfolio/personal URL. (optional) 
            var location = location_example;  // string | Location. (optional) 
            var instagramUsername = instagramUsername_example;  // string | Instagram username. (optional) 

            try
            {
                // Update the current user's profile
                CurrentUser result = apiInstance.UpdateCurrentUser(bio, username, firstName, lastName, email, url, location, instagramUsername);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrentUserApi.UpdateCurrentUser: " + e.Message );
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
 **bio** | **string**| About/bio. | 
 **username** | **string**| Username. | [optional] 
 **firstName** | **string**| First name. | [optional] 
 **lastName** | **string**| Last name. | [optional] 
 **email** | **string**| Email. | [optional] 
 **url** | **string**| Portfolio/personal URL. | [optional] 
 **location** | **string**| Location. | [optional] 
 **instagramUsername** | **string**| Instagram username. | [optional] 

### Return type

[**CurrentUser**](CurrentUser.md)

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

