using Entity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Enumeracoes;

namespace DAL;

public class UsuarioDAL : BaseDAL<UsuarioInfo>
{
    public UsuarioDAL(Banco banco) : base(banco) { }
    public override void Excluir(UsuarioInfo voT)
    {
        throw new NotImplementedException();
    }

    public override int Inserir(UsuarioInfo voT)
    {
        throw new NotImplementedException();
    }

    public override UsuarioInfo Obter(int id)
    {
        throw new NotImplementedException();
    }
    public override List<UsuarioInfo> ObterLista()
    {
        throw new NotImplementedException();
    }
    public List<UsuarioInfo> ObterListaUsuario()
    {
        try
        {
            DataTable dt;
            List<UsuarioInfo> objUsuario = new List<UsuarioInfo>();
            using (Connection)
            {
                dt = ExecuteDataTable("usp_LISTAR_Usuario", System.Data.CommandType.StoredProcedure);

            }

            if (dt.Rows.Count > 0)
            {
                objUsuario = ConverteParaLista<UsuarioInfo>(dt);
            }
            return objUsuario;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public List<string> ObterListaUsuarioNomes()
    {
        try
        {
            DataTable dt;
            List<string> objUsuario = new List<string>();
            using (Connection)
            {
                dt = ExecuteDataTable("usp_LISTAR_Usuario_Nomes", System.Data.CommandType.StoredProcedure);
            }

            if (dt.Rows.Count > 0)
            {
                objUsuario = ConverteParaListaUmTipo<string>(dt);
            }
            return objUsuario;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    public UsuarioInfo Validar(string usuario, string senha)
    {
        try
        {
            DataTable dt;
            UsuarioInfo objUsuario = new UsuarioInfo();
            using (Connection)
            {
                Parameters = new SqlParameter[2];
                Parameters[0] = new SqlParameter("@Usuario", usuario);
                Parameters[1] = new SqlParameter("@Senha", senha);
                dt = ExecuteDataTable("usp_ValidarUsuario", System.Data.CommandType.StoredProcedure, Parameters);
            }

            if (dt.Rows.Count > 0)
            {
                objUsuario = PegaItem<UsuarioInfo>(dt.Rows[0]);
            }                                                                                           




            return objUsuario;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void AlterarUsuario(UsuarioInfo item)
    {
        try
        {
            DataTable dt;
            UsuarioInfo objUsuario = new UsuarioInfo();
            using (Connection)
            {
                Parameters = new SqlParameter[6];
                Parameters[0] = new SqlParameter("@CodUsuario", item.Id);
                Parameters[1] = new SqlParameter("@NomeUsuario", item.Nome);
                Parameters[2] = new SqlParameter("@SenhaUsuario", item.Senha);
                Parameters[3] = new SqlParameter("@AtivoUsuario", item.Ativo);
                Parameters[4] = new SqlParameter("@Administrador", item.Administrador);
                Parameters[5] = new SqlParameter("@Email", item.Email);

                dt = ExecuteDataTable("usp_alterar_Usuario", System.Data.CommandType.StoredProcedure, Parameters);

            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void InserirUsuario(UsuarioInfo item)
    {
        try
        {
            DataTable dt;
            UsuarioInfo objUsuario = new UsuarioInfo();
            using (Connection)
            {
                Parameters = new SqlParameter[6];
                Parameters[0] = new SqlParameter("@CodUsuario", item.Id);
                Parameters[1] = new SqlParameter("@NomeUsuario", item.Nome);
                Parameters[2] = new SqlParameter("@SenhaUsuario", item.Senha);
                Parameters[3] = new SqlParameter("@AtivoUsuario", item.Ativo);
                Parameters[4] = new SqlParameter("@Administrador", item.Administrador);
                Parameters[5] = new SqlParameter("@Email", item.Email);

                dt = ExecuteDataTable("usp_Inserir_Usuario", System.Data.CommandType.StoredProcedure, Parameters);

            }

        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    public void ExcluirUsuario(int pCodUsuario)
    {
        try
        {
            using (Connection)
            {
                Parameters = new SqlParameter[1];
                Parameters[0] = new SqlParameter("@CodUsuario", pCodUsuario);

                ExecuteScalar("usp_ExcluirAcessoUsuario", System.Data.CommandType.StoredProcedure, Parameters);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public bool ObterDireitosUsuario(int codigo, string pTela)
    {
        try
        {
            using (Connection)
            {
                Parameters = new SqlParameter[2];
                Parameters[0] = new SqlParameter("@CodUsuario", codigo);
                Parameters[1] = new SqlParameter("@Tela", pTela);

                object acessar = base.ExecuteScalar("usp_ValidarDireitosUsuario", CommandType.StoredProcedure, Parameters);

                bool resposta = false;
                if (Boolean.TryParse(acessar.ToString(), out resposta))
                {
                    return resposta;
                }
                else
                {
                    return false;
                }
            }
        }
        catch (Exception)
        {
            return false;
            throw;
        }
    }

    public List<string> ObterDireitosUsuario(int codigo)
    {
        DataTable dt;
        List<string> list = new List<string>();
        try
        {
            using (Connection)
            {
                Parameters = new SqlParameter[1];
                Parameters[0] = new SqlParameter("@CodUsuario", codigo);

                dt = ExecuteDataTable("usp_ObterDireitosUsuario", CommandType.StoredProcedure, Parameters);

                if (dt.Rows.Count > 0)
                {
                    list = ConverteParaListaUmTipo<string>(dt);
                }
                return list;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void DeletarDireitosUsuario(int pCodigo)
    {
        try
        {
            using (Connection)
            {
                Parameters = new SqlParameter[1];
                Parameters[0] = new SqlParameter("@CodUsuario", pCodigo);

                base.ExecuteNonQuery("usp_DeletarDireitosUsuario", CommandType.StoredProcedure, Parameters).ToString();
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    public void GravarDireitosUsuario(int pCodigo, string pDireito)
    {
        try
        {
            using (Connection)
            {
                Parameters = new SqlParameter[2];
                Parameters[0] = new SqlParameter("@CodUsuario", pCodigo);
                Parameters[1] = new SqlParameter("@Direitos", pDireito);

                base.ExecuteNonQuery("usp_GravarDireitosUsuario", CommandType.StoredProcedure, Parameters);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}
