# Centroid

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Coordinate** | Pointer to [**Coordinate**](Coordinate.md) |  | [optional] 
**DataPoints** | Pointer to [**[]Coordinate**](Coordinate.md) | Array of data points belonging to the centroid | [optional] 

## Methods

### NewCentroid

`func NewCentroid() *Centroid`

NewCentroid instantiates a new Centroid object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewCentroidWithDefaults

`func NewCentroidWithDefaults() *Centroid`

NewCentroidWithDefaults instantiates a new Centroid object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetCoordinate

`func (o *Centroid) GetCoordinate() Coordinate`

GetCoordinate returns the Coordinate field if non-nil, zero value otherwise.

### GetCoordinateOk

`func (o *Centroid) GetCoordinateOk() (*Coordinate, bool)`

GetCoordinateOk returns a tuple with the Coordinate field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCoordinate

`func (o *Centroid) SetCoordinate(v Coordinate)`

SetCoordinate sets Coordinate field to given value.

### HasCoordinate

`func (o *Centroid) HasCoordinate() bool`

HasCoordinate returns a boolean if a field has been set.

### GetDataPoints

`func (o *Centroid) GetDataPoints() []Coordinate`

GetDataPoints returns the DataPoints field if non-nil, zero value otherwise.

### GetDataPointsOk

`func (o *Centroid) GetDataPointsOk() (*[]Coordinate, bool)`

GetDataPointsOk returns a tuple with the DataPoints field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDataPoints

`func (o *Centroid) SetDataPoints(v []Coordinate)`

SetDataPoints sets DataPoints field to given value.

### HasDataPoints

`func (o *Centroid) HasDataPoints() bool`

HasDataPoints returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


