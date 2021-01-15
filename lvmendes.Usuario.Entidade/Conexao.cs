using System;
using System.Collections.Generic;
using System.Text;

namespace Lvmendes.Prova.Entidade
{
    public static class Conexao
    {
        public static string HNT_INTEGRACAO = "Data Source=192.168.2.13;Initial Catalog=HNT_INTEGRACAO;Persist Security Info=True;User ID=ti_aplicacao;Password=@htn_dev_13";
        public static string HNT_DELIVERY = "Data Source=192.168.2.13;Connection Timeout=90;Initial Catalog=HNT_DELIVERY;Persist Security Info=True;User ID=ti_aplicacao;Password=@htn_dev_13";
        public static string HNT_WEB = "Data Source=192.168.2.13;Connection Timeout=90;Initial Catalog=HNT_WEB;Persist Security Info=True;User ID=ti_aplicacao;Password=@htn_dev_13";
    }
}

