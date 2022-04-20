using System;

namespace Primeiro_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome = "", sobrenome = "", operação;
            int idade;
            double altura, peso, imc, digitoa, digitob, resultado;
            int opcaoa = 010101;
            


           
            do
            {

                Console.WriteLine("");
                Console.WriteLine("Bem vindo");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Qual operação deseja realizar: ");
                Console.WriteLine("1 - Verificação de idade.");
                Console.WriteLine("2 - Calcular IMC.");
                Console.WriteLine("3 - Calculadora");
                Console.WriteLine("0 - Sair");
                opcaoa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                switch (opcaoa)
                {

                    case 0:
                        opcaoa = 010101;

                        break;

                    case 1:

                        Console.WriteLine("");
                        Console.WriteLine("Escreva seu nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Escreva seu sobrenome: ");
                        sobrenome = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Escreva sua idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        if (idade < 18)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(nome + "" + sobrenome + " é menor de idade.");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(nome + "" + sobrenome + " é maior de idade.");
                            Console.WriteLine("");
                        }


                        break;

                    case 2:

                        Console.WriteLine("");
                        Console.WriteLine("Insira sua Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Insira seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");

                        imc = (peso / (altura * altura));

                        Console.WriteLine("");
                        Console.WriteLine("Seu IMC é de " + Math.Round(imc, 2));
                        Console.WriteLine("");

                        break;

                    case 3:

                        Console.WriteLine("");
                        Console.Write("Escreva o primeiro Digito: ");
                        digitoa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Escreva o segundo Digito: ");
                        digitob = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Escolha a operação: ");
                        Console.WriteLine("> Soma <");
                        Console.WriteLine("> Subtração <");
                        Console.WriteLine("> Multiplicação <");
                        Console.WriteLine("> Divisão <");
                        operação = Console.ReadLine();
                        Console.WriteLine("");

                        if (operação.Equals("Soma"))
                        {
                            resultado = digitoa + digitob;

                            Console.WriteLine("");
                            Console.WriteLine("A soma de " + digitoa + " e de " + digitob + " é igual a: " + Math.Round(resultado, 5));
                            Console.WriteLine("");

                        }
                        else if (operação.Equals("Subtração"))
                        {
                            resultado = digitoa - digitob;

                            Console.WriteLine("");
                            Console.WriteLine("A subtração de " + digitoa + " e de " + digitob + " é igual a: " + resultado);

                            Console.WriteLine("");
                        }
                        else if (operação.Equals("Multiplicação"))
                        {
                            resultado = digitoa * digitob;

                            Console.WriteLine("");
                            Console.WriteLine("A multiplicação de " + digitoa + " e de " + digitob + " é igual a: " + resultado);
                            Console.WriteLine("");

                        }
                        else if (operação.Equals("Divisão"))
                        {
                            resultado = digitoa / digitob;

                            Console.WriteLine("");
                            Console.WriteLine("A divisão de " + digitoa + " e de " + digitob + " é igual a: " + resultado);
                            Console.WriteLine("");

                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Opção inválida");
                            Console.WriteLine("");

                        }

                        break;

                    default:

                        Console.WriteLine("");
                        Console.WriteLine("Valor inválido, tente novamente");
                        Console.WriteLine("");

                        break;
                }



            } while (opcaoa != 010101);


            Console.WriteLine("Obrigado por utilizar esta ferramenta");


        }

    }
}



