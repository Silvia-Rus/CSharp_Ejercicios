using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno();
            alumnoUno.nombre = "Cindy";
            alumnoUno.apellido = "Nero";
            alumnoUno.legajo = 1;
            alumnoUno.Estudiar(3, 5);
            alumnoUno.CalcularFinal();
            Console.WriteLine(alumnoUno.Mostrar());

            Alumno alumnoDos = new Alumno();
            alumnoDos.nombre = "Jackie";
            alumnoDos.apellido = "Sieras";
            alumnoDos.legajo = 2;
            alumnoDos.Estudiar(9, 9);
            alumnoDos.CalcularFinal();
            Console.WriteLine(alumnoDos.Mostrar());

            Alumno alumnoTres = new Alumno();
            alumnoTres.nombre = "Kennie";
            alumnoTres.apellido = "Bell";
            alumnoTres.legajo = 3;
            alumnoTres.Estudiar(5, 9);
            alumnoTres.CalcularFinal();
            Console.WriteLine(alumnoTres.Mostrar());

            Console.ReadKey();

        }
    }
}
