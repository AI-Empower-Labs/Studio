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

import io.kotlintest.shouldBe
import io.kotlintest.specs.ShouldSpec

import org.openapitools.client.models.AskDocumentResponse
import org.openapitools.client.models.DocumentCitation

class AskDocumentResponseTest : ShouldSpec() {
    init {
        // uncomment below to create an instance of AskDocumentResponse
        //val modelInstance = AskDocumentResponse()

        // to test the property `noResult`
        should("test noResult") {
            // uncomment below to test the property
            //modelInstance.noResult shouldBe ("TODO")
        }

        // to test the property `noResultReason` - Content of the answer.
        should("test noResultReason") {
            // uncomment below to test the property
            //modelInstance.noResultReason shouldBe ("TODO")
        }

        // to test the property `text` - Content of the answer.
        should("test text") {
            // uncomment below to test the property
            //modelInstance.text shouldBe ("TODO")
        }

        // to test the property `relevantSources` - List of the relevant sources used to produce the answer.  Key = Document ID  Value = List of partitions used from the document.
        should("test relevantSources") {
            // uncomment below to test the property
            //modelInstance.relevantSources shouldBe ("TODO")
        }

    }
}
