using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cabina : Puesto
    {
        private Enumerados.TiposTelefono tipo;
        private string marca;
        private static int nextId = 1;

        public Cabina(Enumerados.TiposTelefono tipo, string marca) : base()
        {
            this.tipo = tipo;
            this.marca = marca;
            if (nextId < 10)
            {
                this.id = "T0" + nextId;
            }
            else
            {
                this.id = "T" + nextId;
            }
            nextId++;
        }
       
        public static Cabina SiguienteCabinaLibre(List<Cabina> collection)
        {
            Cabina retorno = null;

            if(!(collection is null) && Puesto.HayPuestosLibres(ConvertidorCabinaAAux(collection)))
            {
                foreach (Cabina item in collection)
                {
                    if(item.Estado == Enumerados.EstadoPuesto.Libre)
                    {
                        retorno = item;
                        break;
                    }
                }

            }
            

            return retorno;
        }

        public static bool EsNumeroValido(string numero)
        {
            bool retorno = false;

            if (numero.Length == 12 && long.TryParse(numero, out long aux) && aux > -1)
            {
                    retorno = true;
                
            }


            return retorno;
        }

        public static List<Puesto> ConvertidorCabinaAAux(List<Cabina> lista)
        {
            List<Puesto> retorno = new List<Puesto>();

            foreach (Cabina item in lista)
            {
                retorno.Add(item);
            }

            return retorno;
        }



        public Enumerados.TiposTelefono Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }


        public override double CalculoCosto(Sesion llamada)
        {
            double retorno = 0;
            Llamada aux;

            if(llamada is Llamada && llamada.Duracion > 0)
            {
                aux = (Llamada)llamada;

                switch(aux.Tipo)
                {
                    case Enumerados.TipoDeLlamada.Local:
                        retorno = llamada.Duracion;
                        break;
                    case Enumerados.TipoDeLlamada.LargaDistancia:
                        retorno = llamada.Duracion * 2.50f;
                        break;
                    case Enumerados.TipoDeLlamada.Internacional:
                        retorno = llamada.Duracion * 5;
                        break;
                }
            }
          
            return retorno;
        }



        /// <summary>
        /// Sobrrescribe el método ToString. Devuelve todos los datos del teléfono.
        /// </summary>
        /// <returns>Los datos del teléfono.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Tipo de teléfono: {this.Tipo}");
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine("__________________________________________________");


            return sb.ToString();
        }
    }
}
