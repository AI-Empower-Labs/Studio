# KMeansCluster

Response object for K-Means Clustering containing cluster size and centroids array

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cluster_size** | **int** | Number of points in the cluster | 
**centroids** | [**List[Centroid]**](Centroid.md) | List of cluster centroids | 

## Example

```python
from openapi_client.models.k_means_cluster import KMeansCluster

# TODO update the JSON string below
json = "{}"
# create an instance of KMeansCluster from a JSON string
k_means_cluster_instance = KMeansCluster.from_json(json)
# print the JSON string representation of the object
print(KMeansCluster.to_json())

# convert the object into a dict
k_means_cluster_dict = k_means_cluster_instance.to_dict()
# create an instance of KMeansCluster from a dict
k_means_cluster_from_dict = KMeansCluster.from_dict(k_means_cluster_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


