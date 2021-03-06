// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace QuantityComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\_Imports.razor"
using QuantityComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\Render.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\Render.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\Render.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\Render.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\Render.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    public partial class Render : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Clone\NPOSTRAN2-7471\NewWay\QuantityComponents\QuantityComponents\Render.razor"
       

        readonly List<RenderFragment> _components = new List<RenderFragment>();
   
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await AddJavaScript();
            var components = await JsRuntime.InvokeAsync<string>("GetRequest", "https://localhost:5001/api/v1/Components/GetQuantityComponents");
            var componentsJObj = JsonConvert.DeserializeObject<QuantityRazor>(components);

            foreach (ComponentParameter component in componentsJObj.ComponentParameters)
            {
                AddNewCompent(component);
            }

            await JsRuntime.InvokeVoidAsync("ReplaceUIbyQuantity", componentsJObj);
        };

    }

    public async Task AddJavaScript()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var str = assembly.GetManifestResourceStream("QuantityComponents.wwwroot.QuantityReplaceUI.js");
        var sr = new StreamReader(str, Encoding.ASCII);
        await JsRuntime.InvokeVoidAsync("eval", sr.ReadToEnd());

    }

    public void AddNewCompent(ComponentParameter component)
    {
        _components.Add((builder) =>
        {

            builder.OpenComponent(0, typeof(BtnQuantity));
            builder.AddAttribute(1, component.ParameterName, component.ParameterValue);
            builder.AddAttribute(1, "Id", component.Id);
            if (component.ParameterColor != null)
            {
                builder.AddAttribute(1, "Color", component.ParameterColor);
            }
            builder.CloseComponent();
        });
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
