// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Testes_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Testes_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\_Imports.razor"
using Testes_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Index.razor"
using Testes_1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Index.razor"
using Testes_1.Services.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Index.razor"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Index.razor"
using CNProjetos.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Index.razor"
 
    public static IList<cliente> clienteLista = new List<cliente>();

    public static string pesquisar = "";
    
    protected override async Task OnInitializedAsync()
    {
        clienteLista = await clienteService.Get();
    }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService clienteService { get; set; }
    }
}
#pragma warning restore 1591
