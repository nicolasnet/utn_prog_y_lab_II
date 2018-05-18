using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                OtroCalculo ejemplo = new OtroCalculo();
                ejemplo.MetodoInstancia();
            }
            catch (MiException m)
            {
                Console.WriteLine(m.Message);                
                Console.ReadKey();
            }


            Console.ReadKey();
        }
    }
}
