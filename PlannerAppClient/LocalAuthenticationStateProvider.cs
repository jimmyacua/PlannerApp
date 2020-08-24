using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using PlannerAppClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlannerAppClient
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {

        private readonly ILocalStorageService storageService;

        public LocalAuthenticationStateProvider(ILocalStorageService localStorage)
        {
            storageService = localStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if(await storageService.ContainKeyAsync("User"))
            {
                var userInfo = await storageService.GetItemAsync<LocalUserInfo>("User");
                var claims = new[]
                {
                    new Claim("Email", userInfo.Email),
                    new Claim("FirstName", userInfo.FirstName),
                    new Claim("LastName", userInfo.LastName),
                    new Claim("AccessToken", userInfo.AccessToken),
                    new Claim(ClaimTypes.NameIdentifier, userInfo.Id),
                };

                var identity = new ClaimsIdentity(claims, "BearerToken");
                var user = new ClaimsPrincipal(identity);
                var state = new AuthenticationState(user);
                NotifyAuthenticationStateChanged(Task.FromResult(state));
                return state;
            }

            return new AuthenticationState(new ClaimsPrincipal());

        }

        public async Task LogountAsync()
        {
            await storageService.RemoveItemAsync("User");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));
        }
    }

}
