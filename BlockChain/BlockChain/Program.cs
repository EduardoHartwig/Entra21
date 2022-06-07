using System;

namespace BlockChain
{
    class Program
    {
        static void Main(string[] args)
        {
            string Target = "https://www.youtube.com/watch?v=VPp_dvTGAS0";
            int imput = 0;
            int imputb = -1;

            

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n¦==============================================================¦");
                Console.WriteLine("¦            Bem vindos a Apresentação de Blockchain           ¦");
                Console.WriteLine("¦==============================================================¦");


                
                Console.WriteLine("\n\nO que Deseja ver ?");
                Console.WriteLine("\n1 - O que é ?");
                Console.WriteLine("2 - Formas de Aplicação.");
                Console.WriteLine("3 - Curiosidades e Novidades.");
                Console.WriteLine("\n0 - Sair.");
                Console.Write("-> ");
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
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n¦==============================================================¦");
                            Console.WriteLine("¦===================   O que é Blockchain ?   =================¦");
                            Console.WriteLine("¦==============================================================¦");
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.Write("\n\nA blockchain é um ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("livro-razão ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("compartilhado e imutável usado para registrar transações, ");
                            Console.Write("\n rastrear ativos e aumentar a confiança.");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\n¦==============================================================¦");
                            Console.WriteLine("¦===================     Como é utilizado?    =================¦");
                            Console.WriteLine("¦==============================================================¦");
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\nConceito Peer - to - peer: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Cada um dos pontos ou nós da rede funciona tanto como cliente quanto como servidor, ");
                            Console.Write("\n permitindo compartilhamentos de serviços e dados sem a necessidade de um servidor central.");

                            Console.Write("\n\nBasicamente qualquer negócio ou organização que precise de algum tipo de ");
                            Console.Write("\n verificação segura de transações pode se beneficiar de um sistema baseado em blockchain.");





                            imputb = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (imputb != 0);
                        break;

                    case 2:

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n¦==============================================================¦");
                            Console.WriteLine("¦===================    Locais de Aplicação   =================¦");
                            Console.WriteLine("¦==============================================================¦");
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n¦===========================    WEB3   ========================¦");
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.Write("\n\n A Web3, também chamada Web 3.0, mantida pelo Blockchain pode oferecer uma internet verdadeiramente descentralizada, ");
                            Console.Write("\n proporcionar anonimato e garantir privacidade aos usuários. ");
                            Console.Write("\nAs empresas deixarão de utilizar servidores centralizados para armazenamento de dados. Através dessa tecnologia as empresas podem, ");
                            Console.Write("\n por exemplo autenticar seus usuários por suas chaves sem armazenamento de dados pessoais dos clientes.");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n¦===========================   INBLOCK    =====================¦");
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.Write("\n\nO INBLOCK emite criptomoedas Metacoin, que têm base na malha do Hyperledger, ");
                            Console.Write("\n para ajudar a tornar as transações de ativos digitais mais rápidas, mais convenientes e mais seguras.");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n\n¦======================   Demais Aplicações   =================¦");
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.Write("\nSidechains, Blockchains alternativas, Ethereum, Namecoin, ");
                            Console.Write("\n Datacoin, Aplicações Descentralizadas.");


                            imputb = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (imputb != 0);
                        break;

                    case 3:

                        do
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\n¦==============================================================¦");
                            Console.WriteLine("¦======================     Curiosidades    ===================¦");
                            Console.WriteLine("¦==============================================================¦");
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.Write("\n\nNo entanto, o potencial da blockchain logo foi percebido e ela passou a ser aplicada com outras finalidades. ");
                            Console.Write("\nBasicamente qualquer negócio ou organização que precise de algum tipo de ");
                            Console.Write("\n verificação segura de transações pode se beneficiar de um sistema baseado em blockchain.");

                            Console.Write("\n\nBlockchains podem ser divididas em duas categorias: públicas e privadas. ");
                            Console.Write("\nA diferença entre os grupos está em quem tem permissão para participar da rede, executar o protocolo de ");
                            Console.Write("\n consenso para certificar as transações e preservar o registro compartilhado.");




                            imputb = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (imputb != 0);

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("¦==============================================================¦");
                        Console.WriteLine("¦                        OPCÃO INVÁLIDA                        ¦");
                        Console.WriteLine("¦==============================================================¦");
                        break;


                }



            } while (imput != 010101);

        }
    }
}
