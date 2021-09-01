using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Calculadora
    {
        private static bool Validar(float segundoNumero)
        {
            if(segundoNumero != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static float Calcular(float primerNumero, float segundoNumero, string signo)
        {
            float retorno = float.MinValue;

            if(signo.Equals("+") || signo.Equals("-") || signo.Equals("*") || signo.Equals("/"))
            {
                switch(signo)
                {
                    case "+":
                        retorno = primerNumero + segundoNumero;
                        break;
                    case "-":
                        retorno = primerNumero - segundoNumero;
                        break;
                    case "*":
                        retorno = primerNumero * segundoNumero;
                        break;
                    case "/":
                        if(Validar(segundoNumero))
                        {
                            retorno = primerNumero * segundoNumero;
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un signo válido para operar (+,-, * o /");
            }
            return retorno;
        }
    }
}
