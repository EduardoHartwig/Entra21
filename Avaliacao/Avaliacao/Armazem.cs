using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao
{
    public class Armazem
    {
        public int ArmazemID { get; set; }
        public string ArmazemDescricao { get; set; }
        List<Produto> ListaDeProdutos { get; set; } = new List<Produto>();

        public Armazem()
        {
        }
    }
}
