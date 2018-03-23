using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 03";

            int nro = 0;
            int i, j;
            int contador = 0;

            Console.Write("Encribir numero: ");
            if (int.TryParse(Console.ReadLine(), out nro))
            {
                for (i = 2; i <= nro; i++)
                {
                    contador = 0;
                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            //contador++;
                            break;
                        }
                    }

                    //if (contador == 0)
                    if(i == j)
                    {
                        Console.WriteLine("nro primo: {0}", i);
                    }

                }
                Console.ReadKey();
            }

            



        }
    }
}
