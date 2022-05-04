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
                Console.WriteLine("7 - Operações Bancárias.");
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

                    case 7:

                        int imputb = 0;
                        int imputc = 0;
                        int imputd = 0;

                        do
                        {

                            string[] Nome = new string[5] { "Eduardo", "Mateus", "Predu", "Lucas", "Jonathan" };
                            string imputNome;
                            int[] ID = new int[5] { 7589, 7562, 3432, 6666, 8524 };
                            int imputID;
                            double[] Saldo = new double[5] { 1500.50, 8400.75, 3245.99, 7243.15, 2300.20 };
                            double imputSaldo;

                            Console.WriteLine("\nQual Operação Deseja Realizar?");
                            Console.WriteLine("\n1 - Saque.");
                            Console.WriteLine("2 - Depositar.");
                            Console.WriteLine("3 - Transferência.");
                            Console.WriteLine("4 - Consultar Saldo.");
                            Console.WriteLine("\n0 - Sair.");
                            Console.Write("-> ");
                            imputb = Convert.ToInt32(Console.ReadLine());



                            switch (imputb)
                            {

                                case 0:
                                    imputb = 010101;
                                    break;

                                case 1:

                                    Console.WriteLine("\nSaque: ");
                                    Console.WriteLine("\nInforme seu Nome ou ID");
                                    Console.WriteLine("\n1 - Nome");
                                    Console.WriteLine("2 - ID");
                                    Console.WriteLine("\n0 - Cancelar Operação.");
                                    Console.Write("-> ");
                                    imputc = Convert.ToInt32(Console.ReadLine());

                                    switch (imputc)
                                    {
                                        case 0:
                                            imputb = 010101;
                                            break;

                                        case 1:

                                            Console.WriteLine("\nInforme seu Nome: ");
                                            Console.Write("-> ");
                                            imputNome = Console.ReadLine();

                                            for (int i = 0; i < Nome.Length; i++)
                                            {
                                                if (imputNome == Nome[i])
                                                {
                                                    Console.WriteLine($"\nBem Vindo {Nome[i]}, Quanto Deseja Sacar?");
                                                    Console.Write("-> ");
                                                    imputSaldo = Convert.ToDouble(Console.ReadLine());

                                                    if (imputSaldo < Saldo[i])
                                                    {
                                                        Console.WriteLine("\nSALDO INSUFICIENTE");
                                                    }
                                                    else
                                                    {
                                                        Saldo[i] = Saldo[i] - imputSaldo;
                                                        Console.WriteLine($"\nValor Sacado: R${imputSaldo} || Saldo Atual em conta: R${Saldo[i]}");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nCONTA INEXISTENTE");
                                                }
                                            }
                                            break;

                                        case 2:

                                            Console.WriteLine("\nInforme seu ID: ");
                                            Console.Write("-> ");
                                            imputID = Convert.ToInt32(Console.ReadLine());

                                            for (int i = 0; i < ID.Length; i++)
                                            {
                                                if (imputID == ID[i])
                                                {
                                                    Console.WriteLine($"\nBem Vindo {Nome[i]}, Quanto Deseja Sacar?");
                                                    Console.Write("-> ");
                                                    imputSaldo = Convert.ToDouble(Console.ReadLine());

                                                    if (imputSaldo < Saldo[i])
                                                    {
                                                        Console.WriteLine("\nSALDO INSUFICIENTE");
                                                    }
                                                    else
                                                    {
                                                        Saldo[i] = Saldo[i] - imputSaldo;
                                                        Console.WriteLine($"\nValor Sacado: R${imputSaldo} || Saldo Atual em conta: R${Saldo[i]}");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nCONTA INEXISTENTE");
                                                }
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("\nOPÇÃO INVÁLIDA");
                                            break;
                                    }
                                    break;

                                case 2:

                                    Console.WriteLine("\nDepósito: ");
                                    Console.WriteLine("\nInforme seu Nome ou ID");
                                    Console.WriteLine("\n1 - Nome");
                                    Console.WriteLine("2 - ID");
                                    Console.WriteLine("\n0 - Cancelar Operação.");
                                    Console.Write("-> ");
                                    imputc = Convert.ToInt32(Console.ReadLine());

                                    switch (imputc)
                                    {
                                        case 0:
                                            imputb = 010101;
                                            break;


                                        case 1:

                                            Console.WriteLine("\nInforme seu Nome: ");
                                            Console.Write("-> ");
                                            imputNome = Console.ReadLine();

                                            for (int i = 0; i < Nome.Length; i++)
                                            {
                                                if (imputNome == Nome[i])
                                                {
                                                    Console.WriteLine($"\nBem Vindo {Nome[i]}, Quanto Deseja Depositar na sua Conta?");
                                                    Console.Write("-> ");
                                                    imputSaldo = Convert.ToDouble(Console.ReadLine());

                                                    if (imputSaldo <= 0)
                                                    {
                                                        Console.WriteLine("\n Valor Inválido ");
                                                    }
                                                    else
                                                    {
                                                        Saldo[i] = Saldo[i] + imputSaldo;
                                                        Console.WriteLine($"\nValor Depositado: R${imputSaldo} || Saldo Atual em conta: R${Saldo[i]}.");
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nCONTA INEXISTENTE");
                                                }
                                            }

                                            break;

                                        case 2:


                                            Console.WriteLine("\nInforme seu ID: ");
                                            Console.Write("-> ");
                                            imputID = Convert.ToInt32(Console.ReadLine());

                                            for (int i = 0; i < ID.Length; i++)
                                            {
                                                if (imputID == ID[i])
                                                {

                                                    Console.WriteLine($"\nBem Vindo {Nome[i]}, Quanto Deseja Depositar na sua Conta?");
                                                    Console.Write("-> ");
                                                    imputSaldo = Convert.ToDouble(Console.ReadLine());

                                                    if (imputSaldo <= 0)
                                                    {
                                                        Console.WriteLine("\n Valor Inválido ");
                                                    }
                                                    else
                                                    {
                                                        Saldo[i] = Saldo[i] + imputSaldo;
                                                        Console.WriteLine($"\nValor Depositado: R${imputSaldo} || Saldo Atual em conta: R${Saldo[i]}.");
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nCONTA INEXISTENTE");
                                                }
                                            }
                                            break;

                                        default:
                                            Console.WriteLine("\n OPÇÃO INVÁLIDA ");
                                            break;
                                    }
                                    break;

                                case 3:

                                    Console.WriteLine("\nTranferência: ");
                                    Console.WriteLine("\nInforme seu Nome ou ID");
                                    Console.WriteLine("\n1 - Nome");
                                    Console.WriteLine("2 - ID");
                                    Console.WriteLine("\n0 - Cancelar Operação.");
                                    Console.Write("-> ");
                                    imputc = Convert.ToInt32(Console.ReadLine());

                                    switch (imputc)
                                    {
                                        case 0:
                                            imputb = 010101;
                                            break;

                                        case 1:

                                            Console.WriteLine("\nInforme seu Nome: ");
                                            Console.Write("-> ");
                                            imputNome = Console.ReadLine();

                                            for (int i = 0; i < Nome.Length; i++)
                                            {
                                                if (imputNome == Nome[i])
                                                {
                                                    Console.WriteLine($"\nBem Vindo {Nome[i]}, Para Qual Conta Deseja Realizar a Transferência: ");
                                                    Console.WriteLine("\n1 - Nome");
                                                    Console.WriteLine("2 - ID");
                                                    Console.Write("-> ");
                                                    imputd = Convert.ToInt32(Console.ReadLine());

                                                    switch (imputd)
                                                    {
                                                        case 1:

                                                            Console.WriteLine("\nPara Quem Deseja Transferir: ");
                                                            Console.WriteLine("Informe o Nome: ");
                                                            Console.Write("-> ");
                                                            imputNome = Console.ReadLine();

                                                            for (int j = 0; j < Nome.Length; j++)
                                                            {

                                                                if (Nome[i] != Nome[j])
                                                                {

                                                                    if (imputNome == Nome[j])
                                                                    {
                                                                        Console.WriteLine($"\n{Nome[i]}, Quanto Deseja Transferir para {Nome[j]}");
                                                                        Console.Write("-> ");
                                                                        imputSaldo = Convert.ToDouble(Console.ReadLine());

                                                                        if (imputSaldo < Saldo[i])
                                                                        {
                                                                            Console.WriteLine("\nSALDO INSUFICIENTE");
                                                                        }
                                                                        else
                                                                        {
                                                                            Saldo[i] = Saldo[i] - imputSaldo;
                                                                            Console.WriteLine($"\nValor Trasnferido para {Nome[j]}: R${imputSaldo} || Saldo Atual em conta: R${Saldo[i]}");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nCONTA INEXISTENTE");
                                                                    }

                                                                }
                                                                else if (Nome[i] == Nome[j])
                                                                {
                                                                    Console.WriteLine($"\nA conta a qual deseja Transferir é sua, {Nome[i]}");
                                                                }
                                                            }
                                                            break;


                                                        case 2:
                                                            Console.WriteLine("\nPara Quem Deseja Transferir: ");
                                                            Console.WriteLine("Informe o ID: ");
                                                            Console.Write("-> ");
                                                            imputID = Convert.ToInt32(Console.ReadLine());

                                                            for (int j = 0; j < ID.Length; j++)
                                                            {

                                                                if (ID[i] != ID[j])
                                                                {

                                                                    if (imputID == ID[j])
                                                                    {
                                                                        Console.WriteLine($"\n{Nome[i]}, Quanto Deseja Transferir para {Nome[j]}");
                                                                        Console.Write("-> ");
                                                                        imputSaldo = Convert.ToDouble(Console.ReadLine());

                                                                        if (imputSaldo < Saldo[i])
                                                                        {
                                                                            Console.WriteLine("\nSALDO INSUFICIENTE");
                                                                        }
                                                                        else
                                                                        {
                                                                            Saldo[i] = Saldo[i] - imputSaldo;
                                                                            Console.WriteLine($"\nValor Trasnferido para {Nome[j]}: R${imputSaldo} || Saldo Atual em conta: R${Saldo[i]}");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nCONTA INEXISTENTE");
                                                                    }

                                                                }
                                                                else if (ID[i] == ID[j])
                                                                {
                                                                    Console.WriteLine($"\nA conta a qual deseja Transferir é sua, {Nome[i]}");
                                                                }
                                                            }
                                                            break;

                                                        default:
                                                            Console.WriteLine("\n OPÇÃO INVÁLIDA ");
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nCONTA INEXISTENTE");
                                                }
                                            }
                                            break;

                                    }
                                    break;

                                case 4:

                                    Console.WriteLine("\nConsulta de Saldo: ");
                                    Console.WriteLine("\nInforme seu Nome ou ID");
                                    Console.WriteLine("\n1 - Nome");
                                    Console.WriteLine("2 - ID");
                                    Console.WriteLine("\n0 - Cancelar Operação.");
                                    Console.Write("-> ");
                                    imputc = Convert.ToInt32(Console.ReadLine());

                                    switch (imputc)
                                    {
                                        case 0:
                                            imputb = 010101;
                                            break;

                                        case 1:

                                            Console.WriteLine("\nInforme seu Nome: ");
                                            Console.Write("-> ");
                                            imputNome = Console.ReadLine();

                                            for (int i = 0; i < Nome.Length; i++)
                                            {
                                                if (imputNome == Nome[i])
                                                {
                                                    Console.WriteLine($"\n{Nome[i]}, Seu Saldo atual em conta é: R${Saldo[i]}");
                                                }
                                            }
                                            break;

                                        case 2:

                                            Console.WriteLine("\nInforme seu Nome: ");
                                            Console.Write("-> ");
                                            imputID = Convert.ToInt32(Console.ReadLine());

                                            for (int i = 0; i < ID.Length; i++)
                                            {
                                                if (imputID == ID[i])
                                                {
                                                    Console.WriteLine($"\n{Nome[i]}, Seu Saldo atual em conta é: R${Saldo[i]}");
                                                }

                                            }
                                            break;

                                    }
                                    break;
                                default:
                                    Console.WriteLine("\n OPÇÃO INVÁLIDA ");
                                    break;
                            }
                        } while (imputb != 010101);


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
