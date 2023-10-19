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
using System.Runtime;

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

        public List<ClienteInfo> ListarClientesPorNome(string Nome)
        {
            try
            {
                DataTable dt;
                List<ClienteInfo> lstClientes = new List<ClienteInfo>();
                using (Connection)
                {
                    Parameters = new SqlParameter[1];
                    Parameters[0] = new SqlParameter("@Nome", Nome);
                    dt = ExecuteDataTable("usp_ListarClientes", System.Data.CommandType.StoredProcedure, Parameters);
                }

                if (dt.Rows.Count > 0)
                {
                    lstClientes = ConverteParaLista<ClienteInfo>(dt);
                }
                return lstClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public ClienteInfo ObterCliente(string pCPF)
        {
            try
            {
                DataTable dt;
                ClienteInfo pCliente = new ClienteInfo();
                using (Connection)
                {
                    Parameters = new SqlParameter[1];
                    Parameters[0] = new SqlParameter("@CPF", pCPF);
                    dt = ExecuteDataTable("usp_SelecionarCliente", System.Data.CommandType.StoredProcedure, Parameters);
                }

                if (dt.Rows.Count > 0)
                {
                    pCliente = PegaItem<ClienteInfo>(dt.Rows[0]);
                }
                return pCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ClienteInfo> ListarClientes()
        {
            try
            {
                DataTable dt;
                List<ClienteInfo> lstClientes = new List<ClienteInfo>();
                using (Connection)
                {
                    dt = ExecuteDataTable("usp_ListarClientes", System.Data.CommandType.StoredProcedure);
                }

                if (dt.Rows.Count > 0)
                {
                    lstClientes = ConverteParaLista<ClienteInfo>(dt);
                }
                return lstClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void CadastrarCliente(ClienteInfo pCliente)
        {

            try
            {
                using (Connection)
                {
                    Parameters = new SqlParameter[14];
                    Parameters[0] = new SqlParameter("@ID", 0);
                    Parameters[1] = new SqlParameter("@Nome", pCliente.Nome);
                    Parameters[2] = new SqlParameter("@RG", pCliente.RG);
                    Parameters[3] = new SqlParameter("@CPF", pCliente.CPF);
                    Parameters[4] = new SqlParameter("@Email", pCliente.Email);
                    Parameters[5] = new SqlParameter("@Telefone", pCliente.Telefone);
                    Parameters[6] = new SqlParameter("@Celular", pCliente.Celular);
                    Parameters[7] = new SqlParameter("@CEP", pCliente.CEP);
                    Parameters[8] = new SqlParameter("@Endereco", pCliente.Endereco);
                    Parameters[9] = new SqlParameter("@Numero", pCliente.Numero);
                    Parameters[10] = new SqlParameter("@Complemento", pCliente.Complemento);
                    Parameters[11] = new SqlParameter("@Bairro", pCliente.Bairro);
                    Parameters[12] = new SqlParameter("@Cidade", pCliente.Cidade);
                    Parameters[13] = new SqlParameter("@Estado", pCliente.Estado);

                    ExecuteNonQuery("usp_InserirCliente", System.Data.CommandType.StoredProcedure, Parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void ExcluirCliente(ClienteInfo pCliente)
        {

            try
            {
                using (Connection)
                {
                    Parameters = new SqlParameter[1];
                    Parameters[0] = new SqlParameter("@ID", pCliente.Id);

                    ExecuteNonQuery("usp_ExcluirCliente", System.Data.CommandType.StoredProcedure, Parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void AtualizarCliente(ClienteInfo pCliente)
        {

            try
            {
                using (Connection)
                {
                    Parameters = new SqlParameter[14];
                    Parameters[0] = new SqlParameter("@ID", pCliente.Id);
                    Parameters[1] = new SqlParameter("@Nome", pCliente.Nome);
                    Parameters[2] = new SqlParameter("@RG", pCliente.RG);
                    Parameters[3] = new SqlParameter("@CPF", pCliente.CPF);
                    Parameters[4] = new SqlParameter("@Email", pCliente.Email);
                    Parameters[5] = new SqlParameter("@Telefone", pCliente.Telefone);
                    Parameters[6] = new SqlParameter("@Celular", pCliente.Celular);
                    Parameters[7] = new SqlParameter("@CEP", pCliente.CEP);
                    Parameters[8] = new SqlParameter("@Endereco", pCliente.Endereco);
                    Parameters[9] = new SqlParameter("@Numero", pCliente.Numero);
                    Parameters[10] = new SqlParameter("@Complemento", pCliente.Complemento);
                    Parameters[11] = new SqlParameter("@Bairro", pCliente.Bairro);
                    Parameters[12] = new SqlParameter("@Cidade", pCliente.Cidade);
                    Parameters[13] = new SqlParameter("@Estado", pCliente.Estado);

                    ExecuteNonQuery("usp_InserirCliente", System.Data.CommandType.StoredProcedure, Parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
