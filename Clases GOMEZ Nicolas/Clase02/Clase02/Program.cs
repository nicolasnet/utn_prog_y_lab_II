using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro: 09";

            int numero = 0;
            int i;
            string caracter = "*";

            Console.Write("Ingresar nro: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                for (i = 0; i < numero; i++)
                {
                    Console.WriteLine(caracter);
                    caracter += "**";
                }
            }
            Console.ReadKey();

        }
    }
}
