using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 11";

            int valor = 0;
            int limmax = 100;
            int limmin = -100;
            int i;
            int cantidad = 10;
            int valorMax = 0;
            int valorMin = 0;
            int suma = 0;

            for (i = 0; i < cantidad; i++)
            {
                Console.Write("Escribir numero entre {0} y {1}: ", limmin, limmax);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    if (Validacion.Validar(valor, limmin, limmax))
                    {
                        if (i == 0)
                        {
                            valorMin = valor;
                            valorMin = valor;
                        }
                        else
                        {
                            if (valor < valorMin)
                            {
                                valorMin = valor;
                            }

                            if (valor > valorMax)
                            {
                                valorMax = valor;
                            }
                        }

                        suma = suma + valor;

                    }
                    else
                    {
                        Console.WriteLine("Reintente ingresar el numero");
                        i--;
                    }
                }                
            }

            Console.WriteLine("Valor minimo: {0}", valorMin);
            Console.WriteLine("Valor maximo: {0}", valorMax);
            Console.WriteLine("Promedio: {0}", suma / cantidad);
            Console.ReadKey();
        }
    }
}
