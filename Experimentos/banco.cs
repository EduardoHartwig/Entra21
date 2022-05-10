using System;

namespace experimentos
{
    class Program
    {
        static void Main(string[] args)
        {

            int entrada = 0;

            static int Divisor(int a, int b)
            {
                int res = 0;

                return res = ((a % b) == 0) ? (a / b) : 0;
            }

            Console.WriteLine("Digite um valor: ");
            entrada = Convert.ToInt32(Console.ReadLine());

            for (int i = entrada; i > 0; i--)
            {
                if (Divisor(entrada, i) > 0)
                {
                    Console.WriteLine(Divisor(entrada, i)); 
                }

            }

        }
    }
}