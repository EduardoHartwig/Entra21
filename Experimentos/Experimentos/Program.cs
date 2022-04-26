using System;

namespace Experimentos
{
    class Program
    {
        static void Main(string[] args)
        {

            double Xa, Ya, Xb, Yb, D;


            Console.WriteLine("Digite a primeira Coordenada: ");
            Console.Write("Xa: ");
            Xa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ya: ");
            Ya = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Digite a segunda Coordenada: ");
            Console.Write("Xb: ");
            Xb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yb: ");
            Yb = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(" ");



            //D = Math.Sqrt(((Xa - Xb) * (Xa - Xb)) + ((Ya - Yb) * (Ya - Yb)));
            D = Math.Sqrt(Math.Pow((Xa - Xb), 2) + Math.Pow((Ya - Yb), 2));

            Console.WriteLine($"A Distância das 2 coordenadas é: {D}");










        }
    }
}
