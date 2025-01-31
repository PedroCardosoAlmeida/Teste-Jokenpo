#pragma checksum "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ad50810250f6103b7eb9ad2a4fcc697bf73d79"
// <auto-generated/>
#pragma warning disable 1591
namespace Jokenpo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Jokenpo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Jokenpo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\_Imports.razor"
using Jokenpo.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ListaDeJogadores : ListaDeJogadoresBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de Jogadores</h3>\r\n");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "href", 
#nullable restore
#line 6 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
           "/vencedores"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", "btn btn-primary m-1");
            __builder.AddContent(4, "Jogar");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 7 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
 if (Jogadores == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 10 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-deck");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 14 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
         foreach (var jogador in Jogadores)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card m-3");
            __builder.AddAttribute(14, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-header");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "h3");
            __builder.AddContent(20, 
#nullable restore
#line 18 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
                         jogador.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
                                       jogador.SobreNome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 20 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
                                                               jogador.CaminhoFoto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card-footer text-center");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 22 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
                               $"detalhesjogador/{jogador.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-primary m-1");
            __builder.AddContent(35, "Ver");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n                    ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 24 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
                               $"editjogador/{jogador.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "class", "btn btn-primary m-1");
            __builder.AddContent(40, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-danger m-1");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
                                                                               (() => Deletar_Click(jogador.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "\r\n                        Deletar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 31 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 33 "C:\Users\sephi\source\repos2020\Jokenpo\Jokenpo\Pages\ListaDeJogadores.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
