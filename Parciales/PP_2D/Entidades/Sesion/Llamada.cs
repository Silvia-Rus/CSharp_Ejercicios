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

        }

        public string Numero { get => numero; set => numero = value; }
        public Enumerados.TipoDeLlamada Tipo 
        { 
            get => tipo;

            set 
            {
                char[] aux = this.numero.ToCharArray();
                
                if(aux.Length == 12)
                {
                    if (aux[0] == 5 && aux[1] == 4)
                    {
                        //llamdas nacionales
                        if (aux[2] == 1 && aux[3] == 1)
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
        
        }
        public override double Costo { set => costo =  this.Puesto.CalculoCosto(this) ; get => costo;  }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Costo de la llamada: {this.Costo}");           
            return sb.ToString();
        }
    }
}
