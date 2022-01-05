# OASPlash.Core.Api.StatsApi

All URIs are relative to *https://api.unsplash.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMonthlyStatistics**](StatsApi.md#getmonthlystatistics) | **GET** /stats/month | Month
[**GetTotalStatistics**](StatsApi.md#gettotalstatistics) | **GET** /stats/total | Totals


<a name="getmonthlystatistics"></a>
# **GetMonthlyStatistics**
> MonthlyStatistics GetMonthlyStatistics ()

Month

Get the overall Unsplash stats for the past 30 days.

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
    public class GetMonthlyStatisticsExample
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
            var apiInstance = new StatsApi(httpClient, config, httpClientHandler);

            try
            {
                // Month
                MonthlyStatistics result = apiInstance.GetMonthlyStatistics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatsApi.GetMonthlyStatistics: " + e.Message );
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

[**MonthlyStatistics**](MonthlyStatistics.md)

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

<a name="gettotalstatistics"></a>
# **GetTotalStatistics**
> TotalStatistics GetTotalStatistics ()

Totals

Get a list of counts for all of Unsplash.

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
    public class GetTotalStatisticsExample
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
            var apiInstance = new StatsApi(httpClient, config, httpClientHandler);

            try
            {
                // Totals
                TotalStatistics result = apiInstance.GetTotalStatistics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatsApi.GetTotalStatistics: " + e.Message );
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

[**TotalStatistics**](TotalStatistics.md)

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

