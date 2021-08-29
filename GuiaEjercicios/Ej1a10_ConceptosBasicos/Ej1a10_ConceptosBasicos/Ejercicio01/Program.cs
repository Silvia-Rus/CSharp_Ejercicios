using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            int numeroIngresado;
            int minimo = int.MinValue;
            int maximo = int.MaxValue;
            int acumulador = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (acumulador == 0)
                {
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado < minimo)
                    {
                        minimo = numeroIngresado;
                    }
                    else if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                }
                suma += numeroIngresado;
                acumulador++;

            } while (acumulador < 5);

            Console.WriteLine("El valor máximo es {0}", maximo);
            Console.WriteLine("El valor mínimo es {0}", minimo);
            Console.WriteLine("El promedio es {0}", (float)(suma / acumulador));

            Console.ReadLine();

        }
    }
}
