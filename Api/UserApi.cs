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
    public interface IUserApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Stores GPS coordinates for user
        /// </summary>
        /// <remarks>
        /// Stores user&#39;s current location during on my way reporting
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns></returns>
        void AddCoordsByUser (int? userId, Coords coords);

        /// <summary>
        /// Stores GPS coordinates for user
        /// </summary>
        /// <remarks>
        /// Stores user&#39;s current location during on my way reporting
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCoordsByUserWithHttpInfo (int? userId, Coords coords);
        /// <summary>
        /// Add Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User AddPayByUser (int? userId);

        /// <summary>
        /// Add Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> AddPayByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Add Type of Work to Profile
        /// </summary>
        /// <remarks>
        /// Add types of work to profile
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns></returns>
        void AddTypesOfWork (int? userId, List<int?> json);

        /// <summary>
        /// Add Type of Work to Profile
        /// </summary>
        /// <remarks>
        /// Add types of work to profile
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddTypesOfWorkWithHttpInfo (int? userId, List<int?> json);
        /// <summary>
        /// Get Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User GetPayByUser (int? userId);

        /// <summary>
        /// Get Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetPayByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Get Profile and Work History
        /// </summary>
        /// <remarks>
        /// Get Profile and Work History By The User and Work Order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>ProfileAndWorkHistory</returns>
        ProfileAndWorkHistory GetProfileAndWorkHistory (int? userId, int? workOrderId);

        /// <summary>
        /// Get Profile and Work History
        /// </summary>
        /// <remarks>
        /// Get Profile and Work History By The User and Work Order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>ApiResponse of ProfileAndWorkHistory</returns>
        ApiResponse<ProfileAndWorkHistory> GetProfileAndWorkHistoryWithHttpInfo (int? userId, int? workOrderId);
        /// <summary>
        /// Get Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User GetSettingsByUser (int? userId);

        /// <summary>
        /// Get Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetSettingsByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Get Tax by User
        /// </summary>
        /// <remarks>
        /// Get tax info
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserTaxInfo</returns>
        UserTaxInfo GetTaxByUser (int? userId);

        /// <summary>
        /// Get Tax by User
        /// </summary>
        /// <remarks>
        /// Get tax info
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserTaxInfo</returns>
        ApiResponse<UserTaxInfo> GetTaxByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Get Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User GetTourByUser (int? userId);

        /// <summary>
        /// Get Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetTourByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Get User
        /// </summary>
        /// <remarks>
        /// Returns summary details about a user profile.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>User</returns>
        User GetUser (string user);

        /// <summary>
        /// Get User
        /// </summary>
        /// <remarks>
        /// Returns summary details about a user profile.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserWithHttpInfo (string user);
        /// <summary>
        /// Get User Block
        /// </summary>
        /// <remarks>
        /// Gets a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Block</returns>
        Block GetUserBlock (int? userId);

        /// <summary>
        /// Get User Block
        /// </summary>
        /// <remarks>
        /// Gets a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Block</returns>
        ApiResponse<Block> GetUserBlockWithHttpInfo (int? userId);
        /// <summary>
        /// Get User Preference Value
        /// </summary>
        /// <remarks>
        /// Get user preference value
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>Object</returns>
        Object GetUserPreferenceValueByKey (int? userId, string preference);

        /// <summary>
        /// Get User Preference Value
        /// </summary>
        /// <remarks>
        /// Get user preference value
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetUserPreferenceValueByKeyWithHttpInfo (int? userId, string preference);
        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <remarks>
        /// Get the Preferred Provider Networks the user is a part of
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>PPNs</returns>
        PPNs GetUserPreferredProviderNetworks (int? userId);

        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <remarks>
        /// Get the Preferred Provider Networks the user is a part of
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of PPNs</returns>
        ApiResponse<PPNs> GetUserPreferredProviderNetworksWithHttpInfo (int? userId);
        /// <summary>
        /// Get Type of Work of an user
        /// </summary>
        /// <remarks>
        /// Get all types of work of a specific user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>TypesOfWork</returns>
        TypesOfWork GetUserTypesOfWork (int? userId);

        /// <summary>
        /// Get Type of Work of an user
        /// </summary>
        /// <remarks>
        /// Get all types of work of a specific user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of TypesOfWork</returns>
        ApiResponse<TypesOfWork> GetUserTypesOfWorkWithHttpInfo (int? userId);
        /// <summary>
        /// Get work history of a user
        /// </summary>
        /// <remarks>
        /// Get work history of a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>WorkHistory</returns>
        WorkHistory GetWorkHistory (int? userId);

        /// <summary>
        /// Get work history of a user
        /// </summary>
        /// <remarks>
        /// Get work history of a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of WorkHistory</returns>
        ApiResponse<WorkHistory> GetWorkHistoryWithHttpInfo (int? userId);
        /// <summary>
        /// Send Account Activation Link
        /// </summary>
        /// <remarks>
        /// Send account activation link
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns></returns>
        void SendAccountActivationLink (int? userId, Json3 json);

        /// <summary>
        /// Send Account Activation Link
        /// </summary>
        /// <remarks>
        /// Send account activation link
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendAccountActivationLinkWithHttpInfo (int? userId, Json3 json);
        /// <summary>
        /// Send Verification Code via SMS
        /// </summary>
        /// <remarks>
        /// Send account verification code via text message
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns></returns>
        void SendVerificationCodeViaSms (int? userId, Json json);

        /// <summary>
        /// Send Verification Code via SMS
        /// </summary>
        /// <remarks>
        /// Send account verification code via text message
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendVerificationCodeViaSmsWithHttpInfo (int? userId, Json json);
        /// <summary>
        /// Send Verification Code via phone call
        /// </summary>
        /// <remarks>
        /// Send account verification code via phone call
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns></returns>
        void SendVerificationCodeViaVoiceCall (int? userId, Json1 json);

        /// <summary>
        /// Send Verification Code via phone call
        /// </summary>
        /// <remarks>
        /// Send account verification code via phone call
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendVerificationCodeViaVoiceCallWithHttpInfo (int? userId, Json1 json);
        /// <summary>
        /// Set User Preference
        /// </summary>
        /// <remarks>
        /// Set user preference
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        void SetUserPreference (int? userId, string preference, Json4 json);

        /// <summary>
        /// Set User Preference
        /// </summary>
        /// <remarks>
        /// Set user preference
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SetUserPreferenceWithHttpInfo (int? userId, string preference, Json4 json);
        /// <summary>
        /// Swip Notification
        /// </summary>
        /// <remarks>
        /// Swip Notification
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns></returns>
        void SwipNotification (int? userId, int? notificationId);

        /// <summary>
        /// Swip Notification
        /// </summary>
        /// <remarks>
        /// Swip Notification
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SwipNotificationWithHttpInfo (int? userId, int? notificationId);
        /// <summary>
        /// Switches the logged in user to the provided user if acceptable
        /// </summary>
        /// <remarks>
        /// Switches to the proficed user if they are a allowed as a service company admin
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns></returns>
        void SwitchUser (User json);

        /// <summary>
        /// Switches the logged in user to the provided user if acceptable
        /// </summary>
        /// <remarks>
        /// Switches to the proficed user if they are a allowed as a service company admin
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SwitchUserWithHttpInfo (User json);
        /// <summary>
        /// Update Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User UpdatePayByUser (int? userId);

        /// <summary>
        /// Update Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UpdatePayByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Update Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User UpdateSettingsByUser (int? userId);

        /// <summary>
        /// Update Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UpdateSettingsByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Update Tax by User
        /// </summary>
        /// <remarks>
        /// Update tax info.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns></returns>
        void UpdateTaxByUser (int? userId, UserTaxInfoUpdate json);

        /// <summary>
        /// Update Tax by User
        /// </summary>
        /// <remarks>
        /// Update tax info.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateTaxByUserWithHttpInfo (int? userId, UserTaxInfoUpdate json);
        /// <summary>
        /// Update Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User UpdateTourByUser (int? userId);

        /// <summary>
        /// Update Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UpdateTourByUserWithHttpInfo (int? userId);
        /// <summary>
        /// Updates User Block
        /// </summary>
        /// <remarks>
        /// Updates a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>Block</returns>
        Block UpdateUserBlock (int? userId, Block block);

        /// <summary>
        /// Updates User Block
        /// </summary>
        /// <remarks>
        /// Updates a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>ApiResponse of Block</returns>
        ApiResponse<Block> UpdateUserBlockWithHttpInfo (int? userId, Block block);
        /// <summary>
        /// Upload Profile Photo
        /// </summary>
        /// <remarks>
        /// Upload profile photo
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns></returns>
        void UploadProfilePhoto (int? userId, System.IO.Stream file);

        /// <summary>
        /// Upload Profile Photo
        /// </summary>
        /// <remarks>
        /// Upload profile photo
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UploadProfilePhotoWithHttpInfo (int? userId, System.IO.Stream file);
        /// <summary>
        /// Verify Account
        /// </summary>
        /// <remarks>
        /// Verify account
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns></returns>
        void VerifyAccount (int? userId, Json2 json);

        /// <summary>
        /// Verify Account
        /// </summary>
        /// <remarks>
        /// Verify account
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> VerifyAccountWithHttpInfo (int? userId, Json2 json);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Stores GPS coordinates for user
        /// </summary>
        /// <remarks>
        /// Stores user&#39;s current location during on my way reporting
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCoordsByUserAsync (int? userId, Coords coords);

        /// <summary>
        /// Stores GPS coordinates for user
        /// </summary>
        /// <remarks>
        /// Stores user&#39;s current location during on my way reporting
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCoordsByUserAsyncWithHttpInfo (int? userId, Coords coords);
        /// <summary>
        /// Add Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> AddPayByUserAsync (int? userId);

        /// <summary>
        /// Add Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> AddPayByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Add Type of Work to Profile
        /// </summary>
        /// <remarks>
        /// Add types of work to profile
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddTypesOfWorkAsync (int? userId, List<int?> json);

        /// <summary>
        /// Add Type of Work to Profile
        /// </summary>
        /// <remarks>
        /// Add types of work to profile
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddTypesOfWorkAsyncWithHttpInfo (int? userId, List<int?> json);
        /// <summary>
        /// Get Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetPayByUserAsync (int? userId);

        /// <summary>
        /// Get Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetPayByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Get Profile and Work History
        /// </summary>
        /// <remarks>
        /// Get Profile and Work History By The User and Work Order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>Task of ProfileAndWorkHistory</returns>
        System.Threading.Tasks.Task<ProfileAndWorkHistory> GetProfileAndWorkHistoryAsync (int? userId, int? workOrderId);

        /// <summary>
        /// Get Profile and Work History
        /// </summary>
        /// <remarks>
        /// Get Profile and Work History By The User and Work Order
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>Task of ApiResponse (ProfileAndWorkHistory)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProfileAndWorkHistory>> GetProfileAndWorkHistoryAsyncWithHttpInfo (int? userId, int? workOrderId);
        /// <summary>
        /// Get Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetSettingsByUserAsync (int? userId);

        /// <summary>
        /// Get Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetSettingsByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Get Tax by User
        /// </summary>
        /// <remarks>
        /// Get tax info
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserTaxInfo</returns>
        System.Threading.Tasks.Task<UserTaxInfo> GetTaxByUserAsync (int? userId);

        /// <summary>
        /// Get Tax by User
        /// </summary>
        /// <remarks>
        /// Get tax info
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserTaxInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserTaxInfo>> GetTaxByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Get Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetTourByUserAsync (int? userId);

        /// <summary>
        /// Get Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetTourByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Get User
        /// </summary>
        /// <remarks>
        /// Returns summary details about a user profile.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync (string user);

        /// <summary>
        /// Get User
        /// </summary>
        /// <remarks>
        /// Returns summary details about a user profile.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserAsyncWithHttpInfo (string user);
        /// <summary>
        /// Get User Block
        /// </summary>
        /// <remarks>
        /// Gets a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of Block</returns>
        System.Threading.Tasks.Task<Block> GetUserBlockAsync (int? userId);

        /// <summary>
        /// Get User Block
        /// </summary>
        /// <remarks>
        /// Gets a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (Block)</returns>
        System.Threading.Tasks.Task<ApiResponse<Block>> GetUserBlockAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Get User Preference Value
        /// </summary>
        /// <remarks>
        /// Get user preference value
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetUserPreferenceValueByKeyAsync (int? userId, string preference);

        /// <summary>
        /// Get User Preference Value
        /// </summary>
        /// <remarks>
        /// Get user preference value
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetUserPreferenceValueByKeyAsyncWithHttpInfo (int? userId, string preference);
        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <remarks>
        /// Get the Preferred Provider Networks the user is a part of
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of PPNs</returns>
        System.Threading.Tasks.Task<PPNs> GetUserPreferredProviderNetworksAsync (int? userId);

        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <remarks>
        /// Get the Preferred Provider Networks the user is a part of
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (PPNs)</returns>
        System.Threading.Tasks.Task<ApiResponse<PPNs>> GetUserPreferredProviderNetworksAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Get Type of Work of an user
        /// </summary>
        /// <remarks>
        /// Get all types of work of a specific user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of TypesOfWork</returns>
        System.Threading.Tasks.Task<TypesOfWork> GetUserTypesOfWorkAsync (int? userId);

        /// <summary>
        /// Get Type of Work of an user
        /// </summary>
        /// <remarks>
        /// Get all types of work of a specific user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (TypesOfWork)</returns>
        System.Threading.Tasks.Task<ApiResponse<TypesOfWork>> GetUserTypesOfWorkAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Get work history of a user
        /// </summary>
        /// <remarks>
        /// Get work history of a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of WorkHistory</returns>
        System.Threading.Tasks.Task<WorkHistory> GetWorkHistoryAsync (int? userId);

        /// <summary>
        /// Get work history of a user
        /// </summary>
        /// <remarks>
        /// Get work history of a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (WorkHistory)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkHistory>> GetWorkHistoryAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Send Account Activation Link
        /// </summary>
        /// <remarks>
        /// Send account activation link
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendAccountActivationLinkAsync (int? userId, Json3 json);

        /// <summary>
        /// Send Account Activation Link
        /// </summary>
        /// <remarks>
        /// Send account activation link
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendAccountActivationLinkAsyncWithHttpInfo (int? userId, Json3 json);
        /// <summary>
        /// Send Verification Code via SMS
        /// </summary>
        /// <remarks>
        /// Send account verification code via text message
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendVerificationCodeViaSmsAsync (int? userId, Json json);

        /// <summary>
        /// Send Verification Code via SMS
        /// </summary>
        /// <remarks>
        /// Send account verification code via text message
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendVerificationCodeViaSmsAsyncWithHttpInfo (int? userId, Json json);
        /// <summary>
        /// Send Verification Code via phone call
        /// </summary>
        /// <remarks>
        /// Send account verification code via phone call
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SendVerificationCodeViaVoiceCallAsync (int? userId, Json1 json);

        /// <summary>
        /// Send Verification Code via phone call
        /// </summary>
        /// <remarks>
        /// Send account verification code via phone call
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SendVerificationCodeViaVoiceCallAsyncWithHttpInfo (int? userId, Json1 json);
        /// <summary>
        /// Set User Preference
        /// </summary>
        /// <remarks>
        /// Set user preference
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SetUserPreferenceAsync (int? userId, string preference, Json4 json);

        /// <summary>
        /// Set User Preference
        /// </summary>
        /// <remarks>
        /// Set user preference
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SetUserPreferenceAsyncWithHttpInfo (int? userId, string preference, Json4 json);
        /// <summary>
        /// Swip Notification
        /// </summary>
        /// <remarks>
        /// Swip Notification
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SwipNotificationAsync (int? userId, int? notificationId);

        /// <summary>
        /// Swip Notification
        /// </summary>
        /// <remarks>
        /// Swip Notification
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SwipNotificationAsyncWithHttpInfo (int? userId, int? notificationId);
        /// <summary>
        /// Switches the logged in user to the provided user if acceptable
        /// </summary>
        /// <remarks>
        /// Switches to the proficed user if they are a allowed as a service company admin
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SwitchUserAsync (User json);

        /// <summary>
        /// Switches the logged in user to the provided user if acceptable
        /// </summary>
        /// <remarks>
        /// Switches to the proficed user if they are a allowed as a service company admin
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SwitchUserAsyncWithHttpInfo (User json);
        /// <summary>
        /// Update Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UpdatePayByUserAsync (int? userId);

        /// <summary>
        /// Update Pay by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UpdatePayByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Update Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UpdateSettingsByUserAsync (int? userId);

        /// <summary>
        /// Update Settings by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UpdateSettingsByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Update Tax by User
        /// </summary>
        /// <remarks>
        /// Update tax info.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateTaxByUserAsync (int? userId, UserTaxInfoUpdate json);

        /// <summary>
        /// Update Tax by User
        /// </summary>
        /// <remarks>
        /// Update tax info.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateTaxByUserAsyncWithHttpInfo (int? userId, UserTaxInfoUpdate json);
        /// <summary>
        /// Update Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UpdateTourByUserAsync (int? userId);

        /// <summary>
        /// Update Tour by User
        /// </summary>
        /// <remarks>
        /// Submit individual updates to the tour state as a user onboards the site.
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UpdateTourByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Updates User Block
        /// </summary>
        /// <remarks>
        /// Updates a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>Task of Block</returns>
        System.Threading.Tasks.Task<Block> UpdateUserBlockAsync (int? userId, Block block);

        /// <summary>
        /// Updates User Block
        /// </summary>
        /// <remarks>
        /// Updates a block for a user
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>Task of ApiResponse (Block)</returns>
        System.Threading.Tasks.Task<ApiResponse<Block>> UpdateUserBlockAsyncWithHttpInfo (int? userId, Block block);
        /// <summary>
        /// Upload Profile Photo
        /// </summary>
        /// <remarks>
        /// Upload profile photo
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UploadProfilePhotoAsync (int? userId, System.IO.Stream file);

        /// <summary>
        /// Upload Profile Photo
        /// </summary>
        /// <remarks>
        /// Upload profile photo
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UploadProfilePhotoAsyncWithHttpInfo (int? userId, System.IO.Stream file);
        /// <summary>
        /// Verify Account
        /// </summary>
        /// <remarks>
        /// Verify account
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task VerifyAccountAsync (int? userId, Json2 json);

        /// <summary>
        /// Verify Account
        /// </summary>
        /// <remarks>
        /// Verify account
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> VerifyAccountAsyncWithHttpInfo (int? userId, Json2 json);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserApi : IUserApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(Configuration configuration = null)
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
        /// Stores GPS coordinates for user Stores user&#39;s current location during on my way reporting
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns></returns>
        public void AddCoordsByUser (int? userId, Coords coords)
        {
             AddCoordsByUserWithHttpInfo(userId, coords);
        }

        /// <summary>
        /// Stores GPS coordinates for user Stores user&#39;s current location during on my way reporting
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCoordsByUserWithHttpInfo (int? userId, Coords coords)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->AddCoordsByUser");
            // verify the required parameter 'coords' is set
            if (coords == null)
                throw new ApiException(400, "Missing required parameter 'coords' when calling UserApi->AddCoordsByUser");

            var localVarPath = "/users/{user_id}/coords";
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
            if (coords != null && coords.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(coords); // http body (model) parameter
            }
            else
            {
                localVarPostBody = coords; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddCoordsByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Stores GPS coordinates for user Stores user&#39;s current location during on my way reporting
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCoordsByUserAsync (int? userId, Coords coords)
        {
             await AddCoordsByUserAsyncWithHttpInfo(userId, coords);

        }

        /// <summary>
        /// Stores GPS coordinates for user Stores user&#39;s current location during on my way reporting
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">user id of user to store coordinates for</param>
        /// <param name="coords">coordinate data. Only need latitude and longitude fields</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCoordsByUserAsyncWithHttpInfo (int? userId, Coords coords)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->AddCoordsByUser");
            // verify the required parameter 'coords' is set
            if (coords == null)
                throw new ApiException(400, "Missing required parameter 'coords' when calling UserApi->AddCoordsByUser");

            var localVarPath = "/users/{user_id}/coords";
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
            if (coords != null && coords.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(coords); // http body (model) parameter
            }
            else
            {
                localVarPostBody = coords; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddCoordsByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        public User AddPayByUser (int? userId)
        {
             ApiResponse<User> localVarResponse = AddPayByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > AddPayByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->AddPayByUser");

            var localVarPath = "/users/{user_id}/pay";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPayByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Add Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> AddPayByUserAsync (int? userId)
        {
             ApiResponse<User> localVarResponse = await AddPayByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> AddPayByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->AddPayByUser");

            var localVarPath = "/users/{user_id}/pay";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPayByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Add Type of Work to Profile Add types of work to profile
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns></returns>
        public void AddTypesOfWork (int? userId, List<int?> json)
        {
             AddTypesOfWorkWithHttpInfo(userId, json);
        }

        /// <summary>
        /// Add Type of Work to Profile Add types of work to profile
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddTypesOfWorkWithHttpInfo (int? userId, List<int?> json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->AddTypesOfWork");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->AddTypesOfWork");

            var localVarPath = "/users/{user_id}/types-of-work";
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
                Exception exception = ExceptionFactory("AddTypesOfWork", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add Type of Work to Profile Add types of work to profile
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddTypesOfWorkAsync (int? userId, List<int?> json)
        {
             await AddTypesOfWorkAsyncWithHttpInfo(userId, json);

        }

        /// <summary>
        /// Add Type of Work to Profile Add types of work to profile
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON model</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddTypesOfWorkAsyncWithHttpInfo (int? userId, List<int?> json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->AddTypesOfWork");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->AddTypesOfWork");

            var localVarPath = "/users/{user_id}/types-of-work";
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
                Exception exception = ExceptionFactory("AddTypesOfWork", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        public User GetPayByUser (int? userId)
        {
             ApiResponse<User> localVarResponse = GetPayByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetPayByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetPayByUser");

            var localVarPath = "/users/{user_id}/pay";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPayByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetPayByUserAsync (int? userId)
        {
             ApiResponse<User> localVarResponse = await GetPayByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetPayByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetPayByUser");

            var localVarPath = "/users/{user_id}/pay";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPayByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get Profile and Work History Get Profile and Work History By The User and Work Order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>ProfileAndWorkHistory</returns>
        public ProfileAndWorkHistory GetProfileAndWorkHistory (int? userId, int? workOrderId)
        {
             ApiResponse<ProfileAndWorkHistory> localVarResponse = GetProfileAndWorkHistoryWithHttpInfo(userId, workOrderId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Profile and Work History Get Profile and Work History By The User and Work Order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>ApiResponse of ProfileAndWorkHistory</returns>
        public ApiResponse< ProfileAndWorkHistory > GetProfileAndWorkHistoryWithHttpInfo (int? userId, int? workOrderId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetProfileAndWorkHistory");
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling UserApi->GetProfileAndWorkHistory");

            var localVarPath = "/users/{user_id}/workorder/{work_order_id}";
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
            if (workOrderId != null) localVarPathParams.Add("work_order_id", Configuration.ApiClient.ParameterToString(workOrderId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProfileAndWorkHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProfileAndWorkHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProfileAndWorkHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProfileAndWorkHistory)));
        }

        /// <summary>
        /// Get Profile and Work History Get Profile and Work History By The User and Work Order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>Task of ProfileAndWorkHistory</returns>
        public async System.Threading.Tasks.Task<ProfileAndWorkHistory> GetProfileAndWorkHistoryAsync (int? userId, int? workOrderId)
        {
             ApiResponse<ProfileAndWorkHistory> localVarResponse = await GetProfileAndWorkHistoryAsyncWithHttpInfo(userId, workOrderId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Profile and Work History Get Profile and Work History By The User and Work Order
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="workOrderId">Work Order ID</param>
        /// <returns>Task of ApiResponse (ProfileAndWorkHistory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProfileAndWorkHistory>> GetProfileAndWorkHistoryAsyncWithHttpInfo (int? userId, int? workOrderId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetProfileAndWorkHistory");
            // verify the required parameter 'workOrderId' is set
            if (workOrderId == null)
                throw new ApiException(400, "Missing required parameter 'workOrderId' when calling UserApi->GetProfileAndWorkHistory");

            var localVarPath = "/users/{user_id}/workorder/{work_order_id}";
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
            if (workOrderId != null) localVarPathParams.Add("work_order_id", Configuration.ApiClient.ParameterToString(workOrderId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProfileAndWorkHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProfileAndWorkHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProfileAndWorkHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProfileAndWorkHistory)));
        }

        /// <summary>
        /// Get Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        public User GetSettingsByUser (int? userId)
        {
             ApiResponse<User> localVarResponse = GetSettingsByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetSettingsByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetSettingsByUser");

            var localVarPath = "/users/{user_id}/settings";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSettingsByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetSettingsByUserAsync (int? userId)
        {
             ApiResponse<User> localVarResponse = await GetSettingsByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetSettingsByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetSettingsByUser");

            var localVarPath = "/users/{user_id}/settings";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSettingsByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get Tax by User Get tax info
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>UserTaxInfo</returns>
        public UserTaxInfo GetTaxByUser (int? userId)
        {
             ApiResponse<UserTaxInfo> localVarResponse = GetTaxByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Tax by User Get tax info
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of UserTaxInfo</returns>
        public ApiResponse< UserTaxInfo > GetTaxByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetTaxByUser");

            var localVarPath = "/users/{user_id}/tax";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTaxByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserTaxInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserTaxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserTaxInfo)));
        }

        /// <summary>
        /// Get Tax by User Get tax info
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of UserTaxInfo</returns>
        public async System.Threading.Tasks.Task<UserTaxInfo> GetTaxByUserAsync (int? userId)
        {
             ApiResponse<UserTaxInfo> localVarResponse = await GetTaxByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Tax by User Get tax info
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (UserTaxInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserTaxInfo>> GetTaxByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetTaxByUser");

            var localVarPath = "/users/{user_id}/tax";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTaxByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserTaxInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserTaxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserTaxInfo)));
        }

        /// <summary>
        /// Get Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        public User GetTourByUser (int? userId)
        {
             ApiResponse<User> localVarResponse = GetTourByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetTourByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetTourByUser");

            var localVarPath = "/users/{user_id}/tour";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTourByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetTourByUserAsync (int? userId)
        {
             ApiResponse<User> localVarResponse = await GetTourByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetTourByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetTourByUser");

            var localVarPath = "/users/{user_id}/tour";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTourByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get User Returns summary details about a user profile.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>User</returns>
        public User GetUser (string user)
        {
             ApiResponse<User> localVarResponse = GetUserWithHttpInfo(user);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Returns summary details about a user profile.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetUserWithHttpInfo (string user)
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new ApiException(400, "Missing required parameter 'user' when calling UserApi->GetUser");

            var localVarPath = "/users/{user}";
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

            if (user != null) localVarPathParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get User Returns summary details about a user profile.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync (string user)
        {
             ApiResponse<User> localVarResponse = await GetUserAsyncWithHttpInfo(user);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Returns summary details about a user profile.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetUserAsyncWithHttpInfo (string user)
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new ApiException(400, "Missing required parameter 'user' when calling UserApi->GetUser");

            var localVarPath = "/users/{user}";
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

            if (user != null) localVarPathParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Get User Block Gets a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Block</returns>
        public Block GetUserBlock (int? userId)
        {
             ApiResponse<Block> localVarResponse = GetUserBlockWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Block Gets a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of Block</returns>
        public ApiResponse< Block > GetUserBlockWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserBlock");

            var localVarPath = "/users/{user_id}/block";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserBlock", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Block>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Block) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Block)));
        }

        /// <summary>
        /// Get User Block Gets a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of Block</returns>
        public async System.Threading.Tasks.Task<Block> GetUserBlockAsync (int? userId)
        {
             ApiResponse<Block> localVarResponse = await GetUserBlockAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Block Gets a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (Block)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Block>> GetUserBlockAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserBlock");

            var localVarPath = "/users/{user_id}/block";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserBlock", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Block>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Block) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Block)));
        }

        /// <summary>
        /// Get User Preference Value Get user preference value
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>Object</returns>
        public Object GetUserPreferenceValueByKey (int? userId, string preference)
        {
             ApiResponse<Object> localVarResponse = GetUserPreferenceValueByKeyWithHttpInfo(userId, preference);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Preference Value Get user preference value
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetUserPreferenceValueByKeyWithHttpInfo (int? userId, string preference)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserPreferenceValueByKey");
            // verify the required parameter 'preference' is set
            if (preference == null)
                throw new ApiException(400, "Missing required parameter 'preference' when calling UserApi->GetUserPreferenceValueByKey");

            var localVarPath = "/users/{user_id}/preferences/{preference}";
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
            if (preference != null) localVarPathParams.Add("preference", Configuration.ApiClient.ParameterToString(preference)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserPreferenceValueByKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Get User Preference Value Get user preference value
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetUserPreferenceValueByKeyAsync (int? userId, string preference)
        {
             ApiResponse<Object> localVarResponse = await GetUserPreferenceValueByKeyAsyncWithHttpInfo(userId, preference);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Preference Value Get user preference value
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetUserPreferenceValueByKeyAsyncWithHttpInfo (int? userId, string preference)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserPreferenceValueByKey");
            // verify the required parameter 'preference' is set
            if (preference == null)
                throw new ApiException(400, "Missing required parameter 'preference' when calling UserApi->GetUserPreferenceValueByKey");

            var localVarPath = "/users/{user_id}/preferences/{preference}";
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
            if (preference != null) localVarPathParams.Add("preference", Configuration.ApiClient.ParameterToString(preference)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserPreferenceValueByKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>PPNs</returns>
        public PPNs GetUserPreferredProviderNetworks (int? userId)
        {
             ApiResponse<PPNs> localVarResponse = GetUserPreferredProviderNetworksWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of PPNs</returns>
        public ApiResponse< PPNs > GetUserPreferredProviderNetworksWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserPreferredProviderNetworks");

            var localVarPath = "/users/{user_id}/preferredprovidernetworks";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserPreferredProviderNetworks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PPNs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PPNs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PPNs)));
        }

        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of PPNs</returns>
        public async System.Threading.Tasks.Task<PPNs> GetUserPreferredProviderNetworksAsync (int? userId)
        {
             ApiResponse<PPNs> localVarResponse = await GetUserPreferredProviderNetworksAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Preferred Provider Networks the user is a part of Get the Preferred Provider Networks the user is a part of
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (PPNs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PPNs>> GetUserPreferredProviderNetworksAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserPreferredProviderNetworks");

            var localVarPath = "/users/{user_id}/preferredprovidernetworks";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserPreferredProviderNetworks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PPNs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PPNs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PPNs)));
        }

        /// <summary>
        /// Get Type of Work of an user Get all types of work of a specific user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>TypesOfWork</returns>
        public TypesOfWork GetUserTypesOfWork (int? userId)
        {
             ApiResponse<TypesOfWork> localVarResponse = GetUserTypesOfWorkWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Type of Work of an user Get all types of work of a specific user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of TypesOfWork</returns>
        public ApiResponse< TypesOfWork > GetUserTypesOfWorkWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserTypesOfWork");

            var localVarPath = "/users/{user_id}/types-of-work";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserTypesOfWork", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TypesOfWork>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TypesOfWork) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TypesOfWork)));
        }

        /// <summary>
        /// Get Type of Work of an user Get all types of work of a specific user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of TypesOfWork</returns>
        public async System.Threading.Tasks.Task<TypesOfWork> GetUserTypesOfWorkAsync (int? userId)
        {
             ApiResponse<TypesOfWork> localVarResponse = await GetUserTypesOfWorkAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Type of Work of an user Get all types of work of a specific user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (TypesOfWork)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TypesOfWork>> GetUserTypesOfWorkAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserTypesOfWork");

            var localVarPath = "/users/{user_id}/types-of-work";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserTypesOfWork", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TypesOfWork>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TypesOfWork) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TypesOfWork)));
        }

        /// <summary>
        /// Get work history of a user Get work history of a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>WorkHistory</returns>
        public WorkHistory GetWorkHistory (int? userId)
        {
             ApiResponse<WorkHistory> localVarResponse = GetWorkHistoryWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get work history of a user Get work history of a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of WorkHistory</returns>
        public ApiResponse< WorkHistory > GetWorkHistoryWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetWorkHistory");

            var localVarPath = "/users/{user_id}/work_history";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorkHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkHistory)));
        }

        /// <summary>
        /// Get work history of a user Get work history of a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of WorkHistory</returns>
        public async System.Threading.Tasks.Task<WorkHistory> GetWorkHistoryAsync (int? userId)
        {
             ApiResponse<WorkHistory> localVarResponse = await GetWorkHistoryAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get work history of a user Get work history of a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (WorkHistory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkHistory>> GetWorkHistoryAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetWorkHistory");

            var localVarPath = "/users/{user_id}/work_history";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWorkHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WorkHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkHistory)));
        }

        /// <summary>
        /// Send Account Activation Link Send account activation link
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns></returns>
        public void SendAccountActivationLink (int? userId, Json3 json)
        {
             SendAccountActivationLinkWithHttpInfo(userId, json);
        }

        /// <summary>
        /// Send Account Activation Link Send account activation link
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendAccountActivationLinkWithHttpInfo (int? userId, Json3 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SendAccountActivationLink");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SendAccountActivationLink");

            var localVarPath = "/users/{user_id}/verify/email";
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
                Exception exception = ExceptionFactory("SendAccountActivationLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send Account Activation Link Send account activation link
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendAccountActivationLinkAsync (int? userId, Json3 json)
        {
             await SendAccountActivationLinkAsyncWithHttpInfo(userId, json);

        }

        /// <summary>
        /// Send Account Activation Link Send account activation link
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SendAccountActivationLinkAsyncWithHttpInfo (int? userId, Json3 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SendAccountActivationLink");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SendAccountActivationLink");

            var localVarPath = "/users/{user_id}/verify/email";
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
                Exception exception = ExceptionFactory("SendAccountActivationLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send Verification Code via SMS Send account verification code via text message
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns></returns>
        public void SendVerificationCodeViaSms (int? userId, Json json)
        {
             SendVerificationCodeViaSmsWithHttpInfo(userId, json);
        }

        /// <summary>
        /// Send Verification Code via SMS Send account verification code via text message
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendVerificationCodeViaSmsWithHttpInfo (int? userId, Json json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SendVerificationCodeViaSms");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SendVerificationCodeViaSms");

            var localVarPath = "/users/{user_id}/verify/text";
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
                Exception exception = ExceptionFactory("SendVerificationCodeViaSms", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send Verification Code via SMS Send account verification code via text message
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendVerificationCodeViaSmsAsync (int? userId, Json json)
        {
             await SendVerificationCodeViaSmsAsyncWithHttpInfo(userId, json);

        }

        /// <summary>
        /// Send Verification Code via SMS Send account verification code via text message
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SendVerificationCodeViaSmsAsyncWithHttpInfo (int? userId, Json json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SendVerificationCodeViaSms");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SendVerificationCodeViaSms");

            var localVarPath = "/users/{user_id}/verify/text";
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
                Exception exception = ExceptionFactory("SendVerificationCodeViaSms", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send Verification Code via phone call Send account verification code via phone call
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns></returns>
        public void SendVerificationCodeViaVoiceCall (int? userId, Json1 json)
        {
             SendVerificationCodeViaVoiceCallWithHttpInfo(userId, json);
        }

        /// <summary>
        /// Send Verification Code via phone call Send account verification code via phone call
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SendVerificationCodeViaVoiceCallWithHttpInfo (int? userId, Json1 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SendVerificationCodeViaVoiceCall");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SendVerificationCodeViaVoiceCall");

            var localVarPath = "/users/{user_id}/verify/phone";
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
                Exception exception = ExceptionFactory("SendVerificationCodeViaVoiceCall", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send Verification Code via phone call Send account verification code via phone call
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SendVerificationCodeViaVoiceCallAsync (int? userId, Json1 json)
        {
             await SendVerificationCodeViaVoiceCallAsyncWithHttpInfo(userId, json);

        }

        /// <summary>
        /// Send Verification Code via phone call Send account verification code via phone call
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">JSON Payload</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SendVerificationCodeViaVoiceCallAsyncWithHttpInfo (int? userId, Json1 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SendVerificationCodeViaVoiceCall");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SendVerificationCodeViaVoiceCall");

            var localVarPath = "/users/{user_id}/verify/phone";
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
                Exception exception = ExceptionFactory("SendVerificationCodeViaVoiceCall", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Set User Preference Set user preference
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns></returns>
        public void SetUserPreference (int? userId, string preference, Json4 json)
        {
             SetUserPreferenceWithHttpInfo(userId, preference, json);
        }

        /// <summary>
        /// Set User Preference Set user preference
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SetUserPreferenceWithHttpInfo (int? userId, string preference, Json4 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SetUserPreference");
            // verify the required parameter 'preference' is set
            if (preference == null)
                throw new ApiException(400, "Missing required parameter 'preference' when calling UserApi->SetUserPreference");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SetUserPreference");

            var localVarPath = "/users/{user_id}/preferences/{preference}";
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
            if (preference != null) localVarPathParams.Add("preference", Configuration.ApiClient.ParameterToString(preference)); // path parameter
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
                Exception exception = ExceptionFactory("SetUserPreference", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Set User Preference Set user preference
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SetUserPreferenceAsync (int? userId, string preference, Json4 json)
        {
             await SetUserPreferenceAsyncWithHttpInfo(userId, preference, json);

        }

        /// <summary>
        /// Set User Preference Set user preference
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="preference">Preference Key</param>
        /// <param name="json">JSON Model</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SetUserPreferenceAsyncWithHttpInfo (int? userId, string preference, Json4 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SetUserPreference");
            // verify the required parameter 'preference' is set
            if (preference == null)
                throw new ApiException(400, "Missing required parameter 'preference' when calling UserApi->SetUserPreference");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SetUserPreference");

            var localVarPath = "/users/{user_id}/preferences/{preference}";
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
            if (preference != null) localVarPathParams.Add("preference", Configuration.ApiClient.ParameterToString(preference)); // path parameter
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
                Exception exception = ExceptionFactory("SetUserPreference", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Swip Notification Swip Notification
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns></returns>
        public void SwipNotification (int? userId, int? notificationId)
        {
             SwipNotificationWithHttpInfo(userId, notificationId);
        }

        /// <summary>
        /// Swip Notification Swip Notification
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SwipNotificationWithHttpInfo (int? userId, int? notificationId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SwipNotification");
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling UserApi->SwipNotification");

            var localVarPath = "/users/{user_id}/notifications/{notification_id}";
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
            if (notificationId != null) localVarPathParams.Add("notification_id", Configuration.ApiClient.ParameterToString(notificationId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SwipNotification", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Swip Notification Swip Notification
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SwipNotificationAsync (int? userId, int? notificationId)
        {
             await SwipNotificationAsyncWithHttpInfo(userId, notificationId);

        }

        /// <summary>
        /// Swip Notification Swip Notification
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="notificationId">Notification ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SwipNotificationAsyncWithHttpInfo (int? userId, int? notificationId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->SwipNotification");
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling UserApi->SwipNotification");

            var localVarPath = "/users/{user_id}/notifications/{notification_id}";
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
            if (notificationId != null) localVarPathParams.Add("notification_id", Configuration.ApiClient.ParameterToString(notificationId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SwipNotification", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Switches the logged in user to the provided user if acceptable Switches to the proficed user if they are a allowed as a service company admin
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns></returns>
        public void SwitchUser (User json)
        {
             SwitchUserWithHttpInfo(json);
        }

        /// <summary>
        /// Switches the logged in user to the provided user if acceptable Switches to the proficed user if they are a allowed as a service company admin
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SwitchUserWithHttpInfo (User json)
        {
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SwitchUser");

            var localVarPath = "/users/switch";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SwitchUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Switches the logged in user to the provided user if acceptable Switches to the proficed user if they are a allowed as a service company admin
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SwitchUserAsync (User json)
        {
             await SwitchUserAsyncWithHttpInfo(json);

        }

        /// <summary>
        /// Switches the logged in user to the provided user if acceptable Switches to the proficed user if they are a allowed as a service company admin
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="json">User id of the user to be switch to, just need user.id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SwitchUserAsyncWithHttpInfo (User json)
        {
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->SwitchUser");

            var localVarPath = "/users/switch";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SwitchUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        public User UpdatePayByUser (int? userId)
        {
             ApiResponse<User> localVarResponse = UpdatePayByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UpdatePayByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdatePayByUser");

            var localVarPath = "/users/{user_id}/pay";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePayByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Update Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UpdatePayByUserAsync (int? userId)
        {
             ApiResponse<User> localVarResponse = await UpdatePayByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Pay by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UpdatePayByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdatePayByUser");

            var localVarPath = "/users/{user_id}/pay";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePayByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Update Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        public User UpdateSettingsByUser (int? userId)
        {
             ApiResponse<User> localVarResponse = UpdateSettingsByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UpdateSettingsByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateSettingsByUser");

            var localVarPath = "/users/{user_id}/settings";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSettingsByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Update Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UpdateSettingsByUserAsync (int? userId)
        {
             ApiResponse<User> localVarResponse = await UpdateSettingsByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Settings by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UpdateSettingsByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateSettingsByUser");

            var localVarPath = "/users/{user_id}/settings";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSettingsByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Update Tax by User Update tax info.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns></returns>
        public void UpdateTaxByUser (int? userId, UserTaxInfoUpdate json)
        {
             UpdateTaxByUserWithHttpInfo(userId, json);
        }

        /// <summary>
        /// Update Tax by User Update tax info.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateTaxByUserWithHttpInfo (int? userId, UserTaxInfoUpdate json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateTaxByUser");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->UpdateTaxByUser");

            var localVarPath = "/users/{user_id}/tax";
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
                Exception exception = ExceptionFactory("UpdateTaxByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Tax by User Update tax info.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateTaxByUserAsync (int? userId, UserTaxInfoUpdate json)
        {
             await UpdateTaxByUserAsyncWithHttpInfo(userId, json);

        }

        /// <summary>
        /// Update Tax by User Update tax info.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json User tax info object for updating</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateTaxByUserAsyncWithHttpInfo (int? userId, UserTaxInfoUpdate json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateTaxByUser");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->UpdateTaxByUser");

            var localVarPath = "/users/{user_id}/tax";
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
                Exception exception = ExceptionFactory("UpdateTaxByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        public User UpdateTourByUser (int? userId)
        {
             ApiResponse<User> localVarResponse = UpdateTourByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UpdateTourByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateTourByUser");

            var localVarPath = "/users/{user_id}/tour";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTourByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Update Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UpdateTourByUserAsync (int? userId)
        {
             ApiResponse<User> localVarResponse = await UpdateTourByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Tour by User Submit individual updates to the tour state as a user onboards the site.
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UpdateTourByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateTourByUser");

            var localVarPath = "/users/{user_id}/tour";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTourByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        /// <summary>
        /// Updates User Block Updates a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>Block</returns>
        public Block UpdateUserBlock (int? userId, Block block)
        {
             ApiResponse<Block> localVarResponse = UpdateUserBlockWithHttpInfo(userId, block);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates User Block Updates a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>ApiResponse of Block</returns>
        public ApiResponse< Block > UpdateUserBlockWithHttpInfo (int? userId, Block block)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateUserBlock");
            // verify the required parameter 'block' is set
            if (block == null)
                throw new ApiException(400, "Missing required parameter 'block' when calling UserApi->UpdateUserBlock");

            var localVarPath = "/users/{user_id}/block";
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
            if (block != null && block.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(block); // http body (model) parameter
            }
            else
            {
                localVarPostBody = block; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUserBlock", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Block>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Block) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Block)));
        }

        /// <summary>
        /// Updates User Block Updates a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>Task of Block</returns>
        public async System.Threading.Tasks.Task<Block> UpdateUserBlockAsync (int? userId, Block block)
        {
             ApiResponse<Block> localVarResponse = await UpdateUserBlockAsyncWithHttpInfo(userId, block);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates User Block Updates a block for a user
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="block">Block</param>
        /// <returns>Task of ApiResponse (Block)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Block>> UpdateUserBlockAsyncWithHttpInfo (int? userId, Block block)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UpdateUserBlock");
            // verify the required parameter 'block' is set
            if (block == null)
                throw new ApiException(400, "Missing required parameter 'block' when calling UserApi->UpdateUserBlock");

            var localVarPath = "/users/{user_id}/block";
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
            if (block != null && block.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(block); // http body (model) parameter
            }
            else
            {
                localVarPostBody = block; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUserBlock", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Block>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Block) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Block)));
        }

        /// <summary>
        /// Upload Profile Photo Upload profile photo
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns></returns>
        public void UploadProfilePhoto (int? userId, System.IO.Stream file)
        {
             UploadProfilePhotoWithHttpInfo(userId, file);
        }

        /// <summary>
        /// Upload Profile Photo Upload profile photo
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UploadProfilePhotoWithHttpInfo (int? userId, System.IO.Stream file)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UploadProfilePhoto");
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling UserApi->UploadProfilePhoto");

            var localVarPath = "/users/{user_id}/profile/avatar";
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
            if (file != null) localVarFileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UploadProfilePhoto", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Upload Profile Photo Upload profile photo
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UploadProfilePhotoAsync (int? userId, System.IO.Stream file)
        {
             await UploadProfilePhotoAsyncWithHttpInfo(userId, file);

        }

        /// <summary>
        /// Upload Profile Photo Upload profile photo
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="file">Photo to upload</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UploadProfilePhotoAsyncWithHttpInfo (int? userId, System.IO.Stream file)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->UploadProfilePhoto");
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling UserApi->UploadProfilePhoto");

            var localVarPath = "/users/{user_id}/profile/avatar";
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
            if (file != null) localVarFileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UploadProfilePhoto", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Verify Account Verify account
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns></returns>
        public void VerifyAccount (int? userId, Json2 json)
        {
             VerifyAccountWithHttpInfo(userId, json);
        }

        /// <summary>
        /// Verify Account Verify account
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> VerifyAccountWithHttpInfo (int? userId, Json2 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->VerifyAccount");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->VerifyAccount");

            var localVarPath = "/users/{user_id}/verify/2fa";
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
                Exception exception = ExceptionFactory("VerifyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Verify Account Verify account
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task VerifyAccountAsync (int? userId, Json2 json)
        {
             await VerifyAccountAsyncWithHttpInfo(userId, json);

        }

        /// <summary>
        /// Verify Account Verify account
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="json">Json Payload</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> VerifyAccountAsyncWithHttpInfo (int? userId, Json2 json)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserApi->VerifyAccount");
            // verify the required parameter 'json' is set
            if (json == null)
                throw new ApiException(400, "Missing required parameter 'json' when calling UserApi->VerifyAccount");

            var localVarPath = "/users/{user_id}/verify/2fa";
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
                Exception exception = ExceptionFactory("VerifyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
