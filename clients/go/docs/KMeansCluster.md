# KMeansCluster

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterSize** | **int32** | Number of points in the cluster | 
**Centroids** | [**[]Centroid**](Centroid.md) | List of cluster centroids | 

## Methods

### NewKMeansCluster

`func NewKMeansCluster(clusterSize int32, centroids []Centroid, ) *KMeansCluster`

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



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


