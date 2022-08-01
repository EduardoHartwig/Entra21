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

            bool statusVenda = FinalizarVenda();

            Console.WriteLine(statusVenda);



        }
    }
}
