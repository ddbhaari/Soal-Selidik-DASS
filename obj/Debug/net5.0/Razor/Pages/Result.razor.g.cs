#pragma checksum "/Users/user/Desktop/Coding Project/dassproject/Pages/Result.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d137451d7b2934cec5b823f3d07c07a67314e37d"
// <auto-generated/>
#pragma warning disable 1591
namespace dassProjectBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using dassProjectBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using dassProjectBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/result/{tahapAnzieti}/{tahapStress}/{tahapKemurungan}")]
    public partial class Result : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!doctype html>\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "en");
            __builder.AddMarkupContent(3, "<head><title>Kaji Selidik DASS</title></head>\n\n");
            __builder.OpenElement(4, "body");
            __builder.AddMarkupContent(5, @"<style>
        .custom-form {
            background-color: E4D6D2;
        }

        .carousel .carousel-item {
            max-height: 550px;
        }

        .carousel-item img {
            object-fit: cover;
            max-height: 550px;
        }

        .carousel-inner img {
            margin: auto;
        }

        p {
            display: flex;
            margin: auto;
            align-items: center;
            justify-content: center;
        }
    </style>

    ");
            __builder.AddMarkupContent(6, "<div class=\"text-center p-5\" style=\"background-color: #E4D6D2;\"><h1>Keputusan</h1></div>\n\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid h-100 d-flex flex-column border bg-light");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row flex-grow-1");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-4 p-3  bg-light");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "Anzieti = ");
            __builder.AddContent(15, 
#nullable restore
#line 45 "/Users/user/Desktop/Coding Project/dassproject/Pages/Result.razor"
                              tahapAnzieti

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n            \n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-sm-4 p-3  bg-light");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Stress = ");
            __builder.AddContent(21, 
#nullable restore
#line 50 "/Users/user/Desktop/Coding Project/dassproject/Pages/Result.razor"
                             tahapStress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n\n            \n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-sm-4 p-3  bg-light");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Kemurungan = ");
            __builder.AddContent(27, 
#nullable restore
#line 55 "/Users/user/Desktop/Coding Project/dassproject/Pages/Result.razor"
                                 tahapKemurungan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n\n\n        ");
            __builder.AddMarkupContent(29, @"<div id=""carouselExampleIndicators"" class=""carousel slide border"" data-ride=""carousel""><ol class=""carousel-indicators""><li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li></ol>
            <div class=""carousel-inner""><div class=""carousel-item  active""><img class=""d-block w-50"" src=""/gambar1.jpeg"" alt></div>
                <div class=""carousel-item""><img class=""d-block w-50"" src=""/gambar2.jpeg"" alt></div>
                <div class=""carousel-item""><img class=""d-block w-50"" src=""/gambar3.jpeg"" alt></div>
                <div class=""carousel-item""><img class=""d-block w-50"" src=""/gambar4.jpeg"" alt></div></div>
            <a id=""carouselExampleIndicators-prev"" class=""carousel-control-prev"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""false""></span>
                <span class=""sr-only"">Previous</span></a>
            <a id=""carouselExampleIndicators-next"" class=""carousel-control-next"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""false""></span>
                <span class=""sr-only"">Next</span></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "/Users/user/Desktop/Coding Project/dassproject/Pages/Result.razor"
       
    [Parameter]
    public string tahapAnzieti { get; set; }

    [Parameter]
    public string tahapStress { get; set; }

    [Parameter]
    public string tahapKemurungan { get; set; }

    int currentCount = 0;
    bool firstRender = true;

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await
            JsRuntime.InvokeAsync<object>("initializeCarousel"); firstRender = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591