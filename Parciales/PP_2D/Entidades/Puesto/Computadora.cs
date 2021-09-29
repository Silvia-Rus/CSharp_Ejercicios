﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora : Puesto
    {
        private static int nextId = 1;
        private List<Enumerados.Programas> programas;
        private List<Enumerados.Perifericos> perifericos;
        private List<Enumerados.Juegos> juegos;
        private Dictionary<Enumerados.CaracteristicasComputadora, string> caracteristicas;

        public Computadora(string procesador, string ram, string placaDeVideo) : base()
        {
            this.programas = new List<Enumerados.Programas>();
            this.perifericos = new List<Enumerados.Perifericos>();
            this.juegos = juegos = new List<Enumerados.Juegos>();
            this.caracteristicas = new Dictionary<Enumerados.CaracteristicasComputadora, string>();
            this.caracteristicas.Add(Enumerados.CaracteristicasComputadora.procesador, procesador);
            this.caracteristicas.Add(Enumerados.CaracteristicasComputadora.ram, ram);
            this.caracteristicas.Add(Enumerados.CaracteristicasComputadora.placaDeVideo, placaDeVideo);

            if (nextId < 10)
            {
                this.id = "C0" + nextId;
            }
            else
            {
                this.id = "C" + nextId;
            }
            nextId++;
        }



        public List<Enumerados.Programas> Programa { get => programas; }
        public List<Enumerados.Perifericos> Periferico { get => perifericos; }
        public List<Enumerados.Juegos> Juego { get => juegos; }
        public Dictionary<Enumerados.CaracteristicasComputadora, string> Caracteristicas { get => caracteristicas; }


     
        public override double CalculoCosto(Sesion conexion)
        {
            double retorno = 0;
       
            if(conexion is Conexion && conexion.Duracion > 0)
            {
                if(conexion.Duracion%30 == 0)
                {
                    retorno = (conexion.Duracion / 30) + 1;
                }
                else
                {
                    retorno = conexion.Duracion / 30;
                }
            }
            return retorno;
        }

        public bool AniadirJuego(Enumerados.Juegos juego)
        {
            bool retorno = false;

            if (ValidadorListas.ExisteJuego(this.juegos, juego) == -1)
            {
                this.juegos.Add(juego);
            }

            return retorno;
        }

        public bool BorrarJuego(Enumerados.Juegos juego)
        {
            bool retorno = false;
            int i = ValidadorListas.ExisteJuego(this.juegos, juego);

            if(i > -1)
            {
                this.juegos.RemoveAt(i);
                retorno = true;
            }
            return retorno;
        }

        public bool AniadirPeriferico(Enumerados.Perifericos periferico)
        {
            bool retorno = false;

            if (ValidadorListas.ExistePeriferico(this.perifericos, periferico) == -1)
            {
                this.perifericos.Add(periferico);
            }

            return retorno;
        }

        public bool BorrarPeriferico(Enumerados.Perifericos periferico)
        {
            bool retorno = false;
            int i = ValidadorListas.ExistePeriferico(this.perifericos, periferico);

            if (i > -1)
            {
                this.perifericos.RemoveAt(i);
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// Sobreescribe el méodo ToString. Devuelve todos los datos de la computadora.
        /// </summary>
        /// <returns>Los datos de la computadora.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Características de la computadora:");
            sb.AppendLine($"-->Procesador: {this.caracteristicas[Enumerados.CaracteristicasComputadora.procesador]}");
            sb.AppendLine($"-->Ram: {this.caracteristicas[Enumerados.CaracteristicasComputadora.ram]}");
            sb.AppendLine($"-->Placa de video: {this.caracteristicas[Enumerados.CaracteristicasComputadora.placaDeVideo]}");
            if (this.Programa.Count == 0)
            {
                sb.AppendLine("(Sin programas instalados.)");
            }
            else
            {
                sb.AppendLine($"Programas instalados:");
                foreach (Enumerados.Programas item in this.Programa)
                {
                    sb.AppendLine($"--> {item}");
                }
            }
            
            if(this.perifericos.Count == 0)
            {
                sb.AppendLine("(Sin periféricos asociados.)");
            }
            else
            {
                sb.AppendLine($"Periféricos:");
                foreach (Enumerados.Perifericos item in this.Periferico)
                {
                    sb.AppendLine($"--> {item}");
                }
            }

            if(this.juegos.Count == 0)
            {
                sb.AppendLine("(Sin juegos instalados.)");

            }
            else
            {
                sb.AppendLine($"Juegos:");
                foreach (Enumerados.Juegos item in this.Juego)
                {
                    sb.AppendLine($"--> {item}");
                }
            }

            sb.AppendLine("__________________________________________________");


            return sb.ToString();
        }


    }
}