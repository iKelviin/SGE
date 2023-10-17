using BUS;
using Entity;

namespace Facade;

public static class UtilFacade
{
    public static UsuarioInfo ValidarUsuario(string usuario, string senha)
    {
        UtilBUS busUtil = new UtilBUS();
        return busUtil.ValidarUsuario(usuario, senha);
    }
}