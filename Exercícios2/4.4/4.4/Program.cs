using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = 0;

            Console.WriteLine("Quantos valore: ");
            Console.Write("-> ");
            N = Convert.ToInt32(Console.ReadLine());




            int[] entrada = new int[N];
            int[] auxa = new int[N];
            int[] cont = new int[N];




            for (int i = 0; i < entrada.Length; i++)
            {
                Console.Write("DIGITE APENAS NUMEROS INTEIROS : ");
                entrada[i] = Convert.ToInt32(Console.ReadLine());
                auxa[i] = entrada[i];
                cont[i] = 1;


            }

            //mostrando vetor 

            for (int i = 0; i < entrada.Length; i++)
            {
                for (int j = 0; i < entrada.Length; i++)
                {
                    if (entrada[i] == auxa[j])
                    {
                        cont[i] = cont[i]++;
                    }
                }
            }



            for(int i = 0; i <entrada.Length; i++)
            {
                Console.WriteLine($"O elemento {auxc[i]} que está na posição {i}, se repete {cont[i]} vezes.");

            }

        }
    }
}
