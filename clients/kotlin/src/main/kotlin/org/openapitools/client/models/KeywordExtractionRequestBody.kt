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
 * @param text Text to perform keyword extraction on
 * @param model Text to perform keyword extraction on
 */


data class KeywordExtractionRequestBody (

    /* Text to perform keyword extraction on */
    @Json(name = "text")
    val text: kotlin.String,

    /* Text to perform keyword extraction on */
    @Json(name = "model")
    val model: kotlin.String? = null

) {


}
