using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class TestPuestos
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("111", "Kennie", "Bell", 25);
            Cliente c2 = new Cliente("111", "Cindy", "Nero", 36);
            Computadora comp1 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");

            ValidadorListas.AniadirJuego(c1.JuegoNecesita, Enumerados.Juegos.AgeOfEmpiresII);
            ValidadorListas.AniadirJuego(comp1.Juego, Enumerados.Juegos.AgeOfEmpiresII);
            ValidadorListas.AniadirJuego(comp1.Juego, Enumerados.Juegos.CounterStrike);

            if(c1 == comp1)
            {
                Console.WriteLine("SALIÓ BIEN GRACIAS DIOS");
            }
            else
            {
                Console.WriteLine(":(((((((");

            }



            //if (c1 == c2)
            //{
            //    Console.WriteLine("LO HIZO OK EL ==");
            //}

            //Console.WriteLine(c1.ToString());

            //ValidadorListas.AniadirJuego(c1.JuegoNecesita, Enumerados.Juegos.CounterStrike);

            //Console.WriteLine(c1.ToString());







            ////crear puestos. ¿Se generan bien los id?

            ////crear computadoras
            //Computadora computadora1 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");
            //Computadora computadora2 = new Computadora("Intel", "16GB", "Placa ASUS GT 1030");B
            //Computadora computadora3 = new Computadora("Intel", "4GB", "Placa ASUS GT 1030");

            //List<Computadora> listaCompus = new List<Computadora>();
            //listaCompus.Add(computadora1);
            //listaCompus.Add(computadora2);

            //ValidadorListas.EditarCaracteristica(computadora1.Caracteristicas, Enumerados.CaracteristicasComputadora.procesador, "otro nuevo que hemos puesto");
            //ValidadorListas.EditarCaracteristica(computadora2.Caracteristicas, Enumerados.CaracteristicasComputadora.procesador, "otro nuevo que hemos puesto");

            //ValidadorListas.EditarCaracteristica(computadora1.Caracteristicas, Enumerados.CaracteristicasComputadora.ram, "ram okok");
            //ValidadorListas.EditarCaracteristica(computadora2.Caracteristicas, Enumerados.CaracteristicasComputadora.ram, "ram okok");

            //ValidadorListas.EditarCaracteristica(computadora1.Caracteristicas, Enumerados.CaracteristicasComputadora.placaDeVideo, "placa sisis");
            //ValidadorListas.EditarCaracteristica(computadora2.Caracteristicas, Enumerados.CaracteristicasComputadora.placaDeVideo, "placa sisis");




            //Console.WriteLine(computadora1.ToString());
            //Console.WriteLine(computadora2.ToString());

            //if(ValidadorListas.SonIgualesCaracteristicas(computadora1.Caracteristicas, computadora2.Caracteristicas))
            //{
            //    Console.WriteLine("SALIÓ son iguales nosek :)");
            //}
            //else
            //{
            //    Console.WriteLine("NO MAL son iguales nosek");

            //}



            //ValidadorListas.EditarCaracteristica(computadora1.Caracteristicas, Enumerados.CaracteristicasComputadora.procesador, "otro más nuevo todavía omg");
            //Console.WriteLine(computadora1.ToString());



            //foreach (Computadora item in listaCompus)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("----------------------");
            //Console.WriteLine("SEGUNDA VUELTA");
            //Console.WriteLine("----------------------");

            ////probamos los ID
            //listaCompus.Remove(computadora2);
            //listaCompus.Add(computadora3);


            //foreach (Computadora item in listaCompus)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //listaCompus.Add(computadora2);


            //añadir juegos 

            //ValidadorListas.AniadirJuego(computadora2.Juego, Enumerados.Juegos.CounterStrike);
            //ValidadorListas.AniadirJuego(computadora2.Juego, Enumerados.Juegos.DiabloII);

            ////ValidadorListas.AniadirJuego(computadora1.Juego, Enumerados.Juegos.CounterStrike);
            ////ValidadorListas.AniadirJuego(computadora1.Juego, Enumerados.Juegos.DiabloII);


            //Console.WriteLine(computadora2.ToString());

            //if(!ValidadorListas.AniadirJuego(computadora2.Juego, Enumerados.Juegos.DiabloII))
            //{
            //    Console.WriteLine("ANDUVO!");

            //}
            //else
            //{
            //    Console.WriteLine("NO ANDUVO :(");

            //}

            ////Console.WriteLine(computadora2.ToString());

            //ValidadorListas.AniadirJuego(computadora1.Juego, Enumerados.Juegos.DiabloII);
            //ValidadorListas.AniadirJuego(computadora1.Juego, Enumerados.Juegos.CounterStrike);


            //Console.WriteLine("Salen en distinto orden los juegos?");

            //Console.WriteLine(computadora2.ToString());
            //Console.WriteLine(computadora1.ToString());

            //Console.WriteLine("Bueno problemos si anda el son iguales");


            //if (ValidadorListas.SonIgualesListasJuegos(computadora1.Juego, computadora2.Juego))
            //{
            //    Console.WriteLine("SON IGUALES? Anduvo :)");

            //}
            //else
            //{
            //    Console.WriteLine("SON IGUALES? No Anduvo :(");

            //}



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
