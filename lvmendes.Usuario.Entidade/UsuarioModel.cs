using Lvmendes.Prova.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvmendes.Usuario.Entidade
{
    public class UsuarioModel : BaseEntity
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
