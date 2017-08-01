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
    public interface IBonusApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Bonus
        /// </summary>
        /// <remarks>
        /// Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>IdResponse</returns>
        IdResponse AddBonus (PayModifier bonus);

        /// <summary>
        /// Add Bonus
        /// </summary>
        /// <remarks>
        /// Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>ApiResponse of IdResponse</returns>
        ApiResponse<IdResponse> AddBonusWithHttpInfo (PayModifier bonus);
        /// <summary>
        /// Delete Bonus By Bonus
        /// </summary>
        /// <remarks>
        /// Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns></returns>
        void DeleteBonusByBonus (int? bonusId);

        /// <summary>
        /// Delete Bonus By Bonus
        /// </summary>
        /// <remarks>
        /// Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBonusByBonusWithHttpInfo (int? bonusId);
        /// <summary>
        /// Update Bonus by Bonus
        /// </summary>
        /// <remarks>
        /// Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        void UpdateBonusByBonus (int? bonusId, PayModifier json);

        /// <summary>
        /// Update Bonus by Bonus
        /// </summary>
        /// <remarks>
        /// Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateBonusByBonusWithHttpInfo (int? bonusId, PayModifier json);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add Bonus
        /// </summary>
        /// <remarks>
        /// Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>Task of IdResponse</returns>
        System.Threading.Tasks.Task<IdResponse> AddBonusAsync (PayModifier bonus);

        /// <summary>
        /// Add Bonus
        /// </summary>
        /// <remarks>
        /// Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>Task of ApiResponse (IdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IdResponse>> AddBonusAsyncWithHttpInfo (PayModifier bonus);
        /// <summary>
        /// Delete Bonus By Bonus
        /// </summary>
        /// <remarks>
        /// Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBonusByBonusAsync (int? bonusId);

        /// <summary>
        /// Delete Bonus By Bonus
        /// </summary>
        /// <remarks>
        /// Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBonusByBonusAsyncWithHttpInfo (int? bonusId);
        /// <summary>
        /// Update Bonus by Bonus
        /// </summary>
        /// <remarks>
        /// Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateBonusByBonusAsync (int? bonusId, PayModifier json);

        /// <summary>
        /// Update Bonus by Bonus
        /// </summary>
        /// <remarks>
        /// Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBonusByBonusAsyncWithHttpInfo (int? bonusId, PayModifier json);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BonusApi : IBonusApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BonusApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BonusApi(Configuration configuration = null)
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
        /// Add Bonus Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>IdResponse</returns>
        public IdResponse AddBonus (PayModifier bonus)
        {
             ApiResponse<IdResponse> localVarResponse = AddBonusWithHttpInfo(bonus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Bonus Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>ApiResponse of IdResponse</returns>
        public ApiResponse< IdResponse > AddBonusWithHttpInfo (PayModifier bonus)
        {
            // verify the required parameter 'bonus' is set
            if (bonus == null)
                throw new ApiException(400, "Missing required parameter 'bonus' when calling BonusApi->AddBonus");

            var localVarPath = "/bonuses";
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

            if (bonus != null && bonus.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bonus); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bonus; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddBonus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IdResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IdResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdResponse)));
        }

        /// <summary>
        /// Add Bonus Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>Task of IdResponse</returns>
        public async System.Threading.Tasks.Task<IdResponse> AddBonusAsync (PayModifier bonus)
        {
             ApiResponse<IdResponse> localVarResponse = await AddBonusAsyncWithHttpInfo(bonus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Bonus Adds a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonus">JSON Model</param>
        /// <returns>Task of ApiResponse (IdResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IdResponse>> AddBonusAsyncWithHttpInfo (PayModifier bonus)
        {
            // verify the required parameter 'bonus' is set
            if (bonus == null)
                throw new ApiException(400, "Missing required parameter 'bonus' when calling BonusApi->AddBonus");

            var localVarPath = "/bonuses";
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

            if (bonus != null && bonus.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(bonus); // http body (model) parameter
            }
            else
            {
                localVarPostBody = bonus; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddBonus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IdResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IdResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdResponse)));
        }

        /// <summary>
        /// Delete Bonus By Bonus Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns></returns>
        public void DeleteBonusByBonus (int? bonusId)
        {
             DeleteBonusByBonusWithHttpInfo(bonusId);
        }

        /// <summary>
        /// Delete Bonus By Bonus Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBonusByBonusWithHttpInfo (int? bonusId)
        {
            // verify the required parameter 'bonusId' is set
            if (bonusId == null)
                throw new ApiException(400, "Missing required parameter 'bonusId' when calling BonusApi->DeleteBonusByBonus");

            var localVarPath = "/bonuses/{bonus_id}";
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

            if (bonusId != null) localVarPathParams.Add("bonus_id", Configuration.ApiClient.ParameterToString(bonusId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteBonusByBonus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete Bonus By Bonus Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBonusByBonusAsync (int? bonusId)
        {
             await DeleteBonusByBonusAsyncWithHttpInfo(bonusId);

        }

        /// <summary>
        /// Delete Bonus By Bonus Removes a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">ID of Bonus</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBonusByBonusAsyncWithHttpInfo (int? bonusId)
        {
            // verify the required parameter 'bonusId' is set
            if (bonusId == null)
                throw new ApiException(400, "Missing required parameter 'bonusId' when calling BonusApi->DeleteBonusByBonus");

            var localVarPath = "/bonuses/{bonus_id}";
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

            if (bonusId != null) localVarPathParams.Add("bonus_id", Configuration.ApiClient.ParameterToString(bonusId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteBonusByBonus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Bonus by Bonus Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        public void UpdateBonusByBonus (int? bonusId, PayModifier json)
        {
             UpdateBonusByBonusWithHttpInfo(bonusId, json);
        }

        /// <summary>
        /// Update Bonus by Bonus Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateBonusByBonusWithHttpInfo (int? bonusId, PayModifier json)
        {
            // verify the required parameter 'bonusId' is set
            if (bonusId == null)
                throw new ApiException(400, "Missing required parameter 'bonusId' when calling BonusApi->UpdateBonusByBonus");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling BonusApi->UpdateBonusByBonus");

            var localVarPath = "/bonuses/{bonus_id}";
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

            if (bonusId != null) localVarPathParams.Add("bonus_id", Configuration.ApiClient.ParameterToString(bonusId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateBonusByBonus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Bonus by Bonus Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateBonusByBonusAsync (int? bonusId, PayModifier json)
        {
             await UpdateBonusByBonusAsyncWithHttpInfo(bonusId, json);

        }

        /// <summary>
        /// Update Bonus by Bonus Updates a bonus that can be applied to a work order to increase the amount paid upon a condition being met
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bonusId">Bonus ID</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBonusByBonusAsyncWithHttpInfo (int? bonusId, PayModifier json)
        {
            // verify the required parameter 'bonusId' is set
            if (bonusId == null)
                throw new ApiException(400, "Missing required parameter 'bonusId' when calling BonusApi->UpdateBonusByBonus");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling BonusApi->UpdateBonusByBonus");

            var localVarPath = "/bonuses/{bonus_id}";
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

            if (bonusId != null) localVarPathParams.Add("bonus_id", Configuration.ApiClient.ParameterToString(bonusId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateBonusByBonus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
