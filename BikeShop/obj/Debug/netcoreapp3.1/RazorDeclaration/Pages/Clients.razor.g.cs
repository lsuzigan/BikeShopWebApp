#pragma checksum "C:\my-codes\BikeShop\BikeShop\Pages\Clients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76cf1847e8eda68e7d9d1b5b069b4502e5732660"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BikeShop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using BikeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\my-codes\BikeShop\BikeShop\_Imports.razor"
using BikeShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\my-codes\BikeShop\BikeShop\Pages\Clients.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\my-codes\BikeShop\BikeShop\Pages\Clients.razor"
using BikeShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\my-codes\BikeShop\BikeShop\Pages\Clients.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\my-codes\BikeShop\BikeShop\Pages\Clients.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/client")]
    public partial class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\my-codes\BikeShop\BikeShop\Pages\Clients.razor"
        
    List<Client> allClients;

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from client;";
        allClients = await _db.LoadData<Client, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _db { get; set; }
    }
}
#pragma warning restore 1591
