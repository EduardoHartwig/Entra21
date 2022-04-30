using System;

namespace Exercícios_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int imput = 0;

            Console.WriteLine(" ");
            Console.WriteLine("Bem vindo a 2ª lista de exercícios.");
            Console.WriteLine(" ");

            do
            {

                Console.WriteLine(" ");
                Console.WriteLine("Qual Exercício deseja ver ? ");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Lista de Nomes.");
                Console.WriteLine("2 - Calcula da média de números indefinidos.");
                Console.WriteLine("3 - Média de 10 notas - Max/Min.");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Sair.");
                Console.WriteLine(" ");
                Console.Write("-> ");
                imput = Convert.ToInt32(Console.ReadLine());




                switch (imput)
                {

                    case 0:

                        imput = 010101;



                        break;


                    case 1:

                        string[] nome = new string[10];

                        Console.WriteLine(" ");
                        Console.WriteLine("Escreva 10 nomes a seguir: ");

                        for (int i = 0; i < nome.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"{i + 1}) Escreva um nome: ");
                            Console.Write("-> ");
                            nome[i] = Console.ReadLine();

                        }
                        Array.Sort(nome);

                        Console.WriteLine(" ");
                        Console.WriteLine("Segue Abaixo os nomes digitados em ordem crescente: ");

                        for (int i = 0; i < nome.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"{i + 1}) {nome[i]}");
                        }
                        break;



                    case 2:


                        Console.WriteLine(" ");
                        Console.WriteLine("Escolha quantas números serão calculados: ");
                        Console.Write("-> ");
                        int N = Convert.ToInt32(Console.ReadLine());

                        int[] numero = new int[N];
                        int resultado = 0;



                        if (N > 0)
                        {
                            for (int i = 0; i < numero.Length; i++)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{i + 1}) Digite um Número: ");
                                Console.Write("-> ");
                                numero[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            for (int i = 0; i < numero.Length; i++)
                            {
                                resultado = resultado + numero[i];
                            }

                            resultado = resultado / numero.Length;

                            Console.WriteLine(" ");
                            Console.WriteLine($"A média dos números digitados é: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Número de entradas não aceito.");
                        }
                        break;




                    case 3:

                        int[] notas = new int[10];
                        resultado = 0;
                        int max = 0;
                        int min = 0;

                        for (int i = 0; i < notas.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"{i + 1}) Digite uma nota: ");
                            Console.Write("-> ");
                            notas[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        for (int i = 0; i < notas.Length; i++)
                        {
                            resultado = resultado + notas[i];
                        }

                        resultado = resultado / notas.Length;
                        Array.Sort(notas);
                        min = Math.Min(notas[0], notas[9]);
                        max = Math.Max(notas[0], notas[9]);



                        Console.Write(" ");
                        Console.WriteLine($"A média das notas digitadas é: {resultado}");
                        Console.WriteLine($"A maior nota digitada é: {max}");
                        Console.WriteLine($"A menor nota digitada é: {min}");
                        break;



                    case 4:





                        //int[] entrada = new int[N];
                        do
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Escolha quantas entradas serâo: ");
                            Console.Write("-> ");
                            N = Convert.ToInt32(Console.ReadLine());

                            int M = N;
                            int[,] cont = new int[N, M];
                            int[] entrada = new int[N];

                            for (int i = 0; i < entrada.Length; i++)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Digite um valor inteiro: ");
                                Console.Write("-> ");
                                entrada[i] = Convert.ToInt32(Console.ReadLine());
                                for (int j = 0; j < entrada.Length; j++)
                                {
                                    
                                    if (entrada[i] == cont[0, 1]) 
                                    {
                                        cont[0, 1] = (cont[0, 1]++); 

                                    }
                                    else
                                        if(entrada[i] == cont[1,0] )
                                    {
                                        cont[1, 1] = (cont[1, 1]++);

                                    }
                                    else
                                        if(entrada[i] == cont[2,0])
                                    {
                                        cont[2, 1] = (cont[2, 1]++);
                                    }
                                    else
                                        if (entrada[i] == cont[3, 0])
                                    {
                                        cont[3, 1] = (cont[3, 1]++);
                                    }
                                    else
                                        if (entrada[i] == cont[4, 0])
                                    {
                                        cont[4, 1] = (cont[4, 1]++);
                                    }
                                    else
                                        if (entrada[i] == cont[5, 0])
                                    {
                                        cont[5, 1] = (cont[5, 1]++);
                                    }
                                    else
                                        if (entrada[i] == cont[6, 0])
                                    {
                                        cont[6, 1] = (cont[6, 1]++);
                                    }
                                }


                            }






                        } while (N >= 0);





                        break;



                    default:



                        break;





                }







            } while (imput != 010101);


        }
    }
}
