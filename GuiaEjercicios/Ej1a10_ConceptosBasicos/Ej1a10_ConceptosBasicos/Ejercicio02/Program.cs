using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar: el cuadrado y el cubo del mismo.Se debe validar que el número sea
            //mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.

            int numeroIngresado = 0;

            Console.Title = "Ejercicio 02";

            do
            {
                Console.WriteLine("Ingrese un número: ");

                if (int.TryParse(Console.ReadLine(), out numeroIngresado) && numeroIngresado > 0)
                {
                    Console.WriteLine("El cuadrado de {0} es {1}.", numeroIngresado, Math.Pow(numeroIngresado, 2));
                    Console.WriteLine("El cubo de {0} es {1}.", numeroIngresado, Math.Pow(numeroIngresado, 3));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numeroIngresado < 1);

        }
    }
}
