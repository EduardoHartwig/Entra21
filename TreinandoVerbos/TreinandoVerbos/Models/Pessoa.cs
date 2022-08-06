using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinandoVerbos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }
        public Endereco Endereco { get; set; }
        public List<Telefone> Telefones { get; set; }

    }
}

