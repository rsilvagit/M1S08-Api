using FullStackBankAPI.Models;
using FullStackBankAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullStackBankApi.Controllers
{
    [ApiController]
    [Route("Transacao")]
    //[Route("[controller]")] pega o nome da controller de forma dinâmica
    public class TransacaoController : Controller
    {        
        public readonly IClienteService _clienteService;

        public TransacaoController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost("/Transacoes/{idCliente}")]
        public ActionResult<string> AdicionaTransacao(int idCliente, [FromBody] Transacao transacao)
        {
            try
            {
                Cliente cliente = _clienteService.ObterPorId(idCliente);
                if (cliente != null)
                {
                    cliente.Extrato.Add(transacao);
                    return Ok("Transação adicionada com sucesso!");
                }
                    
                return BadRequest("Cliente não encontrado.");
            }
            catch (System.Exception)
            {
                return BadRequest("Ocorreu um erro na requisição.");
            }                       
        }        

        [HttpPut("/Transacoes/{idCliente}")]
        public ActionResult<string> BuscaTransacoesCliente(int idCliente)
        {
            try
            {
                Cliente cliente = _clienteService.ObterPorId(idCliente);
                if (cliente != null)
                {
                    return Ok(cliente.Extrato);                    
                }

                return BadRequest("Cliente não encontrado.");
            }
            catch (System.Exception)
            {
                return BadRequest("Ocorreu um erro na requisição.");
            }
        }
    }
}