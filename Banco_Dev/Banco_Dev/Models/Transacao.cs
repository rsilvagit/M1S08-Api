using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Banco_Dev;
using Banco_Dev.Controllers;
using Banco_Dev.Models;
using Banco_Dev.Service;
using Banco_Dev.Interface;


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