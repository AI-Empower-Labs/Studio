# TimeSpan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ticks** | Pointer to **int64** |  | [optional] 
**Days** | Pointer to **int32** |  | [optional] [readonly] 
**Hours** | Pointer to **int32** |  | [optional] [readonly] 
**Milliseconds** | Pointer to **int32** |  | [optional] [readonly] 
**Microseconds** | Pointer to **int32** |  | [optional] [readonly] 
**Nanoseconds** | Pointer to **int32** |  | [optional] [readonly] 
**Minutes** | Pointer to **int32** |  | [optional] [readonly] 
**Seconds** | Pointer to **int32** |  | [optional] [readonly] 
**TotalDays** | Pointer to **float64** |  | [optional] [readonly] 
**TotalHours** | Pointer to **float64** |  | [optional] [readonly] 
**TotalMilliseconds** | Pointer to **float64** |  | [optional] [readonly] 
**TotalMicroseconds** | Pointer to **float64** |  | [optional] [readonly] 
**TotalNanoseconds** | Pointer to **float64** |  | [optional] [readonly] 
**TotalMinutes** | Pointer to **float64** |  | [optional] [readonly] 
**TotalSeconds** | Pointer to **float64** |  | [optional] [readonly] 

## Methods

### NewTimeSpan

`func NewTimeSpan() *TimeSpan`

NewTimeSpan instantiates a new TimeSpan object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewTimeSpanWithDefaults

`func NewTimeSpanWithDefaults() *TimeSpan`

NewTimeSpanWithDefaults instantiates a new TimeSpan object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetTicks

`func (o *TimeSpan) GetTicks() int64`

GetTicks returns the Ticks field if non-nil, zero value otherwise.

### GetTicksOk

`func (o *TimeSpan) GetTicksOk() (*int64, bool)`

GetTicksOk returns a tuple with the Ticks field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTicks

`func (o *TimeSpan) SetTicks(v int64)`

SetTicks sets Ticks field to given value.

### HasTicks

`func (o *TimeSpan) HasTicks() bool`

HasTicks returns a boolean if a field has been set.

### GetDays

`func (o *TimeSpan) GetDays() int32`

GetDays returns the Days field if non-nil, zero value otherwise.

### GetDaysOk

`func (o *TimeSpan) GetDaysOk() (*int32, bool)`

GetDaysOk returns a tuple with the Days field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDays

`func (o *TimeSpan) SetDays(v int32)`

SetDays sets Days field to given value.

### HasDays

`func (o *TimeSpan) HasDays() bool`

HasDays returns a boolean if a field has been set.

### GetHours

`func (o *TimeSpan) GetHours() int32`

GetHours returns the Hours field if non-nil, zero value otherwise.

### GetHoursOk

`func (o *TimeSpan) GetHoursOk() (*int32, bool)`

GetHoursOk returns a tuple with the Hours field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetHours

`func (o *TimeSpan) SetHours(v int32)`

SetHours sets Hours field to given value.

### HasHours

`func (o *TimeSpan) HasHours() bool`

HasHours returns a boolean if a field has been set.

### GetMilliseconds

`func (o *TimeSpan) GetMilliseconds() int32`

GetMilliseconds returns the Milliseconds field if non-nil, zero value otherwise.

### GetMillisecondsOk

`func (o *TimeSpan) GetMillisecondsOk() (*int32, bool)`

GetMillisecondsOk returns a tuple with the Milliseconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMilliseconds

`func (o *TimeSpan) SetMilliseconds(v int32)`

SetMilliseconds sets Milliseconds field to given value.

### HasMilliseconds

`func (o *TimeSpan) HasMilliseconds() bool`

HasMilliseconds returns a boolean if a field has been set.

### GetMicroseconds

`func (o *TimeSpan) GetMicroseconds() int32`

GetMicroseconds returns the Microseconds field if non-nil, zero value otherwise.

### GetMicrosecondsOk

`func (o *TimeSpan) GetMicrosecondsOk() (*int32, bool)`

GetMicrosecondsOk returns a tuple with the Microseconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMicroseconds

`func (o *TimeSpan) SetMicroseconds(v int32)`

SetMicroseconds sets Microseconds field to given value.

### HasMicroseconds

`func (o *TimeSpan) HasMicroseconds() bool`

HasMicroseconds returns a boolean if a field has been set.

### GetNanoseconds

`func (o *TimeSpan) GetNanoseconds() int32`

GetNanoseconds returns the Nanoseconds field if non-nil, zero value otherwise.

### GetNanosecondsOk

`func (o *TimeSpan) GetNanosecondsOk() (*int32, bool)`

GetNanosecondsOk returns a tuple with the Nanoseconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNanoseconds

`func (o *TimeSpan) SetNanoseconds(v int32)`

SetNanoseconds sets Nanoseconds field to given value.

### HasNanoseconds

`func (o *TimeSpan) HasNanoseconds() bool`

HasNanoseconds returns a boolean if a field has been set.

### GetMinutes

`func (o *TimeSpan) GetMinutes() int32`

GetMinutes returns the Minutes field if non-nil, zero value otherwise.

### GetMinutesOk

`func (o *TimeSpan) GetMinutesOk() (*int32, bool)`

GetMinutesOk returns a tuple with the Minutes field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMinutes

`func (o *TimeSpan) SetMinutes(v int32)`

SetMinutes sets Minutes field to given value.

