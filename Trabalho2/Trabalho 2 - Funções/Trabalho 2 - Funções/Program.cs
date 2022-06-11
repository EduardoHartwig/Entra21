using System;

namespace Trabalho_2___Funções
{
    class Program
    {

        static double[] Bubble(double[] vetor)
        {
            double aux;
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

        static string teste(string nome, double notaMedia, double[] notas, string[] alunos)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == notaMedia)
                {
                    nome = alunos[i];
                }
            }
            return nome;
        }

        static bool joguinho(int escolhido, int burrice, bool teste)
        {
            teste = (burrice == escolhido) ? true : false;
            return teste;
        }

        static string acimaouabaixo(int escolhido, int burrice, string resposta)
        {
            resposta = (burrice < escolhido) ? "\nEstá abaixo." : "\nEstá acima.";
            return resposta;
        }

        static int[] inverterVetor(int[] vetor, int[] vetorInverso)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                vetorInverso[i] = vetor[vetor.Length - (i + 1)];
            }
            return vetorInverso;
        }

        static int Divisor(int a, int b)
        {
            int res = 0;

            return res = ((a % b) == 0) ? (a / b) : 0;
        }


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            int imput = -1;
            Console.WriteLine("\nBem vindo ao trabalho 2 - Funções");

            do
            {
                Console.WriteLine("\nQual exercício deseja utilizar ?");
                Console.WriteLine("\n1 - Média da turma - 10 alunos.");
                Console.WriteLine("2 - Jogo de acertar o número.");
                Console.WriteLine("3 - Inverter os valores do vetor.");
                Console.WriteLine("\n0 - Sair");
                Console.Write("\n-> ");
                imput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (imput)
                {
                    case 0:
                        imput = 010101;
                        break;

                    case 1:
                        string[] aluno = new string[10] {"Eduardo", "Jonathan", "Vitor", "Josué", "Leandro", "Patrick", "Carlos", "Erick", "Jairo", "Ana"};
                        double[] notas = new double[3];
                        double[] mediaAluno = new double[10];
                        double[] maiorAluno = new double[10];
                        double[] menorAluno = new double[10];

                        for(int i = 0; i < aluno.Length; i++)
                        {   
                            //Pede 3 notas do Aluno[i]
                            for (int j = 0; j < notas.Length; j++)
                            {
                                Console.WriteLine($"\nEscreva a {j+1}ª nota do aluno ({i}){aluno[i]}: ");
                                notas[j] = Convert.ToDouble(Console.ReadLine());
                            }
                            //Ordena a notas
                            Bubble(notas);
                            
                            //menor nota do aluno[i]
                            menorAluno[i] = notas[0];
                            //maior nota do aluno[i]
                            maiorAluno[i] = notas[notas.Length - 1];
                            //nota média do aluno[i]
                            mediaAluno[i] = (notas[notas.Length -1] + notas[1]) / 2;
                        }
                        
                        double mediaTurma = 0;
                        
                        for(int i = 0; i < mediaAluno.Length; i++)
                        {
                            mediaTurma = mediaTurma + mediaAluno[i];
                        }

                        mediaTurma = mediaTurma / mediaAluno.Length;
                        

                       for(int i = 0; i < aluno.Length; i++)
                        {
                            Console.WriteLine($"\nO Aluno {aluno[i]} teve a menor nota: {menorAluno[i].ToString("F")}, e a maior nota: {maiorAluno[i].ToString("F")}, e uma média de: {mediaAluno[i].ToString("F")}.");
                        }

                        Bubble(mediaAluno);
                        double menorTurma = mediaAluno[0];
                        double maiorTurma = mediaAluno[mediaAluno.Length - 1];
                        string maiorTurmaNome = "teste", menorTurmaNome = "teste";

                        menorTurmaNome = teste(maiorTurmaNome, maiorTurma, mediaAluno, aluno);
                        maiorTurmaNome = teste(menorTurmaNome, menorTurma, mediaAluno, aluno);

                        Console.WriteLine($"\nA maior média da turma é do {maiorTurmaNome} com a nota média {maiorTurma.ToString("F")}");
                        Console.WriteLine($"A menor média da turma é do {menorTurmaNome} com a nota média {menorTurma.ToString("F")}");
                        Console.WriteLine($"A nota média da turma é: {mediaTurma.ToString("F")}");
                        break;

                    case 2:
                        Random rnd = new Random();
                        int ChosedOne = rnd.Next(100);
                        int entrada = 0;
                        string retorno = "";
                        bool verificação = true;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nUm número escolhido Aleatoriamente(Chosed one) foi gerado.");
                        Console.WriteLine("\nSeu Dever é adivinhar qual número foi digitado.");
                        Console.WriteLine("\nO Sistema informará se o número digitado está acima ou abaixo do ChosedOne.");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n\nQUE OS JOGOS COMECEM");
                        Console.ForegroundColor = ConsoleColor.White;

                        do
                        {
                            Console.WriteLine("\n\n Digite um número: ");
                            entrada = Convert.ToInt32(Console.ReadLine());

                            if(joguinho(ChosedOne, entrada, verificação))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nACERTOUUUU");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nEEERROOOUUUUU");
                                Console.WriteLine(acimaouabaixo(ChosedOne, entrada, retorno));
                                Console.ForegroundColor = ConsoleColor.White;
                            } 
                        } while (!verificação);
                        break;

                    case 3:
                        int[] vetor = new int[10];
                        int[] vetorInverso = new int[10];

                        for (int i = 0; i < vetor.Length; i++)
                        {
                            Console.WriteLine($"\nDigite o {i}º valor: ");
                            Console.Write("-> ");
                            vetor[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        inverterVetor(vetor, vetorInverso);

                        Console.WriteLine("\nSegue abaixo os valores invertidos: ");
                        for (int i = 0; i < vetor.Length; i++)
                        {
                            Console.WriteLine($"\n{i}º valor: {vetorInverso[i]}");
                        }
                            break;

                    case 4:
                        int[] nums = new int[3];
                        //int numA, numB, numC;
                        int[] divisoresA, divisoresB, divisoresC;

                        for(int i = 0; i < nums.Length; i++)
                        {
                            Console.WriteLine($"\n({i})Digite o valor para achar os divisores: ");
                            Console.Write("->");
                            nums[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        for (int i = nums[0]; i > 0; i--)
                        {
                            if (Divisor(nums[0], i) > 0)
                            {
                                divisoresA = new int[] {Divisor(nums[0],i)};
                            }
                        }

                        

                        break;
                }
                

            } while (imput != 010101);



        }
    }
}
