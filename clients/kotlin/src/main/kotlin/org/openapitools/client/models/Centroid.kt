/**
 *
 * Please note:
 * This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit this file manually.
 *
 */

@file:Suppress(
    "ArrayInDataClass",
    "EnumEntryName",
    "RemoveRedundantQualifierName",
    "UnusedImport"
)

package org.openapitools.client.models

import org.openapitools.client.models.Coordinate

import com.squareup.moshi.Json
import com.squareup.moshi.JsonClass

/**
 * Represents a centroid for a cluster, includes coordinate and array of datapoints
 *
 * @param coordinate 
 * @param dataPoints Array of data points belonging to the centroid
 */


data class Centroid (

    @Json(name = "coordinate")
    val coordinate: Coordinate? = null,

    /* Array of data points belonging to the centroid */
    @Json(name = "dataPoints")
    val dataPoints: kotlin.collections.List<Coordinate>? = null

) {


}

