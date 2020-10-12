using Jokenpo.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Jokenpo.Services
{
    public class JogadorServico : IJogadorService
    {
        private readonly HttpClient httpClient;

        public JogadorServico(HttpClient httpCLient)
        {
            this.httpClient = httpCLient;
        }

        public HttpClient HttpCLient { get; }

        public async Task<Jogador> CriarJogador(Jogador novoJogador)
        {

            return await httpClient.PostJsonAsync<Jogador>("api/Jogadores", novoJogador);
        }

        public async Task<Jogador> GetJogador(int id)
        {
            return await httpClient.GetJsonAsync<Jogador>($"api/Jogadores/{ id}");
        }

        public async Task<IEnumerable<Jogador>> GetJogadores()
        {
            return await httpClient.GetJsonAsync<Jogador[]>("api/Jogadores");
        }

        public async Task<Jogador> AtualizarJogador(Jogador jogadorAtualizado)
        { 
           return await httpClient.PutJsonAsync<Jogador>("api/Jogadores", jogadorAtualizado);
        }

        public async Task ExcluirJogador(int id)
        {
             await httpClient.DeleteAsync($"api/Jogadores/{ id}");
        }
    }
}
