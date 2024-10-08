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
 * The HttpValidationProblemDetails model module.
 * @module model/HttpValidationProblemDetails
 * @version v1
 */
class HttpValidationProblemDetails {
    /**
     * Constructs a new <code>HttpValidationProblemDetails</code>.
     * @alias module:model/HttpValidationProblemDetails
     * @extends Object
     */
    constructor() { 
        
        HttpValidationProblemDetails.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>HttpValidationProblemDetails</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/HttpValidationProblemDetails} obj Optional instance to populate.
     * @return {module:model/HttpValidationProblemDetails} The populated <code>HttpValidationProblemDetails</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new HttpValidationProblemDetails();

            ApiClient.constructFromObject(data, obj, 'Object');
            

            if (data.hasOwnProperty('type')) {
                obj['type'] = ApiClient.convertToType(data['type'], 'String');
            }
            if (data.hasOwnProperty('title')) {
                obj['title'] = ApiClient.convertToType(data['title'], 'String');
            }
            if (data.hasOwnProperty('status')) {
                obj['status'] = ApiClient.convertToType(data['status'], 'Number');
            }
            if (data.hasOwnProperty('detail')) {
                obj['detail'] = ApiClient.convertToType(data['detail'], 'String');
            }
            if (data.hasOwnProperty('instance')) {
                obj['instance'] = ApiClient.convertToType(data['instance'], 'String');
            }
            if (data.hasOwnProperty('errors')) {
                obj['errors'] = ApiClient.convertToType(data['errors'], {'String': ['String']});
            }
        }
        return obj;
    }

    /**
     * Validates the JSON data with respect to <code>HttpValidationProblemDetails</code>.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @return {boolean} to indicate whether the JSON data is valid with respect to <code>HttpValidationProblemDetails</code>.
     */
    static validateJSON(data) {
        // ensure the json data is a string
        if (data['type'] && !(typeof data['type'] === 'string' || data['type'] instanceof String)) {
            throw new Error("Expected the field `type` to be a primitive type in the JSON string but got " + data['type']);
        }
        // ensure the json data is a string
        if (data['title'] && !(typeof data['title'] === 'string' || data['title'] instanceof String)) {
            throw new Error("Expected the field `title` to be a primitive type in the JSON string but got " + data['title']);
        }
        // ensure the json data is a string
        if (data['detail'] && !(typeof data['detail'] === 'string' || data['detail'] instanceof String)) {
            throw new Error("Expected the field `detail` to be a primitive type in the JSON string but got " + data['detail']);
        }
        // ensure the json data is a string
        if (data['instance'] && !(typeof data['instance'] === 'string' || data['instance'] instanceof String)) {
            throw new Error("Expected the field `instance` to be a primitive type in the JSON string but got " + data['instance']);
        }

        return true;
    }


}



/**
 * @member {String} type
 */
HttpValidationProblemDetails.prototype['type'] = undefined;

/**
 * @member {String} title
 */
HttpValidationProblemDetails.prototype['title'] = undefined;

/**
 * @member {Number} status
 */
HttpValidationProblemDetails.prototype['status'] = undefined;

/**
 * @member {String} detail
 */
HttpValidationProblemDetails.prototype['detail'] = undefined;

/**
 * @member {String} instance
 */
HttpValidationProblemDetails.prototype['instance'] = undefined;

/**
 * @member {Object.<String, Array.<String>>} errors
 */
HttpValidationProblemDetails.prototype['errors'] = undefined;






export default HttpValidationProblemDetails;

