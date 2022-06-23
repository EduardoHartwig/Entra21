using System;
using System.Collections.Generic;

namespace Mais_Experimentos
{
    class Program
    {

        public static bool FinalizarVenda()
        {
            bool status = false;

            Console.WriteLine("\nDeseja Finalizar a compra ?");
            Console.WriteLine("Y/N");
            char Entrada = Convert.ToChar(Console.ReadLine());
            

            if (Entrada.Equals('Y') || Entrada.Equals('y'))
            {
                status = true;
            }
            else if (Entrada.Equals('N') || Entrada.Equals('n'))
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

            bool statusVenda = FinalizarVenda();

            Console.WriteLine(statusVenda);



        }
    }
}
