using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int nro = 0;
            double resultado = 0;
            Console.Write("Escribir numero: ");

            if (int.TryParse(Console.ReadLine(), out nro))
            {
                if (nro > 0)
                {
                    resultado = Math.Pow(nro, 2);
                    Console.WriteLine("Cuadrado: {0}", resultado);
                    resultado = Math.Pow(nro, 3);
                    Console.WriteLine("Cubo: {0}", resultado);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Error. Reingresar numero");
                    Console.ReadKey();
                }
            }
        }
    }
}
