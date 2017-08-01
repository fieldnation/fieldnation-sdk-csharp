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
    public interface ICustomfieldApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Custom Fields
        /// </summary>
        /// <remarks>
        /// Adds a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>IdResponse</returns>
        IdResponse AddCustomField (CustomField json);

        /// <summary>
        /// Add Custom Fields
        /// </summary>
        /// <remarks>
        /// Adds a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of IdResponse</returns>
        ApiResponse<IdResponse> AddCustomFieldWithHttpInfo (CustomField json);
        /// <summary>
        /// Delete Custom Field
        /// </summary>
        /// <remarks>
        /// Removes a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns></returns>
        void DeleteCustomField (int? customFieldId);

        /// <summary>
        /// Delete Custom Field
        /// </summary>
        /// <remarks>
        /// Removes a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomFieldWithHttpInfo (int? customFieldId);
        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Gets a list of work order custom fields
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CustomFields</returns>
        CustomFields GetCustomFields ();

        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Gets a list of work order custom fields
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> GetCustomFieldsWithHttpInfo ();
        /// <summary>
        /// Update Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        void UpdateCustomField (int? customFieldId, CustomField json);

        /// <summary>
        /// Update Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCustomFieldWithHttpInfo (int? customFieldId, CustomField json);
        /// <summary>
        /// Update Custom Field Visibility
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for all projects and clients
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns></returns>
        void UpdateCustomFieldVisibility (int? customFieldId, string visibility);

        /// <summary>
        /// Update Custom Field Visibility
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for all projects and clients
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCustomFieldVisibilityWithHttpInfo (int? customFieldId, string visibility);
        /// <summary>
        /// Update Custom Field Visibility by Client
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns></returns>
        void UpdateCustomFieldVisibilityByClient (int? customFieldId, int? clientId, string visibility);

        /// <summary>
        /// Update Custom Field Visibility by Client
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCustomFieldVisibilityByClientWithHttpInfo (int? customFieldId, int? clientId, string visibility);
        /// <summary>
        /// Update Custom Field Visibility by Project
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single project
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns></returns>
        void UpdateCustomFieldVisibilityByProject (int? customFieldId, int? projectId, string visibility);

        /// <summary>
        /// Update Custom Field Visibility by Project
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single project
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCustomFieldVisibilityByProjectWithHttpInfo (int? customFieldId, int? projectId, string visibility);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add Custom Fields
        /// </summary>
        /// <remarks>
        /// Adds a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of IdResponse</returns>
        System.Threading.Tasks.Task<IdResponse> AddCustomFieldAsync (CustomField json);

        /// <summary>
        /// Add Custom Fields
        /// </summary>
        /// <remarks>
        /// Adds a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse (IdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IdResponse>> AddCustomFieldAsyncWithHttpInfo (CustomField json);
        /// <summary>
        /// Delete Custom Field
        /// </summary>
        /// <remarks>
        /// Removes a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCustomFieldAsync (int? customFieldId);

        /// <summary>
        /// Delete Custom Field
        /// </summary>
        /// <remarks>
        /// Removes a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomFieldAsyncWithHttpInfo (int? customFieldId);
        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Gets a list of work order custom fields
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> GetCustomFieldsAsync ();

        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Gets a list of work order custom fields
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> GetCustomFieldsAsyncWithHttpInfo ();
        /// <summary>
        /// Update Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCustomFieldAsync (int? customFieldId, CustomField json);

        /// <summary>
        /// Update Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldAsyncWithHttpInfo (int? customFieldId, CustomField json);
        /// <summary>
        /// Update Custom Field Visibility
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for all projects and clients
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCustomFieldVisibilityAsync (int? customFieldId, string visibility);

        /// <summary>
        /// Update Custom Field Visibility
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for all projects and clients
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldVisibilityAsyncWithHttpInfo (int? customFieldId, string visibility);
        /// <summary>
        /// Update Custom Field Visibility by Client
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCustomFieldVisibilityByClientAsync (int? customFieldId, int? clientId, string visibility);

        /// <summary>
        /// Update Custom Field Visibility by Client
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldVisibilityByClientAsyncWithHttpInfo (int? customFieldId, int? clientId, string visibility);
        /// <summary>
        /// Update Custom Field Visibility by Project
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single project
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCustomFieldVisibilityByProjectAsync (int? customFieldId, int? projectId, string visibility);

        /// <summary>
        /// Update Custom Field Visibility by Project
        /// </summary>
        /// <remarks>
        /// Updates a work order custom field&#39;s visibility for a single project
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldVisibilityByProjectAsyncWithHttpInfo (int? customFieldId, int? projectId, string visibility);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CustomfieldApi : ICustomfieldApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomfieldApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomfieldApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomfieldApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomfieldApi(Configuration configuration = null)
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
        /// Add Custom Fields Adds a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>IdResponse</returns>
        public IdResponse AddCustomField (CustomField json)
        {
             ApiResponse<IdResponse> localVarResponse = AddCustomFieldWithHttpInfo(json);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Custom Fields Adds a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of IdResponse</returns>
        public ApiResponse< IdResponse > AddCustomFieldWithHttpInfo (CustomField json)
        {
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling CustomfieldApi->AddCustomField");

            var localVarPath = "/custom-fields";
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
                Exception exception = ExceptionFactory("AddCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IdResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IdResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdResponse)));
        }

        /// <summary>
        /// Add Custom Fields Adds a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of IdResponse</returns>
        public async System.Threading.Tasks.Task<IdResponse> AddCustomFieldAsync (CustomField json)
        {
             ApiResponse<IdResponse> localVarResponse = await AddCustomFieldAsyncWithHttpInfo(json);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Custom Fields Adds a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse (IdResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IdResponse>> AddCustomFieldAsyncWithHttpInfo (CustomField json)
        {
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling CustomfieldApi->AddCustomField");

            var localVarPath = "/custom-fields";
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
                Exception exception = ExceptionFactory("AddCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IdResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IdResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IdResponse)));
        }

        /// <summary>
        /// Delete Custom Field Removes a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns></returns>
        public void DeleteCustomField (int? customFieldId)
        {
             DeleteCustomFieldWithHttpInfo(customFieldId);
        }

        /// <summary>
        /// Delete Custom Field Removes a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCustomFieldWithHttpInfo (int? customFieldId)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->DeleteCustomField");

            var localVarPath = "/custom-fields/{custom_field_id}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete Custom Field Removes a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCustomFieldAsync (int? customFieldId)
        {
             await DeleteCustomFieldAsyncWithHttpInfo(customFieldId);

        }

        /// <summary>
        /// Delete Custom Field Removes a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomFieldAsyncWithHttpInfo (int? customFieldId)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->DeleteCustomField");

            var localVarPath = "/custom-fields/{custom_field_id}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get Custom Fields Gets a list of work order custom fields
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CustomFields</returns>
        public CustomFields GetCustomFields ()
        {
             ApiResponse<CustomFields> localVarResponse = GetCustomFieldsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Custom Fields Gets a list of work order custom fields
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > GetCustomFieldsWithHttpInfo ()
        {

            var localVarPath = "/custom-fields";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCustomFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CustomFields>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomFields)));
        }

        /// <summary>
        /// Get Custom Fields Gets a list of work order custom fields
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> GetCustomFieldsAsync ()
        {
             ApiResponse<CustomFields> localVarResponse = await GetCustomFieldsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Custom Fields Gets a list of work order custom fields
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> GetCustomFieldsAsyncWithHttpInfo ()
        {

            var localVarPath = "/custom-fields";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCustomFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CustomFields>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomFields)));
        }

        /// <summary>
        /// Update Custom Field Updates a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        public void UpdateCustomField (int? customFieldId, CustomField json)
        {
             UpdateCustomFieldWithHttpInfo(customFieldId, json);
        }

        /// <summary>
        /// Update Custom Field Updates a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCustomFieldWithHttpInfo (int? customFieldId, CustomField json)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomField");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling CustomfieldApi->UpdateCustomField");

            var localVarPath = "/custom-fields/{custom_field_id}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Custom Field Updates a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCustomFieldAsync (int? customFieldId, CustomField json)
        {
             await UpdateCustomFieldAsyncWithHttpInfo(customFieldId, json);

        }

        /// <summary>
        /// Update Custom Field Updates a work order custom field
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldAsyncWithHttpInfo (int? customFieldId, CustomField json)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomField");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling CustomfieldApi->UpdateCustomField");

            var localVarPath = "/custom-fields/{custom_field_id}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Custom Field Visibility Updates a work order custom field&#39;s visibility for all projects and clients
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns></returns>
        public void UpdateCustomFieldVisibility (int? customFieldId, string visibility)
        {
             UpdateCustomFieldVisibilityWithHttpInfo(customFieldId, visibility);
        }

        /// <summary>
        /// Update Custom Field Visibility Updates a work order custom field&#39;s visibility for all projects and clients
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCustomFieldVisibilityWithHttpInfo (int? customFieldId, string visibility)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomFieldVisibility");
            // verify the required parameter 'visibility' is set
            if (visibility == null)
                throw new ApiException(400, "Missing required parameter 'visibility' when calling CustomfieldApi->UpdateCustomFieldVisibility");

            var localVarPath = "/custom-fields/{custom_field_id}/visibility/{visibility}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
            if (visibility != null) localVarPathParams.Add("visibility", Configuration.ApiClient.ParameterToString(visibility)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateCustomFieldVisibility", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Custom Field Visibility Updates a work order custom field&#39;s visibility for all projects and clients
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCustomFieldVisibilityAsync (int? customFieldId, string visibility)
        {
             await UpdateCustomFieldVisibilityAsyncWithHttpInfo(customFieldId, visibility);

        }

        /// <summary>
        /// Update Custom Field Visibility Updates a work order custom field&#39;s visibility for all projects and clients
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldVisibilityAsyncWithHttpInfo (int? customFieldId, string visibility)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomFieldVisibility");
            // verify the required parameter 'visibility' is set
            if (visibility == null)
                throw new ApiException(400, "Missing required parameter 'visibility' when calling CustomfieldApi->UpdateCustomFieldVisibility");

            var localVarPath = "/custom-fields/{custom_field_id}/visibility/{visibility}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
            if (visibility != null) localVarPathParams.Add("visibility", Configuration.ApiClient.ParameterToString(visibility)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateCustomFieldVisibility", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Custom Field Visibility by Client Updates a work order custom field&#39;s visibility for a single client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns></returns>
        public void UpdateCustomFieldVisibilityByClient (int? customFieldId, int? clientId, string visibility)
        {
             UpdateCustomFieldVisibilityByClientWithHttpInfo(customFieldId, clientId, visibility);
        }

        /// <summary>
        /// Update Custom Field Visibility by Client Updates a work order custom field&#39;s visibility for a single client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCustomFieldVisibilityByClientWithHttpInfo (int? customFieldId, int? clientId, string visibility)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByClient");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByClient");
            // verify the required parameter 'visibility' is set
            if (visibility == null)
                throw new ApiException(400, "Missing required parameter 'visibility' when calling CustomfieldApi->UpdateCustomFieldVisibilityByClient");

            var localVarPath = "/custom-fields/{custom_field_id}/visibility/client/{client_id}/{visibility}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (visibility != null) localVarPathParams.Add("visibility", Configuration.ApiClient.ParameterToString(visibility)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateCustomFieldVisibilityByClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Custom Field Visibility by Client Updates a work order custom field&#39;s visibility for a single client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCustomFieldVisibilityByClientAsync (int? customFieldId, int? clientId, string visibility)
        {
             await UpdateCustomFieldVisibilityByClientAsyncWithHttpInfo(customFieldId, clientId, visibility);

        }

        /// <summary>
        /// Update Custom Field Visibility by Client Updates a work order custom field&#39;s visibility for a single client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="clientId">Client id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldVisibilityByClientAsyncWithHttpInfo (int? customFieldId, int? clientId, string visibility)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByClient");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByClient");
            // verify the required parameter 'visibility' is set
            if (visibility == null)
                throw new ApiException(400, "Missing required parameter 'visibility' when calling CustomfieldApi->UpdateCustomFieldVisibilityByClient");

            var localVarPath = "/custom-fields/{custom_field_id}/visibility/client/{client_id}/{visibility}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (visibility != null) localVarPathParams.Add("visibility", Configuration.ApiClient.ParameterToString(visibility)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateCustomFieldVisibilityByClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Custom Field Visibility by Project Updates a work order custom field&#39;s visibility for a single project
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns></returns>
        public void UpdateCustomFieldVisibilityByProject (int? customFieldId, int? projectId, string visibility)
        {
             UpdateCustomFieldVisibilityByProjectWithHttpInfo(customFieldId, projectId, visibility);
        }

        /// <summary>
        /// Update Custom Field Visibility by Project Updates a work order custom field&#39;s visibility for a single project
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCustomFieldVisibilityByProjectWithHttpInfo (int? customFieldId, int? projectId, string visibility)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByProject");
            // verify the required parameter 'projectId' is set
            if (projectId == null)
                throw new ApiException(400, "Missing required parameter 'projectId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByProject");
            // verify the required parameter 'visibility' is set
            if (visibility == null)
                throw new ApiException(400, "Missing required parameter 'visibility' when calling CustomfieldApi->UpdateCustomFieldVisibilityByProject");

            var localVarPath = "/custom-fields/{custom_field_id}/visibility/project/{project_id}/{visibility}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
            if (projectId != null) localVarPathParams.Add("project_id", Configuration.ApiClient.ParameterToString(projectId)); // path parameter
            if (visibility != null) localVarPathParams.Add("visibility", Configuration.ApiClient.ParameterToString(visibility)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateCustomFieldVisibilityByProject", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Custom Field Visibility by Project Updates a work order custom field&#39;s visibility for a single project
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCustomFieldVisibilityByProjectAsync (int? customFieldId, int? projectId, string visibility)
        {
             await UpdateCustomFieldVisibilityByProjectAsyncWithHttpInfo(customFieldId, projectId, visibility);

        }

        /// <summary>
        /// Update Custom Field Visibility by Project Updates a work order custom field&#39;s visibility for a single project
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Custom field id</param>
        /// <param name="projectId">Project id</param>
        /// <param name="visibility">Visibility (visible or hidden)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomFieldVisibilityByProjectAsyncWithHttpInfo (int? customFieldId, int? projectId, string visibility)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByProject");
            // verify the required parameter 'projectId' is set
            if (projectId == null)
                throw new ApiException(400, "Missing required parameter 'projectId' when calling CustomfieldApi->UpdateCustomFieldVisibilityByProject");
            // verify the required parameter 'visibility' is set
            if (visibility == null)
                throw new ApiException(400, "Missing required parameter 'visibility' when calling CustomfieldApi->UpdateCustomFieldVisibilityByProject");

            var localVarPath = "/custom-fields/{custom_field_id}/visibility/project/{project_id}/{visibility}";
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

            if (customFieldId != null) localVarPathParams.Add("custom_field_id", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
            if (projectId != null) localVarPathParams.Add("project_id", Configuration.ApiClient.ParameterToString(projectId)); // path parameter
            if (visibility != null) localVarPathParams.Add("visibility", Configuration.ApiClient.ParameterToString(visibility)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateCustomFieldVisibilityByProject", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
