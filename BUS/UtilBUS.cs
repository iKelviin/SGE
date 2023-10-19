using DAL;
using Entity;
using static Common.Enumeracoes;

namespace BUS;

public class UtilBUS
{
    public static UsuarioInfo ValidarUsuario(string usuario, string senha)
    {
        UsuarioDAL dalUsuario = new UsuarioDAL(Banco.SGE);
        return dalUsuario.Validar(usuario, senha);
    }
}