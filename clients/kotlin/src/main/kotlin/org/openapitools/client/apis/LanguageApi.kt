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

import org.openapitools.client.models.DetectLanguageResponse
import org.openapitools.client.models.GetLanguageResponse
import org.openapitools.client.models.HttpValidationProblemDetails
import org.openapitools.client.models.Translate
import org.openapitools.client.models.TranslateResponse

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

class LanguageApi(basePath: kotlin.String = defaultBasePath, client: Call.Factory = ApiClient.defaultClient) : ApiClient(basePath, client) {
    companion object {
        @JvmStatic
        val defaultBasePath: String by lazy {
            System.getProperties().getProperty(ApiClient.baseUrlKey, "https://studio.aiempowerlabs.com")
        }
    }

    /**
     * GET /api/language/detect
     * Detects language of a text
     * Accepts text input and returns information about the language in which the text is written.  The response from the endpoint includes the detected language represented by a language code (e.g., EN for English, ES for Spanish) and may also provide a confidence score indicating the likelihood that the detected language is correct. This type of endpoint is useful for applications requiring automatic language recognition, such as content localization, multilingual support systems, and global data analysis tools.
     * @param text 
     * @return DetectLanguageResponse
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun languageDetection(text: kotlin.String) : DetectLanguageResponse {
        val localVarResponse = languageDetectionWithHttpInfo(text = text)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as DetectLanguageResponse
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
     * GET /api/language/detect
     * Detects language of a text
     * Accepts text input and returns information about the language in which the text is written.  The response from the endpoint includes the detected language represented by a language code (e.g., EN for English, ES for Spanish) and may also provide a confidence score indicating the likelihood that the detected language is correct. This type of endpoint is useful for applications requiring automatic language recognition, such as content localization, multilingual support systems, and global data analysis tools.
     * @param text 
     * @return ApiResponse<DetectLanguageResponse?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun languageDetectionWithHttpInfo(text: kotlin.String) : ApiResponse<DetectLanguageResponse?> {
        val localVariableConfig = languageDetectionRequestConfig(text = text)

        return request<Unit, DetectLanguageResponse>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation languageDetection
     *
     * @param text 
     * @return RequestConfig
     */
    fun languageDetectionRequestConfig(text: kotlin.String) : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf<kotlin.String, kotlin.collections.List<kotlin.String>>()
            .apply {
                put("text", listOf(text.toString()))
            }
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.GET,
            path = "/api/language/detect",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * GET /api/language
     * List of supported languages for translation
     * Returns a list of supported languages, and translation targets
     * @return GetLanguageResponse
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun languageGetLanguageList() : GetLanguageResponse {
        val localVarResponse = languageGetLanguageListWithHttpInfo()

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as GetLanguageResponse
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
     * GET /api/language
     * List of supported languages for translation
     * Returns a list of supported languages, and translation targets
     * @return ApiResponse<GetLanguageResponse?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun languageGetLanguageListWithHttpInfo() : ApiResponse<GetLanguageResponse?> {
        val localVariableConfig = languageGetLanguageListRequestConfig()

        return request<Unit, GetLanguageResponse>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation languageGetLanguageList
     *
     * @return RequestConfig
     */
    fun languageGetLanguageListRequestConfig() : RequestConfig<Unit> {
        val localVariableBody = null
        val localVariableQuery: MultiValueMap = mutableMapOf()
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.GET,
            path = "/api/language",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }

    /**
     * POST /api/language/translate
     * Translation of text from one language to another
     * This endpoint provides a simplified interface for text translation, making it accessible for various applications, including web and mobile apps that require multilingual support.
     * @param translate 
     * @return TranslateResponse
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     * @throws UnsupportedOperationException If the API returns an informational or redirection response
     * @throws ClientException If the API returns a client error response
     * @throws ServerException If the API returns a server error response
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class, UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun languageTranslate(translate: Translate) : TranslateResponse {
        val localVarResponse = languageTranslateWithHttpInfo(translate = translate)

        return when (localVarResponse.responseType) {
            ResponseType.Success -> (localVarResponse as Success<*>).data as TranslateResponse
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
     * POST /api/language/translate
     * Translation of text from one language to another
     * This endpoint provides a simplified interface for text translation, making it accessible for various applications, including web and mobile apps that require multilingual support.
     * @param translate 
     * @return ApiResponse<TranslateResponse?>
     * @throws IllegalStateException If the request is not correctly configured
     * @throws IOException Rethrows the OkHttp execute method exception
     */
    @Suppress("UNCHECKED_CAST")
    @Throws(IllegalStateException::class, IOException::class)
    fun languageTranslateWithHttpInfo(translate: Translate) : ApiResponse<TranslateResponse?> {
        val localVariableConfig = languageTranslateRequestConfig(translate = translate)

        return request<Translate, TranslateResponse>(
            localVariableConfig
        )
    }

    /**
     * To obtain the request config of the operation languageTranslate
     *
     * @param translate 
     * @return RequestConfig
     */
    fun languageTranslateRequestConfig(translate: Translate) : RequestConfig<Translate> {
        val localVariableBody = translate
        val localVariableQuery: MultiValueMap = mutableMapOf()
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        localVariableHeaders["Content-Type"] = "application/json"
        localVariableHeaders["Accept"] = "application/json, application/problem+json"

        return RequestConfig(
            method = RequestMethod.POST,
            path = "/api/language/translate",
            query = localVariableQuery,
            headers = localVariableHeaders,
            requiresAuthentication = false,
            body = localVariableBody
        )
    }


    private fun encodeURIComponent(uriComponent: kotlin.String): kotlin.String =
        HttpUrl.Builder().scheme("http").host("localhost").addPathSegment(uriComponent).build().encodedPathSegments[0]
}
