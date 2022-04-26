using System;

namespace Trabalho1
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcaoa = 0;

            Console.WriteLine("Segue a baixo a lista de Exercícios do Trabalho 1");


            do
            {
                Console.WriteLine("Qual Exercício deseja ver ?");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Aumento de salário.");
                Console.WriteLine("2 - Triângulo.");



                switch(opcaoa)
                {

                    case 1:
                        double salarioBase, aumento, salarioAtualizado, dolar = 4.7, euro = 5.2, salarioDolar, salarioEuro;


                        Console.WriteLine("Colaborador informe seu salário: ");
                        Console.Write("R$ ");
                        salarioBase = Convert.ToDouble(Console.ReadLine());
                        Console.Write(" ");
                        if (salarioBase <= 1200)
                        {
                            aumento = ((20 / 100) * salarioBase);
                        }
                        else
                            if(salarioBase <= 2000)
                            {
                            aumento = ((13 / 100) * salarioBase);
                        }
                        else
                            if(salarioBase <= 2500)
                        {
                            aumento = ((10 / 100) * salarioBase);
                        }
                        else 
                        {
                            aumento = ((5 / 100) * salarioBase);

                        }
                        salarioAtualizado = salarioBase + aumento;
                        Console.WriteLine($"Colaborador teve um aumento de R${aumento}");
                        Console.WriteLine($"O salário atual do colaborador é R${salarioAtualizado}");
                        salarioDolar = salarioAtualizado * dolar;
                        Console.WriteLine($"O salário atual do colaborador em Dólar é U${salarioDolar}");
                        salarioEuro = salarioAtualizado * euro;
                        Console.WriteLine($"O salário atual do colaborador em Euro é €{salarioEuro}");

                        break;


                    case 2:

                        int A, B, C;

                        Console.WriteLine("Informe a medida de 3 lados de um triângulo: ");
                        Console.Write("A: ");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.Write("B: ");
                        B = Convert.ToInt32(Console.ReadLine());
                        Console.Write("C: ");
                        C = Convert.ToInt32(Console.ReadLine());


                        if ((A+B) < C || (A+C) < B || (B+C) < A)
                          {

                            if ((A == B) != C)

                            {


                            }






                        }











                        break;





                    default:


                        break;
                }
            } while (opcaoa != 010101);
            







        }
    }
}
