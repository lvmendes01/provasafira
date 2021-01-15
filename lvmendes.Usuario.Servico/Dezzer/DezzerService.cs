using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Prova.Servico.Dezzer
{
    public class DezzerService
    {

        public List<DezzerModel> ListaArtistas(int totalartista)
        {
            List<DezzerModel> listaArtistas = new List<DezzerModel>();
            for (int i = 1; i < totalartista; i++)
            {
                var client = new RestClient("https://api.deezer.com/artist/" + i.ToString());
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Cookie", "dzr_uniq_id=dzr_uniq_id_fr64b448c595561c032c4d8ed20fc454a14bb016; ak_bmsc=1EB7019F5D5492EAF9FE9D9630FD804E17DBACAC3D2600003CE0016003CFF41A~plhFRCu/JLNUEaKsI6dN8yDzXrU0kVT3JIzqkR02QULqmkdUG0satjlG7Ft0FtOXxA4nQ7ts/5StHvcQGKnHBDHch+cerSWdifgY/nP9N/M7JM/be7fgrf2EsbX+IRO7ttRHc70TslcmrTvQxBP0kNwi7772GUXsF671+NpsEweGE1QBjtutDsQlbNGGbPDw+ypHhSJiApZeF1xSY9tyYzzcbGJyEKg/0K6kVXr4K+HT0=; bm_sv=2660336505C01B80E79BB216A64DE60A~Kc3Le2wvuSXesA6JsslcjLhVXY593K+cT5j1tvlXZSXrZYedDma0uL8a5YeJhS3r+NWNAH2pAO3opp3Xf5RzgGpe7kop2N/WhNT+BAt6nrJDtbIUZ/ehweHjcGC7HvjUs1Ecl9Ub7QJswOe9Gz8xUeriaKaXe2etR9wPFyaFnB4=");
                IRestResponse response = client.Execute(request);

                DezzerModel myDeserializedClass = JsonConvert.DeserializeObject<DezzerModel>(response.Content);
                listaArtistas.Add(myDeserializedClass);
            }
            return listaArtistas;
        }
    }
}
