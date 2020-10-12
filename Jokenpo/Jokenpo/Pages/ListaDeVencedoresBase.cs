using Jokenpo.Models;
using Jokenpo.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Pages
{
    public class ListaDeVencedoresBase : ComponentBase
    {

        [Inject]
        public IJogadorService JogadorServico { get; set; }


        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string TextoTitulo { get; set; }

        public IEnumerable<Jogador> Jogadores { get; set; }

        public List<Jogador> Vencedores = new List<Jogador>();

        public bool vitoria = false;


       

        protected override async Task OnInitializedAsync()
        {

            Jogadores = (await JogadorServico.GetJogadores()).ToList();
            Jogar();
        }

        public void Jogar()
        {
            foreach (var jogador in Jogadores)
            {
                bool vitoria = checkarFraquezas(jogador);
                if (vitoria == true)
                {
                    Jogador vencedor = jogador;

                    Vencedores.Add(vencedor);

                    vencedor = null;
                }
            }

            if (Vencedores.Count > 0)
            {
                vitoria = true;
                TextoTitulo = "Vencedores";
            }
            else
            {
                vitoria = false;
                TextoTitulo = "Ninguem venceu";
            }

            NavigationManager.NavigateTo("/vencedores");


        }

        private bool checkarFraquezas(Jogador jogador)
        {
            string fraqueza;


            if (jogador.movementos.ToString().Equals("PEDRA"))
            {
                fraqueza = "PAPEL";
            }
            else if (jogador.movementos.ToString().Equals("PAPEL"))
            {
                fraqueza = "TESOURA";
            }
            else
            {
                fraqueza = "PEDRA";
            }

            foreach (var jog in Jogadores)
            {
                if (jog.movementos.ToString().Equals(fraqueza))
                {
                    return false;
                }

            }

            return true;




        }
    }
}
