using System;

namespace Mais_Experimentos
{
    class Program
    {
        static void Main(string[] args)
        {

            int imputb = 0;
            int imputc = 0;
            int posição = 0;
            do
            {
                string[] Nome = new string[5] { "Eduardo", "Mateus", "Predu", "Lucas", "Jonathan" };
                string imputNome = "";
                int[] ID = new int[5] { 7589, 7562, 3432, 6666, 8524 };
                int imputID = 0;
                double[] Saldo = new double[5] { 1500.50, 8400.75, 3245.99, 7243.15, 2300.20 };
                double imputSaldo;

                char verificador;
                string imputVerificador;

                Console.WriteLine("\nInforme seu Nome ou ID: ");
                Console.Write("->");
                imputVerificador = Console.ReadLine();
                verificador = imputVerificador[0];

                //verifica se o imputVerificador é int ou String
                //tryparse
                for(int i = 0; i < 10; i++)
                {
                    if (verificador == i)
                    {
                        imputID = Convert.ToInt32(imputVerificador);
                        imputc = 1;
                    }
                    else
                    {
                        imputNome = imputVerificador;
                        imputc = 2;
                    }
                }

                //encontra posição do vetor tanto do string quanto do ID
                for(int i = 0; i < Nome.Length; i++)
                {
                    if (imputc == 1)
                    {
                        if(imputID == ID[i])
                        {
                            posição = i;
                        }
                    }
                    else if (imputc == 2)
                    {
                        if(imputNome == Nome[i])
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




               while(imputc == 1 || imputc == 2)
                {    



                }

            } while (imputb != 010101);
                



        }
    }
}
