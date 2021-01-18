using lvmendes.Prova.Servico.Interfaces;
using lvmendes.Usuario.Entidade;
using Lvmendes.Prova.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvmendes.Prova.Servico
{
    public class UsuarioServico : IUsuarioServico
    {

        IUsuarioRepositorio usuarioRepositorio;
        public UsuarioServico(IUsuarioRepositorio _usuarioRepositorio)
        {
            usuarioRepositorio = _usuarioRepositorio;
        }

        public UsuarioModel LoginUsuario(string usuario, string senha)
        {
            return usuarioRepositorio.LoginUsuario(usuario, senha);
        }
    }
}
