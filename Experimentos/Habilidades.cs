using System;
using System.Collections.Generic;
using System.Text;

namespace Miniguerreiros
{
    class Habilidades
    {


        private int vida;
        private int dano;

        public int AtaqueB
        {
            get { return ataqueB(); }
            set { ataqueB = value; }
        }
       

        public int Vida 
        { 
            get { return vida; }
            set { vida = value; } 
        }



        
        


        private static int ataqueB(int x)
        {
            int dano = 10;
            return x - dano;
        }



    }
}
