using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int resultado;
            if(tinta+this.tinta > -1 && tinta+this.tinta<cantidadTintaMaxima+1)
            {
                resultado = Convert.ToInt32(tinta + this.tinta);
                this.tinta = (short)resultado;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            StringBuilder sb = new StringBuilder();

            if(gasto < 0 && this.tinta+gasto>=0)
            {
                this.SetTinta(gasto);

                for(int i = 0; i<gasto*-1; i++)
                {
                    sb.Append("*");
                }
                retorno = true;
            }

            dibujo = sb.ToString();

            return retorno;
        }




    }
}
