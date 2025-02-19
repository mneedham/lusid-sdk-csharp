# Lusid.Sdk.Api.InstrumentsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstrument**](InstrumentsApi.md#deleteinstrument) | **DELETE** /api/instruments/{identifierType}/{identifier} | [EARLY ACCESS] Delete instrument
[**GetInstrument**](InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{identifierType}/{identifier} | Get instrument
[**GetInstrumentIdentifierTypes**](InstrumentsApi.md#getinstrumentidentifiertypes) | **GET** /api/instruments/identifierTypes | [EARLY ACCESS] Get instrument identifier types
[**GetInstrumentPropertyTimeSeries**](InstrumentsApi.md#getinstrumentpropertytimeseries) | **GET** /api/instruments/{identifierType}/{identifier}/properties/time-series | [EARLY ACCESS] Get the time series of an instrument property
[**GetInstruments**](InstrumentsApi.md#getinstruments) | **POST** /api/instruments/$get | Get instruments
[**ListInstruments**](InstrumentsApi.md#listinstruments) | **GET** /api/instruments | [EARLY ACCESS] List instruments
[**UpdateInstrumentIdentifier**](InstrumentsApi.md#updateinstrumentidentifier) | **POST** /api/instruments/{identifierType}/{identifier} | [EARLY ACCESS] Update instrument identifier
[**UpsertInstruments**](InstrumentsApi.md#upsertinstruments) | **POST** /api/instruments | Upsert instruments
[**UpsertInstrumentsProperties**](InstrumentsApi.md#upsertinstrumentsproperties) | **POST** /api/instruments/$upsertproperties | Upsert instruments properties



## DeleteInstrument

> DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier)

[EARLY ACCESS] Delete instrument

Delete a single instrument identified by a unique instrument identifier. Once an instrument has been  deleted it will be marked as 'inactive' and it can no longer be used when updating or inserting transactions or holdings.  You can still query existing transactions and holdings related to the deleted instrument.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteInstrumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var identifierType = identifierType_example;  // string | The identifier being supplied e.g. \"Figi\".
            var identifier = identifier_example;  // string | The value of the identifier that resolves to the instrument to delete.

            try
            {
                // [EARLY ACCESS] Delete instrument
                DeleteInstrumentResponse result = apiInstance.DeleteInstrument(identifierType, identifier);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.DeleteInstrument: " + e.Message );
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
 **identifierType** | **string**| The identifier being supplied e.g. \&quot;Figi\&quot;. | 
 **identifier** | **string**| The value of the identifier that resolves to the instrument to delete. | 

### Return type

[**DeleteInstrumentResponse**](DeleteInstrumentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the instrument was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstrument

> Instrument GetInstrument (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

Get instrument

Get the definition of a single instrument identified by a unique instrument identifier.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var identifierType = identifierType_example;  // string | The identifier being supplied e.g. \"Figi\".
            var identifier = identifier_example;  // string | The value of the identifier for the requested instrument.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 

            try
            {
                // Get instrument
                Instrument result = apiInstance.GetInstrument(identifierType, identifier, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrument: " + e.Message );
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
 **identifierType** | **string**| The identifier being supplied e.g. \&quot;Figi\&quot;. | 
 **identifier** | **string**| The value of the identifier for the requested instrument. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the instrument definition.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the instrument definition. Defaults to              return the latest version of the instrument definition if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional] 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instrument |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstrumentIdentifierTypes

> ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifierTypes ()

[EARLY ACCESS] Get instrument identifier types

Get the allowable instrument identifier types and their descriptions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentIdentifierTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);

            try
            {
                // [EARLY ACCESS] Get instrument identifier types
                ResourceListOfInstrumentIdTypeDescriptor result = apiInstance.GetInstrumentIdentifierTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrumentIdentifierTypes: " + e.Message );
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

[**ResourceListOfInstrumentIdTypeDescriptor**](ResourceListOfInstrumentIdTypeDescriptor.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The allowable instrument identifier types |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstrumentPropertyTimeSeries

> ResourceListOfPropertyInterval GetInstrumentPropertyTimeSeries (string identifierType, string identifier, string propertyKey = null, string identifierEffectiveAt = null, DateTimeOffset? asAt = null, string filter = null, string page = null, int? limit = null)

[EARLY ACCESS] Get the time series of an instrument property

List the complete time series of an instrument property.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentPropertyTimeSeriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var identifierType = identifierType_example;  // string | The identifier type of the instrument, e.g., \"Figi\"
            var identifier = identifier_example;  // string | The value of the identifier for the requested instrument.
            var propertyKey = propertyKey_example;  // string | The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\".              Each property must be from the \"Instrument\" domain. (optional) 
            var identifierEffectiveAt = identifierEffectiveAt_example;  // string | The effective datetime used to resolve the instrument from the provided identifier. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the instrument's property history. Defaults to return the current datetime if not supplied. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [EARLY ACCESS] Get the time series of an instrument property
                ResourceListOfPropertyInterval result = apiInstance.GetInstrumentPropertyTimeSeries(identifierType, identifier, propertyKey, identifierEffectiveAt, asAt, filter, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrumentPropertyTimeSeries: " + e.Message );
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
 **identifierType** | **string**| The identifier type of the instrument, e.g., \&quot;Figi\&quot; | 
 **identifier** | **string**| The value of the identifier for the requested instrument. | 
 **propertyKey** | **string**| The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;.              Each property must be from the \&quot;Instrument\&quot; domain. | [optional] 
 **identifierEffectiveAt** | **string**| The effective datetime used to resolve the instrument from the provided identifier. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the instrument&#39;s property history. Defaults to return the current datetime if not supplied. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **page** | **string**| The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ResourceListOfPropertyInterval**](ResourceListOfPropertyInterval.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time series of the property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstruments

> GetInstrumentsResponse GetInstruments (string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

Get instruments

Get the definition of one or more instruments identified by a collection of unique instrument identifiers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var identifierType = identifierType_example;  // string | The identifier being supplied e.g. \"Figi\".
            var requestBody = new List<string>(); // List<string> | The values of the identifier for the requested instruments.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 

            try
            {
                // Get instruments
                GetInstrumentsResponse result = apiInstance.GetInstruments(identifierType, requestBody, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstruments: " + e.Message );
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
 **identifierType** | **string**| The identifier being supplied e.g. \&quot;Figi\&quot;. | 
 **requestBody** | [**List&lt;string&gt;**](string.md)| The values of the identifier for the requested instruments. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the instrument definitions.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the instrument definitions.              Defaults to return the latest version of each instrument definition if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto the instrument.              These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional] 

### Return type

[**GetInstrumentsResponse**](GetInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instruments which could be identified along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListInstruments

> PagedResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)

[EARLY ACCESS] List instruments

List all the instruments that have been mastered in the LUSID instrument master.  The maximum number of instruments that this method can list per request is 2,000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListInstrumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>(); // List<string> | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional)  (default to "State eq 'Active'")
            var instrumentPropertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 

            try
            {
                // [EARLY ACCESS] List instruments
                PagedResourceListOfInstrument result = apiInstance.ListInstruments(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.ListInstruments: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the instruments. Defaults to return the latest              version of each instruments if not specified. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the instruments.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Expression to filter the result set. Defaults to filter down to active instruments only, i.e. those              that have not been deleted. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] [default to &quot;State eq &#39;Active&#39;&quot;]
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto each instrument. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional] 

### Return type

[**PagedResourceListOfInstrument**](PagedResourceListOfInstrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instruments |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateInstrumentIdentifier

> Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest)

[EARLY ACCESS] Update instrument identifier

Update, insert or delete a single instrument identifier for a single instrument. If it is not being deleted  the identifier will be updated if it already exists and inserted if it does not.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateInstrumentIdentifierExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var identifierType = identifierType_example;  // string | The identifier to use to resolve the instrument e.g. \"Figi\".
            var identifier = identifier_example;  // string | The original value of the identifier for the requested instrument.
            var updateInstrumentIdentifierRequest = new UpdateInstrumentIdentifierRequest(); // UpdateInstrumentIdentifierRequest | The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument.

            try
            {
                // [EARLY ACCESS] Update instrument identifier
                Instrument result = apiInstance.UpdateInstrumentIdentifier(identifierType, identifier, updateInstrumentIdentifierRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpdateInstrumentIdentifier: " + e.Message );
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
 **identifierType** | **string**| The identifier to use to resolve the instrument e.g. \&quot;Figi\&quot;. | 
 **identifier** | **string**| The original value of the identifier for the requested instrument. | 
 **updateInstrumentIdentifierRequest** | [**UpdateInstrumentIdentifierRequest**](UpdateInstrumentIdentifierRequest.md)| The identifier to update or remove. This may or may not be the same identifier used              to resolve the instrument. | 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated instrument definition with the identifier updated, inserted or deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertInstruments

> UpsertInstrumentsResponse UpsertInstruments (Dictionary<string, InstrumentDefinition> requestBody)

Upsert instruments

Update or insert one or more instruments into the LUSID instrument master. An instrument will be updated  if it already exists and inserted if it does not.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                The response will return both the collection of successfully updated or inserted instruments, as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertInstrumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var requestBody = new Dictionary<string, InstrumentDefinition>(); // Dictionary<string, InstrumentDefinition> | The definitions of the instruments to update or insert.

            try
            {
                // Upsert instruments
                UpsertInstrumentsResponse result = apiInstance.UpsertInstruments(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpsertInstruments: " + e.Message );
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
 **requestBody** | [**Dictionary&lt;string, InstrumentDefinition&gt;**](InstrumentDefinition.md)| The definitions of the instruments to update or insert. | 

### Return type

[**UpsertInstrumentsResponse**](UpsertInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully updated or inserted instruments along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertInstrumentsProperties

> UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest)

Upsert instruments properties

Update or insert one or more instrument properties for one or more instruments. Each instrument property will be updated  if it already exists and inserted if it does not. If any properties fail to be updated or inserted, none will be updated or inserted and  the reason for the failure will be returned.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertInstrumentsPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(Configuration.Default);
            var upsertInstrumentPropertyRequest = new List<UpsertInstrumentPropertyRequest>(); // List<UpsertInstrumentPropertyRequest> | A collection of instruments and associated instrument properties to update or insert.

            try
            {
                // Upsert instruments properties
                UpsertInstrumentPropertiesResponse result = apiInstance.UpsertInstrumentsProperties(upsertInstrumentPropertyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpsertInstrumentsProperties: " + e.Message );
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
 **upsertInstrumentPropertyRequest** | [**List&lt;UpsertInstrumentPropertyRequest&gt;**](UpsertInstrumentPropertyRequest.md)| A collection of instruments and associated instrument properties to update or insert. | 

### Return type

[**UpsertInstrumentPropertiesResponse**](UpsertInstrumentPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The asAt time at which the properties were updated, inserted or deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

