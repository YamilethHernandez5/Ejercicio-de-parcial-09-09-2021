using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_parcial_09_09_2021
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("ADIVINA EL NÚMERO");

            Console.WriteLine("¡Bienvenido a Adivina el número!\n\n Voy a pensar en un número del 0"+
                " al 10 y debes adivinarlo\n Tienes 3 vidas");

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int numminimo = 0, nummaximo = 11, cantidaddevidas = 0;
            int numerosdeljuego = random.Next(numminimo, nummaximo);
            int numingresado = 0;
            do
            {
                 numingresado = Convert.ToInt32(Console.ReadLine());

                if (numingresado > numerosdeljuego)
                {
                    Console.WriteLine("No es el número correcto!");
                    cantidaddevidas++;
                }

                else if (numingresado < numerosdeljuego)
                {
                    Console.WriteLine("No es el número correcto!");
                    cantidaddevidas++;
                }
                  
                else
                {
                    Console.WriteLine("¡GANASTE!");
                    Console.ReadKey();
                }

            } while (cantidaddevidas < 3); 


           

        }
    }
}
   
    