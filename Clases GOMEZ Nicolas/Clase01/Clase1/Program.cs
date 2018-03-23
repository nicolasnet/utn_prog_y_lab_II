using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int cantNumero = 5;
            int i;
            int nro;
            int suma = 0;
            float promedio;
            //int nro2 = 0;
            int max = 0;
            int min = 0;

            
            for (i=0; i < cantNumero; i++)
            {
                Console.Write("escribir numero: ");
                //nro = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out nro))
                {
                    suma = suma + nro;

                    if (i == 0)
                    {
                        min = nro;
                        max = nro;
                    }
                    else
                    {
                        if (nro > max)
                        {
                            max = nro;
                        }
                        if (nro < min)
                        {
                            min = nro;
                        }
                    }
                }
                else
                {
                    i--;
                }
            }

            promedio = (float) suma / cantNumero;
            Console.WriteLine("suma: {0}", suma);
            Console.WriteLine("promedio: {0}", promedio);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
            Console.ReadKey();
        }
    }
}
