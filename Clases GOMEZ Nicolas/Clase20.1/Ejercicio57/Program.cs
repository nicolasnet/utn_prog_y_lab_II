using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona perc = new Persona();

            try
            {
                /*
                if (Persona.Guardar(perc))
                {
                    Console.WriteLine("Guardado con exito");
                }
                else
                {
                    Console.WriteLine("Error al guardar");
                }

                Console.ReadKey();
                */


                perc = Persona.Leer();

                Console.WriteLine(perc.ToString());
                                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
