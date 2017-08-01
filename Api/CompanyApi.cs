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
    public interface ICompanyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add User to Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Adds a user to a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>User</returns>
        User AddUserToPreferredProviderByGroupAndUser (int? userId, int? groupId);

        /// <summary>
        /// Add User to Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Adds a user to a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> AddUserToPreferredProviderByGroupAndUserWithHttpInfo (int? userId, int? groupId);
        /// <summary>
        /// Delete User from Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Deletes a user from a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>User</returns>
        User DeleteUserFromPreferredProviderByGroupAndUser (int? userId, int? groupId);

        /// <summary>
        /// Delete User from Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Deletes a user from a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> DeleteUserFromPreferredProviderByGroupAndUserWithHttpInfo (int? userId, int? groupId);
        /// <summary>
        /// Get Company Details
        /// </summary>
        /// <remarks>
        /// Get Company Details
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns></returns>
        void GetCompanyDetails (int? companyId);

        /// <summary>
        /// Get Company Details
        /// </summary>
        /// <remarks>
        /// Get Company Details
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetCompanyDetailsWithHttpInfo (int? companyId);
        /// <summary>
        /// Get Company Expenses
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ExpenseCategories</returns>
        ExpenseCategories GetCompanyExpenses ();

        /// <summary>
        /// Get Company Expenses
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ExpenseCategories</returns>
        ApiResponse<ExpenseCategories> GetCompanyExpensesWithHttpInfo ();
        /// <summary>
        /// Get Company Expenses by Work Order
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses by a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>ExpenseCategories</returns>
        ExpenseCategories GetCompanyExpensesByWorkOrder (int? workOrderId);

        /// <summary>
        /// Get Company Expenses by Work Order
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses by a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>ApiResponse of ExpenseCategories</returns>
        ApiResponse<ExpenseCategories> GetCompanyExpensesByWorkOrderWithHttpInfo (int? workOrderId);
        /// <summary>
        /// Get Company Managers
        /// </summary>
        /// <remarks>
        /// Gets a list of company managers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void GetCompanyManagers ();

        /// <summary>
        /// Get Company Managers
        /// </summary>
        /// <remarks>
        /// Gets a list of company managers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetCompanyManagersWithHttpInfo ();
        /// <summary>
        /// Get contracts
        /// </summary>
        /// <remarks>
        /// Get a list of contarcts of the client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ServiceContracts</returns>
        ServiceContracts GetContractsByClient (int? clientId);

        /// <summary>
        /// Get contracts
        /// </summary>
        /// <remarks>
        /// Get a list of contarcts of the client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of ServiceContracts</returns>
        ApiResponse<ServiceContracts> GetContractsByClientWithHttpInfo (int? clientId);
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
        /// Get company features
        /// </summary>
        /// <remarks>
        /// Get a list of all features for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>CompanyFeatures</returns>
        CompanyFeatures GetFeatures (string status);

        /// <summary>
        /// Get company features
        /// </summary>
        /// <remarks>
        /// Get a list of all features for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>ApiResponse of CompanyFeatures</returns>
        ApiResponse<CompanyFeatures> GetFeaturesWithHttpInfo (string status);
        /// <summary>
        /// Get company integrations
        /// </summary>
        /// <remarks>
        /// Get a list of all company_integrations for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>CompanyIntegrations</returns>
        CompanyIntegrations GetIntegrations (string accessToken, string companyId);

        /// <summary>
        /// Get company integrations
        /// </summary>
        /// <remarks>
        /// Get a list of all company_integrations for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>ApiResponse of CompanyIntegrations</returns>
        ApiResponse<CompanyIntegrations> GetIntegrationsWithHttpInfo (string accessToken, string companyId);
        /// <summary>
        /// Get managed providers
        /// </summary>
        /// <remarks>
        /// Get Company Managed Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        List<InlineResponse2002> GetManagedProviders (int? companyId = null, int? marketplaceOn = null);

        /// <summary>
        /// Get managed providers
        /// </summary>
        /// <remarks>
        /// Get Company Managed Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        ApiResponse<List<InlineResponse2002>> GetManagedProvidersWithHttpInfo (int? companyId = null, int? marketplaceOn = null);
        /// <summary>
        /// Get Preferred Providers
        /// </summary>
        /// <remarks>
        /// Get Preferred Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PPNs</returns>
        PPNs GetPreferredProviders ();

        /// <summary>
        /// Get Preferred Providers
        /// </summary>
        /// <remarks>
        /// Get Preferred Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PPNs</returns>
        ApiResponse<PPNs> GetPreferredProvidersWithHttpInfo ();
        /// <summary>
        /// Get Rating Info of a Company
        /// </summary>
        /// <remarks>
        /// Get Rating Details of a Company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>CompanyRating</returns>
        CompanyRating GetRatingsByCompanyId (int? companyId);

        /// <summary>
        /// Get Rating Info of a Company
        /// </summary>
        /// <remarks>
        /// Get Rating Details of a Company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>ApiResponse of CompanyRating</returns>
        ApiResponse<CompanyRating> GetRatingsByCompanyIdWithHttpInfo (int? companyId);
        /// <summary>
        /// Get Selection Rules by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of selection rules for company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SelectionRules</returns>
        SelectionRules GetSelectionRulesByCompany ();

        /// <summary>
        /// Get Selection Rules by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of selection rules for company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SelectionRules</returns>
        ApiResponse<SelectionRules> GetSelectionRulesByCompanyWithHttpInfo ();
        /// <summary>
        /// Get Tags
        /// </summary>
        /// <remarks>
        /// Gets tags/labels
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Tags</returns>
        Tags GetTags ();

        /// <summary>
        /// Get Tags
        /// </summary>
        /// <remarks>
        /// Gets tags/labels
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Tags</returns>
        ApiResponse<Tags> GetTagsWithHttpInfo ();
        /// <summary>
        /// Get Tags by Work Order
        /// </summary>
        /// <remarks>
        /// Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>Tags</returns>
        Tags GetTagsByWorkOrder (int? workOrderId);

        /// <summary>
        /// Get Tags by Work Order
        /// </summary>
        /// <remarks>
        /// Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>ApiResponse of Tags</returns>
        ApiResponse<Tags> GetTagsByWorkOrderWithHttpInfo (int? workOrderId);
        /// <summary>
        /// Send a request to enable a feature
        /// </summary>
        /// <remarks>
        /// Send a request to enable a feature of a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns></returns>
        void RequestFeatureByFeature (int? featureId);

        /// <summary>
        /// Send a request to enable a feature
        /// </summary>
        /// <remarks>
        /// Send a request to enable a feature of a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RequestFeatureByFeatureWithHttpInfo (int? featureId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add User to Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Adds a user to a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> AddUserToPreferredProviderByGroupAndUserAsync (int? userId, int? groupId);

        /// <summary>
        /// Add User to Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Adds a user to a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> AddUserToPreferredProviderByGroupAndUserAsyncWithHttpInfo (int? userId, int? groupId);
        /// <summary>
        /// Delete User from Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Deletes a user from a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> DeleteUserFromPreferredProviderByGroupAndUserAsync (int? userId, int? groupId);

        /// <summary>
        /// Delete User from Preferred Provider by User
        /// </summary>
        /// <remarks>
        /// Deletes a user from a preferred network
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> DeleteUserFromPreferredProviderByGroupAndUserAsyncWithHttpInfo (int? userId, int? groupId);
        /// <summary>
        /// Get Company Details
        /// </summary>
        /// <remarks>
        /// Get Company Details
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetCompanyDetailsAsync (int? companyId);

        /// <summary>
        /// Get Company Details
        /// </summary>
        /// <remarks>
        /// Get Company Details
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCompanyDetailsAsyncWithHttpInfo (int? companyId);
        /// <summary>
        /// Get Company Expenses
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ExpenseCategories</returns>
        System.Threading.Tasks.Task<ExpenseCategories> GetCompanyExpensesAsync ();

        /// <summary>
        /// Get Company Expenses
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ExpenseCategories)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExpenseCategories>> GetCompanyExpensesAsyncWithHttpInfo ();
        /// <summary>
        /// Get Company Expenses by Work Order
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses by a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of ExpenseCategories</returns>
        System.Threading.Tasks.Task<ExpenseCategories> GetCompanyExpensesByWorkOrderAsync (int? workOrderId);

        /// <summary>
        /// Get Company Expenses by Work Order
        /// </summary>
        /// <remarks>
        /// Gets a list of company expenses by a work order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of ApiResponse (ExpenseCategories)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExpenseCategories>> GetCompanyExpensesByWorkOrderAsyncWithHttpInfo (int? workOrderId);
        /// <summary>
        /// Get Company Managers
        /// </summary>
        /// <remarks>
        /// Gets a list of company managers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetCompanyManagersAsync ();

        /// <summary>
        /// Get Company Managers
        /// </summary>
        /// <remarks>
        /// Gets a list of company managers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCompanyManagersAsyncWithHttpInfo ();
        /// <summary>
        /// Get contracts
        /// </summary>
        /// <remarks>
        /// Get a list of contarcts of the client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ServiceContracts</returns>
        System.Threading.Tasks.Task<ServiceContracts> GetContractsByClientAsync (int? clientId);

        /// <summary>
        /// Get contracts
        /// </summary>
        /// <remarks>
        /// Get a list of contarcts of the client
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (ServiceContracts)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceContracts>> GetContractsByClientAsyncWithHttpInfo (int? clientId);
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
        /// Get company features
        /// </summary>
        /// <remarks>
        /// Get a list of all features for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>Task of CompanyFeatures</returns>
        System.Threading.Tasks.Task<CompanyFeatures> GetFeaturesAsync (string status);

        /// <summary>
        /// Get company features
        /// </summary>
        /// <remarks>
        /// Get a list of all features for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>Task of ApiResponse (CompanyFeatures)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyFeatures>> GetFeaturesAsyncWithHttpInfo (string status);
        /// <summary>
        /// Get company integrations
        /// </summary>
        /// <remarks>
        /// Get a list of all company_integrations for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>Task of CompanyIntegrations</returns>
        System.Threading.Tasks.Task<CompanyIntegrations> GetIntegrationsAsync (string accessToken, string companyId);

        /// <summary>
        /// Get company integrations
        /// </summary>
        /// <remarks>
        /// Get a list of all company_integrations for a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>Task of ApiResponse (CompanyIntegrations)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyIntegrations>> GetIntegrationsAsyncWithHttpInfo (string accessToken, string companyId);
        /// <summary>
        /// Get managed providers
        /// </summary>
        /// <remarks>
        /// Get Company Managed Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2002>> GetManagedProvidersAsync (int? companyId = null, int? marketplaceOn = null);

        /// <summary>
        /// Get managed providers
        /// </summary>
        /// <remarks>
        /// Get Company Managed Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetManagedProvidersAsyncWithHttpInfo (int? companyId = null, int? marketplaceOn = null);
        /// <summary>
        /// Get Preferred Providers
        /// </summary>
        /// <remarks>
        /// Get Preferred Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PPNs</returns>
        System.Threading.Tasks.Task<PPNs> GetPreferredProvidersAsync ();

        /// <summary>
        /// Get Preferred Providers
        /// </summary>
        /// <remarks>
        /// Get Preferred Providers
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PPNs)</returns>
        System.Threading.Tasks.Task<ApiResponse<PPNs>> GetPreferredProvidersAsyncWithHttpInfo ();
        /// <summary>
        /// Get Rating Info of a Company
        /// </summary>
        /// <remarks>
        /// Get Rating Details of a Company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>Task of CompanyRating</returns>
        System.Threading.Tasks.Task<CompanyRating> GetRatingsByCompanyIdAsync (int? companyId);

        /// <summary>
        /// Get Rating Info of a Company
        /// </summary>
        /// <remarks>
        /// Get Rating Details of a Company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>Task of ApiResponse (CompanyRating)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyRating>> GetRatingsByCompanyIdAsyncWithHttpInfo (int? companyId);
        /// <summary>
        /// Get Selection Rules by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of selection rules for company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SelectionRules</returns>
        System.Threading.Tasks.Task<SelectionRules> GetSelectionRulesByCompanyAsync ();

        /// <summary>
        /// Get Selection Rules by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of selection rules for company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SelectionRules)</returns>
        System.Threading.Tasks.Task<ApiResponse<SelectionRules>> GetSelectionRulesByCompanyAsyncWithHttpInfo ();
        /// <summary>
        /// Get Tags
        /// </summary>
        /// <remarks>
        /// Gets tags/labels
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Tags</returns>
        System.Threading.Tasks.Task<Tags> GetTagsAsync ();

        /// <summary>
        /// Get Tags
        /// </summary>
        /// <remarks>
        /// Gets tags/labels
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Tags)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tags>> GetTagsAsyncWithHttpInfo ();
        /// <summary>
        /// Get Tags by Work Order
        /// </summary>
        /// <remarks>
        /// Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>Task of Tags</returns>
        System.Threading.Tasks.Task<Tags> GetTagsByWorkOrderAsync (int? workOrderId);

        /// <summary>
        /// Get Tags by Work Order
        /// </summary>
        /// <remarks>
        /// Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>Task of ApiResponse (Tags)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tags>> GetTagsByWorkOrderAsyncWithHttpInfo (int? workOrderId);
        /// <summary>
        /// Send a request to enable a feature
        /// </summary>
        /// <remarks>
        /// Send a request to enable a feature of a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RequestFeatureByFeatureAsync (int? featureId);

        /// <summary>
        /// Send a request to enable a feature
        /// </summary>
        /// <remarks>
        /// Send a request to enable a feature of a company.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RequestFeatureByFeatureAsyncWithHttpInfo (int? featureId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompanyApi : ICompanyApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompanyApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompanyApi(Configuration configuration = null)
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
        /// Add User to Preferred Provider by User Adds a user to a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>User</returns>
        public User AddUserToPreferredProviderByGroupAndUser (int? userId, int? groupId)
        {
             ApiResponse<User> localVarResponse = AddUserToPreferredProviderByGroupAndUserWithHttpInfo(userId, groupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add User to Preferred Provider by User Adds a user to a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > AddUserToPreferredProviderByGroupAndUserWithHttpInfo (int? userId, int? groupId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CompanyApi->AddUserToPreferredProviderByGroupAndUser");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling CompanyApi->AddUserToPreferredProviderByGroupAndUser");

            var localVarPath = "/company/preferred-providers/{group_id}/{user_id}";
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
            if (groupId != null) localVarPathParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddUserToPreferredProviderByGroupAndUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Add User to Preferred Provider by User Adds a user to a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> AddUserToPreferredProviderByGroupAndUserAsync (int? userId, int? groupId)
        {
             ApiResponse<User> localVarResponse = await AddUserToPreferredProviderByGroupAndUserAsyncWithHttpInfo(userId, groupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add User to Preferred Provider by User Adds a user to a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> AddUserToPreferredProviderByGroupAndUserAsyncWithHttpInfo (int? userId, int? groupId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CompanyApi->AddUserToPreferredProviderByGroupAndUser");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling CompanyApi->AddUserToPreferredProviderByGroupAndUser");

            var localVarPath = "/company/preferred-providers/{group_id}/{user_id}";
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
            if (groupId != null) localVarPathParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddUserToPreferredProviderByGroupAndUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Delete User from Preferred Provider by User Deletes a user from a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>User</returns>
        public User DeleteUserFromPreferredProviderByGroupAndUser (int? userId, int? groupId)
        {
             ApiResponse<User> localVarResponse = DeleteUserFromPreferredProviderByGroupAndUserWithHttpInfo(userId, groupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete User from Preferred Provider by User Deletes a user from a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > DeleteUserFromPreferredProviderByGroupAndUserWithHttpInfo (int? userId, int? groupId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CompanyApi->DeleteUserFromPreferredProviderByGroupAndUser");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling CompanyApi->DeleteUserFromPreferredProviderByGroupAndUser");

            var localVarPath = "/company/preferred-providers/{group_id}/{user_id}";
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
            if (groupId != null) localVarPathParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteUserFromPreferredProviderByGroupAndUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Delete User from Preferred Provider by User Deletes a user from a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> DeleteUserFromPreferredProviderByGroupAndUserAsync (int? userId, int? groupId)
        {
             ApiResponse<User> localVarResponse = await DeleteUserFromPreferredProviderByGroupAndUserAsyncWithHttpInfo(userId, groupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete User from Preferred Provider by User Deletes a user from a preferred network
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="groupId">PPN ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> DeleteUserFromPreferredProviderByGroupAndUserAsyncWithHttpInfo (int? userId, int? groupId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CompanyApi->DeleteUserFromPreferredProviderByGroupAndUser");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling CompanyApi->DeleteUserFromPreferredProviderByGroupAndUser");

            var localVarPath = "/company/preferred-providers/{group_id}/{user_id}";
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
            if (groupId != null) localVarPathParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteUserFromPreferredProviderByGroupAndUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get Company Details Get Company Details
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns></returns>
        public void GetCompanyDetails (int? companyId)
        {
             GetCompanyDetailsWithHttpInfo(companyId);
        }

        /// <summary>
        /// Get Company Details Get Company Details
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetCompanyDetailsWithHttpInfo (int? companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetCompanyDetails");

            var localVarPath = "/company/{company_id}";
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
                Exception exception = ExceptionFactory("GetCompanyDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get Company Details Get Company Details
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetCompanyDetailsAsync (int? companyId)
        {
             await GetCompanyDetailsAsyncWithHttpInfo(companyId);

        }

        /// <summary>
        /// Get Company Details Get Company Details
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID of company</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCompanyDetailsAsyncWithHttpInfo (int? companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetCompanyDetails");

            var localVarPath = "/company/{company_id}";
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
                Exception exception = ExceptionFactory("GetCompanyDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get Company Expenses Gets a list of company expenses
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ExpenseCategories</returns>
        public ExpenseCategories GetCompanyExpenses ()
        {
             ApiResponse<ExpenseCategories> localVarResponse = GetCompanyExpensesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Expenses Gets a list of company expenses
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ExpenseCategories</returns>
        public ApiResponse< ExpenseCategories > GetCompanyExpensesWithHttpInfo ()
        {

            var localVarPath = "/company/expenses";
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
                Exception exception = ExceptionFactory("GetCompanyExpenses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExpenseCategories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExpenseCategories) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExpenseCategories)));
        }

        /// <summary>
        /// Get Company Expenses Gets a list of company expenses
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ExpenseCategories</returns>
        public async System.Threading.Tasks.Task<ExpenseCategories> GetCompanyExpensesAsync ()
        {
             ApiResponse<ExpenseCategories> localVarResponse = await GetCompanyExpensesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Company Expenses Gets a list of company expenses
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ExpenseCategories)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExpenseCategories>> GetCompanyExpensesAsyncWithHttpInfo ()
        {

            var localVarPath = "/company/expenses";
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
                Exception exception = ExceptionFactory("GetCompanyExpenses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExpenseCategories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExpenseCategories) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExpenseCategories)));
        }

        /// <summary>
        /// Get Company Expenses by Work Order Gets a list of company expenses by a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>ExpenseCategories</returns>
        public ExpenseCategories GetCompanyExpensesByWorkOrder (int? workOrderId)
        {
             ApiResponse<ExpenseCategories> localVarResponse = GetCompanyExpensesByWorkOrderWithHttpInfo(workOrderId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company Expenses by Work Order Gets a list of company expenses by a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>ApiResponse of ExpenseCategories</returns>
        public ApiResponse< ExpenseCategories > GetCompanyExpensesByWorkOrderWithHttpInfo (int? workOrderId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling CompanyApi->GetCompanyExpensesByWorkOrder");

            var localVarPath = "/company/expenses/{work_order_id}";
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
                Exception exception = ExceptionFactory("GetCompanyExpensesByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExpenseCategories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExpenseCategories) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExpenseCategories)));
        }

        /// <summary>
        /// Get Company Expenses by Work Order Gets a list of company expenses by a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of ExpenseCategories</returns>
        public async System.Threading.Tasks.Task<ExpenseCategories> GetCompanyExpensesByWorkOrderAsync (int? workOrderId)
        {
             ApiResponse<ExpenseCategories> localVarResponse = await GetCompanyExpensesByWorkOrderAsyncWithHttpInfo(workOrderId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Company Expenses by Work Order Gets a list of company expenses by a work order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">ID of work order</param>
        /// <returns>Task of ApiResponse (ExpenseCategories)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExpenseCategories>> GetCompanyExpensesByWorkOrderAsyncWithHttpInfo (int? workOrderId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling CompanyApi->GetCompanyExpensesByWorkOrder");

            var localVarPath = "/company/expenses/{work_order_id}";
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
                Exception exception = ExceptionFactory("GetCompanyExpensesByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExpenseCategories>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExpenseCategories) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExpenseCategories)));
        }

        /// <summary>
        /// Get Company Managers Gets a list of company managers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void GetCompanyManagers ()
        {
             GetCompanyManagersWithHttpInfo();
        }

        /// <summary>
        /// Get Company Managers Gets a list of company managers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetCompanyManagersWithHttpInfo ()
        {

            var localVarPath = "/company/managers";
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
                Exception exception = ExceptionFactory("GetCompanyManagers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get Company Managers Gets a list of company managers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetCompanyManagersAsync ()
        {
             await GetCompanyManagersAsyncWithHttpInfo();

        }

        /// <summary>
        /// Get Company Managers Gets a list of company managers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCompanyManagersAsyncWithHttpInfo ()
        {

            var localVarPath = "/company/managers";
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
                Exception exception = ExceptionFactory("GetCompanyManagers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get contracts Get a list of contarcts of the client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ServiceContracts</returns>
        public ServiceContracts GetContractsByClient (int? clientId)
        {
             ApiResponse<ServiceContracts> localVarResponse = GetContractsByClientWithHttpInfo(clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get contracts Get a list of contarcts of the client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>ApiResponse of ServiceContracts</returns>
        public ApiResponse< ServiceContracts > GetContractsByClientWithHttpInfo (int? clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling CompanyApi->GetContractsByClient");

            var localVarPath = "/company/contracts/{client_id}";
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

            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetContractsByClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceContracts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceContracts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceContracts)));
        }

        /// <summary>
        /// Get contracts Get a list of contarcts of the client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ServiceContracts</returns>
        public async System.Threading.Tasks.Task<ServiceContracts> GetContractsByClientAsync (int? clientId)
        {
             ApiResponse<ServiceContracts> localVarResponse = await GetContractsByClientAsyncWithHttpInfo(clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get contracts Get a list of contarcts of the client
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client ID</param>
        /// <returns>Task of ApiResponse (ServiceContracts)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceContracts>> GetContractsByClientAsyncWithHttpInfo (int? clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling CompanyApi->GetContractsByClient");

            var localVarPath = "/company/contracts/{client_id}";
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

            if (clientId != null) localVarPathParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetContractsByClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceContracts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceContracts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceContracts)));
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
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetCreditCardFeesByCompany");

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
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetCreditCardFeesByCompany");

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
        /// Get company features Get a list of all features for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>CompanyFeatures</returns>
        public CompanyFeatures GetFeatures (string status)
        {
             ApiResponse<CompanyFeatures> localVarResponse = GetFeaturesWithHttpInfo(status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get company features Get a list of all features for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>ApiResponse of CompanyFeatures</returns>
        public ApiResponse< CompanyFeatures > GetFeaturesWithHttpInfo (string status)
        {
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling CompanyApi->GetFeatures");

            var localVarPath = "/company/features";
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

            if (status != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFeatures", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyFeatures>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyFeatures) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyFeatures)));
        }

        /// <summary>
        /// Get company features Get a list of all features for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>Task of CompanyFeatures</returns>
        public async System.Threading.Tasks.Task<CompanyFeatures> GetFeaturesAsync (string status)
        {
             ApiResponse<CompanyFeatures> localVarResponse = await GetFeaturesAsyncWithHttpInfo(status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get company features Get a list of all features for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Company feature status (enabled, disabled, requested, denied)</param>
        /// <returns>Task of ApiResponse (CompanyFeatures)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyFeatures>> GetFeaturesAsyncWithHttpInfo (string status)
        {
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling CompanyApi->GetFeatures");

            var localVarPath = "/company/features";
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

            if (status != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFeatures", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyFeatures>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyFeatures) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyFeatures)));
        }

        /// <summary>
        /// Get company integrations Get a list of all company_integrations for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>CompanyIntegrations</returns>
        public CompanyIntegrations GetIntegrations (string accessToken, string companyId)
        {
             ApiResponse<CompanyIntegrations> localVarResponse = GetIntegrationsWithHttpInfo(accessToken, companyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get company integrations Get a list of all company_integrations for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>ApiResponse of CompanyIntegrations</returns>
        public ApiResponse< CompanyIntegrations > GetIntegrationsWithHttpInfo (string accessToken, string companyId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new ApiException(400, "Missing required parameter 'accessToken' when calling CompanyApi->GetIntegrations");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetIntegrations");

            var localVarPath = "/company/{company_id}/integrations";
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
            if (accessToken != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", accessToken)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetIntegrations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyIntegrations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyIntegrations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyIntegrations)));
        }

        /// <summary>
        /// Get company integrations Get a list of all company_integrations for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>Task of CompanyIntegrations</returns>
        public async System.Threading.Tasks.Task<CompanyIntegrations> GetIntegrationsAsync (string accessToken, string companyId)
        {
             ApiResponse<CompanyIntegrations> localVarResponse = await GetIntegrationsAsyncWithHttpInfo(accessToken, companyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get company integrations Get a list of all company_integrations for a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken"></param>
        /// <param name="companyId"></param>
        /// <returns>Task of ApiResponse (CompanyIntegrations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyIntegrations>> GetIntegrationsAsyncWithHttpInfo (string accessToken, string companyId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new ApiException(400, "Missing required parameter 'accessToken' when calling CompanyApi->GetIntegrations");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetIntegrations");

            var localVarPath = "/company/{company_id}/integrations";
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
            if (accessToken != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", accessToken)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetIntegrations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyIntegrations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyIntegrations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyIntegrations)));
        }

        /// <summary>
        /// Get managed providers Get Company Managed Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        public List<InlineResponse2002> GetManagedProviders (int? companyId = null, int? marketplaceOn = null)
        {
             ApiResponse<List<InlineResponse2002>> localVarResponse = GetManagedProvidersWithHttpInfo(companyId, marketplaceOn);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get managed providers Get Company Managed Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        public ApiResponse< List<InlineResponse2002> > GetManagedProvidersWithHttpInfo (int? companyId = null, int? marketplaceOn = null)
        {

            var localVarPath = "/company/managed-providers";
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

            if (companyId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company_id", companyId)); // query parameter
            if (marketplaceOn != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "marketplace_on", marketplaceOn)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetManagedProviders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InlineResponse2002>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2002>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InlineResponse2002>)));
        }

        /// <summary>
        /// Get managed providers Get Company Managed Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2002>> GetManagedProvidersAsync (int? companyId = null, int? marketplaceOn = null)
        {
             ApiResponse<List<InlineResponse2002>> localVarResponse = await GetManagedProvidersAsyncWithHttpInfo(companyId, marketplaceOn);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get managed providers Get Company Managed Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId"> (optional)</param>
        /// <param name="marketplaceOn"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetManagedProvidersAsyncWithHttpInfo (int? companyId = null, int? marketplaceOn = null)
        {

            var localVarPath = "/company/managed-providers";
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

            if (companyId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company_id", companyId)); // query parameter
            if (marketplaceOn != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "marketplace_on", marketplaceOn)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetManagedProviders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InlineResponse2002>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2002>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InlineResponse2002>)));
        }

        /// <summary>
        /// Get Preferred Providers Get Preferred Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PPNs</returns>
        public PPNs GetPreferredProviders ()
        {
             ApiResponse<PPNs> localVarResponse = GetPreferredProvidersWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Preferred Providers Get Preferred Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PPNs</returns>
        public ApiResponse< PPNs > GetPreferredProvidersWithHttpInfo ()
        {

            var localVarPath = "/company/preferred-providers";
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
                Exception exception = ExceptionFactory("GetPreferredProviders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PPNs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PPNs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PPNs)));
        }

        /// <summary>
        /// Get Preferred Providers Get Preferred Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PPNs</returns>
        public async System.Threading.Tasks.Task<PPNs> GetPreferredProvidersAsync ()
        {
             ApiResponse<PPNs> localVarResponse = await GetPreferredProvidersAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Preferred Providers Get Preferred Providers
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PPNs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PPNs>> GetPreferredProvidersAsyncWithHttpInfo ()
        {

            var localVarPath = "/company/preferred-providers";
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
                Exception exception = ExceptionFactory("GetPreferredProviders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PPNs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PPNs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PPNs)));
        }

        /// <summary>
        /// Get Rating Info of a Company Get Rating Details of a Company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>CompanyRating</returns>
        public CompanyRating GetRatingsByCompanyId (int? companyId)
        {
             ApiResponse<CompanyRating> localVarResponse = GetRatingsByCompanyIdWithHttpInfo(companyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Rating Info of a Company Get Rating Details of a Company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>ApiResponse of CompanyRating</returns>
        public ApiResponse< CompanyRating > GetRatingsByCompanyIdWithHttpInfo (int? companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetRatingsByCompanyId");

            var localVarPath = "/company/{company_id}/ratings";
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
                Exception exception = ExceptionFactory("GetRatingsByCompanyId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyRating>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyRating) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyRating)));
        }

        /// <summary>
        /// Get Rating Info of a Company Get Rating Details of a Company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>Task of CompanyRating</returns>
        public async System.Threading.Tasks.Task<CompanyRating> GetRatingsByCompanyIdAsync (int? companyId)
        {
             ApiResponse<CompanyRating> localVarResponse = await GetRatingsByCompanyIdAsyncWithHttpInfo(companyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Rating Info of a Company Get Rating Details of a Company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Company ID</param>
        /// <returns>Task of ApiResponse (CompanyRating)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyRating>> GetRatingsByCompanyIdAsyncWithHttpInfo (int? companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling CompanyApi->GetRatingsByCompanyId");

            var localVarPath = "/company/{company_id}/ratings";
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
                Exception exception = ExceptionFactory("GetRatingsByCompanyId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CompanyRating>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CompanyRating) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CompanyRating)));
        }

        /// <summary>
        /// Get Selection Rules by Company Returns a list of selection rules for company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SelectionRules</returns>
        public SelectionRules GetSelectionRulesByCompany ()
        {
             ApiResponse<SelectionRules> localVarResponse = GetSelectionRulesByCompanyWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Selection Rules by Company Returns a list of selection rules for company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SelectionRules</returns>
        public ApiResponse< SelectionRules > GetSelectionRulesByCompanyWithHttpInfo ()
        {

            var localVarPath = "/company/selection_rules";
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
                Exception exception = ExceptionFactory("GetSelectionRulesByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SelectionRules>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SelectionRules) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelectionRules)));
        }

        /// <summary>
        /// Get Selection Rules by Company Returns a list of selection rules for company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SelectionRules</returns>
        public async System.Threading.Tasks.Task<SelectionRules> GetSelectionRulesByCompanyAsync ()
        {
             ApiResponse<SelectionRules> localVarResponse = await GetSelectionRulesByCompanyAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Selection Rules by Company Returns a list of selection rules for company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SelectionRules)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SelectionRules>> GetSelectionRulesByCompanyAsyncWithHttpInfo ()
        {

            var localVarPath = "/company/selection_rules";
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
                Exception exception = ExceptionFactory("GetSelectionRulesByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SelectionRules>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SelectionRules) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SelectionRules)));
        }

        /// <summary>
        /// Get Tags Gets tags/labels
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Tags</returns>
        public Tags GetTags ()
        {
             ApiResponse<Tags> localVarResponse = GetTagsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Tags Gets tags/labels
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Tags</returns>
        public ApiResponse< Tags > GetTagsWithHttpInfo ()
        {

            var localVarPath = "/company/tags";
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
                Exception exception = ExceptionFactory("GetTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Tags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Tags)));
        }

        /// <summary>
        /// Get Tags Gets tags/labels
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Tags</returns>
        public async System.Threading.Tasks.Task<Tags> GetTagsAsync ()
        {
             ApiResponse<Tags> localVarResponse = await GetTagsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Tags Gets tags/labels
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Tags)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tags>> GetTagsAsyncWithHttpInfo ()
        {

            var localVarPath = "/company/tags";
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
                Exception exception = ExceptionFactory("GetTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Tags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Tags)));
        }

        /// <summary>
        /// Get Tags by Work Order Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>Tags</returns>
        public Tags GetTagsByWorkOrder (int? workOrderId)
        {
             ApiResponse<Tags> localVarResponse = GetTagsByWorkOrderWithHttpInfo(workOrderId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Tags by Work Order Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>ApiResponse of Tags</returns>
        public ApiResponse< Tags > GetTagsByWorkOrderWithHttpInfo (int? workOrderId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling CompanyApi->GetTagsByWorkOrder");

            var localVarPath = "/company/tags/{work_order_id}";
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
                Exception exception = ExceptionFactory("GetTagsByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Tags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Tags)));
        }

        /// <summary>
        /// Get Tags by Work Order Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>Task of Tags</returns>
        public async System.Threading.Tasks.Task<Tags> GetTagsByWorkOrderAsync (int? workOrderId)
        {
             ApiResponse<Tags> localVarResponse = await GetTagsByWorkOrderAsyncWithHttpInfo(workOrderId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Tags by Work Order Gets available tags for a work order and the company it belongs to (provider friendly route)
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workOrderId">work order ID</param>
        /// <returns>Task of ApiResponse (Tags)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tags>> GetTagsByWorkOrderAsyncWithHttpInfo (int? workOrderId)
        {
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling CompanyApi->GetTagsByWorkOrder");

            var localVarPath = "/company/tags/{work_order_id}";
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
                Exception exception = ExceptionFactory("GetTagsByWorkOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Tags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Tags)));
        }

        /// <summary>
        /// Send a request to enable a feature Send a request to enable a feature of a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns></returns>
        public void RequestFeatureByFeature (int? featureId)
        {
             RequestFeatureByFeatureWithHttpInfo(featureId);
        }

        /// <summary>
        /// Send a request to enable a feature Send a request to enable a feature of a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RequestFeatureByFeatureWithHttpInfo (int? featureId)
        {
            // verify the required parameter 'featureId' is set
            if (featureId == null)
                throw new ApiException(400, "Missing required parameter 'featureId' when calling CompanyApi->RequestFeatureByFeature");

            var localVarPath = "/company/features/{feature_id}";
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

            if (featureId != null) localVarPathParams.Add("feature_id", Configuration.ApiClient.ParameterToString(featureId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RequestFeatureByFeature", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send a request to enable a feature Send a request to enable a feature of a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RequestFeatureByFeatureAsync (int? featureId)
        {
             await RequestFeatureByFeatureAsyncWithHttpInfo(featureId);

        }

        /// <summary>
        /// Send a request to enable a feature Send a request to enable a feature of a company.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="featureId">Feature ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RequestFeatureByFeatureAsyncWithHttpInfo (int? featureId)
        {
            // verify the required parameter 'featureId' is set
            if (featureId == null)
                throw new ApiException(400, "Missing required parameter 'featureId' when calling CompanyApi->RequestFeatureByFeature");

            var localVarPath = "/company/features/{feature_id}";
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

            if (featureId != null) localVarPathParams.Add("feature_id", Configuration.ApiClient.ParameterToString(featureId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RequestFeatureByFeature", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
