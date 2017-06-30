using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio
{
    class Bolillero
    {
        private int Numero1;
        private int Numero2;
        private int Numero3;
        private int Numero4;
        private int Numero5;
        Random numero = new Random();        
        
        public int numero1
        {
            get { return Numero1; }
            set { Numero1 = value; }
        }
        public int numero2
        {
            get { return Numero2; }
            set { Numero2 = value; }
        }
        public int numero3
        {
            get { return Numero3; }
            set { Numero3 = value; }
        }
        public int numero4
        {
            get { return Numero4; }
            set { Numero4 = value; }
        }
        public int numero5
        {
            get { return Numero5; }
            set { Numero5 = value; }
        }

        //CONSTRUCTOR DEL BOLILLERO
        public Bolillero(int numero1,int numero2, int numero3, int numero4, int numero5)
        {
            
            numero1= numero.Next(0, 45);
            numero2= numero.Next(0, 45);
            numero3= numero.Next(0, 45);
            numero4= numero.Next(0, 45);
            numero5= numero.Next(0, 45);

            this.Numero1 = numero1;
            this.Numero2 = numero2;
            this.Numero3 = numero3;
            this.Numero4 = numero4;
            this.Numero5 = numero5;
        }
        
    }
    
}
