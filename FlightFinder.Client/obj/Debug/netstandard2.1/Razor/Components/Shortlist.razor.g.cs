#pragma checksum "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a48f69b608f08ae7cd8b8efdaa241c6c676676372542ac933f839f14828e1f3f"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightFinder.Client.Components
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using FlightFinder.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using FlightFinder.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\_Imports.razor"
using FlightFinder.Shared;

#line default
#line hidden
#nullable disable
    public partial class Shortlist : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, "Shortlist (");
#nullable restore
#line 1 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
__builder.AddContent(2, Itineraries.Count);

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
 foreach (var item in Itineraries)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "list-group mb-4");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "list-group-item justify-content-between");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "nobr");
#nullable restore
#line 8 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
__builder.AddContent(15, item.Outbound.FromAirportCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, " -\r\n                ");
            __builder.OpenElement(17, "nobr");
#nullable restore
#line 9 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
__builder.AddContent(18, item.Outbound.ToAirportCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "close");
            __builder.AddAttribute(24, "aria-label", "Close");
            __builder.AddAttribute(25, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
                                                                             () => OnRemoveItinerary.InvokeAsync(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, "<span aria-hidden=\"true\">&times;</span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "list-group-item");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenComponent<global::FlightFinder.Client.Components.ShortlistFlightSegment>(33);
            __builder.AddAttribute(34, "Flight", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FlightFinder.Shared.FlightSegment>(
#nullable restore
#line 16 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
                                            item.Outbound

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "list-group-item");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenComponent<global::FlightFinder.Client.Components.ShortlistFlightSegment>(40);
            __builder.AddAttribute(41, "Flight", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FlightFinder.Shared.FlightSegment>(
#nullable restore
#line 19 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
                                            item.Return

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "list-group-item d-flex justify-content-between align-items-center py-2");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "airline");
            __builder.OpenElement(49, "h4");
#nullable restore
#line 22 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
__builder.AddContent(50, item.AirlineName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "price");
            __builder.OpenElement(54, "h2");
#nullable restore
#line 23 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
__builder.AddContent(55, item.Price.ToString("$0"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 26 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\Shortlist.razor"
 
    [Parameter]
    public IReadOnlyList<Itinerary> Itineraries { get; set; }

    [Parameter]
    public EventCallback<Itinerary> OnRemoveItinerary { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
