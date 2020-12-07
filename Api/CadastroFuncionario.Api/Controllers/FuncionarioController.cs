using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CadastroFuncionario.Domain.Dto;
using CadastroFuncionario.Domain.Entities;
using CadastroFuncionario.Domain.Enums;
using CadastroFuncionario.Domain.Interfaces.Application;
using CadastroFuncionario.Repository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFuncionario.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioApplication<CadastroFuncionarioContext> _application;
        private readonly IMapper _mapper;
        public FuncionarioController(IFuncionarioApplication<CadastroFuncionarioContext> application, IMapper mapper)
        {
            _application = application;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<FuncionarioDto> GetFuncionario()
        {
            var funcionario = _application.GetAll();
            var funcionarioMapper = _mapper.Map<IEnumerable<FuncionarioDto>>(funcionario);

            return funcionarioMapper;
        }

        [HttpGet]
        [Route("{id}")]
        //[Authorize("Bearer")]
        public IActionResult GetFuncionarioById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var funcionario = _application.GetById(id);
            var funcionarioMapper = _mapper.Map<FuncionarioEditDto>(funcionario);
            if (funcionarioMapper == null)
                return NotFound();
            return new ObjectResult(funcionarioMapper);
        }

        [HttpGet]
        [Route("FuncionarioByHabilidade/{habilidade}")]
        public IEnumerable<FuncionarioDto> GetFuncionarioByHabilidade(Habilidade habilidade)
        {
            var funcionario = _application.GetFuncionarioByHabilidade(habilidade);
            var funcionarioMapper = _mapper.Map<IEnumerable<FuncionarioDto>>(funcionario);
            return funcionarioMapper;
        }

        [HttpGet]
        [Route("FuncionarioByIdade/{idade}")]
        public IEnumerable<FuncionarioDto> GetFuncionarioByIdade(int idade)
        {
            var funcionario = _application.GetFuncionarioByIdade(idade);
            var funcionarioMapper = _mapper.Map<IEnumerable<FuncionarioDto>>(funcionario);
            return funcionarioMapper;
        }

        [HttpGet]
        [Route("FuncionarioByNome/{nome}")]
        public IEnumerable<FuncionarioDto> GetFuncionarioByNome(string nome)
        {
            var funcionario = _application.GetFuncionarioByNome(nome);
            var funcionarioMapper = _mapper.Map<IEnumerable<FuncionarioDto>>(funcionario);
            return funcionarioMapper;
        }

        [HttpGet]
        [Route("FuncionarioBySexo/{sexo}")]
        public IEnumerable<FuncionarioDto> GetFuncionarioBySexo(Sexo sexo)
        {
            var funcionario = _application.GetFuncionarioBySexo(sexo);
            var funcionarioMapper = _mapper.Map<IEnumerable<FuncionarioDto>>(funcionario);
            return funcionarioMapper;
        }

        [HttpPost]
        public IActionResult CreateFuncionario([FromBody] Funcionario funcionario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (funcionario == null)
                return BadRequest();

            _application.Create(funcionario);
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateFuncionario([FromRoute] int id, [FromBody] Funcionario funcionario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _application.UpdateFuncionario(id, funcionario);
            return Ok();
        }

        [HttpPut]
        [Route("Ativar/{id}")]
        public IActionResult AtivarFuncionario(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _application.AtivarFuncionario(id);
            return Ok();
        }

        [HttpPut]
        [Route("Inativar/{id}")]
        public IActionResult InativarFuncionario(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _application.InativarFuncionario(id);
            return Ok();
        }
    }
}
