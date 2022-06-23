using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_List
{
    class Produto
    {
        public int IDProduto { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }

        public Produto(int iDProduto, string descricao, string marca, double preco)
        {
            IDProduto = iDProduto;
            Descricao = descricao;
            Marca = marca;
            Preco = preco;
        }

        public Produto()
        {
        }
    }
}
