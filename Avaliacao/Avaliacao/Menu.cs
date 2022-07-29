using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao
{
    public class Menu
    {
        //public enum operacoes
        //{
        //    Sair,
        //    CriarArmazem,
        //    AlterarArmazem,
        //    RemoverArmazem,
        //}

        //public enum operacoesArmazem
        //{
        //    Sair,
        //    AdicionarProduto,
        //    RemoverProduto,
        //}

        static int CadastrarProdutoID(List<Produto> produtos)
        {
            int id = 0;

            for (int i = 0; i <= produtos.Count; i++)
            {
                if (produtos.Count == i)
                {
                    id = i;
                }
            }
            return id;
        }

        static int CadastrarArmazemID(List<Armazem> armazens)
        {
            int id = 0;

            for (int i = 0; i <= armazens.Count; i++)
            {
                if (armazens.Count == i)
                {
                    id = i;
                }
            }
            return id;
        }

        static int VerificarIDArmazem(List<Armazem> armazems)
        {
            int imput;
            do
            {
                Console.WriteLine("\nInforme o ID do armazem: ");
                imput = Convert.ToInt32(Console.ReadLine());
                if (imput > (armazems.Count))
                {
                    Console.WriteLine("\nID Inexistente. Tente Novamente.");
                }
            } while (imput > (armazems.Count));
            return imput;
        }


        static Armazem ValidarArmazemID(List<Armazem> armazems)
        {
            int imput;
            int id = -1;

            imput = VerificarIDArmazem(armazems);

            foreach (Armazem armazem in armazems)
            {
                if (imput == armazem.ArmazemID)
                {
                    id = imput;
                }
            }
            return armazems[id];
        }

        public static List<Produto> PreencherProdutos(List<Produto> produtos)
        {
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Geladeira"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Ventilador"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Fogão"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Micro-ondas"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Forno Elétrico"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Freezer"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Liquitificador"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Ferro de Passar"));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Televisão"));
            return produtos;
        }

        List<Produto> produtos = new List<Produto>();




        public static void MostrarMenu()
        {
            List<Armazem> armazems = new List<Armazem>();


            Console.WriteLine("\n\n1 - Criar um Armazém.");
            Console.WriteLine("2 - Alterar um Armazém.");
            Console.WriteLine("3 - Remover um Armazém.");
            Console.WriteLine("\n0 - Sair");
            Console.Write("-> ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (opcao)
                {
                    case 0:
                        opcao = 010101;
                        break;

                    case 1:
                        Armazem armazem = new Armazem();
                        armazem.ArmazemID = CadastrarArmazemID(armazems);
                        Console.WriteLine("Informe o nome do Armazém.");
                        armazem.ArmazemDescricao = Console.ReadLine();
                        armazems.Add(armazem);
                        break;

                    case 2:
                        int opcaob = -1;

                        Console.WriteLine("Qual Armazém Deseja alterar?");
                        


                        break;
                }
            } while (opcao != 010101);
           


        }
    }
}
