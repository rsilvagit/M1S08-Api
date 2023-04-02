using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Banco_Dev;

namespace Banco_Dev.Controllers
{
    public class TransacaoController : Controller
    {
        public TransacaoController()
        {
            TransacaoModel transacaoModel = new TransacaoModel();
        }
        [HttpPost("Transacao/{idCliente}")]
        
        public ActionResult PostTransacao(int idCliente)
        {
            
                return Results.Ok(transacao);
            
        
        }
        [HttpGet("Transacoes/{idCliente}")]
            public ActionResult ListTransasao(int idCliente)
        {
            return Results.Ok(ClienteModel.Transacao);
        }
    }

       
}
