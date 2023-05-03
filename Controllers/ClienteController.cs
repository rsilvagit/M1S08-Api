using FullStackBankAPI.Models;
using FullStackBankAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullStackBankApi.Controllers
{
    [ApiController]
    [Route("Cliente")]
    //[Route("[controller]")] pega o nome da controller de forma dinâmica
    public class ClienteController : Controller
    {
        IClienteService _clienteService;

        public ClienteController(IClienteService clientService)
        {
            _clienteService = clientService;
        }

        [HttpPost("/Clientes/pessoafisica")]
        public ActionResult<string> InserirPF([FromBody] PessoaFisica cliente)
        {
            _clienteService.Inserir(cliente);
            return Ok("Cliente adicionado com sucesso!");
        }

        [HttpPost("/Clientes/pessoaJuridica")]
        public ActionResult<string> InserirPJ([FromBody] PessoaJuridica cliente)
        {
            _clienteService.Inserir(cliente);
            return Ok("Cliente adicionado com sucesso!");
        }

        [HttpGet("/Clientes/{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            try
            {
                Cliente cliente = _clienteService.ObterPorId(id);
                if (cliente != null)
                    return Ok(cliente);

                return BadRequest("Cliente não encontrado.");
            }
            catch (System.Exception)
            {
                return BadRequest("Ocorreu um erro na requisição.");
            }
        }

        [HttpGet("/Clientes")]
        public ActionResult<string> Get() 
        {
            return Ok(_clienteService.ObterTodos());
        }


        [HttpPut("/Clientes/pessoafisica/{id}")]
        public ActionResult<string> AtualizaPF(int id, [FromBody] PessoaFisica cliente)
        {
            try
            {
                string retorno = _clienteService.AtualizaPF(id, cliente);
                if (retorno == "")
                    return Ok("Cliente atualizado com sucesso!");

                return BadRequest(retorno);
            }
            catch (System.Exception)
            {
                return BadRequest("Ocorreu um erro na requisição.");
            }
        }


        [HttpPut("/Clientes/pessoaJuridica/{id}")]
        public ActionResult<string> AtualizaPJ(int id, [FromBody] PessoaJuridica cliente)
        {
            try
            {
                string retorno = _clienteService.AtualizaPJ(id, cliente);
                if (retorno == "")
                    return Ok("Cliente atualizado com sucesso!");

                return BadRequest(retorno);
            }
            catch (System.Exception)
            {
                return BadRequest("Ocorreu um erro na requisição.");
            }
        }

        [HttpDelete("/Clientes/{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                string retorno = _clienteService.Deletar(id);
                if (retorno == "")
                    return Ok("Cliente removido com sucesso!");

                return BadRequest(retorno);
            }
            catch (System.Exception)
            {
                return BadRequest("Ocorreu um erro na requisição.");
            }
        }

        [HttpDelete("/Clientes")]
        public ActionResult<string> DeleteAll()
        {
            _clienteService.DeletarTudo();
            return Ok("Clientes removidos com sucesso!");
        }
    }
}