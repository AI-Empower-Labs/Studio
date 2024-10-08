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

import org.openapitools.client.models.AskDocumentRequest
import org.openapitools.client.models.DocumentFilters

class AskDocumentRequestTest : ShouldSpec() {
    init {
        // uncomment below to create an instance of AskDocumentRequest
        //val modelInstance = AskDocumentRequest()

        // to test the property `query` - Semantic query to find matching documents and ask questions over
        should("test query") {
            // uncomment below to test the property
            //modelInstance.query shouldBe ("TODO")
        }

        // to test the property `index` - Optional index to specify which index to search in. Defaults to 'default'
        should("test index") {
            // uncomment below to test the property
            //modelInstance.index shouldBe ("TODO")
        }

        // to test the property `filter` - Optional filtering of document id(s) and/or tags
        should("test filter") {
            // uncomment below to test the property
            //modelInstance.filter shouldBe ("TODO")
        }

        // to test the property `minRelevance` - Optional filter to specify minimum relevance. Typically values between 0 and 1
        should("test minRelevance") {
            // uncomment below to test the property
            //modelInstance.minRelevance shouldBe ("TODO")
        }

        // to test the property `llmModel` - Large language model to use in query
        should("test llmModel") {
            // uncomment below to test the property
            //modelInstance.llmModel shouldBe ("TODO")
        }

        // to test the property `embeddingModel` - Embedding model to use in query
        should("test embeddingModel") {
            // uncomment below to test the property
            //modelInstance.embeddingModel shouldBe ("TODO")
        }

        // to test the property `args`
        should("test args") {
            // uncomment below to test the property
            //modelInstance.args shouldBe ("TODO")
        }

    }
}
