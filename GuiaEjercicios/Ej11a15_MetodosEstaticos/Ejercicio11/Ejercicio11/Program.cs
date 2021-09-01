using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = int.MinValue;
            int minimoIngresado = int.MinValue;
            int maximoIngresado = int.MaxValue;
            int numeroIntentos = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");

                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if (Validacion.Validar(numeroIngresado, -100, 100))
                    {
                        Console.WriteLine("({0} está entre -100 y 100)", numeroIngresado);
                    }
                    else
                    {
                        Console.WriteLine("({0} NO está entre -100 y 100)", numeroIngresado);
                    }

                    if (numeroIntentos == 0)
                    {
                        minimoIngresado = numeroIngresado;
                        maximoIngresado = numeroIngresado;
                    }
                    else
                    {
                        if (numeroIngresado < minimoIngresado)
                        {
                            minimoIngresado = numeroIngresado;
                        }
                        else
                        {
                            if (numeroIngresado > maximoIngresado)
                            {
                                maximoIngresado = numeroIngresado;
                            }
                        }
                    }
                    numeroIntentos++;
                    suma += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("No es un número entero. Inténtelo de nuevo");
                }

            } while (numeroIntentos < 10);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("El valor mínimo es {0}", minimoIngresado);
            Console.WriteLine("El valor máximo es {0}", maximoIngresado);
            Console.WriteLine("El promedio es {0}", suma / numeroIntentos);

            Console.ReadKey();

        }
    }
}
