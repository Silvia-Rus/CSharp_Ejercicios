using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ValidadorListas
    {
        #region programas
        private static bool ExistePrograma(List<Enumerados.Programas> lista, Enumerados.Programas programa)
        {
            bool retorno = false;

            foreach (Enumerados.Programas item in lista)
            {
                if(item == programa)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool SonIgualesListasProgramas(List<Enumerados.Programas> listaUno, List<Enumerados.Programas> listaDos)
        {
            bool retorno = true;

            foreach (Enumerados.Programas programa in listaUno)
            {
                if (ExistePrograma(listaDos, programa))
                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        public static bool AniadirPrograma(List<Enumerados.Programas> lista, Enumerados.Programas programa)
        {
            bool retorno = false;

            if(!ExistePrograma(lista, programa))
            {
                lista.Add(programa);
            }

            return retorno;
        }

        #endregion

        #region juegos

        //devuelve el índice en el que está el juego
        public static int ExisteJuego(List<Enumerados.Juegos> lista, Enumerados.Juegos juego)
        {
            bool existe = false;
            int i = 0;

            foreach (Enumerados.Juegos item in lista)
            {
                if (item == juego)
                {
                    existe = true;
                    break;
                }
                i++;
            }

            if(existe)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        public static bool SonIgualesListasJuegos(List<Enumerados.Juegos> listaUno, List<Enumerados.Juegos> listaDos)
        {
            bool retorno = true;

            foreach (Enumerados.Juegos juego in listaUno)
            {
                if (ValidadorListas.ExisteJuego(listaDos, juego) < 0)
                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        #endregion

        #region perifericos

        public static int ExistePeriferico(List<Enumerados.Perifericos> lista, Enumerados.Perifericos periferico)
        {
            bool existe = false;
            int i = 0;

            foreach (Enumerados.Perifericos item in lista)
            {
                if (item == periferico)
                {
                    existe = true;
                    break;
                }
                i++;
            }

            if (existe)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        public static bool SonIgualesListasPerifericos(List<Enumerados.Perifericos> listaUno, List<Enumerados.Perifericos> listaDos)
        {
            bool retorno = true;

            foreach (Enumerados.Perifericos periferico in listaUno)
            {
                if (ExistePeriferico(listaDos, periferico) > -1)
                {
                    retorno = false;
                    break;
                }

            }
            return retorno;
        }

        #endregion

        #region características

        public static void EditarCaracteristica(Dictionary<Enumerados.CaracteristicasComputadora, string> diccionario, Enumerados.CaracteristicasComputadora clave, string valor)
        {
            diccionario[clave] = valor;
        }

        public static bool SonIgualesCaracteristicas(Dictionary<Enumerados.CaracteristicasComputadora, string> diccionarioUno, Dictionary<Enumerados.CaracteristicasComputadora, string> diccionarioDos)
        {
            bool retorno = false;

            if(diccionarioUno[Enumerados.CaracteristicasComputadora.placaDeVideo] == diccionarioDos[Enumerados.CaracteristicasComputadora.placaDeVideo] &&
                diccionarioUno[Enumerados.CaracteristicasComputadora.procesador] == diccionarioDos[Enumerados.CaracteristicasComputadora.procesador] &&
                diccionarioUno[Enumerados.CaracteristicasComputadora.ram] == diccionarioDos[Enumerados.CaracteristicasComputadora.ram])
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion

    }


}
