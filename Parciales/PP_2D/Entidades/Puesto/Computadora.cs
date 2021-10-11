using System;
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

        public string ProgramasToString
        {
            
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (Enumerados.Programas item in this.programas )
                {
                    sb.Append($"{item.ToString()},");
                }

                return sb.ToString();

            }
        }

        public string JuegosToString
        {

            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (Enumerados.Programas item in this.juegos)
                {
                    sb.Append($"{item.ToString()},");
                }

                return sb.ToString();

            }
        }

        public string PerifericosToString
        {

            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (Enumerados.Programas item in this.perifericos)
                {
                    sb.Append($"{item.ToString()},");
                }

                return sb.ToString();

            }
        }
        public List<Enumerados.Perifericos> Periferico { get => perifericos; }
        public List<Enumerados.Juegos> Juego { get => juegos; }
        public Dictionary<Enumerados.CaracteristicasComputadora, string> Caracteristicas { get => caracteristicas; }


     
        public override double CalculoCosto(Sesion conexion)
        {
            double fracciones30Minutos = 0;
       
            if(conexion is Conexion && conexion.Duracion > 0)
            {
                if(conexion.Duracion%30 != 0)
                {
                    fracciones30Minutos = (conexion.Duracion / 30) + 1;
                }
                else
                {
                    fracciones30Minutos = conexion.Duracion / 30;
                }
            }
            return fracciones30Minutos*0.5f;
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
