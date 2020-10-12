using Jokenpo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Services
{
  public interface IJogadorService
    {
        Task<IEnumerable<Jogador>> GetJogadores();
        Task<Jogador> GetJogador(int id);
        Task<Jogador> AtualizarJogador(Jogador jogadorAtualizado);

        Task<Jogador> CriarJogador(Jogador novoJogador);
        Task ExcluirJogador(int id);

    }
}
