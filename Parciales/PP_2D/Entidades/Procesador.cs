using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Procesador
    {
        private string operador;
        private DateTime fecha;
        //private static Procesador procesador; //esto es para el singleton
        private List<Llamada> llamadas;
        private List<Conexion> conexiones;

        private List<Cabina> cabinas; //llegan creadas
        private List<Computadora> computadoras; //llegan creadas
        private List<Cliente> clientes; //llegan creados

        public string Operador { get => operador; set => operador = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List<Cabina> Cabinas { get => cabinas; set => cabinas = value; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public List<Computadora> Computadoras { get => computadoras; set => computadoras = value; }
        public List<Llamada> Llamadas { get => llamadas; set => llamadas = value; }
        public List<Conexion> Conexiones { get => conexiones; set => conexiones = value; }

        //hacer todo lo del singleton

        public Procesador(string operador, List<Cabina> cabinas, List<Computadora> computadoras, List<Cliente> clientes)
        {
            this.Operador = operador;
            this.Cabinas = cabinas;
            this.Computadoras = computadoras;
            this.Clientes = clientes;
            this.Fecha = DateTime.Today;
            this.Llamadas = new List<Llamada>();
            this.Conexiones = new List<Conexion>();

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Operador: {this.Operador}");
            sb.AppendLine($"Fecha: {this.Fecha.ToString("dd/MM/yyyy")}");
            
           
            sb.AppendLine("CABINAS: ");
            foreach (Cabina item in this.Cabinas)
            {
                sb.AppendLine($"--> {item.ToString()}");
            }

            sb.AppendLine("COMPUTADORAS: ");
            foreach (Computadora item in this.Computadoras)
            {
                sb.AppendLine($"--> {item.ToString()}");
            }
            sb.AppendLine("CLIENTES: ");
            foreach (Cliente item in this.Clientes)
            {
                sb.AppendLine($"--> {item.ToString()}");
            }
            if (this.Llamadas != null)
            {
                sb.AppendLine("LLAMADAS:");
                foreach (Sesion item in this.Llamadas)
                {
                    sb.AppendLine($"--> {item.ToString()}");
                }
            }
            else
            {
                sb.AppendLine("No hay llamadas.");
            }

            if (this.Conexiones != null)
            {
                sb.AppendLine("CONEXIONES:");
                foreach (Sesion item in this.Conexiones)
                {
                    sb.AppendLine($"--> {item.ToString()}");
                }
            }
            else
            {
                sb.AppendLine("No hay conexiones.");
            }
            return sb.ToString();

        }


        public void AniadirPuesto(Cabina puesto)
        {
            this.Cabinas.Add(puesto);
        }

        public void AniadirCliente(Cliente cliente)
        {
            this.Clientes.Add(cliente);
        }

        public List<Cliente> ClientesFiltradosPorEstado(Enumerados.EstadoCliente estadoCliente)
        {
            List<Cliente> retorno = new List<Cliente>();

            foreach (Cliente cliente in this.Clientes)
            {
                if(cliente.Estado == estadoCliente)
                {
                    retorno.Add(cliente);
                }
            }

            return retorno;
        }

        public bool AbrirSesion(Puesto puesto, Cliente cliente, Enumerados.TiposDeSesion tipo, String numero) 
        {
            bool retorno = false;

            if(puesto.Estado == Enumerados.EstadoPuesto.Libre)
            {
                switch (tipo)
                {
                    case Enumerados.TiposDeSesion.conexion:
                        if (cliente == (Computadora)puesto && cliente.Estado == Enumerados.EstadoCliente.esperandoComputadora)
                        {
                            Conexion conexion = new Conexion(puesto, cliente);
                            this.Conexiones.Add(conexion);
                            retorno = true;
                        }
                        break;
                    case Enumerados.TiposDeSesion.llamada:
                        if (numero.Length == 12 && cliente.Estado == Enumerados.EstadoCliente.esperandoCabina)
                        {
                            Llamada llamada = new Llamada(puesto, cliente, numero);
                            this.Llamadas.Add(llamada);
                            retorno = true;
                        }
                        break;
                }
            }
            
            return retorno;
        }

        public bool CerrarSesion(Sesion sesion)
        {
            bool retorno = false;

            if(!(sesion is null) && sesion.Puesto.Estado == Enumerados.EstadoPuesto.EnUso && 
              (sesion.Cliente.Estado == Enumerados.EstadoCliente.ubicadoComputadora || sesion.Cliente.Estado == Enumerados.EstadoCliente.ubicadoTelefono))
            {
                sesion.Puesto.Estado = Enumerados.EstadoPuesto.Libre;
                sesion.Cliente.Estado = Enumerados.EstadoCliente.fuera;
                //sesion.HoraFinal = DateTime.Now;
                //this.horaInicio = new DateTime(2021, 10, 04, 22, 30, 00); 
                sesion.Cliente.OrdenDeLlegadaCabina = -1;
                sesion.Cliente.OrdenDeLlegadaComputadora = -1;


                sesion.HoraFinal = new DateTime(2021, 10, 04, 22, 30, 31);
                sesion.Duracion = sesion.CalcularDuracion();
                sesion.Costo = sesion.Puesto.CalculoCosto(sesion);
                Historico.Sesiones.Add(sesion);
                if(sesion is Llamada)
                {
                    this.Llamadas.Remove((Llamada)sesion);
                }
                else
                {
                    this.Conexiones.Remove((Conexion)sesion);

                }

                retorno = true;
                
            }

            return retorno;
           
        }

        public static Procesador CargaDatosAutomatica(Procesador procesador)
        {

            Cliente c1 = new Cliente("111", "Kennie", "Bell", 25, Enumerados.EstadoCliente.fuera);
            Cliente c2 = new Cliente("222", "Jackie", "Sieras", 32, Enumerados.EstadoCliente.fuera);
            Cliente c3 = new Cliente("333", "Elba", "Lazo", 16, Enumerados.EstadoCliente.fuera);
            Cliente c4 = new Cliente("444", "Cindy", "Nero", 39, Enumerados.EstadoCliente.esperandoCabina);
            Cliente c5 = new Cliente("555", "Aquiles", "Bailo", 39, Enumerados.EstadoCliente.esperandoCabina);
            Cliente c6 = new Cliente("666", "Johnny", "Melavo", 14, Enumerados.EstadoCliente.esperandoCabina);
            Cliente c7 = new Cliente("777", "Elba", "Jonazo", 37, Enumerados.EstadoCliente.esperandoComputadora);
            Cliente c8 = new Cliente("888", "Benito", "Camelas", 98, Enumerados.EstadoCliente.esperandoComputadora);
            Cliente c9 = new Cliente("999", "Alberto", "Nisman", 98, Enumerados.EstadoCliente.esperandoComputadora);


            ValidadorListas.AniadirPrograma(c7.ProgramaNecesita, Enumerados.Programas.messenger);
            ValidadorListas.AniadirPrograma(c7.ProgramaNecesita, Enumerados.Programas.ares);

            ValidadorListas.AniadirJuego(c8.JuegoNecesita, Enumerados.Juegos.LineageII);

            ValidadorListas.AniadirJuego(c9.JuegoNecesita, Enumerados.Juegos.LineageII);
            ValidadorListas.AniadirJuego(c9.JuegoNecesita, Enumerados.Juegos.CounterStrike);
            ValidadorListas.AniadirPrograma(c9.ProgramaNecesita, Enumerados.Programas.ares);
            ValidadorListas.EditarCaracteristica(c9.CaracteristicasNecesita, Enumerados.CaracteristicasComputadora.ram, "8gb");

            List<Cliente> listaClientes = new List<Cliente>() {c1, c2, c3, c4, c5, c6, c7, c8, c9};

            Cabina cab1 = new Cabina(Enumerados.TiposTelefono.ADisco, "Telefonica");
            Cabina cab2 = new Cabina(Enumerados.TiposTelefono.ConTeclado, "Panasonic KX-TS500");
            Cabina cab3 = new Cabina(Enumerados.TiposTelefono.ConTeclado, "Noblex NCT200");
            Computadora comp1 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");
            Computadora comp2 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");
            Computadora comp3 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");
            Computadora comp4 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");

            ValidadorListas.AniadirPrograma(comp1.Programa, Enumerados.Programas.messenger);
            ValidadorListas.AniadirPrograma(comp1.Programa, Enumerados.Programas.ares);
            ValidadorListas.AniadirPeriferico(comp1.Periferico, Enumerados.Perifericos.camara);
            ValidadorListas.AniadirPeriferico(comp1.Periferico, Enumerados.Perifericos.auriculares);
            ValidadorListas.AniadirPeriferico(comp1.Periferico, Enumerados.Perifericos.microfono);

            ValidadorListas.AniadirPrograma(comp2.Programa, Enumerados.Programas.office);
            ValidadorListas.AniadirJuego(comp2.Juego, Enumerados.Juegos.LineageII);
            ValidadorListas.AniadirPeriferico(comp2.Periferico, Enumerados.Perifericos.camara);
            ValidadorListas.AniadirPeriferico(comp2.Periferico, Enumerados.Perifericos.auriculares);
            ValidadorListas.AniadirPeriferico(comp2.Periferico, Enumerados.Perifericos.microfono);

            ValidadorListas.AniadirPrograma(comp3.Programa, Enumerados.Programas.ares);
            ValidadorListas.AniadirJuego(comp3.Juego, Enumerados.Juegos.LineageII);
            ValidadorListas.AniadirJuego(comp3.Juego, Enumerados.Juegos.CounterStrike);

            ValidadorListas.AniadirPeriferico(comp4.Periferico, Enumerados.Perifericos.camara);
            ValidadorListas.AniadirPeriferico(comp4.Periferico, Enumerados.Perifericos.auriculares);
            ValidadorListas.AniadirPeriferico(comp4.Periferico, Enumerados.Perifericos.microfono);

            List<Cabina> listaCabinas = new List<Cabina>() { cab1, cab2, cab3 };
            List<Computadora> listaComputadoras = new List<Computadora> { comp1, comp2, comp3, comp4 };


            procesador = new Procesador("Rus", listaCabinas, listaComputadoras, listaClientes);

            return procesador;

        }

    }
}
