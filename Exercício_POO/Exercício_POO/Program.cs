using System;

namespace Exercício_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Veiculo veiculo = new Veiculo();
            Caminhao caminhao = new Caminhao();
            Marca marca = new Marca();
            Motor motor = new Motor();
            Modelo modelo = new Modelo();
            Motocicleta motocicleta = new Motocicleta();

            //veiculo.Modelo.Descricao = "teste";

            caminhao.Modelo.Descricao = "teste2";


            //Console.WriteLine(veiculo.Modelo.Descricao);
            Console.WriteLine(caminhao.Modelo.Descricao);



        }
    }
}
