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
    public interface IRecruitmentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send recruitment email or robocalls
        /// </summary>
        /// <remarks>
        /// Send recruitment email or robocalls
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>List&lt;InlineResponse2003&gt;</returns>
        List<InlineResponse2003> SendCommunicationByWorkOrder (int? workOrderId, Body body);

        /// <summary>
        /// Send recruitment email or robocalls
        /// </summary>
        /// <remarks>
        /// Send recruitment email or robocalls
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;InlineResponse2003&gt;</returns>
        ApiResponse<List<InlineResponse2003>> SendCommunicationByWorkOrderWithHttpInfo (int? workOrderId, Body body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send recruitment email or robocalls
        /// </summary>
        /// <remarks>
        /// Send recruitment email or robocalls
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;InlineResponse2003&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2003>> SendCommunicationByWorkOrderAsync (int? workOrderId, Body body);

        /// <summary>
        /// Send recruitment email or robocalls
        /// </summary>
        /// <remarks>
        /// Send recruitment email or robocalls
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2003&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2003>>> SendCommunicationByWorkOrderAsyncWithHttpInfo (int? workOrderId, Body body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RecruitmentApi : IRecruitmentApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecruitmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecruitmentApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecruitmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecruitmentApi(Configuration configuration = null)
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
        /// Send recruitment email or robocalls Send recruitment email or robocalls
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>List&lt;InlineResponse2003&gt;</returns>
        public List<InlineResponse2003> SendCommunicationByWorkOrder (int? workOrderId, Body body)
        {
             ApiResponse<List<InlineResponse2003>> localVarResponse = SendCommunicationByWorkOrderWithHttpInfo(workOrderId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send recruitment email or robocalls Send recruitment email or robocalls
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;InlineResponse2003&gt;</returns>
        public ApiResponse< List<InlineResponse2003> > SendCommunicationByWorkOrderWithHttpInfo (int? workOrderId, Body body)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling RecruitmentApi->SendCommunicationByWorkOrder");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecruitmentApi->SendCommunicationByWorkOrder");

            var localVarPath = "/staff/recruitment/send-communications/{work_order_id}";
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
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendCommunicationByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InlineResponse2003>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2003>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InlineResponse2003>)));
        }

        /// <summary>
        /// Send recruitment email or robocalls Send recruitment email or robocalls
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;InlineResponse2003&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2003>> SendCommunicationByWorkOrderAsync (int? workOrderId, Body body)
        {
             ApiResponse<List<InlineResponse2003>> localVarResponse = await SendCommunicationByWorkOrderAsyncWithHttpInfo(workOrderId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send recruitment email or robocalls Send recruitment email or robocalls
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2003&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2003>>> SendCommunicationByWorkOrderAsyncWithHttpInfo (int? workOrderId, Body body)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling RecruitmentApi->SendCommunicationByWorkOrder");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecruitmentApi->SendCommunicationByWorkOrder");

            var localVarPath = "/staff/recruitment/send-communications/{work_order_id}";
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
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendCommunicationByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InlineResponse2003>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2003>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InlineResponse2003>)));
        }

    }
}
