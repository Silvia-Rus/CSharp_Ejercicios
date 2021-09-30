using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string dni;
        private string nombre;
        private string apellido;
        private int edad;
        private List<Enumerados.Programas> programaNecesita;
        private List<Enumerados.Juegos> juegoNecesita;
        private Dictionary<Enumerados.CaracteristicasComputadora, string> caracteristicasNecesita;

        private Enumerados.EstadoCliente estado;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public List<Enumerados.Programas> ProgramaNecesita { get => programaNecesita; }
        public List<Enumerados.Juegos> JuegoNecesita { get => juegoNecesita; }
        public Enumerados.EstadoCliente Estado { get => estado; set => estado = value; }


        public Cliente(string dni, string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.programaNecesita = new List<Enumerados.Programas>();
            this.juegoNecesita = new List<Enumerados.Juegos>();
            this.caracteristicasNecesita = new Dictionary<Enumerados.CaracteristicasComputadora, string>();
            ValidadorListas.EditarCaracteristica(this.caracteristicasNecesita, Enumerados.CaracteristicasComputadora.procesador, null);
            ValidadorListas.EditarCaracteristica(this.caracteristicasNecesita, Enumerados.CaracteristicasComputadora.ram, null);
            ValidadorListas.EditarCaracteristica(this.caracteristicasNecesita, Enumerados.CaracteristicasComputadora.placaDeVideo, null);
            ValidadorListas.EditarCaracteristica(this.caracteristicasNecesita, Enumerados.CaracteristicasComputadora.procesador, null);
            this.estado = Enumerados.EstadoCliente.esperando;
        }



        public static bool operator ==(Cliente cliente, Computadora computadora)
        {
            bool retorno = false;
            bool sonIgualesJuegos = ValidadorListas.SonIgualesListasJuegos(cliente.JuegoNecesita, computadora.Juego);
            bool sonIgualesPogramas = ValidadorListas.SonIgualesListasProgramas(cliente.ProgramaNecesita, computadora.Programa);
            bool sonIgualesCaracteristicas = ValidadorListas.SonIgualesCaracteristicas(cliente.caracteristicasNecesita, computadora.Caracteristicas);

            if ((cliente.programaNecesita.Count == 0 || sonIgualesPogramas) &&
                (cliente.JuegoNecesita.Count == 0 || sonIgualesJuegos) &&
                sonIgualesCaracteristicas)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Cliente cliente, Computadora computadora)
        {
            return !(cliente == computadora);
        }
        /// <summary>
        /// Comprueba si dos clientes son iguales comparando sus id.
        /// </summary>
        /// <param name="clienteUno">Primer cliente a comparar.</param>
        /// <param name="clienteDos">Segundo cliente a comparar.</param>
        /// <returns>Verdadero si son iguales. Falso si no.</returns>
        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            bool retorno = false;

            if (clienteUno.Dni.Equals(clienteDos.Dni))
            {
                retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Comprueba si dos clientes son diferentes comparando sus id.
        /// </summary>
        /// <param name="clienteUno">Primer cliente a comparar.</param>
        /// <param name="clienteDos">Segundo cliente a comparar.</param>
        /// <returns>Verdadero si son diferentes. Falso si no.</returns>
        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);
        }
        /// <summary>
        /// Sobreescribe el méodo ToString. Devuelve todos los datos del cliente.
        /// </summary>
        /// <returns>Los datos del cliente.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLIENTE:");
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Estado: {this.Estado}");

            if(this.Estado==(Enumerados.EstadoCliente.esperando) || this.Estado == (Enumerados.EstadoCliente.ubicado))
            {
                               
                sb.AppendLine("REQUERIMIENTOS: ");

                
                if(this.programaNecesita.Count == 0)
                {
                    sb.AppendLine("(Sin requerimientos sobre programas.)");
                }
                else
                {
                    sb.AppendLine($"Programas requeridos:");
                    foreach (Enumerados.Programas item in this.ProgramaNecesita)
                    {
                        sb.AppendLine($"--> {item}");
                    }
                }
                
                if(this.JuegoNecesita.Count == 0)
                {
                    sb.AppendLine("(Sin requerimientos sobre Juegos.)");

                }
                else
                {
                    sb.AppendLine($"Juegos requeridos:");
                    foreach (Enumerados.Juegos item in this.JuegoNecesita)
                    {
                        sb.AppendLine($"--> {item}");
                    }
                }

                if(this.caracteristicasNecesita.Count == 0)
                {
                    sb.AppendLine("(Sin requerimientos sobre la máquina.)");

                }
                else
                {
                    sb.AppendLine($"Características compu:");
                    if(this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador] != null)
                    {
                        sb.AppendLine($"Procesador: {this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador]}");

                    }

                    if(this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador] != null)
                    {
                        sb.AppendLine($"Procesador: {this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador]}");
                    }

                    if(this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.ram] != null)
                    {
                        sb.AppendLine($"Ram: {this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.ram]}");

                    }

                    if(this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.placaDeVideo] != null)
                    {
                        sb.AppendLine($"Placa de video: {this.caracteristicasNecesita[Enumerados.CaracteristicasComputadora.placaDeVideo]}");

                    }

                    sb.AppendLine("------------------------------------------");

                }              

            }
            return sb.ToString();
        }

    }
}
