using System;

namespace experimentos
{
    class Program
    {
        static void Main(string[] args)
        {
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





        }
    }
}