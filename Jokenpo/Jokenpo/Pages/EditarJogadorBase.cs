using AutoMapper;
using Jokenpo.Models;
using Jokenpo.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Pages
{
    public class EditarJogadorBase : ComponentBase
    {
        [Inject]
        public IJogadorService JogadorServico { get; set; }

        private Jogador Jogador { get; set; } = new Jogador();

        public string TextoTitulo { get; set; }

        public JogadorModelo JogadorModelo { get; set; } = new JogadorModelo();

        [Parameter]
        public string id { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }


        protected async override Task OnInitializedAsync()
        {
            int.TryParse(id, out int jogadorid);

            if(jogadorid != 0)
            {
                TextoTitulo = "Editar Jogador";
                Jogador = await JogadorServico.GetJogador(int.Parse(id));
            }
            else
            {
                TextoTitulo = "Criar Jogador";
                Jogador = new Jogador
                {
                    id = 0,
                    CaminhoFoto = "imagens/jokenpo.png"

                };
            }
            
            Mapper.Map(Jogador, JogadorModelo);     
            
        }

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(JogadorModelo,Jogador );

            Jogador result = null;

            if (Jogador.movementos.ToString() == "PEDRA")
            {
                Jogador.CaminhoFoto = "imagens/pedra.png";
            }
            else if(Jogador.movementos.ToString() == "PAPEL")
            {
                Jogador.CaminhoFoto = "imagens/papel.png";
            }
            else if(Jogador.movementos.ToString() == "TESOURA")
            {
                Jogador.CaminhoFoto = "imagens/tesoura.png";
            }
            else
            {
                Jogador.CaminhoFoto = "imagens/jokenpo.png";
            }



            if (Jogador.id != 0)
            {
                result = await JogadorServico.AtualizarJogador(Jogador);
            }
            else
            {

                result =  await JogadorServico.CriarJogador(Jogador);

            }

            if(result != null)
            {
                NavigationManager.NavigateTo("/");
            }

        }

        protected async Task Deletar_Click()
        {
           await JogadorServico.ExcluirJogador(Jogador.id);

            NavigationManager.NavigateTo("/");
        }

    }
}
