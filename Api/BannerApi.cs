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
    public interface IBannerApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get banners
        /// </summary>
        /// <remarks>
        /// Get a list of all banners.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>Banner</returns>
        Banner GetBanners (bool? active = null, bool? allowedBanners = null);

        /// <summary>
        /// Get banners
        /// </summary>
        /// <remarks>
        /// Get a list of all banners.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>ApiResponse of Banner</returns>
        ApiResponse<Banner> GetBannersWithHttpInfo (bool? active = null, bool? allowedBanners = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get banners
        /// </summary>
        /// <remarks>
        /// Get a list of all banners.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>Task of Banner</returns>
        System.Threading.Tasks.Task<Banner> GetBannersAsync (bool? active = null, bool? allowedBanners = null);

        /// <summary>
        /// Get banners
        /// </summary>
        /// <remarks>
        /// Get a list of all banners.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Banner)</returns>
        System.Threading.Tasks.Task<ApiResponse<Banner>> GetBannersAsyncWithHttpInfo (bool? active = null, bool? allowedBanners = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BannerApi : IBannerApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BannerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BannerApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BannerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BannerApi(Configuration configuration = null)
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
        /// Get banners Get a list of all banners.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>Banner</returns>
        public Banner GetBanners (bool? active = null, bool? allowedBanners = null)
        {
             ApiResponse<Banner> localVarResponse = GetBannersWithHttpInfo(active, allowedBanners);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get banners Get a list of all banners.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>ApiResponse of Banner</returns>
        public ApiResponse< Banner > GetBannersWithHttpInfo (bool? active = null, bool? allowedBanners = null)
        {

            var localVarPath = "/system/banners";
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

            if (active != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active", active)); // query parameter
            if (allowedBanners != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "allowedBanners", allowedBanners)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBanners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Banner>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Banner) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Banner)));
        }

        /// <summary>
        /// Get banners Get a list of all banners.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>Task of Banner</returns>
        public async System.Threading.Tasks.Task<Banner> GetBannersAsync (bool? active = null, bool? allowedBanners = null)
        {
             ApiResponse<Banner> localVarResponse = await GetBannersAsyncWithHttpInfo(active, allowedBanners);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get banners Get a list of all banners.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="active"> (optional, default to false)</param>
        /// <param name="allowedBanners"> (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Banner)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Banner>> GetBannersAsyncWithHttpInfo (bool? active = null, bool? allowedBanners = null)
        {

            var localVarPath = "/system/banners";
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

            if (active != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active", active)); // query parameter
            if (allowedBanners != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "allowedBanners", allowedBanners)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetBanners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Banner>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Banner) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Banner)));
        }

    }
}
