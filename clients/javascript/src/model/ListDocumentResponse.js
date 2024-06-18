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
 * The ListDocumentResponse model module.
 * @module model/ListDocumentResponse
 * @version v1
 */
class ListDocumentResponse {
    /**
     * Constructs a new <code>ListDocumentResponse</code>.
     * @alias module:model/ListDocumentResponse
     */
    constructor() { 
        
        ListDocumentResponse.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>ListDocumentResponse</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/ListDocumentResponse} obj Optional instance to populate.
     * @return {module:model/ListDocumentResponse} The populated <code>ListDocumentResponse</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new ListDocumentResponse();

            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'String');
            }
            if (data.hasOwnProperty('vector')) {
                obj['vector'] = ApiClient.convertToType(data['vector'], Object);
            }
            if (data.hasOwnProperty('tags')) {
                obj['tags'] = ApiClient.convertToType(data['tags'], {'String': ['String']});
            }
            if (data.hasOwnProperty('payload')) {
                obj['payload'] = ApiClient.convertToType(data['payload'], {'String': Object});
            }
        }
        return obj;
    }

    /**
     * Validates the JSON data with respect to <code>ListDocumentResponse</code>.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @return {boolean} to indicate whether the JSON data is valid with respect to <code>ListDocumentResponse</code>.
     */
    static validateJSON(data) {
        // ensure the json data is a string
        if (data['id'] && !(typeof data['id'] === 'string' || data['id'] instanceof String)) {
            throw new Error("Expected the field `id` to be a primitive type in the JSON string but got " + data['id']);
        }

        return true;
    }


}



/**
 * Unique record ID
 * @member {String} id
 */
ListDocumentResponse.prototype['id'] = undefined;

/**
 * Embedding vector
 * @member {Object} vector
 */
ListDocumentResponse.prototype['vector'] = undefined;

/**
 * Optional Searchable Key=Value tags (string => string[] collection)                Multiple values per keys are supported.  e.g. [ \"Collection=Work\", \"Project=1\", \"Project=2\", \"Project=3\", \"Type=Chat\", \"LLM=AzureAda2\" ]                Use cases:   * collections, e.g. [ \"Collection=Project1\", \"Collection=Work\" ]   * folders, e.g. [ \"Folder=Inbox\", \"Folder=Spam\" ]   * content types, e.g. [ \"Type=Chat\" ]   * versioning, e.g. [ \"LLM=AzureAda2\", \"Schema=1.0\" ]   * etc.
 * @member {Object.<String, Array.<String>>} tags
 */
ListDocumentResponse.prototype['tags'] = undefined;

/**
 * Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc.
 * @member {Object.<String, Object>} payload
 */
ListDocumentResponse.prototype['payload'] = undefined;






export default ListDocumentResponse;
