#pragma checksum "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c723f74ef2a3f5c9ee0864f2aecc62eb0838fb922e6f35a8fbf5eb12252a6fe2"
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
    public partial class SearchResultFlightSegment : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "symbol");
            __builder.AddMarkupContent(2, "\r\n    ");
#nullable restore
#line 2 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(3, Symbol);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "airline");
            __builder.AddMarkupContent(8, "\r\n    ");
#nullable restore
#line 6 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(9, Flight.Airline);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "small");
#nullable restore
#line 7 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(12, Flight.TicketClass.ToDisplayString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "departure");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "h4");
#nullable restore
#line 11 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(19, Flight.DepartureTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
#nullable restore
#line 12 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(21, Flight.DepartureTime.ToString("ddd MMM d"));

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, " (");
#nullable restore
#line 12 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(23, Flight.FromAirportCode);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, ")\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.AddMarkupContent(26, "<div class=\"arrow\">➝</div>\r\n\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "return");
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "h4");
#nullable restore
#line 18 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(31, Flight.ReturnTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
#nullable restore
#line 19 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(33, Flight.ReturnTime.ToString("ddd MMM d"));

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, " (");
#nullable restore
#line 19 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(35, Flight.ToAirportCode);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, ")\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "duration");
            __builder.AddMarkupContent(40, "\r\n    ");
#nullable restore
#line 23 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
__builder.AddContent(41, Flight.DurationHours);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, " hours\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\SearchResultFlightSegment.razor"
 
    [Parameter]
    public string Symbol { get; set; }

    [Parameter]
    public FlightSegment Flight { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591