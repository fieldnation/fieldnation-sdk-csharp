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
    public interface IUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add User Note
        /// </summary>
        /// <remarks>
        /// Adds a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>User</returns>
        User AddUserNote (int? userId, UserNote note);

        /// <summary>
        /// Add User Note
        /// </summary>
        /// <remarks>
        /// Adds a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> AddUserNoteWithHttpInfo (int? userId, UserNote note);
        /// <summary>
        /// Delete User Note
        /// </summary>
        /// <remarks>
        /// Removes a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>User</returns>
        User DeleteUserNote (int? userId, int? noteId);

        /// <summary>
        /// Delete User Note
        /// </summary>
        /// <remarks>
        /// Removes a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> DeleteUserNoteWithHttpInfo (int? userId, int? noteId);
        /// <summary>
        /// Delete Worker by Worker
        /// </summary>
        /// <remarks>
        /// Deletes/cancels a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns></returns>
        void DeleteWorkerByWorker (int? userId, int? workerId);

        /// <summary>
        /// Delete Worker by Worker
        /// </summary>
        /// <remarks>
        /// Deletes/cancels a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkerByWorkerWithHttpInfo (int? userId, int? workerId);
        /// <summary>
        /// Retry Worker by Worker
        /// </summary>
        /// <remarks>
        /// Retries a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns></returns>
        void RetryWorkerByWorker (int? userId, int? workerId);

        /// <summary>
        /// Retry Worker by Worker
        /// </summary>
        /// <remarks>
        /// Retries a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RetryWorkerByWorkerWithHttpInfo (int? userId, int? workerId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add User Note
        /// </summary>
        /// <remarks>
        /// Adds a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> AddUserNoteAsync (int? userId, UserNote note);

        /// <summary>
        /// Add User Note
        /// </summary>
        /// <remarks>
        /// Adds a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> AddUserNoteAsyncWithHttpInfo (int? userId, UserNote note);
        /// <summary>
        /// Delete User Note
        /// </summary>
        /// <remarks>
        /// Removes a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> DeleteUserNoteAsync (int? userId, int? noteId);

        /// <summary>
        /// Delete User Note
        /// </summary>
        /// <remarks>
        /// Removes a note to a user on behalf of a company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> DeleteUserNoteAsyncWithHttpInfo (int? userId, int? noteId);
        /// <summary>
        /// Delete Worker by Worker
        /// </summary>
        /// <remarks>
        /// Deletes/cancels a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkerByWorkerAsync (int? userId, int? workerId);

        /// <summary>
        /// Delete Worker by Worker
        /// </summary>
        /// <remarks>
        /// Deletes/cancels a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkerByWorkerAsyncWithHttpInfo (int? userId, int? workerId);
        /// <summary>
        /// Retry Worker by Worker
        /// </summary>
        /// <remarks>
        /// Retries a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RetryWorkerByWorkerAsync (int? userId, int? workerId);

        /// <summary>
        /// Retry Worker by Worker
        /// </summary>
        /// <remarks>
        /// Retries a background job
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RetryWorkerByWorkerAsyncWithHttpInfo (int? userId, int? workerId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        /// Add User Note Adds a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>User</returns>
        public User AddUserNote (int? userId, UserNote note)
        {
             ApiResponse<User> localVarResponse = AddUserNoteWithHttpInfo(userId, note);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add User Note Adds a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > AddUserNoteWithHttpInfo (int? userId, UserNote note)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->AddUserNote");
            // verify the required parameter 'note' is set
            if (note == null)
                throw new ApiException(400, "Missing required parameter 'note' when calling UsersApi->AddUserNote");

            var localVarPath = "/users/{user_id}/notes";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (note != null && note.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(note); // http body (model) parameter
            }
            else
            {
                localVarPostBody = note; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddUserNote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Add User Note Adds a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> AddUserNoteAsync (int? userId, UserNote note)
        {
             ApiResponse<User> localVarResponse = await AddUserNoteAsyncWithHttpInfo(userId, note);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add User Note Adds a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> AddUserNoteAsyncWithHttpInfo (int? userId, UserNote note)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->AddUserNote");
            // verify the required parameter 'note' is set
            if (note == null)
                throw new ApiException(400, "Missing required parameter 'note' when calling UsersApi->AddUserNote");

            var localVarPath = "/users/{user_id}/notes";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (note != null && note.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(note); // http body (model) parameter
            }
            else
            {
                localVarPostBody = note; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddUserNote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Delete User Note Removes a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>User</returns>
        public User DeleteUserNote (int? userId, int? noteId)
        {
             ApiResponse<User> localVarResponse = DeleteUserNoteWithHttpInfo(userId, noteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete User Note Removes a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > DeleteUserNoteWithHttpInfo (int? userId, int? noteId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling UsersApi->DeleteUserNote");

            var localVarPath = "/users/{user_id}/notes/{note_id}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (noteId != null) localVarPathParams.Add("note_id", Configuration.ApiClient.ParameterToString(noteId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteUserNote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Delete User Note Removes a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> DeleteUserNoteAsync (int? userId, int? noteId)
        {
             ApiResponse<User> localVarResponse = await DeleteUserNoteAsyncWithHttpInfo(userId, noteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete User Note Removes a note to a user on behalf of a company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User id</param>
        /// <param name="noteId">Note id</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> DeleteUserNoteAsyncWithHttpInfo (int? userId, int? noteId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteUserNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling UsersApi->DeleteUserNote");

            var localVarPath = "/users/{user_id}/notes/{note_id}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (noteId != null) localVarPathParams.Add("note_id", Configuration.ApiClient.ParameterToString(noteId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteUserNote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Delete Worker by Worker Deletes/cancels a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns></returns>
        public void DeleteWorkerByWorker (int? userId, int? workerId)
        {
             DeleteWorkerByWorkerWithHttpInfo(userId, workerId);
        }

        /// <summary>
        /// Delete Worker by Worker Deletes/cancels a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkerByWorkerWithHttpInfo (int? userId, int? workerId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteWorkerByWorker");
            // verify the required parameter 'workerId' is set
            if (workerId == null)
                throw new ApiException(400, "Missing required parameter 'workerId' when calling UsersApi->DeleteWorkerByWorker");

            var localVarPath = "/users/{user_id}/background/{worker_id}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (workerId != null) localVarPathParams.Add("worker_id", Configuration.ApiClient.ParameterToString(workerId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteWorkerByWorker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete Worker by Worker Deletes/cancels a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkerByWorkerAsync (int? userId, int? workerId)
        {
             await DeleteWorkerByWorkerAsyncWithHttpInfo(userId, workerId);

        }

        /// <summary>
        /// Delete Worker by Worker Deletes/cancels a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkerByWorkerAsyncWithHttpInfo (int? userId, int? workerId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->DeleteWorkerByWorker");
            // verify the required parameter 'workerId' is set
            if (workerId == null)
                throw new ApiException(400, "Missing required parameter 'workerId' when calling UsersApi->DeleteWorkerByWorker");

            var localVarPath = "/users/{user_id}/background/{worker_id}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (workerId != null) localVarPathParams.Add("worker_id", Configuration.ApiClient.ParameterToString(workerId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteWorkerByWorker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Retry Worker by Worker Retries a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns></returns>
        public void RetryWorkerByWorker (int? userId, int? workerId)
        {
             RetryWorkerByWorkerWithHttpInfo(userId, workerId);
        }

        /// <summary>
        /// Retry Worker by Worker Retries a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RetryWorkerByWorkerWithHttpInfo (int? userId, int? workerId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->RetryWorkerByWorker");
            // verify the required parameter 'workerId' is set
            if (workerId == null)
                throw new ApiException(400, "Missing required parameter 'workerId' when calling UsersApi->RetryWorkerByWorker");

            var localVarPath = "/users/{user_id}/background/{worker_id}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (workerId != null) localVarPathParams.Add("worker_id", Configuration.ApiClient.ParameterToString(workerId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetryWorkerByWorker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Retry Worker by Worker Retries a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RetryWorkerByWorkerAsync (int? userId, int? workerId)
        {
             await RetryWorkerByWorkerAsyncWithHttpInfo(userId, workerId);

        }

        /// <summary>
        /// Retry Worker by Worker Retries a background job
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">ID of user</param>
        /// <param name="workerId">ID of worker</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RetryWorkerByWorkerAsyncWithHttpInfo (int? userId, int? workerId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->RetryWorkerByWorker");
            // verify the required parameter 'workerId' is set
            if (workerId == null)
                throw new ApiException(400, "Missing required parameter 'workerId' when calling UsersApi->RetryWorkerByWorker");

            var localVarPath = "/users/{user_id}/background/{worker_id}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (workerId != null) localVarPathParams.Add("worker_id", Configuration.ApiClient.ParameterToString(workerId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetryWorkerByWorker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
