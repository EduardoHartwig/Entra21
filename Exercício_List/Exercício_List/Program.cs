using System;
using System.Collections.Generic;


namespace Exercício_List
{
    class Program
    {
        static string CadastrarNome()
        {
            Console.WriteLine("\n\nInforme seu Nome: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        static string CadastrarCpfCliente()
        {
            Console.WriteLine("\n\nInforme seu CPF: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        static string CadastrarEnderecoCliente()
        {
            Console.WriteLine("\n\nInforme seu Endereço: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        static string CadastrarCracha()
        {
            Console.WriteLine("\n\nInforme seu Crachá: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        static string CadastrarDescricao()
        {
            Console.WriteLine("\n\nInforme a Descrição do Produto: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        static string CadastrarMarca()
        {
            Console.WriteLine("\n\nInforme a Marca do Produto: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        static double CadastrarPreco()
        {
            Console.WriteLine("\n\nInforme seu Crachá: ");
            Console.Write("-> ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static int CadastrarClienteID(List<Cliente> clientes)
        {
            int id = 0;

            for (int i = 0; i <= clientes.Count; i++)
            {
                if (clientes.Count == i)
                {
                    id = i;
                }
            }
            return id;
        }

        static int CadastrarVendedorID(List<Vendedor> vendedores)
        {
            int id = 0;

            for (int i = 0; i <= vendedores.Count; i++)
            {
                if (vendedores.Count == i)
                {
                    id = i;
                }
            }
            return id;
        }

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
        static int CadastrarVendaID(List<Venda> vendas)
        {
            int id = 0;

            for (int i = 0; i <= vendas.Count; i++)
            {
                if (vendas.Count == i)
                {
                    id = i;
                }
            }
            return id;
        }

        static int VerificarIDCliente(List<Cliente> clientes)
        {
            int imput;
            do
            {
                Console.WriteLine("\nInforme o ID do Cliente: ");
                imput = Convert.ToInt32(Console.ReadLine());
                if (imput > (clientes.Count))
                {
                    Console.WriteLine("\nID Inexistente. Tente Novamente.");
                }
            } while (imput > (clientes.Count));
            return imput;
        }

        static int VerificarIDProdutoAdicionar(List<Produto> produtos)
        {
            int imput;
            do
            {
                Console.WriteLine("\nQual Produto deseja adicionar ao Carrinho de Compras?");
                imput = Convert.ToInt32(Console.ReadLine());
                if (imput > (produtos.Count))
                {
                    Console.WriteLine("\nID Inexistente. Tente Novamente.");
                }
            } while (imput > (produtos.Count));
            return imput;
        }

        static int VerificarIDProdutoRemover(List<Produto> produtos)
        {
            int imput;
            do
            {
                Console.WriteLine("\nQual Produto deseja remover do Carrinho de Compras?");
                imput = Convert.ToInt32(Console.ReadLine());
                if (imput > (produtos.Count))
                {
                    Console.WriteLine("\nID Inexistente. Tente Novamente.");
                }
            } while (imput > (produtos.Count));
            return imput;
        }

        static Produto ValidarRemoverProdutoID(List<Produto> produtos)
        {
            int imput;
            int id = -1;

            imput = VerificarIDProdutoRemover(produtos);

            foreach (Produto p in produtos)
            {
                if (imput == p.IDProduto)
                {
                    id = imput;
                }

            }
            return produtos[id];
        }


        static Produto ValidarAdicionarProdutoID(List<Produto> produtos)
        {
            int imput;
            int id = -1;

            imput = VerificarIDProdutoAdicionar(produtos);

            foreach(Produto p in produtos)
            {
                if(imput == p.IDProduto)
                {
                    id = imput;
                }
            }
            return produtos[id];
        }

        static Cliente ValidarClienteID(List<Cliente> clientes)
        {
            int imput;
            int id = -1;

            imput = VerificarIDCliente(clientes);

            foreach (Cliente cliente in clientes)
            {
                if (imput == cliente.IDCliente)
                {
                    id = imput;
                }
            }
            return clientes[id];
        }

        static int VerificarIDVendedor(List<Vendedor> vendedores)
        {
            int imput;
            do
            {
                Console.WriteLine("\nInforme o ID do Vendedor: ");
                imput = Convert.ToInt32(Console.ReadLine());
                if (imput > (vendedores.Count))
                {
                    Console.WriteLine("\nID Inexistente. Tente Novamente.");
                }
            } while (imput > (vendedores.Count));
            return imput;
        }

        static Vendedor ValidarVendedorID(List<Vendedor> vendedores)
        {
            int imput;
            int id = -1;

            imput = VerificarIDVendedor(vendedores);

            foreach (Vendedor vendedor in vendedores)
            {
                if (imput == vendedor.IDVendedor)
                {
                    id = imput;
                }
            }
            return vendedores[id];
        }

        static void OpcaoInvalida()
        {
            Console.WriteLine("\n\nOpção Inválida Tente Novamente.");
        }

        static int NenhumDado()
        {
            Console.WriteLine("\n¦==============================================================¦");
            Console.WriteLine("¦                      Nenhum Dado Cadastrado.                 ¦");
            Console.WriteLine("¦==============================================================¦");
            return 010101;
        }

        public static List<Produto> PreencherProdutos(List<Produto> produtos)
        {
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Maminha a vácuo", "Bestbeef", 75));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Leite, 1 Litro", "Tirol", 6));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Bolacha Recheada, Tortinhas", "Isabela", 3.25));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Doritos 300g", "Elma Chips", 20.6));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Sorvete Napolitano 1 Litro", "Kibon", 22.89));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Arroz Parboilizado 5Kg", "Urbano", 28.90));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Feijão Preto 1Kg", "Urbano", 9.50));
            produtos.Add(new Produto(CadastrarProdutoID(produtos), "Açucar Refinado", "União", 2.99));
            return produtos;
        }

        public static void ListarProdutos(List<Produto> produtos)
        {
            Console.WriteLine("\nProdutos a Venda: \n");
            foreach (Produto p in produtos)
            {
                Console.WriteLine($"({p.IDProduto}) - {p.Descricao}, {p.Marca}, {p.Preco.ToString("C")}");
            }
        }

        public static void ListarCarrinho(CarrinhoDeCompras carrinho)
        {
            Console.WriteLine("Produtos no Carrinho: \n");
            foreach(Produto p in carrinho.ListaDeProdutos)
            {
                Console.WriteLine($"({p.IDProduto}) - {p.Descricao}, {p.Marca}, {p.Preco.ToString("C")}");
            }
            Console.WriteLine($"Total no Carrinho: {carrinho.ValorCarrinho.ToString("C")}");
        }

        public static bool FinalizarVenda()
        {
            bool status = false;

            Console.WriteLine("\nDeseja Finalizar a compra ?");
            Console.WriteLine("Y/N");
            char Entrada = Convert.ToChar(Console.ReadLine());

            if ('Y'.Equals(Entrada) || 'y'.Equals(Entrada))
            {
                status = true;
            }
            else if ('N'.Equals(Entrada) || 'n'.Equals(Entrada))
            {
                status = false;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
            return status;
        }


        static void Main(string[] args)
        {
            int imput = -1;
            int imputb = -1;

            List<Cliente> clientes = new List<Cliente>();
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Produto> produtos = new List<Produto>();
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            List<Venda> vendas = new List<Venda>();

            produtos = PreencherProdutos(produtos);

            //Cliente cliente = new Cliente();
            //cliente.NomeCliente = "Eduardo";
            //cliente.CPFCliente = "092";
            //cliente.EnderecoCliente = "rua papapa";
            //clientes.Add(cliente);

            //Vendedor vendedor = new Vendedor();
            //vendedor.NomeVendedor = "Eduardo";
            //vendedor.CodigoCrachaVendedor = "092";
            //vendedores.Add(vendedor);

            do
            {
               
                Console.WriteLine("\n(1) - Cadastros.");
                Console.WriteLine("(2) - Carrinho de Compras.");
                Console.WriteLine("(3) - Exibir Produtos.");


                Console.WriteLine("\n(0) - Sair.");
                Console.Write("-> ");
                imput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (imput)
                {
                    case 0:
                        imput = 010101;
                        break;

                    case 1:

                        do
                        {
                            Console.WriteLine("\n\n(1) - Cadastrar Cliente.");
                            Console.WriteLine("(2) - Cadastrar Vendedor.");
                            Console.WriteLine("(3) - Cadastrar Produto.");
                            Console.WriteLine("\n(0) - Retornar.");

                            Console.Write("-> ");
                            imputb = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (imputb)
                            {


                                case 0:
                                    imputb = 010101;
                                    break;

                                case 1:
                                    Cliente cliente = new Cliente();
                                    Console.WriteLine("Cadastro de Cliente.");
                                    cliente.IDCliente = CadastrarClienteID(clientes);
                                    cliente.NomeCliente = CadastrarNome();
                                    cliente.CPFCliente = CadastrarCpfCliente();
                                    cliente.EnderecoCliente = CadastrarEnderecoCliente();
                                    clientes.Add(cliente);
                                    break;

                                case 2:
                                    Vendedor vendedor = new Vendedor();
                                    Console.WriteLine("Cadastro de Vendedor.");
                                    vendedor.IDVendedor = CadastrarVendedorID(vendedores);
                                    vendedor.NomeVendedor = CadastrarNome();
                                    vendedor.CodigoCrachaVendedor = CadastrarCracha();
                                    vendedores.Add(vendedor);
                                    break;

                                case 3:
                                    Produto produto = new Produto();
                                    Console.WriteLine("Cadastro de Produto.");
                                    produto.IDProduto = CadastrarProdutoID(produtos);
                                    produto.Descricao = CadastrarDescricao();
                                    produto.Marca = CadastrarMarca();
                                    produto.Preco = CadastrarPreco();
                                    produtos.Add(produto);
                                    break;

                                default:
                                    OpcaoInvalida();
                                    break;
                            }
                        } while (imputb != 010101);
                        break;

                    case 2:

                        Console.WriteLine("\nCarrinho de Compras.");
                        carrinho.Cliente = ValidarClienteID(clientes);

                        do
                        {
                            if (clientes[0].NomeCliente != null)
                            {     
                                Console.WriteLine("\n" + carrinho.Cliente.NomeCliente);
                                ListarCarrinho(carrinho);

                                Console.WriteLine("\n(1) - Adicionar Produto ao carrinho.");
                                Console.WriteLine("(2) - Remover Produto do Carrinho.");
                                Console.WriteLine("(3) - Limpar Carrinho.");
                                Console.WriteLine("(4) - Efetuar a Compra.");
                                Console.WriteLine("\n(0) - Retornar.");
                                Console.Write("-> ");
                                imputb = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                switch (imputb)
                                {
                                    case 0:
                                        imputb = 010101;
                                        break;

                                    case 1:
                                        Console.WriteLine("\nAdicionar Produto ao carrinho.");
                                        ListarProdutos(produtos);

                                        carrinho.ListaDeProdutos.Add(ValidarAdicionarProdutoID(produtos));
                                        Console.Clear();
                                        
                                        break;

                                    case 2:
                                        Console.WriteLine("\nRemover Produto do Carrinho.");
                                        ListarCarrinho(carrinho);
                                        if(carrinho.ListaDeProdutos.Count != 0)
                                        {
                                            carrinho.ListaDeProdutos.Remove(ValidarRemoverProdutoID(produtos));
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            imputb = NenhumDado();
                                        }
                                        break;

                                    case 3:
                                        Console.Write("\nLimpando Carrinho...     ");
                                        if (carrinho.ListaDeProdutos.Count != 0)
                                        {
                                            carrinho.ListaDeProdutos.RemoveRange(0, carrinho.ListaDeProdutos.Count);
                                            Console.Write("     ...Carrinho Limpo.\n"); 
                                        }
                                        else
                                        {
                                            imputb = NenhumDado();
                                        }
                                        break;

                                    case 4:
                                        Console.WriteLine("\nEfetuar a Compra.");
                                        if(carrinho.Cliente.NomeCliente != null && carrinho.ListaDeProdutos.Count != 0 && vendedores[0].NomeVendedor != null)
                                        {
                                            Venda venda = new Venda();
                                            venda.IDVenda = CadastrarVendaID(vendas);
                                            venda.Vendedor = ValidarVendedorID(vendedores);
                                            venda.Cliente = carrinho.Cliente;
                                            venda.ListaDeProdutos = carrinho.ListaDeProdutos;
                                            venda.ValorTotalVenda = carrinho.ValorCarrinho;
                                            venda.StatusVenda = FinalizarVenda();

                                            if (venda.StatusVenda)
                                            {
                                                vendas.Add(venda);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Venda Cancelada.");
                                            }
                                        }
                                        else
                                        {
                                            imputb = NenhumDado();
                                        }
                                        break;
                                    default:
                                        OpcaoInvalida();
                                        break;
                                }
                            }
                            else
                            {
                                imputb = NenhumDado();
                            }
                        } while (imputb != 010101);  
                        break;

                    case 3:
                        ListarProdutos(produtos);
                        break;

                    default:
                        OpcaoInvalida();
                        break;
                }
            } while (imput != 010101);

            if(vendas.Count != 0)
            {

                foreach(Venda v in vendas)
                {
                    
                    Console.WriteLine("\n\n" + v.IDVenda);
                    Console.WriteLine($"Cliente {v.Cliente.NomeCliente} com o CPF {v.Cliente.CPFCliente}, residente na {v.Cliente.EnderecoCliente}.");
                    Console.WriteLine($"Vendedor {v.Vendedor.NomeVendedor} com o Crachá {v.Vendedor.CodigoCrachaVendedor}.");
                    
                    foreach(Produto p in v.ListaDeProdutos)
                    {
                        Console.WriteLine($"{p.Descricao}, {p.Marca}, {p.Preco.ToString("C")}");
                    }
                    Console.WriteLine($"Valor total da Venda: {v.ValorTotalVenda.ToString("C")}");
                }
            }
        }
    }
}
