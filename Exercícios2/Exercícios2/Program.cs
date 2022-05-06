using System;

namespace experimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int imputb = 0;
            int imputc = 0;

            Console.WriteLine(" ");
            Console.WriteLine("7 - Operações Bancárias.");

            do
            {

                string[] Nome = new string[5] { "Eduardo", "Mateus", "Predu", "Lucas", "Jonathan" };
                string imputNome;
                int[] ID = new int[5] { 7589, 7562, 3432, 6666, 8524 };
                int imputID;
                double[] Saldo = new double[5] { 1500.50, 8400.75, 3245.99, 7243.15, 2300.20 };
                double imputSaldo;

                Console.WriteLine("Qual Operação Deseja Realizar?");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Saque.");
                Console.WriteLine("2 - Depositar.");
                Console.WriteLine("3 - Transferência.");
                Console.WriteLine(" ");
                Console.WriteLine("0 - Sair.");
                Console.Write("-> ");
                imputb = Convert.ToInt32(Console.ReadLine());



                switch (imputb)
                {

                    case 0:

                        imputb = 010101;

                        break;

                    case 1:

                        Console.WriteLine(" ");
                        Console.WriteLine("Informe seu Nome ou ID");
                        Console.WriteLine(" ");
                        Console.WriteLine("1 - Nome");
                        Console.WriteLine("2 - ID");
                        Console.WriteLine(" ");
                        Console.WriteLine("0 - Cancelar Operação.");
                        Console.Write("-> ");
                        imputc = Convert.ToInt32(Console.ReadLine());

                        switch (imputc)
                        {
                            case 0:
                                imputb = 010101;
                                break;

                            case 1:

                                Console.WriteLine(" ");
                                Console.WriteLine("Informe seu Nome: ");
                                Console.Write("-> ");
                                imputNome = Console.ReadLine();

                                for (int i = 0; i < Nome.Length; i++)
                                {
                                    if (imputNome == Nome[i])
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine($"Bem Vindo {Nome[i]}, Quanto Deseja Sacar?");
                                        Console.Write("-> ");
                                        imputSaldo = Convert.ToDouble(Console.ReadLine());

                                        if (imputSaldo < Saldo[i])
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine("SALDO INSUFICIENTE");
                                        }
                                        else
                                        {
                                            Saldo[i] = Saldo[i] - imputSaldo;
                                            Console.WriteLine(" ");
                                            Console.WriteLine($"Valor Sacado: {imputSaldo} || Saldo Atual em conta: {Saldo[i]}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("CONTA INEXISTENTE");
                                    }
                                }
                                break;

                            case 2:

                                Console.WriteLine(" ");
                                Console.WriteLine("Informe seu ID: ");
                                Console.Write("-> ");
                                imputID = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < ID.Length; i++)
                                {
                                    if (imputID == ID[i])
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine($"Bem Vindo {Nome[i]}, Quanto Deseja Sacar?");
                                        Console.Write("-> ");
                                        imputSaldo = Convert.ToDouble(Console.ReadLine());

                                        if (imputSaldo < Saldo[i])
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine("SALDO INSUFICIENTE");
                                        }
                                        else
                                        {
                                            Saldo[i] = Saldo[i] - imputSaldo;
                                            Console.WriteLine(" ");
                                            Console.WriteLine($"Valor Sacado: {imputSaldo} || Saldo Atual em conta: {Saldo[i]}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("CONTA INEXISTENTE");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine(" ");
                                Console.WriteLine("OPÇÃO INVÁLIDA");
                                break;
                        }
                        break;

                    case 2:



                        break;

                    default:
                        break;
                }
            } while (imputb != 010101);





        }
    }
}