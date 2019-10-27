#pragma checksum "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\ResultComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9bbb1531d759053271346a39ff9f44f3d46bc0c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\ResultComponent.razor"
using DaveTrain.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\ResultComponent.razor"
using FireSharp.Config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\ResultComponent.razor"
using FireSharp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\ResultComponent.razor"
using FireSharp.Response;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/result")]
    public class ResultComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\ResultComponent.razor"
       

    IFirebaseClient client;
    Dispatcher dd;

    private List<DestinationModel> _destinations;
    private List<PassengerModel> _passengers;

    private Destination _destination = new Destination();

    private Destination _selectdDestination = new Destination();


    IFirebaseConfig config = new FirebaseConfig
    {
        AuthSecret = "II3bycCtijU0NplKxY7HoJ1e8YLtIY92PRYHdBRu",
        BasePath = "https://dazzling-torch-8270.firebaseio.com/"
    };

    protected override void OnInitialized()
    {
        

        client = new FireSharp.FirebaseClient(config);

        _destinations = new List<DestinationModel>();
        _destinations = client.Get("DavesTrain/destinations/").ResultAs<List<DestinationModel>>();

        //   PopulatePassengersAndDestinations();

        _passengers = passengerService.GetAllPassengers();

        destinationService.DataUpdated += OnDataUpdated;
          AppData.Winner = destinationService.GetWinner();
    }


    private void OnSubmit()
    {

        var ww = client.Get("DavesTrain/destinations/" + _selectdDestination.Id + "/vote");
        int jj = ww.ResultAs<int>();
        jj = jj + 1;
        client.Set("DavesTrain/destinations/" + _selectdDestination.Id + "/vote", jj);

        // _destinations = client.Get("DavesTrain/destinations/").ResultAs<List<DestinationModel>>();


        //  var f = fd.OrderByDescending(x=>x.vote);
        //var gg = fd.Max(x => x.vote);
        DestinationModel maxItem = _destinations.OrderByDescending(obj => obj.vote).First();

        AppData.Winner = destinationService.GetWinner(); //maxItem.name;

        NavigationManager.NavigateTo("/result");

    }

    private void OnDataUpdated(object sender,EventArgs e)
    {
         AppData.Winner = destinationService.GetWinner();

        //dd.InvokeAsync(new Action(()=> { this.StateHasChanged(); }));

        //base.InvokeAsync(StateHasChanged);
        NavigationManager.NavigateTo("/");
         NavigationManager.NavigateTo("/result");

         destinationService.DataUpdated -= OnDataUpdated;
    }

 

    private void PopulatePassengersAndDestinations()
    {
        //_passengers.Add(new Passenger() { Name = "Dave", Id = 1 });

        //_passengers.Add(new Passenger() { Name = "Ben", Id = 2 });

        //_passengers.Add(new Passenger() { Name = "Kam", Id = 3 });

        //_passengers.Add(new Passenger() { Name = "Steve", Id = 4 });

        //_passengers.Add(new Passenger() { Name = "Bart", Id = 5 });

        //_destinations.Add(new Destination() { Name = "Little Greek", Id = 0 });

        //_destinations.Add(new Destination() { Name = "Cheddar's", Id = 1 });

        //_destinations.Add(new Destination() { Name = "Fire House", Id = 2 });

        //_destinations.Add(new Destination() { Name = "Chick-fil-A", Id = 3 });

        //_destinations.Add(new Destination() { Name = "Lazy Moon", Id = 4 });

        //_destinations.Add(new Destination() { Name = "Chipotle", Id = 5 });


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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DestinationService destinationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService passengerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
