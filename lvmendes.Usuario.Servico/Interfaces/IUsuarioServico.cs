using lvmendes.Usuario.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvmendes.Prova.Servico.Interfaces
{
    public interface IUsuarioServico
    {

        UsuarioModel LoginUsuario(string usuario, string senha);
    }
}
