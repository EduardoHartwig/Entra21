using System;

namespace ExercícioComposição
{
    class Program
    {
        static void ExibirVenda(string vendedor, string codigo, string cliente, string cpf, double venda)
        {
            //System.out.println("papapa");


            Console.WriteLine($"\n\nO Vendedor {vendedor} com o código: {codigo}, realizou uma venda de valor {venda.ToString("C")} para o Cliente {cliente} com o CPF: {cpf}");
        }



        static void Main(string[] args)
        {
            Vendedor vendedorA = new Vendedor ("Eduardo", "475799");
            Vendedor vendedorB = new Vendedor("Jonathan", "412525");

            Cliente clienteA = new Cliente("Leandro", "044.372.433-20", "Rua das Dores, Nº 105");
            Cliente clienteB = new Cliente("Patrick", "094.255.300-04", "Rua Antonio da Conceição, Nº 789");

            Venda venda1 = new Venda(7545.98, vendedorA, clienteB);
            Venda venda2 = new Venda(1560.00, vendedorB, clienteA);

            ExibirVenda(vendedorA.Nome, vendedorA.CodigoCracha, clienteB.Nome, clienteB.CPF, venda1.ValorTotalVenda);
            ExibirVenda(vendedorB.Nome, vendedorB.CodigoCracha, clienteA.Nome, clienteB.CPF, venda2.ValorTotalVenda);
        }
    }
}
