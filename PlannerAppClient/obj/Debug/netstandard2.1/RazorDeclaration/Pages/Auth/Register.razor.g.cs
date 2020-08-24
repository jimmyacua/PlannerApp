#pragma checksum "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\Pages\Auth\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5127ab6607b59569e9b910c8a6d95e5d2cb11a1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PlannerAppClient.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using PlannerAppClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using PlannerAppClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using PlannerAppShared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using PlannerAppShared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\Pages\Auth\Register.razor"
       
    RegisterRequest model = new RegisterRequest();
    bool isBusy = false;
    string message = string.Empty;
    PlannerAppClient.Models.AlertMessageType messageType = Models.AlertMessageType.Success;

    public async Task registerUser()
    {
        isBusy = true;

        var result = await authService.RegisterUserAsync(model);
        if (result.IsSuccess)
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Success;
        }
        else
        {
            message = result.Errors.FirstOrDefault() ?? result.Message;
            messageType = Models.AlertMessageType.Error;
        }
        isBusy = false;
        navigationManager.NavigateTo("/home");

    }

    public void goToLogin()
    {
        navigationManager.NavigateTo("/auth/login");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
