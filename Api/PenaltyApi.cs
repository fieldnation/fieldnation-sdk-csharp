/* 
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
    public interface IPenaltyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Penalty
        /// </summary>
        /// <remarks>
        /// Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>PayModifier</returns>
        PayModifier AddPenalty (PayModifier penalty);

        /// <summary>
        /// Add Penalty
        /// </summary>
        /// <remarks>
        /// Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>ApiResponse of PayModifier</returns>
        ApiResponse<PayModifier> AddPenaltyWithHttpInfo (PayModifier penalty);
        /// <summary>
        /// Delete Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns></returns>
        void DeletePenaltyByPenalty (int? penaltyId);

        /// <summary>
        /// Delete Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePenaltyByPenaltyWithHttpInfo (int? penaltyId);
        /// <summary>
        /// Update Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        void UpdatePenaltyByPenalty (string penaltyId, PayModifier json);

        /// <summary>
        /// Update Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdatePenaltyByPenaltyWithHttpInfo (string penaltyId, PayModifier json);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add Penalty
        /// </summary>
        /// <remarks>
        /// Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>Task of PayModifier</returns>
        System.Threading.Tasks.Task<PayModifier> AddPenaltyAsync (PayModifier penalty);

        /// <summary>
        /// Add Penalty
        /// </summary>
        /// <remarks>
        /// Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>Task of ApiResponse (PayModifier)</returns>
        System.Threading.Tasks.Task<ApiResponse<PayModifier>> AddPenaltyAsyncWithHttpInfo (PayModifier penalty);
        /// <summary>
        /// Delete Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePenaltyByPenaltyAsync (int? penaltyId);

        /// <summary>
        /// Delete Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePenaltyByPenaltyAsyncWithHttpInfo (int? penaltyId);
        /// <summary>
        /// Update Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdatePenaltyByPenaltyAsync (string penaltyId, PayModifier json);

        /// <summary>
        /// Update Penalty by Penalty
        /// </summary>
        /// <remarks>
        /// Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePenaltyByPenaltyAsyncWithHttpInfo (string penaltyId, PayModifier json);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PenaltyApi : IPenaltyApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PenaltyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PenaltyApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PenaltyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PenaltyApi(Configuration configuration = null)
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
        /// Add Penalty Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>PayModifier</returns>
        public PayModifier AddPenalty (PayModifier penalty)
        {
             ApiResponse<PayModifier> localVarResponse = AddPenaltyWithHttpInfo(penalty);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Penalty Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>ApiResponse of PayModifier</returns>
        public ApiResponse< PayModifier > AddPenaltyWithHttpInfo (PayModifier penalty)
        {
            // verify the required parameter 'penalty' is set
            if (penalty == null)
                throw new ApiException(400, "Missing required parameter 'penalty' when calling PenaltyApi->AddPenalty");

            var localVarPath = "/penalties";
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

            if (penalty != null && penalty.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(penalty); // http body (model) parameter
            }
            else
            {
                localVarPostBody = penalty; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPenalty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PayModifier>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PayModifier) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PayModifier)));
        }

        /// <summary>
        /// Add Penalty Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>Task of PayModifier</returns>
        public async System.Threading.Tasks.Task<PayModifier> AddPenaltyAsync (PayModifier penalty)
        {
             ApiResponse<PayModifier> localVarResponse = await AddPenaltyAsyncWithHttpInfo(penalty);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Penalty Add a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penalty">JSON Model</param>
        /// <returns>Task of ApiResponse (PayModifier)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PayModifier>> AddPenaltyAsyncWithHttpInfo (PayModifier penalty)
        {
            // verify the required parameter 'penalty' is set
            if (penalty == null)
                throw new ApiException(400, "Missing required parameter 'penalty' when calling PenaltyApi->AddPenalty");

            var localVarPath = "/penalties";
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

            if (penalty != null && penalty.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(penalty); // http body (model) parameter
            }
            else
            {
                localVarPostBody = penalty; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPenalty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PayModifier>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PayModifier) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PayModifier)));
        }

        /// <summary>
        /// Delete Penalty by Penalty Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns></returns>
        public void DeletePenaltyByPenalty (int? penaltyId)
        {
             DeletePenaltyByPenaltyWithHttpInfo(penaltyId);
        }

        /// <summary>
        /// Delete Penalty by Penalty Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePenaltyByPenaltyWithHttpInfo (int? penaltyId)
        {
            // verify the required parameter 'penaltyId' is set
            if (penaltyId == null)
                throw new ApiException(400, "Missing required parameter 'penaltyId' when calling PenaltyApi->DeletePenaltyByPenalty");

            var localVarPath = "/penalties/{penalty_id}";
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

            if (penaltyId != null) localVarPathParams.Add("penalty_id", Configuration.ApiClient.ParameterToString(penaltyId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePenaltyByPenalty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete Penalty by Penalty Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePenaltyByPenaltyAsync (int? penaltyId)
        {
             await DeletePenaltyByPenaltyAsyncWithHttpInfo(penaltyId);

        }

        /// <summary>
        /// Delete Penalty by Penalty Removes a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePenaltyByPenaltyAsyncWithHttpInfo (int? penaltyId)
        {
            // verify the required parameter 'penaltyId' is set
            if (penaltyId == null)
                throw new ApiException(400, "Missing required parameter 'penaltyId' when calling PenaltyApi->DeletePenaltyByPenalty");

            var localVarPath = "/penalties/{penalty_id}";
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

            if (penaltyId != null) localVarPathParams.Add("penalty_id", Configuration.ApiClient.ParameterToString(penaltyId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePenaltyByPenalty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Penalty by Penalty Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        public void UpdatePenaltyByPenalty (string penaltyId, PayModifier json)
        {
             UpdatePenaltyByPenaltyWithHttpInfo(penaltyId, json);
        }

        /// <summary>
        /// Update Penalty by Penalty Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdatePenaltyByPenaltyWithHttpInfo (string penaltyId, PayModifier json)
        {
            // verify the required parameter 'penaltyId' is set
            if (penaltyId == null)
                throw new ApiException(400, "Missing required parameter 'penaltyId' when calling PenaltyApi->UpdatePenaltyByPenalty");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling PenaltyApi->UpdatePenaltyByPenalty");

            var localVarPath = "/penalties/{penalty_id}";
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

            if (penaltyId != null) localVarPathParams.Add("penalty_id", Configuration.ApiClient.ParameterToString(penaltyId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePenaltyByPenalty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Penalty by Penalty Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdatePenaltyByPenaltyAsync (string penaltyId, PayModifier json)
        {
             await UpdatePenaltyByPenaltyAsyncWithHttpInfo(penaltyId, json);

        }

        /// <summary>
        /// Update Penalty by Penalty Update a penalty which can be added as an option to a work order and applied during the approval process to lower the amount paid to the provider pending a condition is met.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="penaltyId">Penalty ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePenaltyByPenaltyAsyncWithHttpInfo (string penaltyId, PayModifier json)
        {
            // verify the required parameter 'penaltyId' is set
            if (penaltyId == null)
                throw new ApiException(400, "Missing required parameter 'penaltyId' when calling PenaltyApi->UpdatePenaltyByPenalty");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling PenaltyApi->UpdatePenaltyByPenalty");

            var localVarPath = "/penalties/{penalty_id}";
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

            if (penaltyId != null) localVarPathParams.Add("penalty_id", Configuration.ApiClient.ParameterToString(penaltyId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePenaltyByPenalty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
