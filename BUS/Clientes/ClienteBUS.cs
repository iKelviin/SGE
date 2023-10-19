using DAL.Clientes;
using Entity;
using Entity.Clientes;
using System.Data;
using static Common.Enumeracoes;

namespace BUS.Clientes;

public class ClienteBUS
{
    public static List<ClienteInfo> ListarClientesPorNome(string nome)
    {
        ClienteDAL dalCliente = new ClienteDAL(Banco.SGE);
        return dalCliente.ListarClientesPorNome(nome);
    }
    public static List<ClienteInfo> ListarClientes()
    {
        ClienteDAL dalCliente = new ClienteDAL(Banco.SGE);
        return dalCliente.ListarClientes();
    }
    public static ClienteInfo ObterCliente(string pCPF)
    {
        ClienteDAL dalCliente = new ClienteDAL(Banco.SGE);
        return dalCliente.ObterCliente(pCPF);
    }
    public static void CadastrarCliente(ClienteInfo pCliente)
    {
        ClienteDAL dalCliente = new ClienteDAL(Banco.SGE);
        dalCliente.CadastrarCliente(pCliente);
    }

    public static void AtualizarCliente(ClienteInfo pCliente)
    {
        ClienteDAL dalCliente = new ClienteDAL(Banco.SGE);
        dalCliente.AtualizarCliente(pCliente);
    }
    public static void ExcluirCliente(ClienteInfo pCliente)
    {
        ClienteDAL dalCliente = new ClienteDAL(Banco.SGE);
        dalCliente.ExcluirCliente(pCliente);
    }
}
