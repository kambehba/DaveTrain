#pragma checksum "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c78ea07317186fbb489b9612891cdd820eafc2cb"
// <auto-generated/>
#pragma warning disable 1591
namespace DaveTrain.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using DaveTrain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\_Imports.razor"
using DaveTrain.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
using DaveTrain.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
using FireSharp.Config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
using FireSharp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
using FireSharp.Response;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/destination")]
    public class DestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3 class=\"g11\">Passenger:</h3>\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "g12");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 11 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
         for (int i = 0; i < _passengers.Count; i++)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 13 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
                            _passengers[i].Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, 
#nullable restore
#line 13 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
                                                  _passengers[i].Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 14 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.AddMarkupContent(14, "<h3 class=\"g14\">Destination:</h3>\r\n    ");
            __builder.OpenElement(15, "select");
            __builder.AddAttribute(16, "class", "g15");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
                               _selectdDestination.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _selectdDestination.Id = __value, _selectdDestination.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 19 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
         for (int i = 0; i < _destinations.Count; i++)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 21 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
                            _destinations[i].Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 21 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
                                                  _destinations[i].Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 22 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "g16 btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
                                             OnSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n        Submit\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
       

    IFirebaseClient client;

    private List<Passenger> _passengers;
    private List<Destination> _destinations;

    private Passenger _passenger = new Passenger();
    private Destination _destination = new Destination();

    private Destination _selectdDestination = new Destination();
    

    IFirebaseConfig config = new FirebaseConfig
    {
        AuthSecret = "II3bycCtijU0NplKxY7HoJ1e8YLtIY92PRYHdBRu",
        BasePath = "https://dazzling-torch-8270.firebaseio.com/"
    };

    protected override void OnInitialized()
    {
        _passengers = new List<Passenger>();
        _destinations = new List<Destination>();
        
        PopulatePassengersAndDestinations();

        client = new FireSharp.FirebaseClient(config);



    }


    private void OnSubmit()
    {
       
        var ww = client.Get("DavesTrain/destinations/" + _selectdDestination.Id + "/vote");
        int jj = ww.ResultAs<int>();
        jj = jj + 1;
        client.Set("DavesTrain/destinations/" + _selectdDestination.Id + "/vote", jj);

        var fd = client.Get("DavesTrain/destinations/").ResultAs<List<DestinationModel>>();

        Winner.Name = fd[0].name;

         NavigationManager.NavigateTo("/");

    }

    private void PopulatePassengersAndDestinations()
    {
        _passengers.Add(new Passenger() { Name = "Dave", Id = 1 });

        _passengers.Add(new Passenger() { Name = "Ben", Id = 2 });

        _passengers.Add(new Passenger() { Name = "Kam", Id = 3 });

        _passengers.Add(new Passenger() { Name = "Steve", Id = 4 });

        _passengers.Add(new Passenger() { Name = "Bart", Id = 5 });

        _destinations.Add(new Destination() { Name = "Cheddar's", Id = 1 });

        _destinations.Add(new Destination() { Name = "Fire House", Id = 2 });

        _destinations.Add(new Destination() { Name = "Chick-fil-A", Id = 3 });

        _destinations.Add(new Destination() { Name = "PDQ", Id = 4 });

        _destinations.Add(new Destination() { Name = "4 Rivers", Id = 5 });


    }

    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
