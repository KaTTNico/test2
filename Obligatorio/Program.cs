using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio
{
    class Program
    {
        //MOSTRAR TODAS LAS JUGADAS
        public static void MostrarTodo(Jugada[] jugada)
        {
            for (int indice = 0; indice < jugada.Length; indice++)
            {
                    Console.WriteLine();
                    Console.WriteLine(jugada[indice].nombre);
                    Console.Write(jugada[indice].numero1);
                    Console.Write(" , " + jugada[indice].numero2);
                    Console.Write(" , " + jugada[indice].numero3);
                    Console.Write(" , " + jugada[indice].numero4);
                    Console.Write(" , " + jugada[indice].numero5);
            }      
                
        }

        //MOSTRAR DATOS POR BUSQUEDA DE INDICE 
        public static void MostrarPorIndice(int indice , Jugada[] jugada)
        {
            Console.WriteLine();
            Console.WriteLine(jugada[indice].nombre);
            Console.Write(jugada[indice].numero1);
            Console.Write(" , " + jugada[indice].numero2);
            Console.Write(" , " + jugada[indice].numero3);
            Console.Write(" , " + jugada[indice].numero4);
            Console.Write(" , " + jugada[indice].numero5);   
        }

        //MOSTRAR DATOS POR BUSQUEDA DE NOMBRE
        public static void BuscarPorNombre(String Buscar, Jugada[] jugada)
        {
            for (int indice=0; indice < jugada.Length; indice++)
            {
                if (Buscar == jugada[indice].nombre)
                {
                    Console.WriteLine();
                    Console.WriteLine(jugada[indice].nombre);
                    Console.Write(jugada[indice].numero1);
                    Console.Write(" , " + jugada[indice].numero2);
                    Console.Write(" , " + jugada[indice].numero3);
                    Console.Write(" , " + jugada[indice].numero4);
                    Console.Write(" , " + jugada[indice].numero5);
                }
            }
        }

        //CARGA DE LA JUGADA SORPRESA
        public static void CargarAleatorio(ref int numero1, ref int numero2, ref int numero3, ref int numero4, ref int numero5)
        {
            bool loop = true;
            Bolillero aleatorio;
            String respuesta;

            while (loop==true)
            {
                //LLAMAR AL CONSTRUCTOR
                aleatorio = new Bolillero(numero1, numero2, numero3, numero4, numero5);
                
                //CARGAR VARIABLES 
                numero1 = aleatorio.numero1;
                numero2 = aleatorio.numero2;
                numero3 = aleatorio.numero3;
                numero4 = aleatorio.numero4;
                numero5 = aleatorio.numero5;

                Console.WriteLine("SU JUGADA SORPRESA ES:\n " + numero1 + " , " + numero2 + " , " + numero3 + " , " + numero4 + " , " + numero5 + " , " + "\n DESEA GENERAR OTRA JUGADA SORPRESA? 1=SI \n 0=NO");
                respuesta = Console.ReadLine().Trim();

                if (respuesta == "1")
                { }
                else
                { loop = false; }

            }
        }

        static void Main(string[] args)
        {
            //ACA VA EL MENU

            //INGRESAR CANTIDAD DE JUGADAS 
            String Cantidad=Console.ReadLine();
            int cantidad = Convert.ToInt16(Cantidad);
            
            //INGRESAR JUGADAS
            Jugada[] jugada = new Jugada[cantidad];
            
            int [] numeros = new int[5];
            int contador = 0;
            string Numero;
            int numero=0;

            string Nombre;

            string Numero1;
            string Numero2;
            string Numero3;
            string Numero4;
            string Numero5;

            int numero1=0;
            int numero2=0;
            int numero3=0;
            int numero4=0;
            int numero5=0;

            String Respuesta;
                        for (int a = 0; a < cantidad; a++)
                        {
                            
                                Console.WriteLine("INGRESAR NOMBRE:");
                                Nombre = Console.ReadLine().Trim().ToLower();

                                Console.WriteLine("PRECIONE 1 PARA CARGAR UNA JUGADA SORPRESA O CERO PARA CARGAR LOS NUMEROS DE A UNO");
                                Respuesta = Console.ReadLine();
                                
                                if (Respuesta == "1")
                                {
                                    CargarAleatorio(ref numero1, ref numero2, ref numero3, ref numero4, ref numero5);
                                }
                                else
                                {
                                    while (contador<numeros.Length)
                                    {
                                        try
                                        {
                                            Console.WriteLine("INGRESAR NUMERO" + (contador+1));
                                            Numero = Console.ReadLine();
                                            numero = Convert.ToInt16(Numero);
                                            numeros[contador] = numero;

                                            contador++;
                                        }
                                        catch
                                        {
                                            Console.WriteLine("ERROR DE CONVERSION INTENTE DE NUEVO");
                                            Console.ReadKey();

                                        }
                                        
                                    }
                                        contador = 0;

                                        //CARGAR OBJETO
                                        jugada[a] = new Jugada(numeros, Nombre, numero1, numero2, numero3, numero4, numero5);

                                }


                        }
                  
        
            //MOSTRAR DATOS (nombre y jugada)
            Console.WriteLine("MOSTRAR TODO");
            Console.ReadKey();
            MostrarTodo(jugada);
            Console.ReadKey();

            //BUSCAR POR INDICE
            Console.WriteLine("BUSCAR POR INDICE \n INGRESAR INDICE:");
            String Indice = Console.ReadLine();
            int indice = Convert.ToInt16(Indice);
            MostrarPorIndice(indice,jugada);
            Console.ReadKey();

            //BUSCAR POR NOMBRE
            Console.WriteLine("BUSCAR POR NOMBRE \n INGRESAR NOMBRE:");
            String nombre = Console.ReadLine().Trim().ToLower();
            BuscarPorNombre(nombre, jugada);
            Console.ReadKey();
        }
    }
}
