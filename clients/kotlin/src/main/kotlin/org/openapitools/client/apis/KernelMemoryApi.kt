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

import java.io.IOException
import okhttp3.Call
import okhttp3.HttpUrl

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

import com.squareup.moshi.Json

import org.openapitools.client.infrastructure.ApiClient
import org.openapitools.client.infrastructure.ApiResponse
import org.openapitools.client.infrastructure.ClientException
import org.openapitools.client.infrastructure.ClientError
import org.openapitools.client.infrastructure.ServerException
import org.openapitools.client.infrastructure.ServerError
import org.openapitools.client.infrastructure.MultiValueMap
import org.openapitools.client.infrastructure.PartConfig
import org.openapitools.client.infrastructure.RequestConfig
import org.openapitools.client.infrastructure.RequestMethod
import org.openapitools.client.infrastructure.ResponseType
import org.openapitools.client.infrastructure.Success
import org.openapitools.client.infrastructure.toMultiValue

class KernelMemoryApi(basePath: kotlin.String = defaultBasePath, client: Call.Factory = ApiClient.defaultClient) : ApiClient(basePath, client) {
    companion object {
        @JvmStatic
        val defaultBasePath: String by lazy {
            System.getProperties().getProperty(ApiClient.baseUrlKey, "https://studio.aiempowerlabs.com")
        }
    }

