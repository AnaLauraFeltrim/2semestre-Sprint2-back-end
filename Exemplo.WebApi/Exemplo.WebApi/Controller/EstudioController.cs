using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo.WebApi.Domains;
using Exemplo.WebApi.Interface;
using Exemplo.WebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo.WebApi.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public EstudioController()
        {
            _estudioRepository = new EstudiosRepository();
        }

        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Uma lista de estúdios e um status code 200 - Ok</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Retora a resposta da requisição fazendo a chamada para o método
            return Ok(_estudioRepository.Listar());
        }

        /// <summary>
        /// Busca um estúdio através do ID
        /// </summary>
        /// <param name="id">ID do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado e um status code 200 - Ok</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retora a resposta da requisição fazendo a chamada para o método
            return Ok(_estudioRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Estudio novoEstudio)
        {
            // Faz a chamada para o método
            _estudioRepository.Cadastrar(novoEstudio);

            // Retorna um status code
            return StatusCode(201);
        }

        
    }
}