// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
