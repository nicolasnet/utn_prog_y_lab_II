using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 19";
            
            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador();
            int nro1 = 0;
            int nro2 = 0;
            long respuesta = 0;
            
            Console.WriteLine("Ingresar dos numero para suma1: ");
            if (int.TryParse(Console.ReadLine(), out nro1) && int.TryParse(Console.ReadLine(), out nro2))
            {
                Console.WriteLine("Suma1: {0}", suma1.Sumar(nro1, nro2));

            }

            Console.WriteLine("Ingresar dos numero para suma1: ");
            if (int.TryParse(Console.ReadLine(), out nro1) && int.TryParse(Console.ReadLine(), out nro2))
            {
                Console.WriteLine("Suma1: {0}", suma1.Sumar(nro1, nro2));

            }

            Console.WriteLine("Ingresar dos numero para suma2: ");
            if (int.TryParse(Console.ReadLine(), out nro1) && int.TryParse(Console.ReadLine(), out nro2))
            {
                Console.WriteLine("Suma2: {0}", suma2.Sumar(nro1, nro2));

            }

            Console.WriteLine("Ingresar dos numero para suma2: ");
            if (int.TryParse(Console.ReadLine(), out nro1) && int.TryParse(Console.ReadLine(), out nro2))
            {
                Console.WriteLine("Suma2: {0}", suma2.Sumar(nro1, nro2));

            }

            //con la siguiente linea probamos el conversor explicito creado, el cual convierte el objeto Sumador en un int con el valor de cantSumas.
            int cantidadSumas = (int)suma1;

            Console.WriteLine("casteo de cantSumas: {0}", cantidadSumas);

            //en este ejemplo chequeo que el operador + haga la nueva operacion que le sobrecargue
            respuesta = suma1 + suma2;

            Console.WriteLine("Sumador sobrecargado: {0}", respuesta);

            //en este ejemplo chequeo que el operador | haga la nueva operacion que le sobrecargue
            Console.WriteLine(suma1 | suma2);
            

            Console.ReadKey();
        }
    }
}
