using Desafio.API._01.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API._01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        [Route("/api/v1/taxaJuros")]
        public ActionResult Get()
        {
            return Ok("0,01");
        }
    }
}
