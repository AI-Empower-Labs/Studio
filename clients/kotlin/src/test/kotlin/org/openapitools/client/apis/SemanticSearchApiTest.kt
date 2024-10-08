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

import org.openapitools.client.apis.SemanticSearchApi
import org.openapitools.client.models.AskDocumentRequest
import org.openapitools.client.models.AskDocumentResponse
import org.openapitools.client.models.DataPipelineStatus
import org.openapitools.client.models.HttpValidationProblemDetails
import org.openapitools.client.models.IngestDocumentResponse
import org.openapitools.client.models.IngestTextDocumentRequest
import org.openapitools.client.models.IngestWebPageDocumentRequest
import org.openapitools.client.models.KMeansCluster
import org.openapitools.client.models.ListDocumentParameters
import org.openapitools.client.models.ListDocumentResponse
import org.openapitools.client.models.ProblemDetails
import org.openapitools.client.models.QueryDocumentRequest
import org.openapitools.client.models.QueryDocumentResponse
import org.openapitools.client.models.ReRankDocumentsRequest
import org.openapitools.client.models.ReRankDocumentsResponse
import org.openapitools.client.models.SemanticSearchQueryResultsClusteringRequest

class SemanticSearchApiTest : ShouldSpec() {
    init {
        // uncomment below to create an instance of SemanticSearchApi
        //val apiInstance = SemanticSearchApi()

        // to test semanticSearchAsk
        should("test semanticSearchAsk") {
            // uncomment below to test semanticSearchAsk
            //val askDocumentRequest : AskDocumentRequest = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8} // AskDocumentRequest | 
            //val result : AskDocumentResponse = apiInstance.semanticSearchAsk(askDocumentRequest)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchDeleteDocument
        should("test semanticSearchDeleteDocument") {
            // uncomment below to test semanticSearchDeleteDocument
            //val documentId : kotlin.String = documentId_example // kotlin.String | 
            //val index : kotlin.String = index_example // kotlin.String | 
            //apiInstance.semanticSearchDeleteDocument(documentId, index)
        }

        // to test semanticSearchDeleteIndex
        should("test semanticSearchDeleteIndex") {
            // uncomment below to test semanticSearchDeleteIndex
            //val name : kotlin.String = name_example // kotlin.String | 
            //apiInstance.semanticSearchDeleteIndex(name)
        }

        // to test semanticSearchFileIngestion
        should("test semanticSearchFileIngestion") {
            // uncomment below to test semanticSearchFileIngestion
            //val files : kotlin.collections.List<java.io.File> = /path/to/file.txt // kotlin.collections.List<java.io.File> | The file object to ingest.
            //val documentId : kotlin.String = documentId_example // kotlin.String | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema.
            //val index : kotlin.String = index_example // kotlin.String | Optional value to specify with index the document should be ingested. Defaults to 'default'.
            //val pipeline : kotlin.collections.List<kotlin.String> =  // kotlin.collections.List<kotlin.String> | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults.
            //val webHookUrl : kotlin.String = webHookUrl_example // kotlin.String | Url to use for webhook callback when operation finishes or fails.
            //val embeddingModel : kotlin.String = embeddingModel_example // kotlin.String | Embedding model to use in ingestion. Optional. Default to configured default.
            //val args : kotlin.collections.Map<kotlin.String, kotlin.Any> = Object // kotlin.collections.Map<kotlin.String, kotlin.Any> | 
            //val tags : kotlin.collections.Map<kotlin.String, kotlin.Any> = Object // kotlin.collections.Map<kotlin.String, kotlin.Any> | Tags to associate with ingestion
            //val result : IngestDocumentResponse = apiInstance.semanticSearchFileIngestion(files, documentId, index, pipeline, webHookUrl, embeddingModel, args, tags)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchIngestionStatus
        should("test semanticSearchIngestionStatus") {
            // uncomment below to test semanticSearchIngestionStatus
            //val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | 
            //val result : DataPipelineStatus = apiInstance.semanticSearchIngestionStatus(id)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchList
        should("test semanticSearchList") {
            // uncomment below to test semanticSearchList
            //val listDocumentParameters : ListDocumentParameters = {"index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"withEmbeddings":false,"limit":10} // ListDocumentParameters | 
            //val result : ListDocumentResponse = apiInstance.semanticSearchList(listDocumentParameters)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchQuery
        should("test semanticSearchQuery") {
            // uncomment below to test semanticSearchQuery
            //val queryDocumentRequest : QueryDocumentRequest = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8,"limit":10} // QueryDocumentRequest | 
            //val result : QueryDocumentResponse = apiInstance.semanticSearchQuery(queryDocumentRequest)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchQueryResultsClustering
        should("test semanticSearchQueryResultsClustering") {
            // uncomment below to test semanticSearchQueryResultsClustering
            //val semanticSearchQueryResultsClusteringRequest : SemanticSearchQueryResultsClusteringRequest =  // SemanticSearchQueryResultsClusteringRequest | 
            //val result : KMeansCluster = apiInstance.semanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchRerank
        should("test semanticSearchRerank") {
            // uncomment below to test semanticSearchRerank
            //val reRankDocumentsRequest : ReRankDocumentsRequest = {"query":"What is the capital of the United States?","documents":["Carson City is the capital city of the American state of Nevada. At the  2010 United States Census, Carson City had a population of 55,274.","The Commonwealth of the Northern Mariana Islands is a group of islands in the Pacific Ocean that are a political division controlled by the United States. Its capital is Saipan.","Charlotte Amalie is the capital and largest city of the United States Virgin Islands. It has about 20,000 people. The city is on the island of Saint Thomas.","Washington, D.C. (also known as simply Washington or D.C., and officially as the District of Columbia) is the capital of the United States. It is a federal district. ","Capital punishment (the death penalty) has existed in the United States since before the United States was a country. As of 2017, capital punishment is legal in 30 of the 50 states.","North Dakota is a state in the United States. 672,591 people lived in North Dakota in the year 2010. The capital and seat of government is Bismarck."],"limit":10} // ReRankDocumentsRequest | 
            //val result : ReRankDocumentsResponse = apiInstance.semanticSearchRerank(reRankDocumentsRequest)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchTextIngestion
        should("test semanticSearchTextIngestion") {
            // uncomment below to test semanticSearchTextIngestion
            //val ingestTextDocumentRequest : IngestTextDocumentRequest = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Great":[],"AI":[],"Software":["true"]},"text":"Hello world"} // IngestTextDocumentRequest | 
            //val result : IngestDocumentResponse = apiInstance.semanticSearchTextIngestion(ingestTextDocumentRequest)
            //result shouldBe ("TODO")
        }

        // to test semanticSearchWebpageIngestion
        should("test semanticSearchWebpageIngestion") {
            // uncomment below to test semanticSearchWebpageIngestion
            //val ingestWebPageDocumentRequest : IngestWebPageDocumentRequest = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Software":["true"]},"url":"https://www.aiempowerlabs.com"} // IngestWebPageDocumentRequest | 
            //val result : IngestDocumentResponse = apiInstance.semanticSearchWebpageIngestion(ingestWebPageDocumentRequest)
            //result shouldBe ("TODO")
        }

    }
}
