using FullStackBankAPI.Models;

namespace FullStackBankAPI.Services
{
    public interface IClienteService
    {
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void ExibirClientes();
        public Cliente ObterPorId(int id);
        public List<Cliente> ObterTodos();
        public void Inserir(Cliente cliente);
        public string Deletar(int id);
        public void DeletarTudo();
        public string AtualizaPF(int id, PessoaFisica cliente);
        public string AtualizaPJ(int id, PessoaJuridica cliente);
    }
}