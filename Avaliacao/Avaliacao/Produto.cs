using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao
{
    public class Produto
    {



        public int ProdutoID { get; set; }
        public string ProdutoDescricao { get; set; }

        public Produto(int produtoID, string produtoDescricao)
        {
            ProdutoID = produtoID;
            ProdutoDescricao = produtoDescricao;
        }

        public Produto()
        {
        }
    }
}
