using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Puesto
    {
        protected string id;
        private Enumerados.EstadoPuesto estado;
        private int minutosDeUso;

        public Puesto()
        {
            this.estado = Enumerados.EstadoPuesto.Libre;
            this.minutosDeUso = 0;
        }

        
        public Enumerados.EstadoPuesto Estado { get => estado; set => estado = value; }
        public int MinutosDeUso { get => minutosDeUso; set => minutosDeUso = value; }
        public string Id { get => id; }

        public static List<Puesto> FiltroPuestosPorEstado(List<Puesto> lista, Enumerados.EstadoPuesto estado)
        {
            List<Puesto> retorno = new List<Puesto>();

            foreach (Puesto item in lista)
            {
                if (item.Estado == estado)
                {
                    retorno.Add(item);
                }
            }

            return retorno;
        }


        /// <summary>
        /// Comprueba si dos puestos son iguales comparando sus id.
        /// </summary>
        /// <param name="puestoUno">Primer puesto a comparar.</param>
        /// <param name="puestoDos">Segundo puesto a comparar.</param>
        /// <returns>Verdadero si son iguales. Falso si no.</returns>
        public static bool operator ==(Puesto puestoUno, Puesto puestoDos)
        {
            bool retorno = false;

            if(puestoUno.Id.Equals(puestoDos.Id))
            {
                retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Comprueba si dos puestos son diferentes comparando sus id.
        /// </summary>
        /// <param name="puestoUno">Primer puesto a comparar.</param>
        /// <param name="puestoDos">Segundo puesto a comparar.</param>
        /// <returns>Verdadero si son diferentes. Falso si no.</returns>
        public static bool operator !=(Puesto puestoUno, Puesto puestoDos)
        {
            return !(puestoUno == puestoDos);
        }

        /// <summary>
        /// Sobreescribe el méodo ToString. Devuelve todos los datos del puesto.
        /// </summary>
        /// <returns>Los datos del puesto.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {this.Id}");
            sb.AppendLine($"Estado: {this.Estado}");
            sb.AppendLine($"Minutos de uso totales: {this.MinutosDeUso}");                    
            return sb.ToString();
        }

        abstract  public double CalculoCosto(Sesion sesion);


    }
}
