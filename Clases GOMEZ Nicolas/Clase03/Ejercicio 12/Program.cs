using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int suma = 0;
            ConsoleKeyInfo seguir;

            do
            {
                Console.Write("Ingresar numero: ");
                if(int.TryParse(Console.ReadLine(), out valor))
                {
                    suma += valor;
                }
                Console.WriteLine("si desea continuar presione 's'");
                seguir = Console.ReadKey(true);
                

            }while(ValidarRespuesta.ValidaS_N(seguir.KeyChar));

            Console.WriteLine("La suma total es: {0}", suma);
            Console.ReadKey();
        }
    }
}
