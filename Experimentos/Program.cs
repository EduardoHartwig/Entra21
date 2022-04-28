using System;

namespace Miniguerreiros
{
    class Program
    {

         

        static void Main(string[] args)
        {
            int guerreiroHP = 100;
            int imput;
            string[] skillID = new string[10];
            string skillNome;

            static int ataqueB(int x)
            {
                int dano = 10;
                return x - dano;
            }



            Habilidades h = new Habilidades();

            h.Vida = guerreiroHP;
            //h.AtaqueB = 
            

            Console.WriteLine("Qual Habilidade deseja usar ?");
            Console.WriteLine("0 - Ataque básico.");
            imput = Convert.ToInt32(Console.ReadLine());

           switch(imput)
            {

                case 0:

                    skillNome = "Ataque Básico";
                    skillID[0] = skillNome;

                    guerreiroHP = ataqueB(guerreiroHP);

                    Console.WriteLine($"GuerreiroA fico com {guerreiroHP} de vida.");




                    break;



                default:




                    break;


            }



        }
    }
}
