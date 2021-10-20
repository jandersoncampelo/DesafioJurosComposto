using Desafio.API._02.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desafio.API._02.Controllers
{
    [Route("api/v1/calculaJuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public CalculaJurosController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet("{valorInicial}, {tempo}")]
        public async Task<decimal> Get(decimal valorInicial, int tempo)
        {
            var client = _clientFactory.CreateClient("TaxaAPI");
            var response = await client.GetAsync("/api/v1/taxaJuros");
            string str = await response.Content.ReadAsStringAsync();

            decimal taxa = Decimal.Parse(str);
            
            return TaxaServices.TruncateDecimal(Decimal.Multiply(valorInicial, (decimal)Math.Pow(1 + (double)taxa, tempo)), 2);
        }
    }
}
