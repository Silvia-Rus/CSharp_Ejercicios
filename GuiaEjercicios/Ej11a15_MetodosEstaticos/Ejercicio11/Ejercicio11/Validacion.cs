using System;

namespace Ejercicio11
{
    public class Validacion
    {
        /// <summary>
        /// Valida que un entero está en un rango de enteros.
        /// </summary>
        /// <param name="valor">El valor que se quiere validar.</param>
        /// <param name="min">El mínimo del rango.</param>
        /// <param name="max">El máximo del rango</param>
        /// <returns>True si está dentro del rango. False si no.</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;

            if (min < max)
            {
                if (valor > min && valor < max)
                {
                    retorno = true;
                }
            }
            else
            {
                Console.WriteLine("La cifra que entra en segundo lugar debe ser menor a la que entra en el tercero");
            }
            return retorno;
        }
    }
}
