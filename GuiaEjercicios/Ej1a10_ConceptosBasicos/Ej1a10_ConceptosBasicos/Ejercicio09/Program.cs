using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que imprima por pantalla una pirámide como la siguiente:
            //*
            //***
            //*****
            //*******
            //*********
            //El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. 
            //Para el ejemplo anterior la altura ingresada fue de 5.

            int tamanioPiramide = 0;
            string saltoDeLinea = "\n";
            string caracterDibujado = "*";
            int numeroCaracateresADibujar = 1;

            Console.Title = "Ejercicio 09";
         
            do
            {
                Console.WriteLine("Ingrese un tamaño para la pirámide: ");

                if(int.TryParse(Console.ReadLine(), out tamanioPiramide) && tamanioPiramide > 0)
                {
                    //repetir las lineas
                    for(int i = 0; i<tamanioPiramide; i++)
                    {
                        //repetir las estrellas
                        for (int j = 0; j < numeroCaracateresADibujar; j++)
                        {
                            Console.Write(caracterDibujado);
                            
                        }
                        numeroCaracateresADibujar += 2;
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
