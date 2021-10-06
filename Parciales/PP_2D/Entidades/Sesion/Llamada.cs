using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Llamada : Sesion
    {
        private string numero;
        private Enumerados.TipoDeLlamada tipo;



        public Llamada(Puesto puesto, Cliente cliente, string numero) : base(puesto, cliente)
        {
            this.Numero = numero;
            AsignarTipo();

        }

        public string Numero { get => numero; set => numero = value; }
        public Enumerados.TipoDeLlamada Tipo { get => tipo;}

        private void AsignarTipo()
        {
            char[] aux = this.numero.ToCharArray();

            if(aux.Length == 12 && long.TryParse(this.numero, out long auxLong))
            {
                if (aux[0].Equals('5') && aux[1].Equals('4'))
                {
                    //llamdas nacionales
                    if (aux[2].Equals('1') && aux[3].Equals('1'))
                    {
                        //locales
                        tipo = Enumerados.TipoDeLlamada.Local;
                    }
                    else
                    {
                        tipo = Enumerados.TipoDeLlamada.LargaDistancia;
                    }
                }
                else
                {
                    tipo = Enumerados.TipoDeLlamada.Internacional;
                }
            }
            else
            {
                tipo = Enumerados.TipoDeLlamada.NoAsignado;
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Costo de la llamada: {this.Costo}");
            sb.AppendLine($"Tipo de llamada: {this.Tipo}");
            return sb.ToString();
        }
    }
}
