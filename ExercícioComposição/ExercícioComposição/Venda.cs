using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioComposição
{
    class Venda
    {
        public double ValorTotalVenda;
        public Vendedor Vendedor;
        public Cliente Cliente;

        public Venda(double valorTotalVenda, Vendedor vendedor, Cliente cliente)
        {
            ValorTotalVenda = valorTotalVenda;
            Vendedor = vendedor;
            Cliente = cliente;
        }

    }
}
