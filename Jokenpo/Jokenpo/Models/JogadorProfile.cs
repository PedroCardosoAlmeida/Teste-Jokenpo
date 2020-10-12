using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class JogadorProfile : Profile
    {
        public JogadorProfile()
        {
            CreateMap<Jogador, JogadorModelo>();
            CreateMap<JogadorModelo,Jogador>();
        }
    }
}
