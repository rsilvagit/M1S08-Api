using FullStackBankAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace FullStackBankAPI.Services
{
    public class ClienteService : IClienteService
    {
        public List<Cliente> clientes = new();
        public Cliente BuscarClientePorNumeroDeConta(int numeroConta) => clientes.Find(x => x.NumeroConta == numeroConta);

        public Cliente ObterPorId(int id)
        {
            try
            {
                Cliente cliente = clientes.Find(x => x.Id == id);
                if (cliente != null)
                {
                    return cliente;                    
                }
                return null;
            }
            catch (System.Exception)
            {
                return null;
            }
        }


        public List<Cliente> ObterTodos() => clientes;
        public void Inserir(Cliente cliente) => clientes.Add(cliente);
        public string Deletar(int id) {
            try
            {
                Cliente cliente = clientes.Find(x => x.Id == id);
                if (cliente != null)
                {
                    if (cliente.Saldo == 0)
                    {
                        clientes.Remove(cliente);
                        return "";
                    }
                    else
                    {
                        return "Não é possível excluir a conta deste cliente devido o saldo não estar zerado!";
                    }
                }
                return "Cliente não encontrado com o Id informado.";
            }
            catch (System.Exception)
            {
                return "Ocorreu um erro na requisição.";
            }
        }

        public void DeletarTudo() => clientes.Clear();

        public void ExibirClientes()
        {
            Console.WriteLine("Número da conta        | Nome         | CPF    ");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i].ResumoCliente());
            }
        }

        public string AtualizaPJ(int id, PessoaJuridica cliente)
        {
            try
            {
                Cliente clienteAlterar = clientes.Find(x => x.Id == id);
                if (clienteAlterar != null)
                {
                    clientes.Remove(clienteAlterar);
                    clientes.Add(cliente);
                    return "";
                }
                return "Cliente não encontrado.";
            }
            catch (System.Exception)
            {
                return "Ocorreu um erro na requisição.";
            }
        }

        public string AtualizaPF(int id, PessoaFisica cliente)
        {
            try
            {
                Cliente clienteAlterar = clientes.Find(x => x.Id == id);
                if (clienteAlterar != null)
                {
                    clientes.Remove(clienteAlterar);
                    clientes.Add(cliente);
                    return "";
                }
                return "Cliente não encontrado.";
            }
            catch (System.Exception)
            {
                return "Ocorreu um erro na requisição.";
            }
        }        
    }
}
