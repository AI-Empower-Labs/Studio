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

import org.openapitools.client.models.TimeSpan

import com.squareup.moshi.Json
import com.squareup.moshi.JsonClass

/**
 * 
 *
 * @param text 
 * @param start 
 * @param end 
 * @param probability 
 * @param language 
 */


data class SegmentData (

    @Json(name = "text")
    val text: kotlin.String? = null,

    @Json(name = "start")
    val start: TimeSpan? = null,

    @Json(name = "end")
    val end: TimeSpan? = null,

    @Json(name = "probability")
    val probability: kotlin.Float? = null,

    @Json(name = "language")
    val language: kotlin.String? = null

) {


}

