using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18._2
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarTexto<string, string> texto = new GuardarTexto<string,string>();

            Console.WriteLine(texto.Leer());

            Console.ReadKey();


        }
    }
}
