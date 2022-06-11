using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_POO
{
    public class Veiculo
    {

        public string Chassis;
        public double Preco;
        public int Ano;
        public Modelo Modelo = new Modelo();
        public Marca Marca = new Marca();
        public Motor Motor = new Motor();
        public int TamanhoTanque;
        public double Kilometragem;
        public string CategoriaCNH;


        public Veiculo()
        {

        }

        public Veiculo(Modelo modelo)
        {
            this.Modelo = modelo;
        }


    }
}
