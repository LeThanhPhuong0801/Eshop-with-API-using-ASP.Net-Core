#pragma checksum "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352f5cc864f04ea6e89ac589293eafe90580b898"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdmin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.JavaScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Web\eShopOnWeb\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : BlazorAdmin.Helpers.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>Admin</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 9 "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "admin");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "manage/my-account");
                __builder2.AddAttribute(37, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor"
                                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n                        <span class=\"oi oi-person\" aria-hidden=\"true\"></span>                         ");
                    __builder3.AddContent(40, 
#nullable restore
#line 20 "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor"
                                                                                                       context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(41, "\r\n\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "li");
                __builder2.AddAttribute(45, "class", "nav-item px-3");
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
                __builder2.AddAttribute(48, "class", "nav-link");
                __builder2.AddAttribute(49, "href", "logout");
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "\r\n                            <span class=\"oi oi-account-logout\" aria-hidden=\"true\"></span> Logout\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\Web\eShopOnWeb\src\BlazorAdmin\Shared\NavMenu.razor"
       

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