### HasMinutes

`func (o *TimeSpan) HasMinutes() bool`

HasMinutes returns a boolean if a field has been set.

### GetSeconds

`func (o *TimeSpan) GetSeconds() int32`

GetSeconds returns the Seconds field if non-nil, zero value otherwise.

### GetSecondsOk

`func (o *TimeSpan) GetSecondsOk() (*int32, bool)`

GetSecondsOk returns a tuple with the Seconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSeconds

`func (o *TimeSpan) SetSeconds(v int32)`

SetSeconds sets Seconds field to given value.

### HasSeconds

`func (o *TimeSpan) HasSeconds() bool`

HasSeconds returns a boolean if a field has been set.

### GetTotalDays

`func (o *TimeSpan) GetTotalDays() float64`

GetTotalDays returns the TotalDays field if non-nil, zero value otherwise.

### GetTotalDaysOk

`func (o *TimeSpan) GetTotalDaysOk() (*float64, bool)`

GetTotalDaysOk returns a tuple with the TotalDays field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalDays

`func (o *TimeSpan) SetTotalDays(v float64)`

SetTotalDays sets TotalDays field to given value.

### HasTotalDays

`func (o *TimeSpan) HasTotalDays() bool`

HasTotalDays returns a boolean if a field has been set.

### GetTotalHours

`func (o *TimeSpan) GetTotalHours() float64`

GetTotalHours returns the TotalHours field if non-nil, zero value otherwise.

### GetTotalHoursOk

`func (o *TimeSpan) GetTotalHoursOk() (*float64, bool)`

GetTotalHoursOk returns a tuple with the TotalHours field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalHours

`func (o *TimeSpan) SetTotalHours(v float64)`

SetTotalHours sets TotalHours field to given value.

### HasTotalHours

`func (o *TimeSpan) HasTotalHours() bool`

HasTotalHours returns a boolean if a field has been set.

### GetTotalMilliseconds

`func (o *TimeSpan) GetTotalMilliseconds() float64`

GetTotalMilliseconds returns the TotalMilliseconds field if non-nil, zero value otherwise.

### GetTotalMillisecondsOk

`func (o *TimeSpan) GetTotalMillisecondsOk() (*float64, bool)`

GetTotalMillisecondsOk returns a tuple with the TotalMilliseconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalMilliseconds

`func (o *TimeSpan) SetTotalMilliseconds(v float64)`

SetTotalMilliseconds sets TotalMilliseconds field to given value.

### HasTotalMilliseconds

`func (o *TimeSpan) HasTotalMilliseconds() bool`

HasTotalMilliseconds returns a boolean if a field has been set.

### GetTotalMicroseconds

`func (o *TimeSpan) GetTotalMicroseconds() float64`

GetTotalMicroseconds returns the TotalMicroseconds field if non-nil, zero value otherwise.

### GetTotalMicrosecondsOk

`func (o *TimeSpan) GetTotalMicrosecondsOk() (*float64, bool)`

GetTotalMicrosecondsOk returns a tuple with the TotalMicroseconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalMicroseconds

`func (o *TimeSpan) SetTotalMicroseconds(v float64)`

SetTotalMicroseconds sets TotalMicroseconds field to given value.

### HasTotalMicroseconds

`func (o *TimeSpan) HasTotalMicroseconds() bool`

HasTotalMicroseconds returns a boolean if a field has been set.

### GetTotalNanoseconds

`func (o *TimeSpan) GetTotalNanoseconds() float64`

GetTotalNanoseconds returns the TotalNanoseconds field if non-nil, zero value otherwise.

### GetTotalNanosecondsOk

`func (o *TimeSpan) GetTotalNanosecondsOk() (*float64, bool)`

GetTotalNanosecondsOk returns a tuple with the TotalNanoseconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalNanoseconds

`func (o *TimeSpan) SetTotalNanoseconds(v float64)`

SetTotalNanoseconds sets TotalNanoseconds field to given value.

### HasTotalNanoseconds

`func (o *TimeSpan) HasTotalNanoseconds() bool`

HasTotalNanoseconds returns a boolean if a field has been set.

### GetTotalMinutes

`func (o *TimeSpan) GetTotalMinutes() float64`

GetTotalMinutes returns the TotalMinutes field if non-nil, zero value otherwise.

### GetTotalMinutesOk

`func (o *TimeSpan) GetTotalMinutesOk() (*float64, bool)`

GetTotalMinutesOk returns a tuple with the TotalMinutes field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalMinutes

`func (o *TimeSpan) SetTotalMinutes(v float64)`

SetTotalMinutes sets TotalMinutes field to given value.

### HasTotalMinutes

`func (o *TimeSpan) HasTotalMinutes() bool`

HasTotalMinutes returns a boolean if a field has been set.

### GetTotalSeconds

`func (o *TimeSpan) GetTotalSeconds() float64`

GetTotalSeconds returns the TotalSeconds field if non-nil, zero value otherwise.

### GetTotalSecondsOk

`func (o *TimeSpan) GetTotalSecondsOk() (*float64, bool)`

GetTotalSecondsOk returns a tuple with the TotalSeconds field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTotalSeconds

`func (o *TimeSpan) SetTotalSeconds(v float64)`

SetTotalSeconds sets TotalSeconds field to given value.

### HasTotalSeconds

`func (o *TimeSpan) HasTotalSeconds() bool`

HasTotalSeconds returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


