using Jokenpo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace Jokenpo.Api.Models
{
    public class RepositorioJogador : IRepositorioJogador
    {
        private readonly AppDbContext appDbContext;

        public RepositorioJogador(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Jogador> AddJogador(Jogador jogador)
        {
           var result = await appDbContext.Jogadores.AddAsync(jogador);
           await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Jogador> ExcluirJogador(int id)
        {
            var result = await appDbContext.Jogadores
                .FirstOrDefaultAsync(e => e.id == id);
            if(result != null)
            {
                appDbContext.Jogadores.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Jogador> GetJogador(int id)
        {
            return await appDbContext.Jogadores
                .FirstOrDefaultAsync(e => e.id == id);
        }

        public async Task<Jogador> GetJogadorPeloNome(string nome)
        {
            return await appDbContext.Jogadores
                .FirstOrDefaultAsync(e => e.Nome == nome);
        }

        public async Task<IEnumerable<Jogador>> GetJogadores()
        {
            return await appDbContext.Jogadores.ToListAsync();
        }

        public  async Task<IEnumerable<Jogador>> Procurar(string nome, Movementos? mov)
        {
            IQueryable<Jogador> query = appDbContext.Jogadores;

            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(e => e.Nome.Contains(nome) || e.SobreNome.Contains(nome)); 
            }


            if (mov != null)
            {
                query = query.Where(e => e.movementos == mov);
            }

            return await query.ToArrayAsync();
        }

        public async Task<Jogador> AtualizarJogador(Jogador Jogador)
        {
            var result = await appDbContext.Jogadores
                .FirstOrDefaultAsync(e => e.id == Jogador.id);

            if (result != null)
            {
                result.Nome = Jogador.Nome;
                result.SobreNome = Jogador.SobreNome;
                result.movementos = Jogador.movementos;
                result.CaminhoFoto = Jogador.CaminhoFoto;
               

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
