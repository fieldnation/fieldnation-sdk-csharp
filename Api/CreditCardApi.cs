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
    public interface ICreditCardApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get company user credit cards
        /// </summary>
        /// <remarks>
        /// Get a list of all credit cards for a company user.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SavedCreditCards</returns>
        SavedCreditCards GetCompanyUserCreditCards ();

        /// <summary>
        /// Get company user credit cards
        /// </summary>
        /// <remarks>
        /// Get a list of all credit cards for a company user.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SavedCreditCards</returns>
        ApiResponse<SavedCreditCards> GetCompanyUserCreditCardsWithHttpInfo ();
        /// <summary>
        /// Get credit card processing fees
        /// </summary>
        /// <remarks>
        /// Get credit card processing fees
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetCreditCardFeesByCompany (int? companyId);

        /// <summary>
        /// Get credit card processing fees
        /// </summary>
        /// <remarks>
        /// Get credit card processing fees
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetCreditCardFeesByCompanyWithHttpInfo (int? companyId);
        /// <summary>
        /// Create fund transaction, typically a deposit
        /// </summary>
        /// <remarks>
        /// Perform fund deposit
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns></returns>
        void UpdateFundByFund (int? companyId, int? financeId, FundTransaction fundTransaction = null);

        /// <summary>
        /// Create fund transaction, typically a deposit
        /// </summary>
        /// <remarks>
        /// Perform fund deposit
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateFundByFundWithHttpInfo (int? companyId, int? financeId, FundTransaction fundTransaction = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get company user credit cards
        /// </summary>
        /// <remarks>
        /// Get a list of all credit cards for a company user.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SavedCreditCards</returns>
        System.Threading.Tasks.Task<SavedCreditCards> GetCompanyUserCreditCardsAsync ();

        /// <summary>
        /// Get company user credit cards
        /// </summary>
        /// <remarks>
        /// Get a list of all credit cards for a company user.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SavedCreditCards)</returns>
        System.Threading.Tasks.Task<ApiResponse<SavedCreditCards>> GetCompanyUserCreditCardsAsyncWithHttpInfo ();
        /// <summary>
        /// Get credit card processing fees
        /// </summary>
        /// <remarks>
        /// Get credit card processing fees
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetCreditCardFeesByCompanyAsync (int? companyId);

        /// <summary>
        /// Get credit card processing fees
        /// </summary>
        /// <remarks>
        /// Get credit card processing fees
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetCreditCardFeesByCompanyAsyncWithHttpInfo (int? companyId);
        /// <summary>
        /// Create fund transaction, typically a deposit
        /// </summary>
        /// <remarks>
        /// Perform fund deposit
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateFundByFundAsync (int? companyId, int? financeId, FundTransaction fundTransaction = null);

        /// <summary>
        /// Create fund transaction, typically a deposit
        /// </summary>
        /// <remarks>
        /// Perform fund deposit
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFundByFundAsyncWithHttpInfo (int? companyId, int? financeId, FundTransaction fundTransaction = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CreditCardApi : ICreditCardApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CreditCardApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CreditCardApi(Configuration configuration = null)
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
        /// Get company user credit cards Get a list of all credit cards for a company user.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SavedCreditCards</returns>
        public SavedCreditCards GetCompanyUserCreditCards ()
        {
             ApiResponse<SavedCreditCards> localVarResponse = GetCompanyUserCreditCardsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get company user credit cards Get a list of all credit cards for a company user.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SavedCreditCards</returns>
        public ApiResponse< SavedCreditCards > GetCompanyUserCreditCardsWithHttpInfo ()
        {

            var localVarPath = "/company/creditcards";
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
                Exception exception = ExceptionFactory("GetCompanyUserCreditCards", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SavedCreditCards>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SavedCreditCards) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SavedCreditCards)));
        }

        /// <summary>
        /// Get company user credit cards Get a list of all credit cards for a company user.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SavedCreditCards</returns>
        public async System.Threading.Tasks.Task<SavedCreditCards> GetCompanyUserCreditCardsAsync ()
        {
             ApiResponse<SavedCreditCards> localVarResponse = await GetCompanyUserCreditCardsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get company user credit cards Get a list of all credit cards for a company user.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SavedCreditCards)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SavedCreditCards>> GetCompanyUserCreditCardsAsyncWithHttpInfo ()
        {

            var localVarPath = "/company/creditcards";
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
                Exception exception = ExceptionFactory("GetCompanyUserCreditCards", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SavedCreditCards>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SavedCreditCards) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SavedCreditCards)));
        }

        /// <summary>
        /// Get credit card processing fees Get credit card processing fees
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetCreditCardFeesByCompany (int? companyId)
        {
             ApiResponse<InlineResponse200> localVarResponse = GetCreditCardFeesByCompanyWithHttpInfo(companyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get credit card processing fees Get credit card processing fees
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetCreditCardFeesByCompanyWithHttpInfo (int? companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CreditCardApi->GetCreditCardFeesByCompany");

            var localVarPath = "/company/{company_id}/settings/ccfees";
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

            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCreditCardFeesByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
        }

        /// <summary>
        /// Get credit card processing fees Get credit card processing fees
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetCreditCardFeesByCompanyAsync (int? companyId)
        {
             ApiResponse<InlineResponse200> localVarResponse = await GetCreditCardFeesByCompanyAsyncWithHttpInfo(companyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get credit card processing fees Get credit card processing fees
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetCreditCardFeesByCompanyAsyncWithHttpInfo (int? companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CreditCardApi->GetCreditCardFeesByCompany");

            var localVarPath = "/company/{company_id}/settings/ccfees";
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

            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCreditCardFeesByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
        }

        /// <summary>
        /// Create fund transaction, typically a deposit Perform fund deposit
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns></returns>
        public void UpdateFundByFund (int? companyId, int? financeId, FundTransaction fundTransaction = null)
        {
             UpdateFundByFundWithHttpInfo(companyId, financeId, fundTransaction);
        }

        /// <summary>
        /// Create fund transaction, typically a deposit Perform fund deposit
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateFundByFundWithHttpInfo (int? companyId, int? financeId, FundTransaction fundTransaction = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CreditCardApi->UpdateFundByFund");
            // verify the required parameter 'financeId' is set
            if (financeId == null)
                throw new ApiException(400, "Missing required parameter 'financeId' when calling CreditCardApi->UpdateFundByFund");

            var localVarPath = "/company/{company_id}/funds/{finance_id}";
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

            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (financeId != null) localVarPathParams.Add("finance_id", Configuration.ApiClient.ParameterToString(financeId)); // path parameter
            if (fundTransaction != null && fundTransaction.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(fundTransaction); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fundTransaction; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateFundByFund", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create fund transaction, typically a deposit Perform fund deposit
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateFundByFundAsync (int? companyId, int? financeId, FundTransaction fundTransaction = null)
        {
             await UpdateFundByFundAsyncWithHttpInfo(companyId, financeId, fundTransaction);

        }

        /// <summary>
        /// Create fund transaction, typically a deposit Perform fund deposit
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <param name="financeId">ID of finance account</param>
        /// <param name="fundTransaction">Transaction attempting to be created (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFundByFundAsyncWithHttpInfo (int? companyId, int? financeId, FundTransaction fundTransaction = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CreditCardApi->UpdateFundByFund");
            // verify the required parameter 'financeId' is set
            if (financeId == null)
                throw new ApiException(400, "Missing required parameter 'financeId' when calling CreditCardApi->UpdateFundByFund");

            var localVarPath = "/company/{company_id}/funds/{finance_id}";
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

            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (financeId != null) localVarPathParams.Add("finance_id", Configuration.ApiClient.ParameterToString(financeId)); // path parameter
            if (fundTransaction != null && fundTransaction.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(fundTransaction); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fundTransaction; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateFundByFund", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
