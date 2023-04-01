using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Banco_Dev;

namespace Banco_Dev.Controllers
{
    public class ClienteController : Controller
    {
        [HttpPost("Clientes")]
        public ActionResult PessoaFisica([FromBody] Cliente PessoaFisica)
        {
            return Ok("Created");
        }
        [HttpPost("Clientes")]
        public ActionResult PessoaJuridica([FromBody] Cliente PessoaJuridica)
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
        public ActionResult ExcluirCliente(int id)
        {
            if (Cliente saldo<=0)
            {
                return Ok("conta excluida");
            } else 
                {
                    return BadRequest("Não foi possivel excluir a conta pois o saldo não está zerado");
                }
        }

    }
}
