using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) 
            //que son divisores del número. El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            //Nota: Utilizar estructuras repetitivas y selectivas

            int contadorNumerosPerfectos = 0;
            int numero = 1;
            int acumuladorDivisores = 0;

            Console.Title = "Ejercicio 04";
            Console.WriteLine("Los cuatro primeros números perfectos son:");

            do
            {
                acumuladorDivisores = 0;
                //chequear todos los números que componen un número
                for (int i = 1; i < numero; i++)
                {

                    if (numero % i == 0)//ver si son divisores del número    
                    {
                        acumuladorDivisores += i;//sumarlo
                    }
                }
                //ver si la suma de sus divisores es igual al número
                if (acumuladorDivisores == numero)
                {
                    Console.WriteLine(numero);
                    contadorNumerosPerfectos++;
                }
                numero++;
            } while (contadorNumerosPerfectos < 4);
            Console.ReadKey();
        }
    }
}
