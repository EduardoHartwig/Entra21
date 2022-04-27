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

                Console.WriteLine(" ");
                Console.WriteLine("Qual Exercício deseja ver ?");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Aumento de salário.");
                Console.WriteLine("2 - Triângulo.");
                Console.WriteLine("3 - Bhaskara.");
                Console.WriteLine("4 - Distinguir Vogal/Consoante");
                Console.WriteLine("5 - Ordem Crescente.");
                Console.WriteLine("6 - Ano Bissexto.");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Sair.");
                Console.Write("-> ");
                opcaoa = Convert.ToInt32(Console.ReadLine());


                switch(opcaoa)
                {
                    case 0:

                        opcaoa = 010101;

                        break;

                    case 1:
                        double salarioBase, aumento, salarioAtualizado, dolar = 4.7, euro = 5.2, salarioDolar, salarioEuro;

                        Console.WriteLine(" ");
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
                        Console.WriteLine(" "); 
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
                        if ((A + B) > C || (A + C) > B || (B + C) > A)
                        {
                            Console.WriteLine("Formam um triângulo.");
                            if ((A == B) && (B == C))

                            {
                                Console.WriteLine(" ");
                                Console.Write("Triângulo Equilátero");
                            }
                            else if ((A == B) || (B == C) || (A == C))
                            {
                                Console.WriteLine(" ");
                                Console.Write("Triângulo Isósceles");
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                Console.Write("Triângulo Escaleno");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não formam um triângulo.");
                        }
                        break;


                    case 3:

                        
                        double delta, x1, x2;

                        Console.WriteLine("Informe os 3 valores de uma fórmula de Bhaskara: ");
                        Console.WriteLine("(Ax² + Bx + C)");
                        Console.Write("A: ");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.Write("B: ");
                        B = Convert.ToInt32(Console.ReadLine());
                        Console.Write("C: ");
                        C = Convert.ToInt32(Console.ReadLine());
                        delta = Math.Pow(B, 2) - 4 * A * C;
                        while (!(delta > 0))
                        {

                            if (delta == 0)
                            {

                                x1 = (-B + Math.Sqrt(delta));

                                Console.WriteLine($"X' = {x1}");

                            }
                            else
                            {
                                x1 = (-B + Math.Sqrt(delta));
                                x2 = (-B - Math.Sqrt(delta));


                                Console.WriteLine($"X' = {x1}");
                                Console.WriteLine($"X'' = {x2}");
                            }
                        }
                        Console.WriteLine("Equação sem raízes.");
                        break;
                    
                     case 4:

                        char letra;

                        Console.WriteLine("Digite uma letra:");
                        letra = Convert.ToChar(Console.ReadLine());

                        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                        {
                            Console.WriteLine($"'{letra}' é uma vogal.");
                        }
                        else
                        {
                            Console.WriteLine($"'{letra}' é uma consoante.");
                        }
                        break;

                    case 5:


                        int[] num = new int[3];

                        Console.WriteLine("Informe 3 valores diferentes: ");
                        Console.Write("A: ");
                        A =  Convert.ToInt32(Console.ReadLine());
                        num[0] = A;
                        Console.Write("B: ");
                        B =  Convert.ToInt32(Console.ReadLine());
                        num[1] = B;
                        Console.Write("C: ");
                        C = Convert.ToInt32(Console.ReadLine());
                        num[2] = C;

                        Console.WriteLine("Segue abaixo os valores em ordem Crescente: ");

                        Array.Sort(num);
                        foreach (int i in num)
                        {
                            Console.Write("-> ");
                            Console.WriteLine(i);
                        }
                        break;

                    case 6:

                        int ano = 0;

                        Console.WriteLine("Digite o valor do ano: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        if (((ano % 4 == 0) && (ano % 100 != 0)) || ano % 400 == 0)
                            Console.WriteLine($"{ano} é um ano bissexto");
                        else
                            Console.WriteLine($"{ano} não é um ano bissexto");
                        Console.WriteLine();

                        break;

                    default:

                        Console.WriteLine("Válor inválido, Tente Novamente.");
                        break;
                }
            } while (opcaoa != 010101);

            Console.WriteLine(" ");
            Console.WriteLine("Obrigado por ter Vizulizado o meu Primeiro Trabalho realizado em C# no Entra21");
        }
    }
}
