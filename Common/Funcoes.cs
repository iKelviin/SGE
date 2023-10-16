using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Enumeracoes;

namespace Common;

public static class Funcoes
{
    public static string MontaConexao(Banco nomeBanco)
    {
        string providerString = string.Empty;

        //Busca a conexao criptografada no arquivo de configuracao de acordo com o banco informado
        switch (nomeBanco)
        {
            case Banco.PROVA:
                providerString = ConfigurationManager.ConnectionStrings["ConnectionPROVA"].ConnectionString;
                break;
            case Banco.Util:
                providerString = ConfigurationManager.ConnectionStrings["ConnectionUtil"].ConnectionString;
                break;
            case Banco.Logistica:
                providerString = ConfigurationManager.ConnectionStrings["ConnectionLogistica"].ConnectionString;
                break;
            default:
                break;
        }


        providerString = Plural.Seguranca.Criptografia.Descriptografar(providerString, "!P@L@U#R$A%L&0*");

        return providerString;
    }
}
