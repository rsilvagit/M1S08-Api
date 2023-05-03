namespace FullStackBankAPI.Models
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public PessoaJuridica()
        {

        }
        public PessoaJuridica(string razaoSocial, string cnpj, string email, string telefone, string end, DateTime dtNascimento, int numeroConta) : base(email, telefone, end, numeroConta)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
        }

        public override string ResumoCliente() => $"{base.ResumoCliente} | {RazaoSocial} | {CNPJ}";
    }
}
