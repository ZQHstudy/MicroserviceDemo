﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CommonLibrary;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Refit;

namespace HostWeb.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration { get; }
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["APIAccessToken"] = await GetApiAccessToken();

            ViewBag.ApiClaims = new Dictionary<string, string>();

            var callApi = RestService.For<ICallApi>(Configuration["ApiGatewayService:Url"],
              new RefitSettings() { AuthorizationHeaderValueGetter = GetApiAccessToken });
            List<RoleAssignmentModel> roleAssignments = await callApi.GetRoleAssignments();
            List<SelectListItem> ddlCurrentUserRolesitems = new List<SelectListItem>();
            foreach (var item in roleAssignments)
            {
                ddlCurrentUserRolesitems.Add(new SelectListItem { Text = item.ScopeName + " - " + item.RoleName, Value = item.ID.ToString() });
            }
           
            ViewData["ddlCurrentUserRoles"] = ddlCurrentUserRolesitems;


            return View();
        }

        
        private async Task<string> GetApiAccessToken()
        {
            var access_token = await HttpContext.GetTokenAsync("access_token");
            JwtSecurityToken jwtSecurityToken = (new JwtSecurityTokenHandler()).ReadToken(access_token) as JwtSecurityToken;
            var apiAccess_token = jwtSecurityToken.Claims.First(claim => claim.Type == "general_access_token").Value;
            return apiAccess_token;
        }




        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }

        public async Task<IActionResult> GetApiClaims()
        {
            var callTestApi = RestService.For<ICallApi>(Configuration["ApiGatewayService:Url"],
               new RefitSettings() { AuthorizationHeaderValueGetter = GetApiAccessToken });
            var dic = await callTestApi.GetApiClaims();
            ViewBag.ApiClaims = dic;
            return View("Index");
        }

    }

    public interface ICallApi
    {
        [Get("/ProductService/values/getuserclaims")]
        [Headers("Authorization: Bearer")]
        Task<Dictionary<string, string>> GetApiClaims();

        [Get("/PermissionService/getpermission/roleassignments/")]
        [Headers("Authorization: Bearer")]
        Task<List<RoleAssignmentModel>> GetRoleAssignments();

    }

    public class RoleAssignmentModel : BaseModel
    {
        public string PrincipalCode { get; set; }
        public string PrincipalName { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public string ScopeCode { get; set; }
        public string FullScopeCode { get; set; }
        public string ScopeName { get; set; }
        public int SortNO { get; set; }

    }
}