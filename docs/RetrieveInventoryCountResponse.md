# Square.Connect.Model.RetrieveInventoryCountResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Counts** | [**List&lt;InventoryCount&gt;**](InventoryCount.md) | The current calculated inventory counts for the requested object and locations. | [optional] 
**Cursor** | **string** | The pagination cursor to be used in a subsequent request. If unset, this is the final response.  See [Paginating results](#paginatingresults) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

