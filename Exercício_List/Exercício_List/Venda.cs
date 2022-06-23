using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_List
{
    class Venda 
    {
        public int IDVenda { get; set; }
        public double ValorTotalVenda { get; set; }
        public bool StatusVenda { get; set; }
        public Vendedor Vendedor { get; set; } = new Vendedor();
        public Cliente Cliente { get; set; } = new Cliente();
        public List<Produto> ListaDeProdutos { get; set; } = new List<Produto>();

        public Venda()
        {
        }
    }
}
