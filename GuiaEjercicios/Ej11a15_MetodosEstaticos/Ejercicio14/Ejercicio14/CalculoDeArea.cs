using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        /// <summary>
        /// Clacula el área de un cuadrado del que tenemos el lado.
        /// </summary>
        /// <param name="lado">Lado del cuadrado.</param>
        /// <returns>El área del cuadrado o -1 si el lado es negativo.</returns>
        public static double CalcularCuadrado(double lado)
        {
            if(lado > -1)
            {
                return lado * lado;
            }
            else
            {
                return -1;
            }
            
        }
        /// <summary>
        /// Calcula el área de un triángulo del que tenemos dos lados.
        /// </summary>
        /// <param name="ladoUno">Lado del triángulo.</param>
        /// <param name="ladoDos">Lado del triánulo.</param>
        /// <returns>El área del triángulo o -1 si alguno de los lados es negativo.</returns>
        public static double CalcularTriangulo(double ladoUno, double ladoDos)
        {           
            if(ladoUno > -1 && ladoDos > -1)
            {
                return (ladoUno * ladoDos) / 2;
            }
            else
            {
                return -1;

            }
        }
        /// <summary>
        /// Calcula el área de un círculo del que tenemos el radio.
        /// </summary>
        /// <param name="radio">Radio del círculo.</param>
        /// <returns>El área del círculo o -1 si el radio es negativo</returns>
        public static double CalcularCirculo(double radio)
        {
            if(radio > -1)
            {
                return 2 * 3.14f * radio;
            }
            else
            {
                return -1;
            }

        }
    }
}
