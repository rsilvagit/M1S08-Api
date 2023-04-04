using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Banco_Dev;
using Banco_Dev.Controllers;
using Banco_Dev.Models;
using Banco_Dev.Interface;
using Banco_Dev.Service;

namespace Banco_Dev.Controllers
{
    public class TransacaoController : Controller
    {
        public TransacaoController()
        {
            Transacao transacaoModel = new Transacao();
        }
        [HttpPost("Transacao/{idCliente}")]
        
        public ActionResult PostTransacao(int idCliente)
        {
            
                return Ok();
            
        
        }
        [HttpGet("Transacoes/{idCliente}")]
            public ActionResult ListTransasao(int idCliente)
        {
            return Ok();
        }
    }

       
}
