using System;

namespace Exercícios2
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
                Console.WriteLine("4 - Verificação de números repetidos.");
                Console.WriteLine("5 - Intercalar texto.");
                Console.WriteLine("6 - Multiplicação de vetores.");
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

                        int aux = notas[0];
                        for (int i = 0; i < notas.Length; i++)
                        {
                            for (int j = i + 1; j < notas.Length; j++)
                            {
                                if (notas[i] > notas[j])
                                {
                                    aux = notas[i];

                                    notas[i] = notas[j];

                                    notas[j] = aux;
                                }
                            }
                        }
                        min = notas[0];
                        max = notas[9];
                        Console.Write(" ");
                        Console.WriteLine($"A média das notas digitadas é: {resultado}");
                        Console.WriteLine($"A maior nota digitada é: {max}");
                        Console.WriteLine($"A menor nota digitada é: {min}");
                        break;

                    case 4:

                        Console.WriteLine(" ");
                        Console.WriteLine("Escolha quantas entradas serâo: ");
                        Console.Write("-> ");
                        N = Convert.ToInt32(Console.ReadLine());

                        int[] vet = new int[N];
                        int[] vetcopia = new int[N];
                        int[] vetcont = new int[N];

                        for (int i = 0; i < vet.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Digite um valor inteiro: ");
                            Console.Write("-> ");
                            vet[i] = Convert.ToInt32(Console.ReadLine());
                            vetcopia[i] = vet[i];
                            vetcont[i]++;
                        }

                        for (int i = 0; i < vet.Length; i++)
                        {
                            for (int j = 0; j < vet.Length; j++)
                            {
                                if (i != j)
                                {
                                    if (vet[i] == vetcopia[j])
                                    {
                                        vetcont[i]++;
                                    }
                                }
                            }
                        }

                        for (int i = 0; i < vet.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"O elemento {vet[i]}, que está na posição {i} aparece {vetcont[i]} vezes.");
                        }
                        break;



                    case 5:

                        string[] texto = new string[10];


                        for (int i = 0; i < texto.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Digite um texto: ");
                            Console.Write("-> ");
                            texto[i] = Console.ReadLine();
                        }
                        Console.WriteLine(" ");

                        for (int i = 0; i < texto.Length; i++)
                        {
                            Console.Write($" {texto[i]} ");

                            if (i != texto.Length - 1)
                            {
                                Console.Write(" -OU- ");
                            }

                        }

                        break;

                    case 6:

                        double[] veta = new double[5];
                        double[] vetb = new double[5];
                        double[] vetresultado = new double[5];



                        Console.WriteLine("Digite 5 Valores para o Vetor A: ");
                        for (int i = 0; i < veta.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Digite um um valor: ");
                            Console.Write("-> ");
                            veta[i] = Convert.ToDouble(Console.ReadLine());

                        }

                        Console.WriteLine("Digite 5 Valores para o Vetor B: ");
                        for (int i = 0; i < vetb.Length; i++)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Digite um um valor: ");
                            Console.Write("-> ");
                            vetb[i] = Convert.ToDouble(Console.ReadLine());
                        }


                        for (int i = 0; i < veta.Length; i++)
                        {
                            vetresultado[i] = veta[i] * vetb[i];
                            Console.WriteLine(" ");
                            Console.WriteLine($"O resultado de {veta[i]} vezes {vetb[i]} é {vetresultado[i]}.");
                        }

                        break;

                    default:

                        Console.WriteLine(" ");
                        Console.WriteLine("Opção inválida. Tente Novamente.");

                        break;

                }
            } while (imput != 010101);
        }
    }
}