    /**
     * 
     * 
     * @param documentId 
     * @param filename 
     * @param index  (optional)
     * @return StreamableFileContent
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun downloadGet(documentId: kotlin.String, filename: kotlin.String, index: kotlin.String? = null) : StreamableFileContent {
        val localVarResponse = downloadGetWithHttpInfo(documentId = documentId, filename = filename, index = index)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as StreamableFileContent
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * 
     * 
     * @param documentId 
     * @param filename 
     * @param index  (optional)
     * @return ApiResponse<StreamableFileContent?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun downloadGetWithHttpInfo(documentId: kotlin.String, filename: kotlin.String, index: kotlin.String?) : ApiResponse<StreamableFileContent?> {
        val localVariableConfig = downloadGetRequestConfig(documentId = documentId, filename = filename, index = index)

        return request<Unit, StreamableFileContent>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation downloadGet
     *
     * @param documentId 
     * @param filename 
     * @param index  (optional)
     * @return RequestConfig
     */
    fun downloadGetRequestConfig(documentId: kotlin.String, filename: kotlin.String, index: kotlin.String?) : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf<kotlin.String, kotlin.collections.List<kotlin.String>>()
            .apply {
                if (index != null) {
                    put("index", listOf(index.toString()))
                }
                put("documentId", listOf(documentId.toString()))
                put("filename", listOf(filename.toString()))
            }
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.GET,
            path = "/download",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * Query documents and forward result to LLM
     * 
     * @param memoryQuery 
     * @return MemoryAnswer
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun kernelMemoryAsk(memoryQuery: MemoryQuery) : MemoryAnswer {
        val localVarResponse = kernelMemoryAskWithHttpInfo(memoryQuery = memoryQuery)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as MemoryAnswer
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * Query documents and forward result to LLM
     * 
     * @param memoryQuery 
     * @return ApiResponse<MemoryAnswer?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun kernelMemoryAskWithHttpInfo(memoryQuery: MemoryQuery) : ApiResponse<MemoryAnswer?> {
        val localVariableConfig = kernelMemoryAskRequestConfig(memoryQuery = memoryQuery)

        return request<MemoryQuery, MemoryAnswer>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation kernelMemoryAsk
     *
     * @param memoryQuery 
     * @return RequestConfig
     */
    fun kernelMemoryAskRequestConfig(memoryQuery: MemoryQuery) : RequestConfig<MemoryQuery> {
        val localVariableBody = memoryQuery
        val localVariableQuery: MultiValueMap = mutableMapOf()
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Content-Type"] = "application/json"
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.POST,
            path = "/api/kernelmemory/ask",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * Delete document from specific index
     * 
     * @param documentId 
     * @param index  (optional)
     * @return DeleteAccepted
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun kernelMemoryDelete(documentId: kotlin.String, index: kotlin.String? = null) : DeleteAccepted {
        val localVarResponse = kernelMemoryDeleteWithHttpInfo(documentId = documentId, index = index)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as DeleteAccepted
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * Delete document from specific index
     * 
     * @param documentId 
     * @param index  (optional)
     * @return ApiResponse<DeleteAccepted?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun kernelMemoryDeleteWithHttpInfo(documentId: kotlin.String, index: kotlin.String?) : ApiResponse<DeleteAccepted?> {
        val localVariableConfig = kernelMemoryDeleteRequestConfig(documentId = documentId, index = index)

        return request<Unit, DeleteAccepted>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation kernelMemoryDelete
     *
     * @param documentId 
     * @param index  (optional)
     * @return RequestConfig
     */
    fun kernelMemoryDeleteRequestConfig(documentId: kotlin.String, index: kotlin.String?) : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf<kotlin.String, kotlin.collections.List<kotlin.String>>()
            .apply {
                if (index != null) {
                    put("index", listOf(index.toString()))
                }
                put("documentId", listOf(documentId.toString()))
            }
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.DELETE,
            path = "/api/kernelmemory/documents",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * Delete index
     * 
     * @param index  (optional)
     * @return DeleteAccepted
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun kernelMemoryDeleteIndex(index: kotlin.String? = null) : DeleteAccepted {
        val localVarResponse = kernelMemoryDeleteIndexWithHttpInfo(index = index)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as DeleteAccepted
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * Delete index
     * 
     * @param index  (optional)
     * @return ApiResponse<DeleteAccepted?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun kernelMemoryDeleteIndexWithHttpInfo(index: kotlin.String?) : ApiResponse<DeleteAccepted?> {
        val localVariableConfig = kernelMemoryDeleteIndexRequestConfig(index = index)

        return request<Unit, DeleteAccepted>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation kernelMemoryDeleteIndex
     *
     * @param index  (optional)
     * @return RequestConfig
     */
    fun kernelMemoryDeleteIndexRequestConfig(index: kotlin.String?) : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf<kotlin.String, kotlin.collections.List<kotlin.String>>()
            .apply {
                if (index != null) {
                    put("index", listOf(index.toString()))
                }
            }
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.DELETE,
            path = "/api/kernelmemory/indexes",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * List indexes
     * 
     * @return IndexCollection
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun kernelMemoryGetIndex() : IndexCollection {
        val localVarResponse = kernelMemoryGetIndexWithHttpInfo()

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as IndexCollection
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * List indexes
     * 
     * @return ApiResponse<IndexCollection?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun kernelMemoryGetIndexWithHttpInfo() : ApiResponse<IndexCollection?> {
        val localVariableConfig = kernelMemoryGetIndexRequestConfig()

        return request<Unit, IndexCollection>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation kernelMemoryGetIndex
     *
     * @return RequestConfig
     */
    fun kernelMemoryGetIndexRequestConfig() : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf()
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.GET,
            path = "/api/kernelmemory/indexes",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * Search for documents in specific index
     * 
     * @param searchQuery 
     * @return SearchResult
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun kernelMemorySearch(searchQuery: SearchQuery) : SearchResult {
        val localVarResponse = kernelMemorySearchWithHttpInfo(searchQuery = searchQuery)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as SearchResult
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * Search for documents in specific index
     * 
     * @param searchQuery 
     * @return ApiResponse<SearchResult?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun kernelMemorySearchWithHttpInfo(searchQuery: SearchQuery) : ApiResponse<SearchResult?> {
        val localVariableConfig = kernelMemorySearchRequestConfig(searchQuery = searchQuery)

        return request<SearchQuery, SearchResult>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation kernelMemorySearch
     *
     * @param searchQuery 
     * @return RequestConfig
     */
    fun kernelMemorySearchRequestConfig(searchQuery: SearchQuery) : RequestConfig<SearchQuery> {
        val localVariableBody = searchQuery
        val localVariableQuery: MultiValueMap = mutableMapOf()
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Content-Type"] = "application/json"
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.POST,
            path = "/api/kernelmemory/search",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * Upload file for ingestion
     * 
     * @return UploadAccepted
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun kernelMemoryUpload() : UploadAccepted {
        val localVarResponse = kernelMemoryUploadWithHttpInfo()

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as UploadAccepted
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * Upload file for ingestion
     * 
     * @return ApiResponse<UploadAccepted?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun kernelMemoryUploadWithHttpInfo() : ApiResponse<UploadAccepted?> {
        val localVariableConfig = kernelMemoryUploadRequestConfig()

        return request<Unit, UploadAccepted>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation kernelMemoryUpload
     *
     * @return RequestConfig
     */
    fun kernelMemoryUploadRequestConfig() : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf()
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.POST,
            path = "/api/kernelmemory/upload",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * Get ingestion status for specific document
     * 
     * @param documentId 
     * @param index  (optional)
     * @return DataPipelineStatus
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun kernelMemoryUploadStatus(documentId: kotlin.String, index: kotlin.String? = null) : DataPipelineStatus {
        val localVarResponse = kernelMemoryUploadStatusWithHttpInfo(documentId = documentId, index = index)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as DataPipelineStatus
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()} ${localVarError.body}", localVarError.statusCode, localVarResponse)
            }
        }
    }

    /**
     * Get ingestion status for specific document
     * 
     * @param documentId 
     * @param index  (optional)
     * @return ApiResponse<DataPipelineStatus?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun kernelMemoryUploadStatusWithHttpInfo(documentId: kotlin.String, index: kotlin.String?) : ApiResponse<DataPipelineStatus?> {
        val localVariableConfig = kernelMemoryUploadStatusRequestConfig(documentId = documentId, index = index)

        return request<Unit, DataPipelineStatus>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation kernelMemoryUploadStatus
     *
     * @param documentId 
     * @param index  (optional)
     * @return RequestConfig
     */
    fun kernelMemoryUploadStatusRequestConfig(documentId: kotlin.String, index: kotlin.String?) : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf<kotlin.String, kotlin.collections.List<kotlin.String>>()
            .apply {
                if (index != null) {
                    put("index", listOf(index.toString()))
                }
                put("documentId", listOf(documentId.toString()))
            }
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.GET,
            path = "/api/kernelmemory/upload-status",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }


    private fun encodeURIComponent(uriComponent: kotlin.String): kotlin.String =
        HttpUrl.Builder().scheme("http").host("localhost").addPathSegment(uriComponent).build().encodedPathSegments[0]
}