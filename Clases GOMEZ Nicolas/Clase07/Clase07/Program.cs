using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    /*
     *  
    */
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 20;
            int[] listaNros = new int[cant];
            Random r = new Random();
            int i, j, aux=0;

            for (i = 0; i < cant; i++)
            {
                listaNros[i] = r.Next(-1000, 1000);
                Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
            }


            for (i = 0; i < cant-1; i++)
            {
                for (j = i + 1; j < cant; j++)
                {
                    if(listaNros[i] > listaNros[j])
                    {
                        aux = listaNros[i];
                        listaNros[i] = listaNros[j];
                        listaNros[j] = aux;
                    }
                }                    
            }

            Console.WriteLine("---.---.---.---.---.---.---.---.---.---.---.---.---.---.---.---.");

            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Numeros Negativos: ");

            for (i = 0; i < cant; i++)
            {
                if (listaNros[i] < 0)
                {
                    Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Numeros positivos: ");

            for (i = cant-1; i >= 0 ; i--)
            {
                if (listaNros[i] > 0)
                {
                    Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
                }
            }

            Console.ResetColor();

            //Console.WriteLine("termino la lista");

            Console.ReadKey();
        }
    }
}
