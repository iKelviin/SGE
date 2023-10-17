using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity;

public class UsuarioInfo
{
    /// <summary>
    /// Codigo de matricula do usuario.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Nome do usuario.
    /// </summary>
    public string Nome { get; set; }
    /// <summary>
    /// Senha de acesso do usuario.
    /// </summary>
    public string Senha { get; set; }
    /// <summary>
    /// Usuario de acesso do usuario.
    /// </summary>
    public string Usuario { get; set; }
    /// <summary>
    /// Senha de acesso do usuario.
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Indica se o usuario esta ou nao esta ativo.
    /// </summary>
    public bool Ativo { get; set; }
    /// <summary>
    /// Indica se o usuario tem status de administrador.
    /// </summary>
    public bool Administrador { get; set; }
}
