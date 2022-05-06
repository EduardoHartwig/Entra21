using System;

namespace Mais_Experimentos
{
    class Program
    {
        static void Main(string[] args)
        {

            int imputb = -1;
            int imputc = -1;
            int imputd = -1;
            int posição = -1;
            int posiçãob = -1;

            do
            {
                string[] Nome = new string[5] { "Eduardo", "Mateus", "Predu", "Lucas", "Jonathan" };               
                int[] ID = new int[5] { 7589, 7562, 3432, 6666, 8524 };
                double[] Saldo = new double[5] { 1500.50, 8400.75, 3245.99, 7243.15, 2300.20 };

                string imputNome = "";
                string imputNomeb = "";
                int imputID = 0;
                int imputIDb = 0;
                double imputSaldo;

                
                string imputVerificador;              
                string imputVerificadorb;

                Console.WriteLine("\nInforme seu Nome ou ID: ");
                Console.Write("->");
                imputVerificador = Console.ReadLine();
                

                imputc = (int.TryParse(imputVerificador, out imputID)) ? 1 : 2;


                for (int i = 0; i < Nome.Length; i++)
                {
                    if (imputc == 1)
                    {
                        if (imputID == ID[i])
                        {
                            posição = i;
                        }
                    }
                    else if (imputc == 2)
                    {
                        imputNome = imputVerificador;
                        if (imputNome == Nome[i])
                        {
                            posição = i;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nConta Inexistente.");
                        imputb = 010101;
                    }
                }


                while (imputc == 1 || imputc == 2)
                {
                    do
                    {
                        Console.WriteLine("\nQual Operação Deseja Realizar?");
                        Console.WriteLine("\n1 - Saque.");
                        Console.WriteLine("2 - Depositar.");
                        Console.WriteLine("3 - Transferência.");
                        Console.WriteLine("4 - Consultar Saldo.");
                        Console.WriteLine("\n0 - Sair.");
                        Console.Write("-> ");
                        imputb = Convert.ToInt32(Console.ReadLine());
                        if(imputb == 0)
                        {
                            imputb = 010101;
                            imputc = 0;
                        }
                        else
                        {
                            switch(imputb)
                            {
                                case 1:
                                    Console.WriteLine($"\nBem vindo {Nome[posição]}, Quanto Deseja Sacar ?");
                                    Console.Write("-> ");
                                    imputSaldo = Convert.ToDouble(Console.ReadLine());

                                    if (imputSaldo > Saldo[posição])
                                    {
                                        Console.WriteLine("\nSALDO INSUFICIENTE");
                                    }
                                    else
                                    {
                                        Saldo[posição] = Saldo[posição] - imputSaldo;
                                        Console.WriteLine($"\nValor Sacado: R${imputSaldo} || Saldo Atual em conta: {Saldo[posição].ToString("C")}");
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine($"\nBem Vindo {Nome[posição]}, Quanto Deseja Depositar na sua Conta?");
                                    Console.Write("-> ");
                                    imputSaldo = Convert.ToDouble(Console.ReadLine());

                                    if (imputSaldo <= 0)
                                    {
                                        Console.WriteLine("\n Valor Inválido ");
                                    }
                                    else
                                    {
                                        Saldo[posição] = Saldo[posição] + imputSaldo;
                                        Console.WriteLine($"\nValor Depositado: R${imputSaldo} || Saldo Atual em conta: R${Saldo[posição]}.");
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine($"\nBem Vindo {Nome[posição]}, Para Quem Deseja Transferir?");
                                    Console.Write("-> ");
                                    imputVerificadorb = Console.ReadLine();
                                    

                                    imputd = (int.TryParse(imputVerificadorb, out imputIDb)) ? 1 : 2;

                                    for (int i = 0; i < Nome.Length; i++)
                                    {
                                        if (imputd == 1)
                                        {
                                            if (imputIDb == ID[i])
                                            {
                                                posiçãob = i;
                                            }
                                        }
                                        else if (imputd == 2)
                                        {
                                            imputNomeb = imputVerificadorb;
                                            if (imputNomeb == Nome[i])
                                            {
                                                posiçãob = i;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nConta Inexistente.");
                                            imputb = 010101;
                                        }
                                    }

                                    if (posição == posiçãob)
                                    {
                                        Console.WriteLine($"\nA conta a qual deseja Transferir é sua, {Nome[posição]}");
                                    }
                                    else
                                    {
                                        while (imputd == 1 || imputd == 2)
                                        {
                                            Console.WriteLine($"\n{Nome[posição]}, Quanto Deseja Transferir para {Nome[posiçãob]} ?");
                                            Console.Write("-> ");
                                            imputSaldo = Convert.ToDouble(Console.ReadLine());

                                            if(imputSaldo < 0)
                                            {
                                                Console.WriteLine("\n Valor Inválido ");
                                            }
                                            else
                                            {
                                                if(imputSaldo > Saldo[posição])
                                                {
                                                    Console.WriteLine("\n Saldo Insuficiente ");
                                                }
                                                else
                                                {
                                                    Saldo[posição] = Saldo[posição] - imputSaldo;
                                                    Console.WriteLine($"\nValor Trasnferido para {Nome[posiçãob]}: R${imputSaldo} || Saldo Atual em conta: R${Saldo[posição]}");
                                                    imputd = -1;
                                                }
                                            }
                                        }
                                    }
                                        break;

                                case 4:
                                    Console.WriteLine($"\nBem vindo {Nome[posição]}, Seu Saldo atual em conta é: R${Saldo[posição]}");
                                    break;
                            }
                        }
                    } while (imputc != 0);
                }
            } while (imputb != 010101);
        }
    }
}
