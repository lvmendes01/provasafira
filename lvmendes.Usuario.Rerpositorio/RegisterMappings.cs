using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Lvmendes.Prova.Repositorio.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Prova.Repositorio
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.ForDommel();
            });
        }
    }
}
