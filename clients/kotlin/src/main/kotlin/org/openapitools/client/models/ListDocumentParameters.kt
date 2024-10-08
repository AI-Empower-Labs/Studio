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

import org.openapitools.client.models.DocumentFilters

import com.squareup.moshi.Json
import com.squareup.moshi.JsonClass

/**
 * 
 *
 * @param index Optional index to specify which index to search in. Defaults to 'default'
 * @param filter Optional filtering of document id(s) and/or tags
 * @param withEmbeddings Optionally specifies if embedding should be returned in response. Default is false
 * @param limit Optional filter for specifying maximum number of entries to return. Defaults to 3
 * @param offset Optional filter for specifying list offset for paging. Default is 0
 */


data class ListDocumentParameters (

    /* Optional index to specify which index to search in. Defaults to 'default' */
    @Json(name = "index")
    val index: kotlin.String? = null,

    /* Optional filtering of document id(s) and/or tags */
    @Json(name = "filter")
    val filter: kotlin.collections.List<DocumentFilters>? = null,

    /* Optionally specifies if embedding should be returned in response. Default is false */
    @Json(name = "withEmbeddings")
    val withEmbeddings: kotlin.Boolean? = null,

    /* Optional filter for specifying maximum number of entries to return. Defaults to 3 */
    @Json(name = "limit")
    val limit: kotlin.Int? = null,

    /* Optional filter for specifying list offset for paging. Default is 0 */
    @Json(name = "offset")
    val offset: kotlin.Int? = null

) {


}

