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

package org.openapitools.client.apis

import io.kotlintest.shouldBe
import io.kotlintest.specs.ShouldSpec

import org.openapitools.client.apis.KernelMemoryApi
import org.openapitools.client.models.DataPipelineStatus
import org.openapitools.client.models.DeleteAccepted
import org.openapitools.client.models.IndexCollection
import org.openapitools.client.models.MemoryAnswer
import org.openapitools.client.models.MemoryQuery
import org.openapitools.client.models.ProblemDetails
import org.openapitools.client.models.SearchQuery
import org.openapitools.client.models.SearchResult
import org.openapitools.client.models.StreamableFileContent
import org.openapitools.client.models.UploadAccepted

class KernelMemoryApiTest : ShouldSpec() {
    init {
        // uncomment below to create an instance of KernelMemoryApi
        //val apiInstance = KernelMemoryApi()

        // to test downloadGet
        should("test downloadGet") {
            // uncomment below to test downloadGet
            //val documentId : kotlin.String = documentId_example // kotlin.String | 
            //val filename : kotlin.String = filename_example // kotlin.String | 
            //val index : kotlin.String = index_example // kotlin.String | 
            //val result : StreamableFileContent = apiInstance.downloadGet(documentId, filename, index)
            //result shouldBe ("TODO")
        }

        // to test kernelMemoryAsk
        should("test kernelMemoryAsk") {
            // uncomment below to test kernelMemoryAsk
            //val memoryQuery : MemoryQuery =  // MemoryQuery | 
            //val result : MemoryAnswer = apiInstance.kernelMemoryAsk(memoryQuery)
            //result shouldBe ("TODO")
        }

        // to test kernelMemoryDelete
        should("test kernelMemoryDelete") {
            // uncomment below to test kernelMemoryDelete
            //val documentId : kotlin.String = documentId_example // kotlin.String | 
            //val index : kotlin.String = index_example // kotlin.String | 
            //val result : DeleteAccepted = apiInstance.kernelMemoryDelete(documentId, index)
            //result shouldBe ("TODO")
        }

        // to test kernelMemoryDeleteIndex
        should("test kernelMemoryDeleteIndex") {
            // uncomment below to test kernelMemoryDeleteIndex
            //val index : kotlin.String = index_example // kotlin.String | 
            //val result : DeleteAccepted = apiInstance.kernelMemoryDeleteIndex(index)
            //result shouldBe ("TODO")
        }

        // to test kernelMemoryGetIndex
        should("test kernelMemoryGetIndex") {
            // uncomment below to test kernelMemoryGetIndex
            //val result : IndexCollection = apiInstance.kernelMemoryGetIndex()
            //result shouldBe ("TODO")
        }

        // to test kernelMemorySearch
        should("test kernelMemorySearch") {
            // uncomment below to test kernelMemorySearch
            //val searchQuery : SearchQuery =  // SearchQuery | 
            //val result : SearchResult = apiInstance.kernelMemorySearch(searchQuery)
            //result shouldBe ("TODO")
        }

        // to test kernelMemoryUpload
        should("test kernelMemoryUpload") {
            // uncomment below to test kernelMemoryUpload
            //val result : UploadAccepted = apiInstance.kernelMemoryUpload()
            //result shouldBe ("TODO")
        }

        // to test kernelMemoryUploadStatus
        should("test kernelMemoryUploadStatus") {
            // uncomment below to test kernelMemoryUploadStatus
            //val documentId : kotlin.String = documentId_example // kotlin.String | 
            //val index : kotlin.String = index_example // kotlin.String | 
            //val result : DataPipelineStatus = apiInstance.kernelMemoryUploadStatus(documentId, index)
            //result shouldBe ("TODO")
        }

    }
}