#pragma checksum "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e87fa9bc8aeb025324e3e8a4b865d7830b1dcec"
// <auto-generated/>
#pragma warning disable 1591
namespace personal_website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using personal_website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mike\dev\personal-website-blazor\_Imports.razor"
using personal_website.Shared;

#line default
#line hidden
#nullable disable
    public partial class TimelineElement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "flex flex-col");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 2 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
     foreach (var Event in Events)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "flex flex-row");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "flex-initial w-1/6 bg-gray-300");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "flex flex-row w-full h-full");
            __builder.AddMarkupContent(12, "\r\n                    <div class=\"w-2/12\"></div>\r\n                    <div class=\"w-1/12 bg-black\"></div>\r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "w-9/12");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
                         if (Event.Date.Month == 1 && Event.Date.Day == 1) 
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                            ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, 
#nullable restore
#line 12 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
                                Event.Date.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 13 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
                 if (Event.Date.Month == 1 && Event.Date.Day == 1) 
                {
                    // Display dot and year
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenComponent<personal_website.Pages.Card>(25);
            __builder.AddAttribute(26, "Event", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TimelineEvent>(
#nullable restore
#line 22 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
                          Event

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 24 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Mike\dev\personal-website-blazor\Pages\TimelineElement.razor"
       
    [Parameter]
    public TimelineEvent[] Events { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
