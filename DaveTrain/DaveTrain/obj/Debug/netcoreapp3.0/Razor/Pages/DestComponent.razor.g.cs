#pragma checksum "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf5dabd28eae8530274fe4749d9b9426b23a164"
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
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "Kam");
            __builder.AddContent(9, "Kam");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", "Dave");
            __builder.AddContent(13, "Dave");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "Ben");
            __builder.AddContent(17, "Ben");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "Steve");
            __builder.AddContent(21, "Audi");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.AddMarkupContent(24, "<h3 class=\"g14\">Destination:</h3>\r\n    ");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "class", "g15");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "ChickFla");
            __builder.AddContent(30, "ChickFla");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "Subway");
            __builder.AddContent(34, "Subway");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "Chedders");
            __builder.AddContent(38, "Chedders");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "Chipotle");
            __builder.AddContent(42, "Chipotle");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "g16 btn-danger");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
                                             OnSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "\r\n        Submit\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Kam\Documents\GitHub\DaveTrain\DaveTrain\DaveTrain\Pages\DestComponent.razor"
       

    private void OnSubmit()
    {
         NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
