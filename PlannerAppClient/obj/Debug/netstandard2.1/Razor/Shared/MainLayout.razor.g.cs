#pragma checksum "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e87ba833ac3ca80b1c623430a848a275a97b10"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerAppClient.Shared
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
#nullable restore
#line 17 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\_Imports.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<PlannerAppClient.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<PlannerAppClient.Shared.UserStatus>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.AddContent(18, 
#nullable restore
#line 13 "C:\Users\datacostarica\source\repos\PlannerAppClient\PlannerAppClient\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
