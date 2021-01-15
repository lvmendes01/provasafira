using System;
using System.Collections.Generic;
using System.Text;

namespace Lvmendes.Prova.Entidade
{
   public  class ArtistaModel : BaseEntity
    {
        public string Nome { get; set; }
        public string link { get; set; }
        public string Origem { get; set; }
        public int Posicao { get; set; }

    }
}
