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
    public interface ILocationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Locations
        /// </summary>
        /// <remarks>
        /// Add a location to company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>StoredLocation</returns>
        StoredLocation AddLocations (StoredLocation location);

        /// <summary>
        /// Add Locations
        /// </summary>
        /// <remarks>
        /// Add a location to company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        ApiResponse<StoredLocation> AddLocationsWithHttpInfo (StoredLocation location);
        /// <summary>
        /// Add Notes by Location
        /// </summary>
        /// <remarks>
        /// Adds a note to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>StoredLocation</returns>
        StoredLocation AddNotesByLocation (int? locationId, LocationNote note);

        /// <summary>
        /// Add Notes by Location
        /// </summary>
        /// <remarks>
        /// Adds a note to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        ApiResponse<StoredLocation> AddNotesByLocationWithHttpInfo (int? locationId, LocationNote note);
        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Soft deletes a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>StoredLocation</returns>
        StoredLocation DeleteLocation (int? locationId);

        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Soft deletes a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        ApiResponse<StoredLocation> DeleteLocationWithHttpInfo (int? locationId);
        /// <summary>
        /// Delete a Note by Location
        /// </summary>
        /// <remarks>
        /// Deletes a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>StoredLocation</returns>
        StoredLocation DeleteNoteByLocation (int? locationId, int? noteId);

        /// <summary>
        /// Delete a Note by Location
        /// </summary>
        /// <remarks>
        /// Deletes a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        ApiResponse<StoredLocation> DeleteNoteByLocationWithHttpInfo (int? locationId, int? noteId);
        /// <summary>
        /// Get Countries
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries for selection
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Countries</returns>
        Countries GetCountries ();

        /// <summary>
        /// Get Countries
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries for selection
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Countries</returns>
        ApiResponse<Countries> GetCountriesWithHttpInfo ();
        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets stored locations
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StoredLocations</returns>
        StoredLocations GetLocations ();

        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets stored locations
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StoredLocations</returns>
        ApiResponse<StoredLocations> GetLocationsWithHttpInfo ();
        /// <summary>
        /// Get Providers Info By Location
        /// </summary>
        /// <remarks>
        /// Get Providers Info By Location ID
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>LocationProviders</returns>
        LocationProviders GetProvidersByLocationId (int? locationId);

        /// <summary>
        /// Get Providers Info By Location
        /// </summary>
        /// <remarks>
        /// Get Providers Info By Location ID
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>ApiResponse of LocationProviders</returns>
        ApiResponse<LocationProviders> GetProvidersByLocationIdWithHttpInfo (int? locationId);
        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>StoredLocation</returns>
        StoredLocation UpdateLocation (int? locationId, StoredLocation location);

        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        ApiResponse<StoredLocation> UpdateLocationWithHttpInfo (int? locationId, StoredLocation location);
        /// <summary>
        /// Update a Note by Location
        /// </summary>
        /// <remarks>
        /// Updates a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>StoredLocation</returns>
        StoredLocation UpdateNoteByLocation (int? locationId, LocationNote note, int? noteId);

        /// <summary>
        /// Update a Note by Location
        /// </summary>
        /// <remarks>
        /// Updates a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        ApiResponse<StoredLocation> UpdateNoteByLocationWithHttpInfo (int? locationId, LocationNote note, int? noteId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add Locations
        /// </summary>
        /// <remarks>
        /// Add a location to company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of StoredLocation</returns>
        System.Threading.Tasks.Task<StoredLocation> AddLocationsAsync (StoredLocation location);

        /// <summary>
        /// Add Locations
        /// </summary>
        /// <remarks>
        /// Add a location to company
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<StoredLocation>> AddLocationsAsyncWithHttpInfo (StoredLocation location);
        /// <summary>
        /// Add Notes by Location
        /// </summary>
        /// <remarks>
        /// Adds a note to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of StoredLocation</returns>
        System.Threading.Tasks.Task<StoredLocation> AddNotesByLocationAsync (int? locationId, LocationNote note);

        /// <summary>
        /// Add Notes by Location
        /// </summary>
        /// <remarks>
        /// Adds a note to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<StoredLocation>> AddNotesByLocationAsyncWithHttpInfo (int? locationId, LocationNote note);
        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Soft deletes a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>Task of StoredLocation</returns>
        System.Threading.Tasks.Task<StoredLocation> DeleteLocationAsync (int? locationId);

        /// <summary>
        /// Delete Location
        /// </summary>
        /// <remarks>
        /// Soft deletes a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<StoredLocation>> DeleteLocationAsyncWithHttpInfo (int? locationId);
        /// <summary>
        /// Delete a Note by Location
        /// </summary>
        /// <remarks>
        /// Deletes a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of StoredLocation</returns>
        System.Threading.Tasks.Task<StoredLocation> DeleteNoteByLocationAsync (int? locationId, int? noteId);

        /// <summary>
        /// Delete a Note by Location
        /// </summary>
        /// <remarks>
        /// Deletes a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<StoredLocation>> DeleteNoteByLocationAsyncWithHttpInfo (int? locationId, int? noteId);
        /// <summary>
        /// Get Countries
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries for selection
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Countries</returns>
        System.Threading.Tasks.Task<Countries> GetCountriesAsync ();

        /// <summary>
        /// Get Countries
        /// </summary>
        /// <remarks>
        /// Get a list of supported countries for selection
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Countries)</returns>
        System.Threading.Tasks.Task<ApiResponse<Countries>> GetCountriesAsyncWithHttpInfo ();
        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets stored locations
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StoredLocations</returns>
        System.Threading.Tasks.Task<StoredLocations> GetLocationsAsync ();

        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets stored locations
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StoredLocations)</returns>
        System.Threading.Tasks.Task<ApiResponse<StoredLocations>> GetLocationsAsyncWithHttpInfo ();
        /// <summary>
        /// Get Providers Info By Location
        /// </summary>
        /// <remarks>
        /// Get Providers Info By Location ID
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of LocationProviders</returns>
        System.Threading.Tasks.Task<LocationProviders> GetProvidersByLocationIdAsync (int? locationId);

        /// <summary>
        /// Get Providers Info By Location
        /// </summary>
        /// <remarks>
        /// Get Providers Info By Location ID
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of ApiResponse (LocationProviders)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationProviders>> GetProvidersByLocationIdAsyncWithHttpInfo (int? locationId);
        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of StoredLocation</returns>
        System.Threading.Tasks.Task<StoredLocation> UpdateLocationAsync (int? locationId, StoredLocation location);

        /// <summary>
        /// Update Location
        /// </summary>
        /// <remarks>
        /// Updates a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<StoredLocation>> UpdateLocationAsyncWithHttpInfo (int? locationId, StoredLocation location);
        /// <summary>
        /// Update a Note by Location
        /// </summary>
        /// <remarks>
        /// Updates a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of StoredLocation</returns>
        System.Threading.Tasks.Task<StoredLocation> UpdateNoteByLocationAsync (int? locationId, LocationNote note, int? noteId);

        /// <summary>
        /// Update a Note by Location
        /// </summary>
        /// <remarks>
        /// Updates a note attached to a stored location
        /// </remarks>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        System.Threading.Tasks.Task<ApiResponse<StoredLocation>> UpdateNoteByLocationAsyncWithHttpInfo (int? locationId, LocationNote note, int? noteId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocationApi : ILocationApi
    {
        private FieldNation.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FieldNation.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationApi(Configuration configuration = null)
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
        /// Add Locations Add a location to company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>StoredLocation</returns>
        public StoredLocation AddLocations (StoredLocation location)
        {
             ApiResponse<StoredLocation> localVarResponse = AddLocationsWithHttpInfo(location);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Locations Add a location to company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        public ApiResponse< StoredLocation > AddLocationsWithHttpInfo (StoredLocation location)
        {
            // verify the required parameter 'location' is set
            if (location == null)
                throw new ApiException(400, "Missing required parameter 'location' when calling LocationApi->AddLocations");

            var localVarPath = "/locations";
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

            if (location != null && location.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(location); // http body (model) parameter
            }
            else
            {
                localVarPostBody = location; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Add Locations Add a location to company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of StoredLocation</returns>
        public async System.Threading.Tasks.Task<StoredLocation> AddLocationsAsync (StoredLocation location)
        {
             ApiResponse<StoredLocation> localVarResponse = await AddLocationsAsyncWithHttpInfo(location);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Locations Add a location to company
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredLocation>> AddLocationsAsyncWithHttpInfo (StoredLocation location)
        {
            // verify the required parameter 'location' is set
            if (location == null)
                throw new ApiException(400, "Missing required parameter 'location' when calling LocationApi->AddLocations");

            var localVarPath = "/locations";
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

            if (location != null && location.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(location); // http body (model) parameter
            }
            else
            {
                localVarPostBody = location; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Add Notes by Location Adds a note to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>StoredLocation</returns>
        public StoredLocation AddNotesByLocation (int? locationId, LocationNote note)
        {
             ApiResponse<StoredLocation> localVarResponse = AddNotesByLocationWithHttpInfo(locationId, note);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Notes by Location Adds a note to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        public ApiResponse< StoredLocation > AddNotesByLocationWithHttpInfo (int? locationId, LocationNote note)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->AddNotesByLocation");
            // verify the required parameter 'note' is set
            if (note == null)
                throw new ApiException(400, "Missing required parameter 'note' when calling LocationApi->AddNotesByLocation");

            var localVarPath = "/locations/{location_id}/notes";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
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
                Exception exception = ExceptionFactory("AddNotesByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Add Notes by Location Adds a note to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of StoredLocation</returns>
        public async System.Threading.Tasks.Task<StoredLocation> AddNotesByLocationAsync (int? locationId, LocationNote note)
        {
             ApiResponse<StoredLocation> localVarResponse = await AddNotesByLocationAsyncWithHttpInfo(locationId, note);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add Notes by Location Adds a note to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredLocation>> AddNotesByLocationAsyncWithHttpInfo (int? locationId, LocationNote note)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->AddNotesByLocation");
            // verify the required parameter 'note' is set
            if (note == null)
                throw new ApiException(400, "Missing required parameter 'note' when calling LocationApi->AddNotesByLocation");

            var localVarPath = "/locations/{location_id}/notes";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
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
                Exception exception = ExceptionFactory("AddNotesByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Delete Location Soft deletes a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>StoredLocation</returns>
        public StoredLocation DeleteLocation (int? locationId)
        {
             ApiResponse<StoredLocation> localVarResponse = DeleteLocationWithHttpInfo(locationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Location Soft deletes a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        public ApiResponse< StoredLocation > DeleteLocationWithHttpInfo (int? locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->DeleteLocation");

            var localVarPath = "/locations/{location_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Delete Location Soft deletes a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>Task of StoredLocation</returns>
        public async System.Threading.Tasks.Task<StoredLocation> DeleteLocationAsync (int? locationId)
        {
             ApiResponse<StoredLocation> localVarResponse = await DeleteLocationAsyncWithHttpInfo(locationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Location Soft deletes a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredLocation>> DeleteLocationAsyncWithHttpInfo (int? locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->DeleteLocation");

            var localVarPath = "/locations/{location_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Delete a Note by Location Deletes a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>StoredLocation</returns>
        public StoredLocation DeleteNoteByLocation (int? locationId, int? noteId)
        {
             ApiResponse<StoredLocation> localVarResponse = DeleteNoteByLocationWithHttpInfo(locationId, noteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Note by Location Deletes a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        public ApiResponse< StoredLocation > DeleteNoteByLocationWithHttpInfo (int? locationId, int? noteId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->DeleteNoteByLocation");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling LocationApi->DeleteNoteByLocation");

            var localVarPath = "/locations/{location_id}/notes/{note_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (noteId != null) localVarPathParams.Add("note_id", Configuration.ApiClient.ParameterToString(noteId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteNoteByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Delete a Note by Location Deletes a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of StoredLocation</returns>
        public async System.Threading.Tasks.Task<StoredLocation> DeleteNoteByLocationAsync (int? locationId, int? noteId)
        {
             ApiResponse<StoredLocation> localVarResponse = await DeleteNoteByLocationAsyncWithHttpInfo(locationId, noteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Note by Location Deletes a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredLocation>> DeleteNoteByLocationAsyncWithHttpInfo (int? locationId, int? noteId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->DeleteNoteByLocation");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling LocationApi->DeleteNoteByLocation");

            var localVarPath = "/locations/{location_id}/notes/{note_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (noteId != null) localVarPathParams.Add("note_id", Configuration.ApiClient.ParameterToString(noteId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteNoteByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Get Countries Get a list of supported countries for selection
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Countries</returns>
        public Countries GetCountries ()
        {
             ApiResponse<Countries> localVarResponse = GetCountriesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Countries Get a list of supported countries for selection
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Countries</returns>
        public ApiResponse< Countries > GetCountriesWithHttpInfo ()
        {

            var localVarPath = "/locations/countries";
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
                Exception exception = ExceptionFactory("GetCountries", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Countries>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Countries) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Countries)));
        }

        /// <summary>
        /// Get Countries Get a list of supported countries for selection
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Countries</returns>
        public async System.Threading.Tasks.Task<Countries> GetCountriesAsync ()
        {
             ApiResponse<Countries> localVarResponse = await GetCountriesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Countries Get a list of supported countries for selection
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Countries)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Countries>> GetCountriesAsyncWithHttpInfo ()
        {

            var localVarPath = "/locations/countries";
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
                Exception exception = ExceptionFactory("GetCountries", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Countries>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Countries) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Countries)));
        }

        /// <summary>
        /// Get Locations Gets stored locations
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StoredLocations</returns>
        public StoredLocations GetLocations ()
        {
             ApiResponse<StoredLocations> localVarResponse = GetLocationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Locations Gets stored locations
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StoredLocations</returns>
        public ApiResponse< StoredLocations > GetLocationsWithHttpInfo ()
        {

            var localVarPath = "/locations";
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
                Exception exception = ExceptionFactory("GetLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocations)));
        }

        /// <summary>
        /// Get Locations Gets stored locations
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StoredLocations</returns>
        public async System.Threading.Tasks.Task<StoredLocations> GetLocationsAsync ()
        {
             ApiResponse<StoredLocations> localVarResponse = await GetLocationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Locations Gets stored locations
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StoredLocations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredLocations>> GetLocationsAsyncWithHttpInfo ()
        {

            var localVarPath = "/locations";
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
                Exception exception = ExceptionFactory("GetLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocations)));
        }

        /// <summary>
        /// Get Providers Info By Location Get Providers Info By Location ID
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>LocationProviders</returns>
        public LocationProviders GetProvidersByLocationId (int? locationId)
        {
             ApiResponse<LocationProviders> localVarResponse = GetProvidersByLocationIdWithHttpInfo(locationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Providers Info By Location Get Providers Info By Location ID
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>ApiResponse of LocationProviders</returns>
        public ApiResponse< LocationProviders > GetProvidersByLocationIdWithHttpInfo (int? locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->GetProvidersByLocationId");

            var localVarPath = "/locations/{location_id}/providers";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProvidersByLocationId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LocationProviders>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationProviders) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationProviders)));
        }

        /// <summary>
        /// Get Providers Info By Location Get Providers Info By Location ID
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of LocationProviders</returns>
        public async System.Threading.Tasks.Task<LocationProviders> GetProvidersByLocationIdAsync (int? locationId)
        {
             ApiResponse<LocationProviders> localVarResponse = await GetProvidersByLocationIdAsyncWithHttpInfo(locationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Providers Info By Location Get Providers Info By Location ID
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location ID</param>
        /// <returns>Task of ApiResponse (LocationProviders)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationProviders>> GetProvidersByLocationIdAsyncWithHttpInfo (int? locationId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->GetProvidersByLocationId");

            var localVarPath = "/locations/{location_id}/providers";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProvidersByLocationId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LocationProviders>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationProviders) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationProviders)));
        }

        /// <summary>
        /// Update Location Updates a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>StoredLocation</returns>
        public StoredLocation UpdateLocation (int? locationId, StoredLocation location)
        {
             ApiResponse<StoredLocation> localVarResponse = UpdateLocationWithHttpInfo(locationId, location);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Location Updates a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        public ApiResponse< StoredLocation > UpdateLocationWithHttpInfo (int? locationId, StoredLocation location)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->UpdateLocation");
            // verify the required parameter 'location' is set
            if (location == null)
                throw new ApiException(400, "Missing required parameter 'location' when calling LocationApi->UpdateLocation");

            var localVarPath = "/locations/{location_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (location != null && location.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(location); // http body (model) parameter
            }
            else
            {
                localVarPostBody = location; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Update Location Updates a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of StoredLocation</returns>
        public async System.Threading.Tasks.Task<StoredLocation> UpdateLocationAsync (int? locationId, StoredLocation location)
        {
             ApiResponse<StoredLocation> localVarResponse = await UpdateLocationAsyncWithHttpInfo(locationId, location);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Location Updates a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="location">JSON payload</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredLocation>> UpdateLocationAsyncWithHttpInfo (int? locationId, StoredLocation location)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->UpdateLocation");
            // verify the required parameter 'location' is set
            if (location == null)
                throw new ApiException(400, "Missing required parameter 'location' when calling LocationApi->UpdateLocation");

            var localVarPath = "/locations/{location_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (location != null && location.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(location); // http body (model) parameter
            }
            else
            {
                localVarPostBody = location; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Update a Note by Location Updates a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>StoredLocation</returns>
        public StoredLocation UpdateNoteByLocation (int? locationId, LocationNote note, int? noteId)
        {
             ApiResponse<StoredLocation> localVarResponse = UpdateNoteByLocationWithHttpInfo(locationId, note, noteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Note by Location Updates a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>ApiResponse of StoredLocation</returns>
        public ApiResponse< StoredLocation > UpdateNoteByLocationWithHttpInfo (int? locationId, LocationNote note, int? noteId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->UpdateNoteByLocation");
            // verify the required parameter 'note' is set
            if (note == null)
                throw new ApiException(400, "Missing required parameter 'note' when calling LocationApi->UpdateNoteByLocation");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling LocationApi->UpdateNoteByLocation");

            var localVarPath = "/locations/{location_id}/notes/{note_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (noteId != null) localVarPathParams.Add("note_id", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateNoteByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

        /// <summary>
        /// Update a Note by Location Updates a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of StoredLocation</returns>
        public async System.Threading.Tasks.Task<StoredLocation> UpdateNoteByLocationAsync (int? locationId, LocationNote note, int? noteId)
        {
             ApiResponse<StoredLocation> localVarResponse = await UpdateNoteByLocationAsyncWithHttpInfo(locationId, note, noteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Note by Location Updates a note attached to a stored location
        /// </summary>
        /// <exception cref="FieldNation.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationId">Location id</param>
        /// <param name="note">Notes</param>
        /// <param name="noteId">Location note id</param>
        /// <returns>Task of ApiResponse (StoredLocation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredLocation>> UpdateNoteByLocationAsyncWithHttpInfo (int? locationId, LocationNote note, int? noteId)
        {
            // verify the required parameter 'locationId' is set
            if (locationId == null)
                throw new ApiException(400, "Missing required parameter 'locationId' when calling LocationApi->UpdateNoteByLocation");
            // verify the required parameter 'note' is set
            if (note == null)
                throw new ApiException(400, "Missing required parameter 'note' when calling LocationApi->UpdateNoteByLocation");
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling LocationApi->UpdateNoteByLocation");

            var localVarPath = "/locations/{location_id}/notes/{note_id}";
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

            if (locationId != null) localVarPathParams.Add("location_id", Configuration.ApiClient.ParameterToString(locationId)); // path parameter
            if (noteId != null) localVarPathParams.Add("note_id", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateNoteByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredLocation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredLocation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredLocation)));
        }

    }
}
