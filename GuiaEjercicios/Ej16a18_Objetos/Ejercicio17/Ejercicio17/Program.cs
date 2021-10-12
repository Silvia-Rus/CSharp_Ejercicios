using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliUno = new Boligrafo(ConsoleColor.Blue, 100);
            //Boligrafo boliDos = new Boligrafo(ConsoleColor.Red, 50);

            string dibujo;

            if(boliUno.Pintar(-100, out dibujo)) // --> RECARGA AL FINAL
            //if (boliUno.Pintar(-50, out dibujo)) // --> PINTA CON NORMALIDAD
            //if (boliUno.Pintar(-150, out dibujo)) // --> NO PINTA POR PEDIR DEMASIADA TINTA
            {
                Console.WriteLine("Tinta usada: {0}: ", dibujo);
            }
            else
            {
                Console.WriteLine("No se pudo :(");
            }

            Console.WriteLine("Color usado: {0}", boliUno.GetColor().ToString());
            Console.WriteLine("Tinta disponible: {0}", boliUno.GetTinta().ToString());

            if(boliUno.GetTinta() < 1)
            {
                Console.WriteLine("\nBolígrafo vacío, se procede a recargar...");
                boliUno.Recargar();
                Console.WriteLine("Recargado. La tinta disponible es: {0}", boliUno.GetTinta().ToString());
            }

            Console.ReadLine();

        }
    }
}
