﻿namespace FullStackBankAPI.Models
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get { return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set { } }

        public PessoaFisica()
        {

        }
        public PessoaFisica(string nome, string cpf, string email, string telefone, string end, DateTime dtNascimento, int numeroConta) : base(email, telefone, end, numeroConta)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dtNascimento;
        }

        public bool EhMaior() => Idade >= 18;

        public override string ResumoCliente() => $"{base.ResumoCliente} | {Nome} | {CPF}";
    }
}
