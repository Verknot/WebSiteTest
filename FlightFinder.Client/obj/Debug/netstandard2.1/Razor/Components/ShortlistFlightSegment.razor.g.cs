#pragma checksum "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c3e2ec99ac5a8eeae3bae4db1fc1717f79d9003975e8b4a0d37c4f821561e86a"
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
    public partial class ShortlistFlightSegment : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "date");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h4");
#nullable restore
#line 2 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor"
__builder.AddContent(4, Flight.DepartureTime.ToString("ddd MMM d"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
#nullable restore
#line 3 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor"
__builder.AddContent(6, Flight.TicketClass.ToDisplayString());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "departure");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "h4");
#nullable restore
#line 7 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor"
__builder.AddContent(13, Flight.DepartureTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
#nullable restore
#line 8 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor"
__builder.AddContent(15, Flight.FromAirportCode);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.AddMarkupContent(18, "<div class=\"arrow\">➝</div>\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "return");
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "h4");
#nullable restore
#line 14 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor"
__builder.AddContent(23, Flight.ReturnTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
#nullable restore
#line 15 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor"
__builder.AddContent(25, Flight.ToAirportCode);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Alex\RiderProjects\samples\samples\aspnetcore\blazor\FlightFinder\FlightFinder.Client\Components\ShortlistFlightSegment.razor"
 
    [Parameter]
    public FlightSegment Flight { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
