using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class ValidarRespuesta
    {
        /// <summary>
        /// Valida si el caracter introducido es "S".
        /// </summary>
        /// <param name="c">El carácter introducido.</param>
        /// <returns>Verdadero si es "S". Falso si no.</returns>
        public static bool ValidaS_N(char c)
        {
            bool retorno = false;

            if(c.Equals('S'))
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
