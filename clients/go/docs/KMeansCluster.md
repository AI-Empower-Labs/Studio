# KMeansCluster

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterSize** | Pointer to **int32** | Size of the cluster | [optional] 
**Centroids** | Pointer to [**[]Centroid**](Centroid.md) | Array of Centroid objects | [optional] 

## Methods

### NewKMeansCluster

`func NewKMeansCluster() *KMeansCluster`

NewKMeansCluster instantiates a new KMeansCluster object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewKMeansClusterWithDefaults

`func NewKMeansClusterWithDefaults() *KMeansCluster`

NewKMeansClusterWithDefaults instantiates a new KMeansCluster object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetClusterSize

`func (o *KMeansCluster) GetClusterSize() int32`

GetClusterSize returns the ClusterSize field if non-nil, zero value otherwise.

### GetClusterSizeOk

`func (o *KMeansCluster) GetClusterSizeOk() (*int32, bool)`

GetClusterSizeOk returns a tuple with the ClusterSize field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetClusterSize

`func (o *KMeansCluster) SetClusterSize(v int32)`

SetClusterSize sets ClusterSize field to given value.

### HasClusterSize

`func (o *KMeansCluster) HasClusterSize() bool`

HasClusterSize returns a boolean if a field has been set.

### GetCentroids

`func (o *KMeansCluster) GetCentroids() []Centroid`

GetCentroids returns the Centroids field if non-nil, zero value otherwise.

### GetCentroidsOk

`func (o *KMeansCluster) GetCentroidsOk() (*[]Centroid, bool)`

GetCentroidsOk returns a tuple with the Centroids field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCentroids

`func (o *KMeansCluster) SetCentroids(v []Centroid)`

SetCentroids sets Centroids field to given value.

### HasCentroids

`func (o *KMeansCluster) HasCentroids() bool`

HasCentroids returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


