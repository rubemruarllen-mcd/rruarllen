#pragma checksum "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e8cf36aa6d2050fd491f584e838eab0bd722472"
// <auto-generated/>
#pragma warning disable 1591
namespace Matrix.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Matrix.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Matrix.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 3 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "AdditionalAssemblies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Reflection.Assembly>>(
#nullable restore
#line 4 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor"
                               lazyLoadedAssemblies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnNavigateAsync", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Routing.NavigationContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Routing.NavigationContext>(this, 
#nullable restore
#line 5 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor"
                          OnNavigationAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(5);
                __builder2.AddAttribute(6, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 8 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(9);
                __builder2.AddAttribute(10, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 11 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "<p>Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Clone\NPOSTRAN2-7471\NewWay\Matrix.UI\Matrix.UI\App.razor"
       

    private List<Assembly> lazyLoadedAssemblies = new List<Assembly>();

    private async Task OnNavigationAsync(NavigationContext ctx)
    {
        var assemblies = await assemblyLoader.LoadAssembliesAsync(
            new List<string>() { "QuantityComponents.dll", "MenuComponents.dll" }
            );
        lazyLoadedAssemblies.AddRange(assemblies);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LazyAssemblyLoader assemblyLoader { get; set; }
    }
}
#pragma warning restore 1591
