using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Crud
{
    class Pessoa
    {
       
    

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }

        public Pessoa(string nome, string cpf, string rg, DateTime dataNascimento, string naturalidade)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Naturalidade = naturalidade;
        }

        public Pessoa(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }

        public Pessoa(int id, string nome, string cpf, string rg, DateTime dataNascimento, string naturalidade)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Naturalidade = naturalidade;
        }

        public Pessoa()
        {
        }
    }
}
