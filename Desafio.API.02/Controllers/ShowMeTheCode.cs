using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API._02.Controllers
{
    [Route("/api/v1/showmethecode")]
    [ApiController]
    public class ShowMeTheCode : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("https://github.com/jandersoncampelo/DesafioJurosComposto");
        }
    }
}
