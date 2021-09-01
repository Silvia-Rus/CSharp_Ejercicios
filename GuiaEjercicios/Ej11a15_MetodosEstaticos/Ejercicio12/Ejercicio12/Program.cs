using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int suma = 0;
            char respuesta = 'S';

            Console.Title = "Ejercicio 12";

            do
            {
                Console.WriteLine("Ingrese un número para sumar: ");

                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    suma += numeroIngresado;
                    Console.WriteLine("\n¿Desea seguir ingresando números? S/N");
                    respuesta = Console.ReadKey().KeyChar;
                }
                else
                {
                    Console.WriteLine("ERROR.Ingrese una cifra válida.");
                }

            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine("\nLas cifras introducidas suman {0}", suma);
            Console.ReadKey();
        }
    }
}
