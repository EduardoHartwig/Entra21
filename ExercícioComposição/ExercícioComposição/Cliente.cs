using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioComposição
{
    class Cliente
    {
        public string Nome;
        public string CPF;
        public string Endereco;

        public Cliente(string nome, string cPF, string endereco)
        {
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
        }
    }
}
