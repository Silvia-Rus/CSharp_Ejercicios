using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            this.notaFinal = -1;
            Random rnd = new Random();

            if(this.nota1 >=4 && this.nota2 >= 4)
            {
                this.notaFinal = (float)rnd.Next();
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DATOS DEL ALUMNO");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Nota Parcial 1: {this.nota1}");
            sb.AppendLine($"Nota Parcial 2: {this.nota2}");
            if (this.notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {this.notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado :(");
            }
            return sb.ToString();
        }

    }
}
