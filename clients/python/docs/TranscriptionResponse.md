# TranscriptionResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** |  | [optional] 
**duration** | [**TimeSpan**](TimeSpan.md) |  | [optional] 
**data** | [**List[SegmentData]**](SegmentData.md) |  | [optional] 

## Example

```python
from openapi_client.models.transcription_response import TranscriptionResponse

# TODO update the JSON string below
json = "{}"
# create an instance of TranscriptionResponse from a JSON string
transcription_response_instance = TranscriptionResponse.from_json(json)
# print the JSON string representation of the object
print(TranscriptionResponse.to_json())

# convert the object into a dict
transcription_response_dict = transcription_response_instance.to_dict()
# create an instance of TranscriptionResponse from a dict
transcription_response_from_dict = TranscriptionResponse.from_dict(transcription_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


