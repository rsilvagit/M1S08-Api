using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Banco_Dev;
using Banco_Dev.Controllers;
using Banco_Dev.Models;

namespace Banco_Dev.Models
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Transacao()
        {

        }
        public Transacao(DateTime data, double valor)
        {
            Data = data;

            Valor = valor;
        }
    }
}