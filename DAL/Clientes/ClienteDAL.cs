using Entity;
using Entity.Clientes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Enumeracoes;

namespace DAL.Clientes
{
    public class ClienteDAL : BaseDAL<ClienteInfo>
    {
        public ClienteDAL(Banco banco) : base(banco) { }
        public override void Excluir(ClienteInfo voT)
        {
            throw new NotImplementedException();
        }

        public override int Inserir(ClienteInfo voT)
        {
            throw new NotImplementedException();
        }

        public override ClienteInfo Obter(int id)
        {
            throw new NotImplementedException();
        }
        public override List<ClienteInfo> ObterLista()
        {
            throw new NotImplementedException();
        }

        public List<ClienteInfo> ListarClientesPorNome(string nome)
        {
            try
            {
                DataTable dt;
                List<ClienteInfo> lstClientes = new List<ClienteInfo>();
                using (Connection)
                {
                    Parameters = new SqlParameter[1];
                    Parameters[0] = new SqlParameter("@Nome", nome);
                    dt = ExecuteDataTable("usp_ListarClientesPorNome", System.Data.CommandType.StoredProcedure, Parameters);
                }

                if (dt.Rows.Count > 0)
                {
                    lstClientes = ConverteParaLista<ClienteInfo>(dt);
                }
                return lstClientes;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

    }
}
