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

            Sumador suma = new Sumador();
            int nro1 = 0;
            int nro2 = 0;


            Console.WriteLine("Ingresar dos numero: ");
            if (int.TryParse(Console.ReadLine(), out nro1) && int.TryParse(Console.ReadLine(), out nro2))
            {
                Console.WriteLine(suma.Sumar(nro1, nro2));

            }

        }
    }
}
