using APISistemaGerencial.Interface;
using APISistemaGerencial.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaGerencial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {

        private readonly IFuncionarioContext _funcionarioContext;

        public FuncionariosController(IFuncionarioContext funcionarioContext)
        {
            _funcionarioContext = funcionarioContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Funcionario>>> GetAll()
        {
            return Ok(await _funcionarioContext.GetAll());
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Funcionario>> Get(Guid id)
        {
            var funcionario = await _funcionarioContext.Get(id);

            if (funcionario.Id == new Guid()) return NoContent();

            return Ok(funcionario);
        }

        [HttpPost]
        public async Task<ActionResult<Funcionario>> Create([FromBody] Funcionario _funcionario)
        {
            try
            {
                var funcionario = await _funcionarioContext.Create(_funcionario);

                return Ok(funcionario); ;
            }
            catch (ArgumentException ex)
            {
                return UnprocessableEntity("Erro ao inserir Funcionário");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Funcionario>> Update([FromBody] Funcionario _funcionario)
        {
            try
            {
               await _funcionarioContext.Update(_funcionario);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return UnprocessableEntity("Erro ao Alterar Funcionário");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<Funcionario>> Delete(Guid id)
        {
            try
            {
                await _funcionarioContext.Delete(id);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return UnprocessableEntity("Erro ao Excluir Funcionário");
            }
        }
    }
}
