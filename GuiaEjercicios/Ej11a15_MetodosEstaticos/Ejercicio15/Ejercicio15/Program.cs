using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio sin validaciones para la entrada de datos.

            float primerNumero;
            float segundoNumero;
            float resultado;
            string signo;

            Console.Title = "Ejercicio 15";

            Console.WriteLine("Ingrese el primer número: ");
            primerNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            segundoNumero = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el signo (+, -, * ó /): ");
            signo = Console.ReadLine().ToString().Trim();

            resultado = Calculadora.Calcular(primerNumero, segundoNumero, signo);

            if (resultado != float.MinValue)
            {
                Console.WriteLine("El resultado es: {0}", resultado);
            }
           
            Console.ReadLine();
        }
    }
}
