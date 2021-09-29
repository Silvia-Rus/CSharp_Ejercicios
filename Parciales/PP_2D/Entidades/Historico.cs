using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Historico
    {
        private static List<Sesion> sesiones;

        public static List<Sesion> Sesiones { get => sesiones; set => sesiones = value; }

        static Historico()
        {
            Sesiones = new List<Sesion>();
        }

        public static int OrdenarPorDuracion(Puesto puesto1, Puesto puesto2)
        {
            return puesto1.MinutosDeUso.CompareTo(puesto2.MinutosDeUso);
        }


        //LOS SORT DEL DEMONIO

        //esta saca una lista de todas as llamadas/conexiones 
        private static List<Puesto> FiltroLista (string tipoDePuesto)
        {
            List<Puesto> retorno = new List<Puesto>();

            if (tipoDePuesto.Equals("Cabina") || tipoDePuesto.Equals("Computadora"))
            {
                foreach (Sesion item in Historico.Sesiones)
                {
                    if (item.Puesto.GetType().ToString().Equals(tipoDePuesto))
                    {
                        retorno.Add(item.Puesto);
                    }

                }
            }

            return retorno;
        }
        public static List<Puesto> OrdenarLista(string tipoDePuesto)
        {
            List<Puesto> retorno = new List<Puesto>();

            if(tipoDePuesto.Equals("Cabina") || tipoDePuesto.Equals("Computadora"))
            {
                retorno = FiltroLista(tipoDePuesto);

                if (retorno.Count > 0)
                {
                    retorno.Sort(OrdenarPorDuracion);
                }
            }     

            return retorno;
        }

        #region Ganancias

        public static double GananciasLlamadasLocales()
        {
            double retorno = 0;
            Llamada aux;

            foreach (Sesion item in Sesiones)
            {
                if(item is Llamada)
                {
                    aux = (Llamada)item;
                    if(aux.Tipo == Enumerados.TipoDeLlamada.Local)
                    {
                        retorno += item.Costo;
                    }                  
                }

            }
            return retorno;

        }

        public static double GananciasLlamadasLargaDistancia()
        {
            double retorno = 0;
            Llamada aux;

            foreach (Sesion item in Sesiones)
            {
                if (item is Llamada)
                {
                    aux = (Llamada)item;
                    if (aux.Tipo == Enumerados.TipoDeLlamada.LargaDistancia)
                    {
                        retorno += item.Costo;
                    }
                }

            }
            return retorno;

        }

        public static double GananciasLlamadasInternacional()
        {
            double retorno = 0;
            Llamada aux;

            foreach (Sesion item in Sesiones)
            {
                if (item is Llamada)
                {
                    aux = (Llamada)item;
                    if (aux.Tipo == Enumerados.TipoDeLlamada.Internacional)
                    {
                        retorno += item.Costo;
                    }
                }

            }
            return retorno;

        }

        public static double GananciasComputadora()
        {
            double retorno = 0;

            foreach (Sesion item in Sesiones)
            {
                if (item is Conexion)
                {
                    retorno += item.Costo;
                }

            }
            return retorno;
        }

        public static double GananciasTotales()
        {
            return GananciasComputadora() + GananciasLlamadasInternacional() + GananciasLlamadasLargaDistancia() + GananciasLlamadasLocales();
        }
        #endregion

        #region Horas

        public static int HorasTotales()
        {
            int retorno = 0;

            foreach (Sesion item in Sesiones)
            {
                retorno += item.Duracion / 60;
            }

            return retorno;
        }

        #endregion

        #region especificaciones


        #endregion



    }
}
