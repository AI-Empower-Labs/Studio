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
import Coordinate from './Coordinate';

/**
 * The Centroid model module.
 * @module model/Centroid
 * @version v1
 */
class Centroid {
    /**
     * Constructs a new <code>Centroid</code>.
     * Represents a centroid for a cluster, includes coordinate and array of datapoints
     * @alias module:model/Centroid
     */
    constructor() { 
        
        Centroid.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>Centroid</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/Centroid} obj Optional instance to populate.
     * @return {module:model/Centroid} The populated <code>Centroid</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new Centroid();

            if (data.hasOwnProperty('coordinate')) {
                obj['coordinate'] = Coordinate.constructFromObject(data['coordinate']);
            }
            if (data.hasOwnProperty('dataPoints')) {
                obj['dataPoints'] = ApiClient.convertToType(data['dataPoints'], [Coordinate]);
            }
        }
        return obj;
    }

    /**
     * Validates the JSON data with respect to <code>Centroid</code>.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @return {boolean} to indicate whether the JSON data is valid with respect to <code>Centroid</code>.
     */
    static validateJSON(data) {
        // validate the optional field `coordinate`
        if (data['coordinate']) { // data not null
          Coordinate.validateJSON(data['coordinate']);
        }
        if (data['dataPoints']) { // data not null
            // ensure the json data is an array
            if (!Array.isArray(data['dataPoints'])) {
                throw new Error("Expected the field `dataPoints` to be an array in the JSON data but got " + data['dataPoints']);
            }
            // validate the optional field `dataPoints` (array)
            for (const item of data['dataPoints']) {
                Coordinate.validateJSON(item);
            };
        }

        return true;
    }


}



/**
 * @member {module:model/Coordinate} coordinate
 */
Centroid.prototype['coordinate'] = undefined;

/**
 * Array of data points belonging to the centroid
 * @member {Array.<module:model/Coordinate>} dataPoints
 */
Centroid.prototype['dataPoints'] = undefined;






export default Centroid;
