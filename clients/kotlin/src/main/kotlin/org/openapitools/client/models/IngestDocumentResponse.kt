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
 * @param id Ingestion queue identifier
 * @param index Index ingestion is written to
 * @param documentId Identity of the document written to index
 * @param pipeline Index ingestion is written to
 */


data class IngestDocumentResponse (

    /* Ingestion queue identifier */
    @Json(name = "id")
    val id: kotlin.String? = null,

    /* Index ingestion is written to */
    @Json(name = "index")
    val index: kotlin.String? = null,

    /* Identity of the document written to index */
    @Json(name = "documentId")
    val documentId: kotlin.String? = null,

    /* Index ingestion is written to */
    @Json(name = "pipeline")
    val pipeline: kotlin.collections.List<kotlin.String>? = null

) {


}
