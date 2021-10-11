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
            Cliente c1 = new Cliente("111", "Kennie", "Bell", 25, Enumerados.EstadoCliente.esperandoComputadora);
            //ValidadorListas.AniadirJuego(c1.JuegoNecesita, Enumerados.Juegos.CounterStrike);
            //Cliente c2 = new Cliente("111", "Cindy", "Nero", 36);
            //Computadora comp1 = new Computadora("Intel", "8GB", "Intel® Iris® Xe Graphics");
            //ValidadorListas.AniadirJuego(comp1.Juego, Enumerados.Juegos.CounterStrike);
            Cabina cab1 = new Cabina(Enumerados.TiposTelefono.ADisco, "Telefonica");

            //List<Cliente> listaClientes = new List<Cliente>();
            //List<Cabina> listaPuestos = new List<Cabina>();

            //listaClientes.Add(c1);
            ////listaClientes.Add(c2);

            ////listaPuestos.Add(comp1);
            //listaPuestos.Add(cab1);

            ////Procesador procesador = new Procesador("Rus", listaPuestos, listaClientes);

            ////Console.WriteLine(procesador.ToString());

            //procesador.AbrirSesion(cab1, c1, Enumerados.TiposDeSesion.llamada, "541234567891");

            

            //Console.WriteLine(procesador.ToString());

            //if(procesador.CerrarSesion(procesador.Sesiones[0]))
            //{
            //    Console.WriteLine(procesador.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("TEMITA CERRANDO LA SESIÓN");
            //}

            //Console.WriteLine("EL HISTÓRICO OJO");

            //foreach (Sesion item in Historico.Sesiones)
            //{
            //    Console.WriteLine(item.ToString());


            //}


            

            


            //prueba tipos de llamada

            //larga distancia
            //Llamada llamada1 = new Llamada(cab1, c1, "5488888888888888888888888888888");

            //Console.WriteLine(llamada1.ToString());





            //ValidadorListas.AniadirJuego(c1.JuegoNecesita, Enumerados.Juegos.AgeOfEmpiresII);
            //ValidadorListas.AniadirJuego(comp1.Juego, Enumerados.Juegos.AgeOfEmpiresII);
            //ValidadorListas.AniadirJuego(comp1.Juego, Enumerados.Juegos.CounterStrike);

            //if(c1 == comp1)
            //{
            //    Console.WriteLine("SALIÓ BIEN GRACIAS DIOS");
            //}
            //else
            //{
            //    Console.WriteLine(":(((((((");

            //}



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
