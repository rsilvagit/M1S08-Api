using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banco_Dev;
using Banco_Dev.Models;
using Banco_Dev.Interface;
using Banco_Dev.Service;
using Banco_Dev.Controllers;


namespace Banco_Dev.Models 
{ 
    public abstract class Cliente
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
 
        public int NumeroConta { get; set; }
        public double Saldo { get { return GetSaldo(); } private set { } 
        }

        public abstract string ResumoCliente();

        public List<Transacao> Extrato { get; set; }
    
    
            public Cliente()
        {
            Extrato = new List<Transacao>();
        }

        public Cliente(int numeroConta, string endereco, string telefone, string email, List<Transacao> extrato)
        {
           NumeroConta = numeroConta;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Extrato = extrato;
        }

        private double GetSaldo()
        {
            double saldo = 0;
            foreach (Transacao transacao in Extrato)
            {
                saldo += transacao.Valor;
            }
            return saldo;
        }
    }
}