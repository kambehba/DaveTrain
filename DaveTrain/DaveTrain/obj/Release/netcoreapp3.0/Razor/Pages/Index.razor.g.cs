#pragma checksum "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbbcb0bd3e0da83083e2f7f147bd2ab39a60b654"
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
#line 2 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
using DaveTrain.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h1 class=\"g0\">Dave\'s Train</h1>\r\n    ");
            __builder.OpenElement(4, "h1");
            __builder.AddAttribute(5, "class", "g2");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                    currentWeekDay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "h3");
            __builder.AddAttribute(9, "class", "g3");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                    currentMonth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.AddMarkupContent(12, "<h3 class=\"g4\">Select Your Name:</h3>\r\n    ");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "class", "g5");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                              AppData.PassengerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppData.PassengerId = __value, AppData.PassengerId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(17, "\r\n        \r\n        ");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", "0");
            __builder.AddContent(20, 
#nullable restore
#line 16 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                         string.Empty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
         for (int i = 0; i < _passengers.Count; i++)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 20 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                            _passengers[i].Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, 
#nullable restore
#line 20 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                                                _passengers[i].Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 21 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "g6 btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                                            GoToDest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\r\n        Start\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "g7 b1 btn-warning");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
                                                ResetAllVotes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\r\n        Reset\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\Index.razor"
      


    private DateClient _dateClient;
    private string currentWeekDay;
    private string currentMonth;
    private List<PassengerModel> _passengers;
    private string selectedPassenger;
    protected override async Task OnInitializedAsync()
    {

        // result = await _dateClient.Client.GetStringAsync("http://worldclockapi.com/api/json/est/now");

    }




    protected override void OnInitialized()
    {



        AppData.PassengerId = -1;
        //_dateClient = DateClient;

        //if (string.IsNullOrEmpty(Winner.Name)) Winner.Name = PassengerService.GetWinner();

        //var dateTime = DateTime.Now;
        //currentWeekDay = dateTime.DayOfWeek.ToString();
        //currentMonth = DateTime.Now.ToString("MMMM") + " " + DateTime.Now.ToString("dd") + ", " + DateTime.Now.ToString("yyyy");

        //NavigationManager.LocationChanged += OnLocationChanges;

        _dateClient = DateClient;
        _passengers = new List<PassengerModel>();
        _passengers = passengerService.GetAllPassengers();

        var dateTime = DateTime.Now;
        currentWeekDay = dateTime.DayOfWeek.ToString();
        currentMonth = DateTime.Now.ToString("MMMM") + " " + DateTime.Now.ToString("dd") + ", " + DateTime.Now.ToString("yyyy");

        NavigationManager.LocationChanged += OnLocationChanges;

        AppData.PassengerId = 0;





    }


    //protected override void OnInitialized()
    //{

    //    Task j = GetDateAsync();

    //}
    // string hh = "strff";


    //private async Task GetDateAsync()
    //{
    //    //var response = await Http.GetStringAsync("http://worldclockapi.com/api/json/est/now");
    //    //hh = response;

    //   // var hh = await Http.GetAsync("http://worldclockapi.com/api/json/est/now");
    //}



    //public static class ApiHelper
    //{
    //    public static HttpClient ApiClient { get; set; }

    //    public static void IntitializeClient()
    //    {
    //        ApiClient = new HttpClient();
    //        ApiClient.DefaultRequestHeaders.Accept.Clear();
    //        ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    //    }
    //}

    private string GetMonthByNumber(string n)
    {
        string month = string.Empty;

        return month;
    }

    private void GoToDest()
    {

        NavigationManager.NavigateTo("/destination");


    }

    private void ResetAllVotes()
    {
        destinationService.ResetAllVotes();


    }



    private void OnLocationChanges(object sender, LocationChangedEventArgs e)
    {
        var kk = AppData.Winner;

        StateHasChanged();
    }



    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Isvoted { get; set; }
        public DayOfWeek Day { get; set; }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DestinationService destinationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService passengerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DateClient DateClient { get; set; }
    }
}
#pragma warning restore 1591
