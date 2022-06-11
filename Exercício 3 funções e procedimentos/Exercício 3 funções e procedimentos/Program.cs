using System;

namespace Exercício_3_funções_e_procedimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            static void Digite2()
            {
                Console.WriteLine("\nDigite 2 Valores: ");
                Console.Write("\n-> ");
            }

            static void Digite()
            {
                Console.WriteLine("\nDigite 1 Valor: ");
                Console.Write("\n-> ");
            }

            static int[] Bubble(int[] vetor)
            {
                int aux;
                for (int i = 0; i < vetor.Length; i++)
                {
                    for (int j = i + 1; j < vetor.Length; j++)
                    {
                        if (vetor[i] > vetor[j])
                        {
                            aux = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = aux;
                        }
                    }
                }
                return vetor;
            }

            static bool[] sucess(int[] notas, bool[] sucesso)
            {
                for (int i = 0; i < notas.Length; i++)
                {
                    sucesso[i] = (notas[i] >= 7) ? true : false;
                }
                return sucesso;
            }

            static double Soma(double n1, double n2)
            {
                double res;
                return res = n1 + n2;
            }
            static double Subtração(double n1, double n2)
            {
                double res;
                return res = n1 - n2;
            }
            static double Multiplicação(double n1, double n2)
            {
                double res;
                return res = n1 * n2;
            }

            static double Divisão(double n1, double n2)
            {
                double res;
                return res = n1 / n2;
            }
            static int Divisor(int a, int b)
            {
                int res = 0;

                return res = ((a % b) == 0) ? (a / b) : 0;
            }

            int imput = -1;
            int imputb = -1;
            double valorA, valorB = 0;

            


            Console.WriteLine("\n Bem Vindo a 3ª Lista de Exercícios - Funções e Procedimentos. ");

            do
            {
                Console.WriteLine("\nQual Exercício Deseja Ver? ");
                Console.WriteLine("\n1 - Calculadora.");
                Console.WriteLine("2 - Preencher 10 valores e mostrar o maior.");
                Console.WriteLine("3 - Mostrar os Divisores.");
                Console.WriteLine("4 - Alunos Aprovados.");
                Console.WriteLine("\n0 - Sair.");
                Console.Write("\n-> ");
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
                            Console.WriteLine("\nQual operação deseja Efetuar ?");
                            Console.WriteLine("\n1 - Soma.");
                            Console.WriteLine("2 - Subtração.");
                            Console.WriteLine("3 - Multiplicação.");
                            Console.WriteLine("4 - Divisão.");
                            Console.WriteLine("\n0 - Sair.");
                            Console.Write("\n-> ");
                            imputb = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            switch (imputb)
                            {
                                case 0:
                                    imputb = 010101;
                                    break;

                                case 1:
                                    Digite2();
                                    valorA = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("\n-> ");
                                    valorB = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine($"\nA Soma de {valorA} e {valorB} é igual a {Soma(valorA, valorB)}");
                                    break;

                                case 2:
                                    Digite2();
                                    valorA = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("\n-> ");
                                    valorB = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine($"\nA Subtração de {valorA} por {valorB} é igual a {Subtração(valorA, valorB)}");
                                    break;

                                case 3:
                                    Digite();
                                    valorA = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("\n-> ");
                                    valorB = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine($"\nA Multiplicação de {valorA} por {valorB} é igual a {Multiplicação(valorA, valorB)}");
                                    break;

                                case 4:
                                    Digite();
                                    valorA = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("\n-> ");
                                    valorB = Convert.ToDouble(Console.ReadLine());
                                    if (valorB > 0)
                                    {
                                        Console.WriteLine($"\nA Divisão de {valorA} por {valorB} é igual a {Divisão(valorA, valorB)}");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n¦==============================================================¦");
                                        Console.WriteLine("\n¦            NÃO É POSSÍVEL DIVIDIR POR 0 OU MENOR!!!          ¦");
                                        Console.WriteLine("\n¦==============================================================¦");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    }
                                    
                                    break;
                            }

                        } while (imputb != 010101);
                        break;

                    case 2:
                        int[] valor = new int[10];
                        for(int i = 0; i < valor.Length; i++)
                        {
                            Digite();
                            valor[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Bubble(valor);
                        Console.WriteLine($"\nO maior valor é {valor[(valor.Length - 1)]}");

                        for(int i = 0; i < valor.Length; i++)
                        {
                            Console.WriteLine(valor[i]);
                        }

                        break;

                    case 3:
                        int entrada = 0;
                        Console.WriteLine("\nDigite um valor: ");
                        entrada = Convert.ToInt32(Console.ReadLine());

                        for (int i = entrada; i > 0; i--)
                        {
                            if (Divisor(entrada, i) > 0)
                            {
                                Console.WriteLine(Divisor(entrada, i));
                            }
                        }
                        break;

                    case 4:
                        int[] notas = new int[10] { 2, 10, 4, 1, 6, 7, 1, 8, 3, 5 };
                        bool[] aprovados = new bool[10];
                        sucess(notas, aprovados);

                        for (int i = 0; i < notas.Length; i++)
                        {

                            String escreva = (aprovados[i]) ? ($"\nAluno {i}, com a nota {notas[i]}, Você foi Aprovado") : ($"\nAluno {i}, com a nota {notas[i]}, Você foi Reprovado");

                            Console.WriteLine(escreva);    
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n¦==============================================================¦");
                        Console.WriteLine("¦                         OPÇÃO INVÁLIDA                       ¦");
                        Console.WriteLine("¦==============================================================¦");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                }
            } while (imput != 010101);
        }
    }
}
