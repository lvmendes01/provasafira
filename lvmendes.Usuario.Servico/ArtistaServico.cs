using Lvmendes.Prova.Entidade;
using System.Collections.Generic;
using Lvmendes.Prova.Servico.Dezzer;

namespace Lvmendes.Prova.Servico
{
    public class ArtistaServico : IArtistaService
    {

        public List<ArtistaModel> ListaArtistasPorTotal(int total) 
        {
            List<ArtistaModel> listaRetornar = new List<ArtistaModel>();

            DezzerService dezzerService = new DezzerService();
            var listadoDezze = dezzerService.ListaArtistas(total);


            for (int i = 0; i < listadoDezze.Count; i++)
            {
                listaRetornar.Add(new ArtistaModel
                {
                    link = listadoDezze[i].link,
                    Nome = listadoDezze[i].name,
                    Origem = listadoDezze[i].tracklist,
                    Posicao = i+1

                });
            }
            return listaRetornar;
        }
    }
}
