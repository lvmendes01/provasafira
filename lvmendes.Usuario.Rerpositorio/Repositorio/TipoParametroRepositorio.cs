
using Dapper;
using Lvmendes.Prova.Entidade;
using Lvmendes.Prova.Repositorio.Interfaces;
using Lvmendes.Prova.Repositorio.RepositorioBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Lvmendes.Prova.Repositorio
{
    public class TipoParametroRepositorio : RepositoryBase<ArtistaModel>, ITipoParametroRepositorio
	{


        public TipoParametroRepositorio()
        {
            this.ConnectionString = Conexao.HNT_DELIVERY.ToString();
        }

        public override IEnumerable<ArtistaModel> GetAll()
        {
            
			using (var con = new SqlConnection(Conexao.HNT_DELIVERY))
			{

				List<ArtistaModel> lista = new List<ArtistaModel>();
				try
				{
					con.Open();


					string sqlQuery = @"SELECT	 t.[CodParametro] 
												,t.[NomeParametro]
												,t.[Observacao]
												,t.[Ativo]
												,t.[NomeParaVisualizacao]
												FROM [HNT_DELIVERY].[dbo].[TbParametro]  p 
												inner join[HNT_DELIVERY].[dbo].[TbTipoParametro] t 
												on p.Cod_Parametro = t.CodParametro
												where t.Ativo = 1
												and p.Condicao = '0'";






					lista = con.Query<ArtistaModel>(sqlQuery).ToList();
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					con.Close();
				}
				return lista;
			}




		}

	}
}
