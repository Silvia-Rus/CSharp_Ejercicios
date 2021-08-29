using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla una pirámide como la siguiente:
            //                                                                *
            //                                                               ***
            //                                                              *****
            //                                                             *******
            //                                                            *********
            //Nota: Utilizar estructuras repetitivas y selectivas.

            int tamanioPiramide = 0;
            string saltoDeLinea = "\n";
            string caracterDibujado = "*";
            string espacio = " ";
            int numeroCaracateresADibujar = 1;
            int numeroEspaciosADibujar;

            Console.Title = "Ejercicio 10";

            do
            {
                Console.WriteLine("Ingrese un tamaño para la pirámide: ");

                if (int.TryParse(Console.ReadLine(), out tamanioPiramide) && tamanioPiramide > 0)
                {
                    //repetir las lineas
                    numeroEspaciosADibujar = tamanioPiramide;
                    for (int i = 0; i < tamanioPiramide; i++)
                    {
                        //repetir los espacios
                        for(int k = numeroEspaciosADibujar;k>=0; k--)
                        {
                            Console.Write(espacio);
                        }
                                              
                        //repetir las estrellas
                        for (int j = 0; j < numeroCaracateresADibujar; j++)
                        {
                            Console.Write(caracterDibujado);

                        }
                        numeroCaracateresADibujar += 2;
                        numeroEspaciosADibujar -= 1;

                        Console.Write(saltoDeLinea);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. Debe ser un número entero positivo.");
                }

            } while (tamanioPiramide < 1);

            Console.ReadLine();
        }
    }
}
