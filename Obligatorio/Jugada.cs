using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio
{
    class Jugada
    {
        private String Nombre;
       
        private int Numero1;
        private int Numero2;
        private int Numero3;
        private int Numero4;
        private int Numero5;

        public string nombre 
        {
            get { return Nombre; }
            set { value= Nombre; }

        }


        public int numero1
        {
            get { return Numero1; }
            set { value = Numero1; }
        }
        public int numero2 
        {
            get { return Numero2; }
            set { value = Numero2; }
        }
        public int numero3 
        {
            get { return Numero3; }
            set { value = Numero3; }
        }
        public int numero4
        {
            get { return Numero4; }
            set { value = Numero4; }
        }
        public int numero5
        {
            get { return Numero5; }
            set { value = Numero5; }
        }



        public Jugada(int[] numeros , String nombre , int numero1, int numero2 , int numero3 , int numero4 , int numero5)
        {
            numero1 = numeros[0];
            numero2 = numeros[1]; 
            numero3 = numeros[2];
            numero4 = numeros[3];
            numero5 = numeros[4];

            this.Nombre = nombre;

            this.Numero1 = numero1;
            this.Numero2 = numero2;
            this.Numero3 = numero3;
            this.Numero4 = numero4;
            this.Numero5 = numero5;
        }

    }
}