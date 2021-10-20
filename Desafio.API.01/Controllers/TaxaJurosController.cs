using Desafio.API._01.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API._01.Controllers
{
    [Route("/api/v1/taxaJuros")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("0,01");
        }
    }
}
