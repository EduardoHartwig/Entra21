using System;

namespace Primeiro_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome = "", sobrenome = "", operação;
            int idade;
            double altura, peso, imc, digitoa, digitob, resultado, notaa, notab, notac, maior, menor, auxa, auxb, auxc, auxd;
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
                Console.WriteLine("4 - Média notas.");
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
                            Console.WriteLine($"{nome} {sobrenome} é menor de idade.");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"{nome} {sobrenome} é maior de idade.");
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

                        if (imc < 16)
                        {
                            Console.WriteLine("Situação: Subpeso Severo");
                        }
                        else if (imc < 19.9)
                        {
                            Console.WriteLine("Situação: Subpeso");
                        }
                        else if (imc < 24.9)
                        {
                            Console.WriteLine("Situação: Normal");

                        }
                        else if (imc < 29.9)
                        {
                            Console.WriteLine("Situação: Sobrepeso");

                        }
                        else if (imc < 39.9)
                        {
                            Console.WriteLine("Situação: Obesidade");

                        }
                        else
                        {
                            Console.WriteLine("Situação: Obeisade Mórbida");

                        }


                        Console.WriteLine("");
                        Console.WriteLine($"Seu IMC é de {imc}");
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
                            Console.WriteLine($"A soma de  {digitoa}  e de  {digitob}  é igual a:  {resultado}");
                            Console.WriteLine("");

                        }
                        else if (operação.Equals("Subtração"))
                        {
                            resultado = digitoa - digitob;

                            Console.WriteLine("");
                            Console.WriteLine($"A subtração de  {digitoa}  e de  {digitob}  é igual a:  {resultado}");

                            Console.WriteLine("");
                        }
                        else if (operação.Equals("Multiplicação"))
                        {
                            resultado = digitoa * digitob;

                            Console.WriteLine("");
                            Console.WriteLine($"A multiplicação de  {digitoa}  e de  {digitob}  é igual a: {resultado}");
                            Console.WriteLine("");

                        }
                        else if (operação.Equals("Divisão"))
                        {
                            resultado = digitoa / digitob;

                            Console.WriteLine("");
                            Console.WriteLine($"A divisão de {digitoa} e de {digitob} é igual a:  {resultado}");
                            Console.WriteLine("");

                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Opção inválida");
                            Console.WriteLine("");

                        }

                        break;

                    case 4:

                        Console.WriteLine("Digite as 3 notas de um aluno: ");
                        notaa = Convert.ToInt32(Console.ReadLine());
                        notab = Convert.ToInt32(Console.ReadLine());
                        notac = Convert.ToInt32(Console.ReadLine());


                        auxa = Math.Max(notaa, notab);
                        auxb = Math.Max(notab, notac);
                        maior = Math.Max(auxa, auxb);

                        auxc = Math.Min(notaa, notab);
                        auxd = Math.Min(notab, notac);
                        menor = Math.Min(auxc, auxd);

                        resultado = (notaa + notab + notac) / 3;


                        Console.WriteLine($"A maior nota é: {maior}");
                        Console.WriteLine($"A menor nota é: {menor}");
                        Console.WriteLine($"A média é: {resultado}");


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



