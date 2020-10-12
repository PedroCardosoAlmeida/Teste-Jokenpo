using Jokenpo.Api.Models;
using Jokenpo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Jokenpo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadoresController : ControllerBase
    {
        private readonly IRepositorioJogador repositorioJogador;

        public JogadoresController(IRepositorioJogador repositorioJogador)
        {
            this.repositorioJogador = repositorioJogador;
        }


        [HttpGet("{procurar}")]
        public async Task<ActionResult<IEnumerable<Jogador>>> Procurar(string nome, Movementos? mov)
        {
            try
            {
               var result  = await repositorioJogador.Procurar(nome, mov);

                if(result.Any())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception)
            {


                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentar reaver data");
            }
        }  
     
        [HttpGet]
        public async Task<ActionResult> GetJogadores()
        {

            try
            {
                return Ok(await repositorioJogador.GetJogadores());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentar reaver data");
            }
            
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Jogador>> GetJogador(int id)
        {

            try
            {
                var result = await repositorioJogador.GetJogador(id);

                if(result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentar reaver data");
            }

        }

        [HttpPost]
        public async Task<ActionResult<Jogador>> CriarJogador(Jogador jogador)
        {

            try
            {
                if(jogador == null)
                {
                    return BadRequest();
                }

                var jog = await repositorioJogador.GetJogadorPeloNome(jogador.Nome);


                if(jog != null)
                {
                    ModelState.AddModelError("nome", "Nome já está sendo usado");
                    return BadRequest();
                }


                var jogadorCriado = await repositorioJogador.AddJogador(jogador);


                return CreatedAtAction(nameof(GetJogador),new {id = jogadorCriado.id},jogadorCriado);


            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentar reaver data");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Jogador>> AtualizarJogador(Jogador jogador)
        {
            try
            {
               

               var jogadorPAtualizar = repositorioJogador.GetJogador(jogador.id);

                if(jogadorPAtualizar == null)
                {
                    return NotFound($"Jogador com Id={jogador.id} não encontrado");
                }

               return await repositorioJogador.AtualizarJogador(jogador);


            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentar ataulizar data");
            }

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Jogador>> ExcluirJogador(int id)
        {
            try
            {
                var jogadorADeletar = repositorioJogador.GetJogador(id);

                if(jogadorADeletar == null)
                {
                    return NotFound($"Jogador com Id={id} não encontrado");
                }

                return await repositorioJogador.ExcluirJogador(id);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error ao tentar deletar data");
            }

        }


    }
}
