﻿using Moralis.SolanaApi.Client;
using Moralis.SolanaApi.Interfaces;
using Moralis.SolanaApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Moralis.SolanaApi.Api
{
    public class NftApi : INftApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NativeApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		/// <returns></returns>
		public NftApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="NativeApi"/> class.
		/// </summary>
		/// <returns></returns>
		public NftApi(String basePath)
		{
			this.ApiClient = new ApiClient(basePath);
		}

		/// <summary>
		/// Sets the base path of the API client.
		/// </summary>
		/// <param name="basePath">The base path</param>
		/// <value>The base path</value>
		public void SetBasePath(String basePath)
		{
			this.ApiClient.BasePath = basePath;
		}

		/// <summary>
		/// Gets the base path of the API client.
		/// </summary>
		/// <param name="basePath">The base path</param>
		/// <value>The base path</value>
		public String GetBasePath(String basePath)
		{
			return this.ApiClient.BasePath;
		}

		/// <summary>
		/// Gets or sets the API client.
		/// </summary>
		/// <value>An instance of the ApiClient</value>
		public ApiClient ApiClient { get; set; }


		public async Task<NftMetadata> GetNFTMetadata(NetworkTypes network, string address)
        {
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetNFTMetadata");

			var headerParams = new Dictionary<String, String>();

			var path = "/nft/{network}/{address}/metadata";
			path = path.Replace("{" + "network" + "}", ApiClient.ParameterToString(network.ToString()));
			path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			//IRestResponse response = (IRestResponse)(await ApiClient.CallApi(path, Method.GET, null, null, headerParams, null, null, authSettings));
			HttpResponseMessage response = await ApiClient.CallApi(path, HttpMethod.Get, null, headerParams, null, authSettings);

			if (((int)response.StatusCode) >= 400)
				throw new ApiException((int)response.StatusCode, "Error calling GetNFTMetadata: " + response.Content, response.Content);
			else if (((int)response.StatusCode) == 0)
				throw new ApiException((int)response.StatusCode, "Error calling GetNFTMetadata: " + response.ReasonPhrase, response.ReasonPhrase);

			return (NftMetadata)(await ApiClient.Deserialize(response.Content, typeof(NftMetadata), response.Headers)) ;
		}
	}
}
