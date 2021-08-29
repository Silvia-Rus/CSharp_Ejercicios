using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que determine si un año es bisiesto.
            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos
            //también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

            int anioInicio = int.MinValue;
            int anioFinal = int.MaxValue;

            bool banderaValidacionAnios = false;
            bool banderaPasoAlCalculo = false;
            Console.Title = "Ejercicio 06";

            //introducir primer número
            do
            {
                Console.WriteLine("Ingrese un año de inicio: ");

                if (int.TryParse(Console.ReadLine(), out anioInicio))
                {

                    banderaValidacionAnios = true;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (!banderaValidacionAnios);

            //introducir segundo número
            if (banderaValidacionAnios)
            {
                do
                {
                    Console.WriteLine("Ingrese un año de final: ");

                    if (int.TryParse(Console.ReadLine(), out anioFinal) && anioFinal > anioInicio)
                    {

                        banderaValidacionAnios = false;
                        banderaPasoAlCalculo = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. ¡Reingresar número!");
                    }

                } while (banderaValidacionAnios);
            }
            //hacer el cálculo
            if (banderaPasoAlCalculo)
            {
                Console.WriteLine("Los años bisiestos del {0} al {1} fueron: ", anioInicio, anioFinal);
                for (int anioAChequear = anioInicio; anioAChequear <= anioFinal; anioAChequear++)
                {

                    if ((anioAChequear % 4 == 0 && anioAChequear % 100 != 0) || (anioAChequear % 100 == 0 && anioAChequear % 400 == 0))
                    {
                        Console.WriteLine(anioAChequear);
                    }

                }
                Console.WriteLine("Pulse cualquier tecla para salir.");
            }
            Console.ReadKey();
        }
    }
}
