﻿/* 
 * FIELDNATION RESTful API V2
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using FieldNation.SDK.Client;
using FieldNation.SDK.Model;

namespace FieldNation.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Update Model
        /// </summary>
        /// <remarks>
        /// Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>UpdateModel</returns>
        UpdateModel SystemUpdateModel (string path, string _event, KeyValue json, bool? async = null);

        /// <summary>
        /// Update Model
        /// </summary>
        /// <remarks>
        /// Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>ApiResponse of UpdateModel</returns>
        ApiResponse<UpdateModel> SystemUpdateModelWithHttpInfo (string path, string _event, KeyValue json, bool? async = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Update Model
        /// </summary>
        /// <remarks>
        /// Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>Task of UpdateModel</returns>
        System.Threading.Tasks.Task<UpdateModel> SystemUpdateModelAsync (string path, string _event, KeyValue json, bool? async = null);

        /// <summary>
        /// Update Model
        /// </summary>
        /// <remarks>
        /// Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>Task of ApiResponse (UpdateModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateModel>> SystemUpdateModelAsyncWithHttpInfo (string path, string _event, KeyValue json, bool? async = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SystemApi : ISystemApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FieldNation.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Update Model Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>UpdateModel</returns>
        public UpdateModel SystemUpdateModel (string path, string _event, KeyValue json, bool? async = null)
        {
             ApiResponse<UpdateModel> localVarResponse = SystemUpdateModelWithHttpInfo(path, _event, json, async);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Model Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>ApiResponse of UpdateModel</returns>
        public ApiResponse< UpdateModel > SystemUpdateModelWithHttpInfo (string path, string _event, KeyValue json, bool? async = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
                throw new ApiException(400, "Missing required parameter 'path' when calling SystemApi->SystemUpdateModel");
            // verify the required parameter '_event' is set
            if (_event == null)
                throw new ApiException(400, "Missing required parameter '_event' when calling SystemApi->SystemUpdateModel");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling SystemApi->SystemUpdateModel");

            var localVarPath = "/system/update-model";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (path != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "path", path)); // query parameter
            if (_event != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "event", _event)); // query parameter
            if (async != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "async", async)); // query parameter
            if (json != null && json.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(json); // http body (model) parameter
            }
            else
            {
                localVarPostBody = json; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemUpdateModel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpdateModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateModel)));
        }

        /// <summary>
        /// Update Model Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>Task of UpdateModel</returns>
        public async System.Threading.Tasks.Task<UpdateModel> SystemUpdateModelAsync (string path, string _event, KeyValue json, bool? async = null)
        {
             ApiResponse<UpdateModel> localVarResponse = await SystemUpdateModelAsyncWithHttpInfo(path, _event, json, async);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Model Fires an event that a model has been updated and propogates the new model to all interested parties.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The route for obtaining the new model</param>
        /// <param name="_event">operationId from the swagger API route</param>
        /// <param name="json">JSON parameters of the change</param>
        /// <param name="async">Return the model in the response (slower) (optional)</param>
        /// <returns>Task of ApiResponse (UpdateModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateModel>> SystemUpdateModelAsyncWithHttpInfo (string path, string _event, KeyValue json, bool? async = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
                throw new ApiException(400, "Missing required parameter 'path' when calling SystemApi->SystemUpdateModel");
            // verify the required parameter '_event' is set
            if (_event == null)
                throw new ApiException(400, "Missing required parameter '_event' when calling SystemApi->SystemUpdateModel");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling SystemApi->SystemUpdateModel");

            var localVarPath = "/system/update-model";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (path != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "path", path)); // query parameter
            if (_event != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "event", _event)); // query parameter
            if (async != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "async", async)); // query parameter
            if (json != null && json.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(json); // http body (model) parameter
            }
            else
            {
                localVarPostBody = json; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SystemUpdateModel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpdateModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateModel)));
        }

    }
}
