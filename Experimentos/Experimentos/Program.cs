using System;

namespace Experimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numa = 0, numb = 0, numc = 0, maior = 0, menor = 0, auxa = 0, auxb = 0;
            


            Console.WriteLine("Escreva 3 digitos");
            numa = Convert.ToInt32(Console.ReadLine());
            numb = Convert.ToInt32(Console.ReadLine());
            numc = Convert.ToInt32(Console.ReadLine());



            auxa = Math.Max(numa, numb);
            auxb = Math.Max(numb, numc);

            maior = Math.Max(auxa, auxb);


            Console.WriteLine("maior nota = " + maior);


            
            

            
        }
    }
}
