using Dapper.FluentMap.Dommel.Mapping;
using Lvmendes.Prova.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lvmendes.Prova.Repositorio.Mappers
{
   public class TipoParametroMap : DommelEntityMap<ArtistaModel>
    {
        //public TipoParametroMap()
        //{
        //    ToTable("TbTipoParametro");
        //    Map(x => x.CodParametro).ToColumn("CodParametro");
        //    Map(x => x.Ativo).ToColumn("Ativo");
        //    Map(x => x.NomeParametro).ToColumn("NomeParametro");
        //    Map(x => x.NomeParaVisualizacao).ToColumn("NomeParaVisualizacao");
        //    // Map(x => x.Team).Ignore();
        //}
    }
}
