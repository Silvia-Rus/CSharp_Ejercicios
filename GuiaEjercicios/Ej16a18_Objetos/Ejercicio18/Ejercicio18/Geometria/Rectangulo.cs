using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18.Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
           
            if(vertice1.GetX() < vertice1.GetY() && vertice3.GetX() < vertice3.GetY()   //chequea los vértices por sí mismos
                && vertice3.GetX() > vertice1.GetX() && vertice3.GetX() >vertice1.GetY() //chequea el eje X
                && vertice3.GetY() > vertice1.GetY() && vertice3.GetY() > vertice1.GetX() //chequea el eje y
                ) 
            {
                this.vertice1 = vertice1;
                this.vertice3 = vertice3;
                this.area = this.Area();
                this.perimetro = this.Perimetro();
            }
            else
            {
                Console.WriteLine("Valores para X e Y incorrectos.");
            }
                     
        }

        public float Area()
        {
            float abajo = this.vertice3.GetY() - this.vertice1.GetX();
            float altura = this.vertice3.GetX() - this.vertice1.GetY();
            float area = abajo * altura;

            return area;
        }

        public float Perimetro()
        {
            float abajo = this.vertice3.GetY() - this.vertice1.GetX();
            float altura = this.vertice3.GetX() - this.vertice1.GetY();

            float perimetro = ((abajo + altura) * 2);

            return perimetro;

        }
        
        






    }
}
