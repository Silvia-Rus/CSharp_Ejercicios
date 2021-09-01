using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El área del cuadrado cuyo lado es 9 es: {0}", CalculoDeArea.CalcularCuadrado(9));
            Console.WriteLine("El área del triángulo cuyos lados son 9 y 3 es: {0}", CalculoDeArea.CalcularTriangulo(9, 3));
            Console.WriteLine("El área del círculo cuyo radio es 9 es: {0}", CalculoDeArea.CalcularCirculo(9));
            Console.ReadKey();
        }
    }
}
