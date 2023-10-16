using Common;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Common.Enumeracoes;

namespace DAL;

abstract public class BaseDAL<T>
{
    #region Propriedades
    /// <summary>
    /// Propriedade de Conexão
    /// </summary>
    private SqlConnection connection;
    /// <summary>
    /// Propriedade de Transação do Banco de Dados.
    /// </summary>
    private SqlTransaction transaction;
    /// <summary>
    /// Parametros utilizados nos comandos SQL das classes DAL.
    /// </summary>
    private SqlParameter[] parameters;
    /// <summary>
    /// Comando SQL que será utilizado pelas classes DAL.
    /// </summary>
    private SqlCommand command;
    /// <summary>
    /// SqlDataReader utilizado nas classes DAL.
    /// </summary>
    private SqlDataReader reader;
    /// <summary>
    /// Banco aonde a conexao sera realizada.
    /// </summary>
    private Banco bancoConexao;

    public SqlConnection Connection
    {
        get
        {
            if (connection == null)
            {

                connection = new SqlConnection(Funcoes.MontaConexao(bancoConexao));

                connection.Open();


            }
            else
            {


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Dispose();

                    connection = new SqlConnection(Funcoes.MontaConexao(bancoConexao));
                    connection.Open();
                }


            }
            return connection;
        }
        set { connection = value; }
    }

    public Banco BancoConexao
    {
        get { return bancoConexao; }
        set { bancoConexao = value; }
    }

    public SqlTransaction Transaction
    {
        get { return transaction; }
        set { transaction = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public SqlParameter[] Parameters
    {
        get { return parameters; }
        set { parameters = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public SqlCommand Command
    {
        get
        {
            command.CommandTimeout = 30000;
            return command;
        }
        set { command = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public SqlDataReader Reader
    {
        get { return reader; }
        set { reader = value; }
    }

    /// <summary>
    /// Propriedades de TryParse
    /// </summary>
    public DateTime data = new DateTime();
    public int inteiro = new int();
    public float numero = new float();
    #endregion

    #region Construtores
    /// <summary>
    /// Construtor da BaseDAL onde abre a conexão para todas as classes DAL.
    /// </summary>
    public BaseDAL(Banco pBanco)
    {
        try
        {
            this.bancoConexao = pBanco;
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Destrutor da BaseDAL, onde verifica o status da Conexão. 
    /// Se estiver aberta, a conexão será fechada.
    /// </summary>
    ~BaseDAL()
    {
        try
        {

        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #region Metodos CRUD


    /// <summary>
    /// Método abstrato para excluir um objeto do banco.
    /// </summary>
    /// <param name="voT">Objeto que será excluído do banco.</param>
    abstract public void Excluir(T voT);

    /// <summary>
    /// Método abstrato para gravar(alterar) um objeto no banco.
    /// </summary>
    /// <param name="voT">Objeto com as informações que serão gravadas.</param>
    abstract public int Inserir(T voT);

    /// <summary>
    /// Método que obtém os dados do tipo do objeto(T) que estão no banco.
    /// </summary>
    /// <param name="voT">Objeto com informações para filtrar a busca no banco.</param>
    /// <returns>Collection do Tipo do Objeto (T) que será retornada.</returns>
    abstract public List<T> ObterLista();

    /// <summary>
    /// Metodo que obtem um objeto T a partir de um ID informado.
    /// </summary>
    /// <param name="id">ID do objeto.</param>
    /// <returns>Objeto (T).</returns>
    abstract public T Obter(int id);

    #endregion

    /// <summary>
    /// Comando padrão para execução NonQuery com controle de conexão.
    /// </summary>
    /// <param name="pSqlCommand">Comando SQL</param>
    /// <param name="pCommandType">Tipo do Comando</param>
    /// <param name="pParameters">Parametros do Comando</param>
    /// <returns>Retorna Identity em caso de Insert, ou a quantidade de linhas alteradas.</returns>
    public int ExecuteNonQuery(string pSqlCommand, System.Data.CommandType pCommandType, SqlParameter[] pParameters)
    {
        try
        {
            using (Connection)
            {

                Command = new SqlCommand(pSqlCommand, connection);
                Command.CommandType = pCommandType;

                Command.Parameters.AddRange(pParameters);

                return Command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            //connection.Close();
        }
    }

    public int ExecuteNonQuery(string pSqlCommand, System.Data.CommandType pCommandType)
    {
        parameters = new SqlParameter[0];
        return ExecuteNonQuery(pSqlCommand, pCommandType, parameters);
    }

    /// <summary>
    /// Comando para executar NonQuery com passagem automatica de parametros,
    /// a partir dos atributos do objeto informado.
    /// </summary>
    /// <typeparam name="Typ">Tipo do objeto informado.</typeparam>
    /// <param name="pProcedureName">Nome da procedure a ser executada.</param>
    /// <param name="pObj">Objeto cujos atributos serao passados como parametro.</param>
    /// <returns>Resultado da execucao.</returns>
    public int ExecuteNonQuery<Typ>(string pProcedureName, Typ pObj)
    {
        List<ParametroSQLInfo> parametrosProcedure = ObtemParametrosDeEntrada(pProcedureName);

        Type tipo = typeof(Typ);
        Parameters = new SqlParameter[parametrosProcedure.Count];
        int contador = 0;

        foreach (ParametroSQLInfo parametro in parametrosProcedure)
        {
            foreach (PropertyInfo propriedade in tipo.GetProperties())
            {
                if (parametro.Nome == string.Concat("@", propriedade.Name))
                {
                    if (parametro.AceitaNulo && propriedade.GetValue(pObj) == null)
                    {
                        Parameters[contador] = new SqlParameter(parametro.Nome, DBNull.Value);
                    }
                    Parameters[contador] = new SqlParameter(parametro.Nome, propriedade.GetValue(pObj));
                    contador++;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        return ExecuteNonQuery(pProcedureName, CommandType.StoredProcedure, Parameters);
    }

    public DataTable ExecuteDataTable(string pSqlCommand, System.Data.CommandType pCommandType)
    {
        parameters = new SqlParameter[0];
        return ExecuteDataTable(pSqlCommand, pCommandType, parameters);
    }

    public DataTable ExecuteDataTable(string pSqlCommand, System.Data.CommandType pCommandType, List<SqlParameter> pParameters)
    {
        return ExecuteDataTable(pSqlCommand, pCommandType, pParameters.ToArray());
    }

    /// <summary>
    /// Comando padrão para execução de comandos de Select com controle de conexão.
    /// </summary>
    /// <param name="pSqlCommand">Comando SQL</param>
    /// <param name="pCommandType">Tipo de Comando</param>
    /// <param name="pParameters">Parametros do Comando</param>
    /// <returns>SqlDataReader</returns>
    public DataTable ExecuteDataTable(string pSqlCommand, System.Data.CommandType pCommandType, SqlParameter[] pParameters)
    {
        try
        {
            using (Connection)
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                Command = new SqlCommand(pSqlCommand, connection);
                Command.CommandType = pCommandType;
                Command.CommandTimeout = 60;

                if (pParameters != null)
                    Command.Parameters.AddRange(pParameters);

                SqlDataAdapter sda = new SqlDataAdapter(Command);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                return dt;
            }
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            //if (Connection.State == ConnectionState.Open)
            //    Connection.Close();
        }
    }

    public object ExecuteScalar(string pSqlCommand, System.Data.CommandType pCommandType)
    {
        parameters = new SqlParameter[0];
        return ExecuteScalar(pSqlCommand, pCommandType, parameters);
    }

    public object ExecuteScalar(string pSqlCommand, System.Data.CommandType pCommandType, List<SqlParameter> pParameters)
    {
        return ExecuteScalar(pSqlCommand, pCommandType, pParameters.ToArray());
    }
    /// <summary>
    /// Comando padrão para execução de um comando SQL retornando Objeto.
    /// </summary>
    /// <param name="pSqlCommand">Comando SQL</param>
    /// <param name="pCommandType">Tipo do Comando</param>
    /// <param name="pParameters">Parametros</param>
    /// <returns>Objeto</returns>
    public object ExecuteScalar(string pSqlCommand, System.Data.CommandType pCommandType, SqlParameter[] pParameters)
    {
        try
        {
            using (Connection)
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                Command = new SqlCommand(pSqlCommand, Connection);
                Command.CommandType = pCommandType;

                Command.Parameters.AddRange(pParameters);

                return Command.ExecuteScalar();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Comando para executar NonQuery com passagem automatica de parametros,
    /// a partir dos atributos do objeto informado.
    /// </summary>
    /// <typeparam name="Typ">Tipo do objeto informado.</typeparam>
    /// <param name="pProcedureName">Nome da procedure a ser executada.</param>
    /// <param name="pObj">Objeto cujos atributos serao passados como parametro.</param>
    /// <returns>Resultado da execucao.</returns>
    public object ExecuteScalar<Typ>(string pProcedureName, Typ pObj)
    {
        List<ParametroSQLInfo> parametrosProcedure = ObtemParametrosDeEntrada(pProcedureName);

        Type tipo = typeof(Typ);
        Parameters = new SqlParameter[parametrosProcedure.Count];
        int contador = 0;

        foreach (ParametroSQLInfo parametro in parametrosProcedure)
        {
            foreach (PropertyInfo propriedade in tipo.GetProperties())
            {
                if (parametro.Nome == string.Concat("@", propriedade.Name))
                {
                    if (parametro.AceitaNulo && propriedade.GetValue(pObj) == null)
                    {
                        Parameters[contador] = new SqlParameter(parametro.Nome, DBNull.Value);
                        contador++;
                        break;
                    }
                    Parameters[contador] = new SqlParameter(parametro.Nome, propriedade.GetValue(pObj));
                    contador++;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        return ExecuteScalar(pProcedureName, CommandType.StoredProcedure, Parameters);
    }

    public bool VerificaColuna(string NomeColuna, SqlDataReader Reader)
    {
        for (int i = 0; i < Reader.FieldCount; i++)
        {
            if (Reader.GetName(i) == NomeColuna)
                return true;
        }
        return false;
    }

    public bool VerificaColuna(string NomeColuna, DataRow dr)
    {
        for (int i = 0; i < dr.Table.Columns.Count; i++)
        {
            if (dr.Table.Columns[i].ColumnName == NomeColuna)
                return true;
        }
        return false;
    }

    /// <summary>
    /// Metodo que popula um objeto T com dados de um registro do banco de dados.
    /// </summary>
    /// <param name="registro">Registro do banco de dados.</param>
    /// <returns>Objeto do tipo T.</returns>
    protected List<Typ> ConverteParaLista<Typ>(DataTable dt)
    {
        List<Typ> lst = new List<Typ>();
        foreach (DataRow row in dt.Rows)
        {
            Typ item = PegaItem<Typ>(row);
            lst.Add(item);
        }
        return lst;
    }

    protected List<Typ> ConverteParaListaUmTipo<Typ>(DataTable dt)
    {
        List<Typ> lst = new List<Typ>();
        foreach (DataRow row in dt.Rows)
        {
            Typ item = (Typ)row[0];
            lst.Add(item);
        }
        return lst;
    }

    protected Typ PegaItem<Typ>(DataRow registro)
    {
        Type temp = typeof(Typ);
        Typ obj = Activator.CreateInstance<Typ>();

        foreach (DataColumn coluna in registro.Table.Columns)
        {
            foreach (PropertyInfo propriedade in temp.GetProperties())
            {
                if (propriedade.Name == coluna.ColumnName)
                {
                    if (registro[coluna.ColumnName] != DBNull.Value)
                    {
                        propriedade.SetValue(obj, registro[coluna.ColumnName], null);
                    }

                }
                else
                {
                    continue;
                }
            }
        }
        return obj;
    }

    private List<ParametroSQLInfo> ObtemParametrosDeEntrada(string pNomeProcedure)
    {
        try
        {
            List<ParametroSQLInfo> parametros = new List<ParametroSQLInfo>();
            DataTable dt = new DataTable();

            using (Connection)
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                Command = new SqlCommand("usp_ObterParametrosProcedure", connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandTimeout = 60;

                Command.Parameters.Add(new SqlParameter() { ParameterName = "@NomeProcedure", Value = pNomeProcedure });

                SqlDataAdapter sda = new SqlDataAdapter(Command);


                sda.Fill(dt);
            }

            parametros = ConverteParaLista<ParametroSQLInfo>(dt);

            return parametros;
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {

        }
    }

}