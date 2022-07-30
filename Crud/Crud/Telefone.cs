using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    class Telefone
    {
        public int Id { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public int IdPessoa { get; set; }

        public Telefone(string dDD, string numero, int idPessoa)
        {
            DDD = dDD;
            Numero = numero;
            IdPessoa = idPessoa;
        }

        public Telefone(string dDD, string numero)
        {
            DDD = dDD;
            Numero = numero;
        }

        public Telefone()
        {
        }
    }
}
