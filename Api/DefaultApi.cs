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
    public interface IDefaultApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete Alert by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete a single alert associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>WorkOrder</returns>
        WorkOrder DeleteAlertByWorkOrderAndTask (int? workOrderId, int? taskId, int? alertId);

        /// <summary>
        /// Delete Alert by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete a single alert associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>ApiResponse of WorkOrder</returns>
        ApiResponse<WorkOrder> DeleteAlertByWorkOrderAndTaskWithHttpInfo (int? workOrderId, int? taskId, int? alertId);
        /// <summary>
        /// Delete Alerts by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete all alerts associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>WorkOrder</returns>
        WorkOrder DeleteAlertsByWorkOrderAndTask (int? workOrderId, int? taskId);

        /// <summary>
        /// Delete Alerts by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete all alerts associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>ApiResponse of WorkOrder</returns>
        ApiResponse<WorkOrder> DeleteAlertsByWorkOrderAndTaskWithHttpInfo (int? workOrderId, int? taskId);
        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task
        /// </summary>
        /// <remarks>
        /// Reorders a task associated with a work order to a position before or after a target task
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>WorkOrder</returns>
        WorkOrder ReorderTaskByWorkOrderAndTaskAndTargetTask (int? workOrderId, int? taskId, int? targetTaskId, string position);

        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task
        /// </summary>
        /// <remarks>
        /// Reorders a task associated with a work order to a position before or after a target task
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>ApiResponse of WorkOrder</returns>
        ApiResponse<WorkOrder> ReorderTaskByWorkOrderAndTaskAndTargetTaskWithHttpInfo (int? workOrderId, int? taskId, int? targetTaskId, string position);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete Alert by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete a single alert associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>Task of WorkOrder</returns>
        System.Threading.Tasks.Task<WorkOrder> DeleteAlertByWorkOrderAndTaskAsync (int? workOrderId, int? taskId, int? alertId);

        /// <summary>
        /// Delete Alert by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete a single alert associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>Task of ApiResponse (WorkOrder)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkOrder>> DeleteAlertByWorkOrderAndTaskAsyncWithHttpInfo (int? workOrderId, int? taskId, int? alertId);
        /// <summary>
        /// Delete Alerts by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete all alerts associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>Task of WorkOrder</returns>
        System.Threading.Tasks.Task<WorkOrder> DeleteAlertsByWorkOrderAndTaskAsync (int? workOrderId, int? taskId);

        /// <summary>
        /// Delete Alerts by Work Order and Task
        /// </summary>
        /// <remarks>
        /// Delete all alerts associated with a single task on a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>Task of ApiResponse (WorkOrder)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkOrder>> DeleteAlertsByWorkOrderAndTaskAsyncWithHttpInfo (int? workOrderId, int? taskId);
        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task
        /// </summary>
        /// <remarks>
        /// Reorders a task associated with a work order to a position before or after a target task
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>Task of WorkOrder</returns>
        System.Threading.Tasks.Task<WorkOrder> ReorderTaskByWorkOrderAndTaskAndTargetTaskAsync (int? workOrderId, int? taskId, int? targetTaskId, string position);

        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task
        /// </summary>
        /// <remarks>
        /// Reorders a task associated with a work order to a position before or after a target task
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>Task of ApiResponse (WorkOrder)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkOrder>> ReorderTaskByWorkOrderAndTaskAndTargetTaskAsyncWithHttpInfo (int? workOrderId, int? taskId, int? targetTaskId, string position);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDefaultApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
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
        /// Delete Alert by Work Order and Task Delete a single alert associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>WorkOrder</returns>
        public WorkOrder DeleteAlertByWorkOrderAndTask (int? workOrderId, int? taskId, int? alertId)
        {
             ApiResponse<WorkOrder> localVarResponse = DeleteAlertByWorkOrderAndTaskWithHttpInfo(workOrderId, taskId, alertId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Alert by Work Order and Task Delete a single alert associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>ApiResponse of WorkOrder</returns>
        public ApiResponse< WorkOrder > DeleteAlertByWorkOrderAndTaskWithHttpInfo (int? workOrderId, int? taskId, int? alertId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling DefaultApi->DeleteAlertByWorkOrderAndTask");
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling DefaultApi->DeleteAlertByWorkOrderAndTask");
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling DefaultApi->DeleteAlertByWorkOrderAndTask");

            var localVarPath = "/workorders/{work_order_id}/tasks/{task_id}/alerts/{alert_id}";
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
            if (taskId != null) localVarPathParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // path parameter
            if (alertId != null) localVarPathParams.Add("alert_id", Configuration.ApiClient.ParameterToString(alertId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAlertByWorkOrderAndTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkOrder)));
        }

        /// <summary>
        /// Delete Alert by Work Order and Task Delete a single alert associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>Task of WorkOrder</returns>
        public async System.Threading.Tasks.Task<WorkOrder> DeleteAlertByWorkOrderAndTaskAsync (int? workOrderId, int? taskId, int? alertId)
        {
             ApiResponse<WorkOrder> localVarResponse = await DeleteAlertByWorkOrderAndTaskAsyncWithHttpInfo(workOrderId, taskId, alertId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Alert by Work Order and Task Delete a single alert associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="alertId">Alert id</param>
        /// <returns>Task of ApiResponse (WorkOrder)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkOrder>> DeleteAlertByWorkOrderAndTaskAsyncWithHttpInfo (int? workOrderId, int? taskId, int? alertId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling DefaultApi->DeleteAlertByWorkOrderAndTask");
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling DefaultApi->DeleteAlertByWorkOrderAndTask");
            // verify the required parameter 'alertId' is set
            if (alertId == null)
                throw new ApiException(400, "Missing required parameter 'alertId' when calling DefaultApi->DeleteAlertByWorkOrderAndTask");

            var localVarPath = "/workorders/{work_order_id}/tasks/{task_id}/alerts/{alert_id}";
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
            if (taskId != null) localVarPathParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // path parameter
            if (alertId != null) localVarPathParams.Add("alert_id", Configuration.ApiClient.ParameterToString(alertId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAlertByWorkOrderAndTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkOrder)));
        }

        /// <summary>
        /// Delete Alerts by Work Order and Task Delete all alerts associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>WorkOrder</returns>
        public WorkOrder DeleteAlertsByWorkOrderAndTask (int? workOrderId, int? taskId)
        {
             ApiResponse<WorkOrder> localVarResponse = DeleteAlertsByWorkOrderAndTaskWithHttpInfo(workOrderId, taskId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Alerts by Work Order and Task Delete all alerts associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>ApiResponse of WorkOrder</returns>
        public ApiResponse< WorkOrder > DeleteAlertsByWorkOrderAndTaskWithHttpInfo (int? workOrderId, int? taskId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling DefaultApi->DeleteAlertsByWorkOrderAndTask");
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling DefaultApi->DeleteAlertsByWorkOrderAndTask");

            var localVarPath = "/workorders/{work_order_id}/tasks/{task_id}/alerts";
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
            if (taskId != null) localVarPathParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAlertsByWorkOrderAndTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkOrder)));
        }

        /// <summary>
        /// Delete Alerts by Work Order and Task Delete all alerts associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>Task of WorkOrder</returns>
        public async System.Threading.Tasks.Task<WorkOrder> DeleteAlertsByWorkOrderAndTaskAsync (int? workOrderId, int? taskId)
        {
             ApiResponse<WorkOrder> localVarResponse = await DeleteAlertsByWorkOrderAndTaskAsyncWithHttpInfo(workOrderId, taskId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Alerts by Work Order and Task Delete all alerts associated with a single task on a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>Task of ApiResponse (WorkOrder)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkOrder>> DeleteAlertsByWorkOrderAndTaskAsyncWithHttpInfo (int? workOrderId, int? taskId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling DefaultApi->DeleteAlertsByWorkOrderAndTask");
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling DefaultApi->DeleteAlertsByWorkOrderAndTask");

            var localVarPath = "/workorders/{work_order_id}/tasks/{task_id}/alerts";
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
            if (taskId != null) localVarPathParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAlertsByWorkOrderAndTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkOrder)));
        }

        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task Reorders a task associated with a work order to a position before or after a target task
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>WorkOrder</returns>
        public WorkOrder ReorderTaskByWorkOrderAndTaskAndTargetTask (int? workOrderId, int? taskId, int? targetTaskId, string position)
        {
             ApiResponse<WorkOrder> localVarResponse = ReorderTaskByWorkOrderAndTaskAndTargetTaskWithHttpInfo(workOrderId, taskId, targetTaskId, position);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task Reorders a task associated with a work order to a position before or after a target task
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>ApiResponse of WorkOrder</returns>
        public ApiResponse< WorkOrder > ReorderTaskByWorkOrderAndTaskAndTargetTaskWithHttpInfo (int? workOrderId, int? taskId, int? targetTaskId, string position)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");
            // verify the required parameter 'targetTaskId' is set
            if (targetTaskId == null)
                throw new ApiException(400, "Missing required parameter 'targetTaskId' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");
            // verify the required parameter 'position' is set
            if (position == null)
                throw new ApiException(400, "Missing required parameter 'position' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");

            var localVarPath = "/workorders/{work_order_id}/tasks/{task_id}/reorder/{position}/{target_task_id}";
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
            if (taskId != null) localVarPathParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // path parameter
            if (targetTaskId != null) localVarPathParams.Add("target_task_id", Configuration.ApiClient.ParameterToString(targetTaskId)); // path parameter
            if (position != null) localVarPathParams.Add("position", Configuration.ApiClient.ParameterToString(position)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReorderTaskByWorkOrderAndTaskAndTargetTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkOrder)));
        }

        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task Reorders a task associated with a work order to a position before or after a target task
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>Task of WorkOrder</returns>
        public async System.Threading.Tasks.Task<WorkOrder> ReorderTaskByWorkOrderAndTaskAndTargetTaskAsync (int? workOrderId, int? taskId, int? targetTaskId, string position)
        {
             ApiResponse<WorkOrder> localVarResponse = await ReorderTaskByWorkOrderAndTaskAndTargetTaskAsyncWithHttpInfo(workOrderId, taskId, targetTaskId, position);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reorders Task by Work Order and Task and Target Task Reorders a task associated with a work order to a position before or after a target task
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">Work order id</param>
        /// <param name="taskId">Task id</param>
        /// <param name="targetTaskId">Target task id</param>
        /// <param name="position">before or after target task</param>
        /// <returns>Task of ApiResponse (WorkOrder)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkOrder>> ReorderTaskByWorkOrderAndTaskAndTargetTaskAsyncWithHttpInfo (int? workOrderId, int? taskId, int? targetTaskId, string position)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");
            // verify the required parameter 'taskId' is set
            if (taskId == null)
                throw new ApiException(400, "Missing required parameter 'taskId' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");
            // verify the required parameter 'targetTaskId' is set
            if (targetTaskId == null)
                throw new ApiException(400, "Missing required parameter 'targetTaskId' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");
            // verify the required parameter 'position' is set
            if (position == null)
                throw new ApiException(400, "Missing required parameter 'position' when calling DefaultApi->ReorderTaskByWorkOrderAndTaskAndTargetTask");

            var localVarPath = "/workorders/{work_order_id}/tasks/{task_id}/reorder/{position}/{target_task_id}";
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
            if (taskId != null) localVarPathParams.Add("task_id", Configuration.ApiClient.ParameterToString(taskId)); // path parameter
            if (targetTaskId != null) localVarPathParams.Add("target_task_id", Configuration.ApiClient.ParameterToString(targetTaskId)); // path parameter
            if (position != null) localVarPathParams.Add("position", Configuration.ApiClient.ParameterToString(position)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReorderTaskByWorkOrderAndTaskAndTargetTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkOrder>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkOrder) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkOrder)));
        }

    }
}
