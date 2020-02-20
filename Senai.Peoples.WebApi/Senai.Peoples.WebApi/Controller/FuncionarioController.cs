using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domain;
using Senai.Peoples.WebApi.IRepository;
using Senai.Peoples.WebApi.Repository;

namespace Senai.Peoples.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private IFuncionarioRepository _funcionarioRpository { get; set; }

        public FuncionarioController ()
        {
            _funcionarioRpository = new FuncionarioRepository();
        }

        [HttpGet]
        public IEnumerable <FuncionarioDomain> Get()
        {
            return _funcionarioRpository.Listar(); 
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(FuncionarioDomain funcionarioDomain, int id)
        {
            funcionarioDomain.IdFuncionario = id;
             _funcionarioRpository.Alterar(funcionarioDomain);
            return StatusCode(200);
        }

        [HttpPost]
        public IActionResult Cadastrar (FuncionarioDomain funcionario)
        {
            _funcionarioRpository.Cadastrar(funcionario);
            return StatusCode(201);
        }
    }
}