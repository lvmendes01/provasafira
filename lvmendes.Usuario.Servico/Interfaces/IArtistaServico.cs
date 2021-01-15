using Lvmendes.Prova.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Prova.Servico
{
   public interface IArtistaService
    {
        List<ArtistaModel> ListaArtistasPorTotal(int total);
    }
}
