using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Banco_Dev;
using Banco_Dev.Controllers;
using Banco_Dev.Models;

namespace Banco_Dev.Controllers
{
    public class ClienteController : Controller
    {
        [HttpPost("Clientes")]
        public ActionResult PessoaFisica([FromBody] Cliente PessoaFisica)
        {
            return Results.OK();
        }
        [HttpPost("Clientes")]
        public ActionResult PessoaJuridica(Cliente PessoaJuridica)
        {
            return Ok("Created");
        }
        [HttpGet("Clientes")]
        public ActionResult ObterClientes()
        {
            return Ok("Success");
        }
        [HttpGet("Clientes/{id}")]
        public ActionResult ObterClientes(int id)
        {
            return Ok("Success");
        }
        [HttpPut("Clientes/{id}")]
        public ActionResult PessoaFisica(int id)
        {
            return Ok("Success");
        }
        [HttpPut("Clientes/{id}")]
        public ActionResult PessoaJuridica(int id)
        {
            return Ok("Success");
        }
        [HttpDelete("Clientes/{id}")]
        public ActionResult DeletarCliente([FromRoute] int id)
        {
            Cliente clienteDeletar = _clienteService.BuscarCliente(id);

            if (clienteDeletar.Saldo != 0)
            {
                return BadRequest($"Não foi possível deletar cliente. Cliente há saldo de: {clienteDeletar.Saldo}");
            }


            _clienteService.DeletarCliente(id);
            return Ok();


        }


    }
}
