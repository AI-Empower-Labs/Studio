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
 * @param index 
 * @param query 
 * @param filters 
 * @param minRelevance 
 * @param limit 
 */


data class SearchQuery (

    @Json(name = "index")
    val index: kotlin.String? = null,

    @Json(name = "query")
    val query: kotlin.String? = null,

    @Json(name = "filters")
    val filters: kotlin.collections.List<kotlin.collections.Map<kotlin.String, kotlin.collections.List<kotlin.String>>>? = null,

    @Json(name = "minRelevance")
    val minRelevance: kotlin.Double? = null,

    @Json(name = "limit")
    val limit: kotlin.Int? = null

) {


}
