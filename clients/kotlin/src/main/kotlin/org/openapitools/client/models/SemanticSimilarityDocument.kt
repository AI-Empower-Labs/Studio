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


import com.squareup.moshi.Json
import com.squareup.moshi.JsonClass

/**
 * 
 *
 * @param document 
 * @param distance 
 */


data class SemanticSimilarityDocument (

    @Json(name = "document")
    val document: kotlin.String? = null,

    @Json(name = "distance")
    val distance: kotlin.Float? = null

) {


}
