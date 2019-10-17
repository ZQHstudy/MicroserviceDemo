﻿using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{

    public interface ICallAuthServiceApi
    {
        [Post("/AuthService/account/userlogin")]
        [Headers("Authorization: Bearer")]
        Task<CurrentUserInfo> UserLogin([Body] UserLoginRequest request);

        [Get("/AuthService/account/getroles/{principalCode}")]
        [Headers("Authorization: Bearer")]
        Task<List<RoleAssignmentModel>> GetRoleAssignments(string principalCode);

        [Get("/AuthService/account/getpermission/{principalID}")]
        [Headers("Authorization: Bearer")]
        Task<CurrentUserPermission> GetPermission(Guid principalID);
    }



    public class CallAuthServiceApi : ICallAuthServiceApi
    {
        public IConfiguration Configuration { get; }
        private readonly IHttpClientFactory _httpClientFactory;
        public CallAuthServiceApi(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            Configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        private async Task<string> GetTokenEndpoint()
        {
            HttpClient client = _httpClientFactory.CreateClient();
            var disco = await client.GetDiscoveryDocumentAsync(Configuration["IdentityService:Authority"]);
            if (disco.IsError)
            {
                throw new Exception(disco.Error);
            }
            return disco.TokenEndpoint;
        }
        private async Task<string> GetAuthServiceApiToken()
        {
            // request token
            HttpClient client = _httpClientFactory.CreateClient();
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = await GetTokenEndpoint(),
                ClientId = "AuthApiClient",
                ClientSecret = "P@ssw0rd",
                Scope = "AuthServiceApi"
            });

            if (tokenResponse.IsError)
            {
                throw new Exception(tokenResponse.Error + " " + tokenResponse.ErrorDescription);
            }

            return tokenResponse.AccessToken;
        }

        private ICallAuthServiceApi callAuthServiceApi {
            get {
                return RestService.For<ICallAuthServiceApi>(Configuration["ApiGatewayService:Url"],
                    new RefitSettings() { AuthorizationHeaderValueGetter = GetAuthServiceApiToken });
            }
        }

        public async Task<CurrentUserInfo> UserLogin(UserLoginRequest userLoginRequest)
        { 
            return await callAuthServiceApi.UserLogin(userLoginRequest);
        }

        public async Task<List<RoleAssignmentModel>> GetRoleAssignments(string principalCode)
        {
            return await callAuthServiceApi.GetRoleAssignments(principalCode);
        }

        public async Task<CurrentUserPermission> GetPermission(Guid principalID)
        {
            return await callAuthServiceApi.GetPermission(principalID);
        }
    }

    public class UserLoginRequest
    {
        public string UserCode { get; set; }
        public string UserPassword { get; set; }
    }

}
