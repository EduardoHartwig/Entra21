using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraAPI
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {

        [HttpGet]
        public string Somar(string valorA, string valorB)
        {
            int resultado = Convert.ToInt32(valorA) + Convert.ToInt32(valorB);

            return resultado.ToString();
        }

        [HttpGet]
        public string Subtrair(string valorA, string valorB)
        {
            int resultado = Convert.ToInt32(valorA) - Convert.ToInt32(valorB);

            return resultado.ToString();
        }

        [HttpGet]
        public string Dividir(string valorA, string valorB)
        {
            int resultado = Convert.ToInt32(valorA) / Convert.ToInt32(valorB);

            return resultado.ToString();
        }

        [HttpGet]
        public string Multiplicar(string valorA, string valorB)
        {
            int resultado = Convert.ToInt32(valorA) * Convert.ToInt32(valorB);

            return resultado.ToString();
        }

    }
}
