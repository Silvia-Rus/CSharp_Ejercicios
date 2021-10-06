using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sesion
    {
        private static int nextId = 1;
        private int id;
        private Puesto puesto;
        private Cliente cliente;
        private DateTime horaInicio;
        private DateTime horaFinal;
        private int duracion; //en minutos
        protected double costo;

        public Sesion(Puesto puesto, Cliente cliente) 
        {
            this.id = nextId;
            this.Puesto = puesto;
            this.Cliente = cliente;
            //this.horaInicio = DateTime.Now;
            this.horaInicio = new DateTime(2021, 10, 04, 22, 30, 00); 
            this.HoraFinal = default(DateTime);
            this.Duracion = 0; // en minutos
            this.Costo = 0;
            nextId++;

            this.Puesto.Estado = Enumerados.EstadoPuesto.EnUso;
            if(puesto is Cabina)
            {
                this.Cliente.Estado = Enumerados.EstadoCliente.ubicadoTelefono;

            }
            else
            {
                this.Cliente.Estado = Enumerados.EstadoCliente.ubicadoComputadora;

            }
        }

        public  int CalcularDuracion()
        {
            TimeSpan duracion = this.horaFinal - this.HoraInicio;
            return (int)duracion.TotalSeconds;
        }

        public int Id { get => id; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public DateTime HoraInicio { get => horaInicio;  }
        public DateTime HoraFinal { get => horaFinal; set => horaFinal = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public double Costo { set => costo = value; get => costo; }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id de sesión: {this.Id}.");
            sb.AppendLine($"Puesto:");
            sb.AppendLine(Puesto.ToString());
            sb.AppendLine("Cliente:");
            sb.AppendLine(Cliente.ToString());
            sb.AppendLine($"Hora de inicio: {this.HoraInicio}.");
            if(this.HoraFinal != DateTime.MinValue)
            {
                sb.AppendLine($"Duración: {this.Duracion}.");
                sb.AppendLine($"Hora final: {this.HoraFinal}.");
                sb.AppendLine($"Costo: {this.Costo}.");
            }

            return sb.ToString(); 
        }

        public string Ticket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------Ticket----------");
            sb.AppendLine("-----Ciber 'El Vicio'-----");
            sb.AppendLine($"Tiempo de uso {this.duracion}");
            sb.AppendLine($"Costo bruto: {this.costo}");
            sb.AppendLine($"Costo neto: {this.costo * 0,16}");

            return sb.ToString();

        }



    }
}
