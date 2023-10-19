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
}
