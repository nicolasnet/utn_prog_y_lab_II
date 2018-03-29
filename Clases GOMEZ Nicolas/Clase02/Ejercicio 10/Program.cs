using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro: 10";

            int numero = 0;
            int i, j;
            string caracter = "*";

            Console.Write("Ingresar nro: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                for (i = 0; i < numero; i++)
                {
                    for (j = i; j < numero-1; j++)
                    {
                        Console.Write(" ");
                    }
                    
                    Console.WriteLine(caracter);
                    caracter += "**";
                }
            }
            Console.ReadKey();

            
        }
    }
}
