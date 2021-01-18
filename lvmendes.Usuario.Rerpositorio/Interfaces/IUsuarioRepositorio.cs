using lvmendes.Usuario.Entidade;
using Lvmendes.Prova.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lvmendes.Prova.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio : IRepositoryBase<UsuarioModel>
    {
        UsuarioModel LoginUsuario(string usuario, string senha);
    }
}
