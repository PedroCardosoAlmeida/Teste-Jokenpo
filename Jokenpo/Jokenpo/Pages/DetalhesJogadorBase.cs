using Jokenpo.Models;
using Jokenpo.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Jokenpo.Pages
{
    public class DetalhesJogadorBase : ComponentBase
    {
        public Jogador Jogador { get; set; } = new Jogador();

        protected string Coordenadas { get; set; }

        [Inject]
        public IJogadorService JogadorServico { get; set; }

        [Parameter]
        public string id { get; set; }

        protected async override Task OnInitializedAsync()
        {
           Jogador =  await JogadorServico.GetJogador(int.Parse(id));
        }

        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordenadas = $"X= {e.ClientX} Y ={e.ClientY}";
        }
    }
}
