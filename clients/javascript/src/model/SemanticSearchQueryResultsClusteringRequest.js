/**
 * Studio - AI Empower Labs
 * # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@aiempowerlabs.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';

/**
 * The SemanticSearchQueryResultsClusteringRequest model module.
 * @module model/SemanticSearchQueryResultsClusteringRequest
 * @version v1
 */
class SemanticSearchQueryResultsClusteringRequest {
    /**
     * Constructs a new <code>SemanticSearchQueryResultsClusteringRequest</code>.
     * @alias module:model/SemanticSearchQueryResultsClusteringRequest
     */
    constructor() { 
        
        SemanticSearchQueryResultsClusteringRequest.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>SemanticSearchQueryResultsClusteringRequest</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/SemanticSearchQueryResultsClusteringRequest} obj Optional instance to populate.
     * @return {module:model/SemanticSearchQueryResultsClusteringRequest} The populated <code>SemanticSearchQueryResultsClusteringRequest</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new SemanticSearchQueryResultsClusteringRequest();

            if (data.hasOwnProperty('clusterCount')) {
                obj['clusterCount'] = ApiClient.convertToType(data['clusterCount'], 'Number');
            }
            if (data.hasOwnProperty('maxDegreeOfParallelism')) {
                obj['maxDegreeOfParallelism'] = ApiClient.convertToType(data['maxDegreeOfParallelism'], 'Number');
            }
            if (data.hasOwnProperty('maxTokens')) {
                obj['maxTokens'] = ApiClient.convertToType(data['maxTokens'], 'Number');
            }
            if (data.hasOwnProperty('index')) {
                obj['index'] = ApiClient.convertToType(data['index'], 'String');
            }
            if (data.hasOwnProperty('minRelevance')) {
                obj['minRelevance'] = ApiClient.convertToType(data['minRelevance'], 'Number');
            }
            if (data.hasOwnProperty('maxRelevance')) {
                obj['maxRelevance'] = ApiClient.convertToType(data['maxRelevance'], 'Number');
            }
            if (data.hasOwnProperty('llmModel')) {
                obj['llmModel'] = ApiClient.convertToType(data['llmModel'], 'String');
            }
            if (data.hasOwnProperty('embeddingModel')) {
                obj['embeddingModel'] = ApiClient.convertToType(data['embeddingModel'], 'String');
            }
        }
        return obj;
    }

    /**
     * Validates the JSON data with respect to <code>SemanticSearchQueryResultsClusteringRequest</code>.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @return {boolean} to indicate whether the JSON data is valid with respect to <code>SemanticSearchQueryResultsClusteringRequest</code>.
     */
    static validateJSON(data) {
        // ensure the json data is a string
        if (data['index'] && !(typeof data['index'] === 'string' || data['index'] instanceof String)) {
            throw new Error("Expected the field `index` to be a primitive type in the JSON string but got " + data['index']);
        }
        // ensure the json data is a string
        if (data['llmModel'] && !(typeof data['llmModel'] === 'string' || data['llmModel'] instanceof String)) {
            throw new Error("Expected the field `llmModel` to be a primitive type in the JSON string but got " + data['llmModel']);
        }
        // ensure the json data is a string
        if (data['embeddingModel'] && !(typeof data['embeddingModel'] === 'string' || data['embeddingModel'] instanceof String)) {
            throw new Error("Expected the field `embeddingModel` to be a primitive type in the JSON string but got " + data['embeddingModel']);
        }

        return true;
    }


}



/**
 * The number of clusters to be used in k-means clustering.
 * @member {Number} clusterCount
 * @default 3
 */
SemanticSearchQueryResultsClusteringRequest.prototype['clusterCount'] = 3;

/**
 * The Maximum Degrees Of Parallelism
 * @member {Number} maxDegreeOfParallelism
 * @default 1
 */
SemanticSearchQueryResultsClusteringRequest.prototype['maxDegreeOfParallelism'] = 1;

/**
 * The maximum number of tokens to be used in the KMeans clustering algorithm.
 * @member {Number} maxTokens
 * @default 10
 */
SemanticSearchQueryResultsClusteringRequest.prototype['maxTokens'] = 10;

/**
 * Optional index to specify which index to search in. Defaults to 'default'.
 * @member {String} index
 */
SemanticSearchQueryResultsClusteringRequest.prototype['index'] = undefined;

/**
 * The minimum relevance value used for querying the search result audit.
 * @member {Number} minRelevance
 */
SemanticSearchQueryResultsClusteringRequest.prototype['minRelevance'] = undefined;

/**
 * The maximum relevance value to be used in the search query.
 * @member {Number} maxRelevance
 */
SemanticSearchQueryResultsClusteringRequest.prototype['maxRelevance'] = undefined;

/**
 * Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm.
 * @member {String} llmModel
 */
SemanticSearchQueryResultsClusteringRequest.prototype['llmModel'] = undefined;

/**
 * The name of the embedding model used for clustering.
 * @member {String} embeddingModel
 */
SemanticSearchQueryResultsClusteringRequest.prototype['embeddingModel'] = undefined;






export default SemanticSearchQueryResultsClusteringRequest;
