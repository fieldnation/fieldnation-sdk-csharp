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
    public interface IHoldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get holds on work order
        /// </summary>
        /// <remarks>
        /// Get holds on work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Holds</returns>
        Holds GetHoldsByWorkOrder (int? workOrderId);

        /// <summary>
        /// Get holds on work order
        /// </summary>
        /// <remarks>
        /// Get holds on work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>ApiResponse of Holds</returns>
        ApiResponse<Holds> GetHoldsByWorkOrderWithHttpInfo (int? workOrderId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get holds on work order
        /// </summary>
        /// <remarks>
        /// Get holds on work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of Holds</returns>
        System.Threading.Tasks.Task<Holds> GetHoldsByWorkOrderAsync (int? workOrderId);

        /// <summary>
        /// Get holds on work order
        /// </summary>
        /// <remarks>
        /// Get holds on work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of ApiResponse (Holds)</returns>
        System.Threading.Tasks.Task<ApiResponse<Holds>> GetHoldsByWorkOrderAsyncWithHttpInfo (int? workOrderId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HoldsApi : IHoldsApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HoldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HoldsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HoldsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HoldsApi(Configuration configuration = null)
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
        /// Get holds on work order Get holds on work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Holds</returns>
        public Holds GetHoldsByWorkOrder (int? workOrderId)
        {
             ApiResponse<Holds> localVarResponse = GetHoldsByWorkOrderWithHttpInfo(workOrderId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get holds on work order Get holds on work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>ApiResponse of Holds</returns>
        public ApiResponse< Holds > GetHoldsByWorkOrderWithHttpInfo (int? workOrderId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling HoldsApi->GetHoldsByWorkOrder");

            var localVarPath = "/workorders/{work_order_id}/holds";
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

            if (workOrderId != null) localVarPathParams.Add("work_order_id", Configuration.ApiClient.ParameterToString(workOrderId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHoldsByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Holds>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Holds) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Holds)));
        }

        /// <summary>
        /// Get holds on work order Get holds on work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of Holds</returns>
        public async System.Threading.Tasks.Task<Holds> GetHoldsByWorkOrderAsync (int? workOrderId)
        {
             ApiResponse<Holds> localVarResponse = await GetHoldsByWorkOrderAsyncWithHttpInfo(workOrderId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get holds on work order Get holds on work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of ApiResponse (Holds)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Holds>> GetHoldsByWorkOrderAsyncWithHttpInfo (int? workOrderId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling HoldsApi->GetHoldsByWorkOrder");

            var localVarPath = "/workorders/{work_order_id}/holds";
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

            if (workOrderId != null) localVarPathParams.Add("work_order_id", Configuration.ApiClient.ParameterToString(workOrderId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHoldsByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Holds>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Holds) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Holds)));
        }

    }
}
