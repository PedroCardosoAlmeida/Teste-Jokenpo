using Jokenpo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Api.Models
{
   public interface IRepositorioJogador
    {
        Task<IEnumerable<Jogador>> Procurar(string nome, Movementos? mov);
        Task<IEnumerable<Jogador>> GetJogadores();
        Task<Jogador> GetJogador(int jogadorId);

        Task<Jogador> GetJogadorPeloNome(string nome);
        Task<Jogador> AddJogador(Jogador jogador);
        Task<Jogador> AtualizarJogador(Jogador Jogador);
        Task<Jogador> ExcluirJogador(int Id);
    }
}
