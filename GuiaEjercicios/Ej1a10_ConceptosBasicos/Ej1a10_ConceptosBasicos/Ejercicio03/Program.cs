using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

            int numeroIngresado = 0;
            bool rompe = false;

            Console.Title = "Ejercicio 03";

            do
            {
                Console.WriteLine("Ingrese un número: ");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado) && numeroIngresado > 1)
                {
                    for (int numeroAChequear = 0; numeroIngresado >= numeroAChequear; numeroAChequear++)
                    {
                        for (int i = 2; i < numeroAChequear; i++)
                        {
                            if (numeroAChequear % i == 0)
                            {
                                rompe = true;
                                break;
                            }
                        }
                        if (!rompe && numeroAChequear > 1)
                        {
                            Console.WriteLine("{0} es primo.", numeroAChequear);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. Debe ser un número positivo mayor a 1.");
                }


            } while (numeroIngresado < 2);
            Console.ReadKey();
        }
    }
}
