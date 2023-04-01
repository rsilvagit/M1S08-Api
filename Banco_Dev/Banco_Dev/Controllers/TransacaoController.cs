using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Banco_Dev;

namespace Banco_Dev.Controllers
{
    public class TransacaoController : Controller
    {

        [HttpPost] ("Transacao/{idCliente}")
        
        public ActionResult PostTransacao(int idCliente)
        {
            
                return Results.Ok(transacao);
            
        
        }
        [HttpGet]("Transacoes/{idCliente}")
            public ActionResult ListTransasao(int idCliente)
        {
            return Ok(ClienteModel.Transacao);
        }
    }

       
}
