# Coordinate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**X** | Pointer to **float32** | X-axis value of the coordinate | [optional] 
**Y** | Pointer to **float32** | Y-axis value of the coordinate | [optional] 
**Label** | Pointer to **string** | Label associated with the coordinate | [optional] 

## Methods

### NewCoordinate

`func NewCoordinate() *Coordinate`

NewCoordinate instantiates a new Coordinate object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewCoordinateWithDefaults

`func NewCoordinateWithDefaults() *Coordinate`

NewCoordinateWithDefaults instantiates a new Coordinate object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetX

`func (o *Coordinate) GetX() float32`

GetX returns the X field if non-nil, zero value otherwise.

### GetXOk

`func (o *Coordinate) GetXOk() (*float32, bool)`

GetXOk returns a tuple with the X field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetX

`func (o *Coordinate) SetX(v float32)`

SetX sets X field to given value.

### HasX

`func (o *Coordinate) HasX() bool`

HasX returns a boolean if a field has been set.

### GetY

`func (o *Coordinate) GetY() float32`

GetY returns the Y field if non-nil, zero value otherwise.

### GetYOk

`func (o *Coordinate) GetYOk() (*float32, bool)`

GetYOk returns a tuple with the Y field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetY

`func (o *Coordinate) SetY(v float32)`

SetY sets Y field to given value.

### HasY

`func (o *Coordinate) HasY() bool`

HasY returns a boolean if a field has been set.

### GetLabel

`func (o *Coordinate) GetLabel() string`

GetLabel returns the Label field if non-nil, zero value otherwise.

### GetLabelOk

`func (o *Coordinate) GetLabelOk() (*string, bool)`

GetLabelOk returns a tuple with the Label field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLabel

`func (o *Coordinate) SetLabel(v string)`

SetLabel sets Label field to given value.

### HasLabel

`func (o *Coordinate) HasLabel() bool`

HasLabel returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


