using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear puestos. ¿Se generan bien los id?

            //crear computadoras
            Computadora computadora1 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");
            Computadora computadora2 = new Computadora("Intel", "16GB", "Placa ASUS GT 1030");
            Computadora computadora3 = new Computadora("Intel", "4GB", "Placa ASUS GT 1030");

            List<Computadora> listaCompus = new List<Computadora>();
            listaCompus.Add(computadora1);
            listaCompus.Add(computadora2);


            foreach (Computadora item in listaCompus)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("SEGUNDA VUELTA");
            Console.WriteLine("----------------------");

            //probamos los ID
            listaCompus.Remove(computadora2);
            listaCompus.Add(computadora3);


            foreach (Computadora item in listaCompus)
            {
                Console.WriteLine(item.ToString());
            }


            //añadir juegos 



            //borrar juegos



            //añadir periféricos



            //borrar perifericos



            //OJO LAS CARACTERÍSTICAS?


            //crear cabinas
            //Cabina cabina1 = new Cabina(Enumerados.TiposTelefono.ADisco, "viejito");
            //Cabina cabina2 = new Cabina(Enumerados.TiposTelefono.ConTeclado, "nuevito");
            //Cabina cabina3 = new Cabina(Enumerados.TiposTelefono.ConTeclado, "más nuevito");

            //List<Cabina> listaCabinas = new List<Cabina>();
            //listaCabinas.Add(cabina1);
            //listaCabinas.Add(cabina2);


            //foreach (Cabina item in listaCabinas)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("----------------------");
            //Console.WriteLine("SEGUNDA VUELTA");
            //Console.WriteLine("----------------------");

            //listaCabinas.Remove(cabina2);
            //listaCabinas.Add(cabina3);

            //foreach (Cabina item in listaCabinas)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            Console.ReadKey();
        }
    }
}
