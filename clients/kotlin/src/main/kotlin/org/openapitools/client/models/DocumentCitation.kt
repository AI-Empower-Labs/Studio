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

import org.openapitools.client.models.DocumentPartition

import com.squareup.moshi.Json
import com.squareup.moshi.JsonClass

/**
 * 
 *
 * @param link URL or reference to the original source document
 * @param index Identifier or position of the citation within the source
 * @param documentId Unique identifier for the document
 * @param fileId Unique identifier for the file in storage
 * @param sourceContentType Format of the source (e.g., 'pdf', 'docx', 'chat')
 * @param sourceName Human-readable name or title of the source
 * @param sourceUrl Web URL of the source for online content
 * @param partitions Array of text segments used from the source
 */


data class DocumentCitation (

    /* URL or reference to the original source document */
    @Json(name = "link")
    val link: kotlin.String? = null,

    /* Identifier or position of the citation within the source */
    @Json(name = "index")
    val index: kotlin.String? = null,

    /* Unique identifier for the document */
    @Json(name = "documentId")
    val documentId: kotlin.String? = null,

    /* Unique identifier for the file in storage */
    @Json(name = "fileId")
    val fileId: kotlin.String? = null,

    /* Format of the source (e.g., 'pdf', 'docx', 'chat') */
    @Json(name = "sourceContentType")
    val sourceContentType: kotlin.String? = null,

    /* Human-readable name or title of the source */
    @Json(name = "sourceName")
    val sourceName: kotlin.String? = null,

    /* Web URL of the source for online content */
    @Json(name = "sourceUrl")
    val sourceUrl: kotlin.String? = null,

    /* Array of text segments used from the source */
    @Json(name = "partitions")
    val partitions: kotlin.collections.List<DocumentPartition>? = null

) {


}

