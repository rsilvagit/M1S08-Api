using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    { 

        public ClientesController() { }

        [HttpGet]
        public string Get()
        {
            return "Rafael";
        }
    }
}