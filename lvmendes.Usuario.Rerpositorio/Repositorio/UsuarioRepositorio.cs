
using Dapper;
using lvmendes.Usuario.Entidade;
using Lvmendes.Prova.Entidade;
using Lvmendes.Prova.Repositorio.Interfaces;
using Lvmendes.Prova.Repositorio.RepositorioBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Lvmendes.Prova.Repositorio
{
    public class UsuarioRepositorio : RepositoryBase<UsuarioModel>, IUsuarioRepositorio
    {
        public UsuarioModel LoginUsuario(string usuario, string senha)
        {
            try
            {
                using (var context = new CadastroContext())
                {
                    return context.Usuarios
                        .SingleOrDefault(s => s.Usuario == usuario && s.Senha == senha);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
