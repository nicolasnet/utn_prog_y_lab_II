using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio OBJETOS nro 16";


            Alumno alumno = new Alumno();
            byte notaUno = 0;
            byte notaDos = 0;

            Console.WriteLine("Ingresar apellido del alumno :");
            alumno.apellido = Console.ReadLine();

            Console.WriteLine("Ingresar Nombre del alumno :");
            alumno.nombre = Console.ReadLine();

            Console.WriteLine("ingresar Legajo: ");
            if (int.TryParse(Console.ReadLine(), out alumno.legajo))


            Console.WriteLine("ingresar nota 1");
            if(byte.TryParse(Console.ReadLine(), out notaUno))

            Console.WriteLine("ingresar nota 2");
            if (byte.TryParse(Console.ReadLine(), out notaDos))

            alumno.Estudiar(notaUno, notaDos);


            alumno.CalcularFinal();


            Console.WriteLine(alumno.Mostrar());
     
            //Console.WriteLine(alumno.apellido);
            
            Console.ReadKey();

        }
    }
}
