using Jokenpo.Models;
using Jokenpo.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Pages
{
    public class ListaDeJogadoresBase : ComponentBase
    {

        [Inject]
        public IJogadorService JogadorServico { get; set; }


        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public  string TextoTitulo { get; set; }

        public  IEnumerable<Jogador> Jogadores { get; set; }

        public List<Jogador> Vencedores = new List<Jogador>();

        public bool vitoria = false;
        

        protected async Task Deletar_Click(int id)
        {
            await JogadorServico.ExcluirJogador(id);
            NavigationManager.NavigateTo("/", true);
        }

        protected override async Task OnInitializedAsync()
        {
         
           Jogadores = (await JogadorServico.GetJogadores()).ToList();
        }


    }
}
