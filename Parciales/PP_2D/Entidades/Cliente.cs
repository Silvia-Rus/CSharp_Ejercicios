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
        private int ordenDeLlegadaCabina;
        private int ordenDeLlegadaComputadora;

        private List<Enumerados.Programas> programasNecesita;
        private List<Enumerados.Juegos> juegosNecesita;

        private Dictionary<Enumerados.CaracteristicasComputadora, string> caracteristicasNecesita;

        private static int nextCabina = 1;
        private static int nextComputadora = 1;

        private Enumerados.EstadoCliente estado;

        public string JuegosNecesitaToString
        {

            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (Enumerados.Programas item in this.juegosNecesita)
                {
                    sb.Append($"{item.ToString()},");
                }

                return sb.ToString();

            }
        }

        public string ProgramasNecesitaToString
        {

            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (Enumerados.Programas item in this.programasNecesita)
                {
                    sb.Append($"{item.ToString()},");
                }

                return sb.ToString();

            }
        }

        public string CaracteristicasNecesitaToString
        {

            get
            {
                if(this.CaracteristicasNecesita.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (KeyValuePair<Enumerados.CaracteristicasComputadora, string> item in this.CaracteristicasNecesita)
                    {
                        if(!(item.Value is null))
                        {
                            sb.Append($"{item},");
                        }
                        
                    }

                    return sb.ToString();
                }
                else
                {
                    return "null";
                }
               

            }
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public List<Enumerados.Programas> ProgramaNecesita { get => programasNecesita; }
        public List<Enumerados.Juegos> JuegoNecesita { get => juegosNecesita; }
        public Enumerados.EstadoCliente Estado { get => estado; set => estado = value; }
        public int OrdenDeLlegadaCabina { get => ordenDeLlegadaCabina; set => ordenDeLlegadaCabina = value; }
        public int OrdenDeLlegadaComputadora { get => ordenDeLlegadaComputadora; set => ordenDeLlegadaComputadora = value; }
        public Dictionary<Enumerados.CaracteristicasComputadora, string> CaracteristicasNecesita { get => caracteristicasNecesita; set => caracteristicasNecesita = value; }

        public Cliente(string dni, string nombre, string apellido, int edad, Enumerados.EstadoCliente estado)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.programasNecesita = new List<Enumerados.Programas>();
            this.juegosNecesita = new List<Enumerados.Juegos>();
            this.CaracteristicasNecesita = new Dictionary<Enumerados.CaracteristicasComputadora, string>();
            ValidadorListas.EditarCaracteristica(this.CaracteristicasNecesita, Enumerados.CaracteristicasComputadora.procesador, null);
            ValidadorListas.EditarCaracteristica(this.CaracteristicasNecesita, Enumerados.CaracteristicasComputadora.ram, null);
            ValidadorListas.EditarCaracteristica(this.CaracteristicasNecesita, Enumerados.CaracteristicasComputadora.placaDeVideo, null);
            ValidadorListas.EditarCaracteristica(this.CaracteristicasNecesita, Enumerados.CaracteristicasComputadora.procesador, null);
            this.estado = estado;
            if(this.estado == Enumerados.EstadoCliente.esperandoCabina)
            {
                AsignarOrdenDeLlegadaCabina(this);
                this.OrdenDeLlegadaComputadora = -1;
            }
            else if (this.estado == Enumerados.EstadoCliente.esperandoComputadora)
            {
                AsignarOrdenDeLlegadaComputadora(this);
                this.ordenDeLlegadaCabina = -1;
            }
            else
            {
                this.OrdenDeLlegadaComputadora = -1;
                this.ordenDeLlegadaCabina = -1;
            }
        }

        public static void AsignarOrdenDeLlegadaCabina(Cliente cliente)
        {
            cliente.ordenDeLlegadaCabina = nextCabina;
            nextCabina++;
        }

        public static void AsignarOrdenDeLlegadaComputadora(Cliente cliente)
        {
            cliente.ordenDeLlegadaComputadora = nextComputadora;
            nextComputadora++;
        }

        public static List<Cliente> FiltroClientesPorEstado(List<Cliente> lista, Enumerados.EstadoCliente estado)
        {
            List<Cliente> retorno = new List<Cliente>();

            foreach (Cliente item in lista)
            {
                if(item.Estado == estado)
                {
                    retorno.Add(item);
                }
            }

            return retorno;
        }


        public static bool operator ==(Cliente cliente, Computadora computadora)
        {
            bool retorno = false;
            bool sonIgualesJuegos = ValidadorListas.SonIgualesListasJuegos(cliente.JuegoNecesita, computadora.Juego);
            bool sonIgualesPogramas = ValidadorListas.SonIgualesListasProgramas(cliente.ProgramaNecesita, computadora.Programa);
            bool sonIgualesCaracteristicas = ValidadorListas.SonIgualesCaracteristicas(cliente.CaracteristicasNecesita, computadora.Caracteristicas);

            if ((cliente.programasNecesita.Count == 0 || sonIgualesPogramas) &&
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

            if(this.Estado==(Enumerados.EstadoCliente.esperandoComputadora) || this.Estado == (Enumerados.EstadoCliente.ubicadoComputadora))
            {
                               
                sb.AppendLine("REQUERIMIENTOS: ");

                
                if(this.programasNecesita.Count == 0)
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

                if(this.CaracteristicasNecesita.Count == 0)
                {
                    sb.AppendLine("(Sin requerimientos sobre la máquina.)");

                }
                else
                {
                    sb.AppendLine($"Características compu:");
                    if(this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador] != null)
                    {
                        sb.AppendLine($"Procesador: {this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador]}");

                    }

                    if(this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador] != null)
                    {
                        sb.AppendLine($"Procesador: {this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.procesador]}");
                    }

                    if(this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.ram] != null)
                    {
                        sb.AppendLine($"Ram: {this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.ram]}");

                    }

                    if(this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.placaDeVideo] != null)
                    {
                        sb.AppendLine($"Placa de video: {this.CaracteristicasNecesita[Enumerados.CaracteristicasComputadora.placaDeVideo]}");

                    }

                    sb.AppendLine("------------------------------------------");

                }              

            }
            return sb.ToString();
        }

    }
}
