using Jokenpo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

        public DbSet<Jogador> Jogadores { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Seed Employee Table
            modelBuilder.Entity<Jogador>().HasData(new Jogador
            {
                id = 1,
               Nome = "Pedro",
                SobreNome = "asd",
                movementos = Movementos.PEDRA,
                CaminhoFoto = "imagens/pedra.png"
                
            }) ;

            modelBuilder.Entity<Jogador>().HasData(new Jogador
            {
                id = 2,
                Nome = "Pedro",
                SobreNome = "asd",
                movementos = Movementos.PEDRA,
                CaminhoFoto = "imagens/pedra.png"
            });

            modelBuilder.Entity<Jogador>().HasData(new Jogador
            {
                id = 3,
                Nome = "Pedro",
                SobreNome = "asd",
                movementos = Movementos.PEDRA,
                CaminhoFoto = "imagens/papel.png"
            });

            modelBuilder.Entity<Jogador>().HasData(new Jogador
            {
                id = 4,
                Nome = "Pedro",
                SobreNome = "asd",
                movementos = Movementos.PEDRA,
                CaminhoFoto = "imagens/tesoura.png"
            });
        }
    }
}
