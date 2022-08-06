using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinandoVerbos.ViewModel;

namespace TreinandoVerbos.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly List<Pessoa> pessoas = new List<Pessoa>();
        private static readonly List<Telefone> telefones = new List<Telefone>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new JsonResult(new
            {
                sucesso = true,
                resultado = pessoas
            }));
        }

        [HttpPost]
        public IActionResult Save([FromBody] CadastrarPessoa pessoaViewModel)
        {
            if (pessoaViewModel == null)
                return new JsonResult(new { sucesso = false, mensagem = "Não há dados" });

            pessoas.Add(pessoaViewModel.Pessoa);

            pessoaViewModel.Pessoa.Telefones.ForEach(e => telefones.Add(e));

            return Ok();

        }

    }
}
