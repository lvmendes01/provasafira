
using Lvmendes.Prova.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lvmendes.Super.WeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private readonly IArtistaService servico;

        public ArtistaController(IArtistaService _servico)
        {
            servico = _servico;
        }
        /// <summary>
        /// 
        /// </summary>
        //[Authorize]
        [HttpGet]
        [Route("/ListaTop/{total}")]
        [SwaggerOperation("")]
        public RetornoApi ListaTop(int total)
        {
            var item = servico.ListaArtistasPorTotal(total);
          
            RetornoApi retornoApi = new RetornoApi
            {
                resultado = (item != null),
                valor = (item != null) ? item : null

            };
            return retornoApi;
        }
       
    }
}
