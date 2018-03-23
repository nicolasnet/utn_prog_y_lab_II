using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 04";

            int i, j;
            int contador = 0;
            //int numero = 0;
            int suma = 0;

                for (i = 1; ; i++)
                {
                    suma = 0;
                    for (j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            suma = suma + j;
                        }
                    }
                    if (suma == i)
                    {
                        contador++;
                        Console.WriteLine("Numero perfecto: {0}", i);
                    }

                    if (contador > 3)
                    {
                        break;
                    }
                }

           

            Console.ReadKey();

        }
    }
}
