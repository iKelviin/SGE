using Entity.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Fornecedores
{
    public class FornecedoresInfo : ClienteInfo
    {
        public string cnpj { get; set; }
    }
}
