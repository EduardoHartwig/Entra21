using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercício_List
{
    class CarrinhoDeCompras
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public List<Produto> ListaDeProdutos { get; set; } = new List<Produto>();

        public double ValorCarrinho
        {
            get
            {
                double total = 0;
                if(ListaDeProdutos != null && ListaDeProdutos.Any())
                {
                    foreach(Produto p in ListaDeProdutos)
                    {
                        total += p.Preco;
                    }
                }
                return total;
            }
        }

        public CarrinhoDeCompras()
        {
        }
    }
}
