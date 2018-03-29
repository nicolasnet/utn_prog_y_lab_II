using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConversorBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor Binario";
            int opcion = 0;
            int numero = 0;
            string seguir = "s";

            do
            {
                Console.WriteLine("1- Convertir de Binario a Entero.");
                Console.WriteLine("2- Convertir de Entero a Binario.");
                Console.WriteLine("3- Salir.");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            Conversor.BinarioEntero(Console.ReadLine());
                            break;

                        case 2:
                            if (int.TryParse(Console.ReadLine(), out numero))
                            {
                                Console.WriteLine(Conversor.EnteroBinario(numero));
                            }
                            break;

                        case 3:
                            seguir = "n";
                            break;
                    }
                }
            } while (seguir == "s");
        }
    }
}
