using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filmes.Domain;
using filmes.Interfaces;
using filmes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace filmes.Controller
{
    [Produces ("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {

        private IFilmeRepository _filmeRepository { get; set; }

        public FilmeController()
        {
            _filmeRepository = new FilmeRepository();
        }

        [HttpGet]
        public IEnumerable<FilmeDomain> Get()
        {
           return  _filmeRepository.Listar();              
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            FilmeDomain filmeBuscado = _filmeRepository.ListarPorId(id);

            if(filmeBuscado == null)
            {
                return NotFound("Nenhum filme encontrado");
            }return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult AlterarFilme(FilmeDomain filmeDomain, int id)
        {
            filmeDomain.IdFilme = id;
             _filmeRepository.AlterarFilme(filmeDomain);
            return StatusCode(200);
        }

        [HttpPost]
        public IActionResult CadastrarFilme(FilmeDomain filmeDomain)
        {
            _filmeRepository.CadastrarFilme(filmeDomain);
            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarFilme(int id)
        {
            _filmeRepository.DeletarFilme(id);
            return Ok();


        }




    }
}