using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
            //trabajadas en el mes de N empleados de una fábrica.
            //Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el
            //valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            //multiplicados por $ 150, y al total de todas esas operaciones restarle el 13 % en concepto de
            //descuentos.
            //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            //bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            //Nota: Utilizar estructuras repetitivas y selectivas

            string nombre;
            float valorHora;
            float cantidadHoras;
            int antiguedad;
            float sueldoBruto;
            float sueldoNeto;
            string seguir = "S";

            do
            {
                do
                {
                    Console.WriteLine("Ingrese el nombre del empleado: ");
                    nombre = Console.ReadLine().ToString();

                    if (nombre.Length < 1)
                    {
                        Console.WriteLine("ERROR.");
                    }

                } while (nombre.Length < 1);

                do
                {
                    Console.WriteLine("Ingrese el valor de la hora: ");

                    if (!(float.TryParse(Console.ReadLine(), out valorHora)) || valorHora < 1)
                    {
                        Console.WriteLine("ERROR. el valor de la hora debe ser una cifra mayor a 0.");
                    }

                } while (valorHora < 1);

                do
                {
                    Console.WriteLine("Ingrese la cantidad de horas:  ");

                    if (!(float.TryParse(Console.ReadLine(), out cantidadHoras)) || cantidadHoras < 1)
                    {
                        Console.WriteLine("ERROR. La cantidad de horas debe ser una cifra mayor a 0.");
                    }

                } while (cantidadHoras < 1);

                do
                {
                    Console.WriteLine("Ingrese la antigüedad:  ");

                    if (!(int.TryParse(Console.ReadLine(), out antiguedad)) || antiguedad < 0)
                    {
                        Console.WriteLine("ERROR. La antigüedad debe ser una cifra igual o mayor a 0.");
                        antiguedad = -1;
                    }

                } while (antiguedad < 0);

                sueldoBruto = ((valorHora * cantidadHoras) + (antiguedad * 150));
                sueldoNeto = sueldoBruto * 0.87f;

                Console.WriteLine("\nRECIBO DE SUELDO");
                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antigüedad: {0}", antiguedad);
                Console.WriteLine("Valor hora: {0}", valorHora);
                Console.WriteLine("Sueldo bruto: {0}", sueldoBruto);
                Console.WriteLine("Descuentos: {0}", sueldoBruto * 0.13f);
                Console.WriteLine("Sueldo Neto: {0}", sueldoNeto);

                Console.WriteLine("\n¿Desea imprimir otro recibo de sueldo? S para seguir, cualquier otra tecla y enter para salir. ");
                seguir = Console.ReadLine().ToString();

            } while (seguir == "S");


        }
    }
}
