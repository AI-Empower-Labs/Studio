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
 * @param documentId 
 * @param tags 
 */


data class DocumentFilters (

    @Json(name = "documentId")
    val documentId: kotlin.collections.List<kotlin.String>? = null,

    @Json(name = "tags")
    val tags: kotlin.collections.Map<kotlin.String, kotlin.collections.List<kotlin.String>>? = null

) {


}

