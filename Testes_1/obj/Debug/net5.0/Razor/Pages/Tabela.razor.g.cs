#pragma checksum "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15480a99fdd4f9f2a9012caf4ec57bf06a72b6a"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
using Testes_1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
using Testes_1.Services.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
using CNProjetos.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tabela")]
    public partial class Tabela : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Tabela</h3>");
#nullable restore
#line 18 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
 if (utilizadorLista == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Carregando...</em></p>");
#nullable restore
#line 23 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                      () => mostrar()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Adicionar");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>ID</th>\r\n            <th>Nome</th>\r\n            <th>Iniciais</th>\r\n            <th>Email</th></tr></thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 37 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                    editarHidden

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                              user.utilizadorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.utilizadorId = __value, user.utilizadorId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                              user.utilizadorNome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.utilizadorNome = __value, user.utilizadorNome));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                              user.utilizadorEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.utilizadorEmail = __value, user.utilizadorEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                              user.utilizadorIniciais

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.utilizadorIniciais = __value, user.utilizadorIniciais));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                                  () => inserirRegisto()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Guardar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
         foreach (var c in utilizadorLista.OrderByDescending(c => c.utilizadorId))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 47 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                     c.utilizadorId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 48 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                     c.utilizadorNome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 49 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                     c.utilizadorIniciais

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 50 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                     c.utilizadorEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
                                  () => apagarRegisto(c.utilizadorId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Apagar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\mcorr\Desktop\Testes\Testes_1\Testes_1\Pages\Tabela.razor"
 
    public static int idTeste;

    public static IList<utilizador> utilizadorLista = new List<utilizador>();

    public static List<utilizador> lista;

    public string editarHidden;

    public static utilizador user = new utilizador();

    protected override async Task OnInitializedAsync()
    {
        editarHidden = "d-none";
        utilizadorLista = await userService.Get();
    }

    public async Task apagarRegisto(int id)
    {
        userService.Delete(id);
        var itemRemove = utilizadorLista.Single(r => r.utilizadorId == id);
        utilizadorLista.Remove(itemRemove);
    }
    
    public async Task inserirRegisto()
    {
        userService.Post(user);
        utilizadorLista.Add(user);
        editarHidden = "d-none";
    }

    
    public void mostrar()
    {
        editarHidden = "";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UtilizadorService userService { get; set; }
    }
}
#pragma warning restore 1591