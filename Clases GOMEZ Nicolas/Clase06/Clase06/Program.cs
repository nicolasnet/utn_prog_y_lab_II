using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    class Program
    {
        static void Main(string[] args)
        {



            Euro ahorroEuro = new Euro(5);
            
            Dolar cantEnDolares = new Dolar(0);
            Pesos cantEnPesos = new Pesos(0);


            cantEnDolares = (Dolar)ahorroEuro;
            cantEnPesos = (Pesos)ahorroEuro;


            Console.WriteLine("En dolares: {0}", cantEnDolares.GetCantidad());
            Console.WriteLine("En pesos: {0}", cantEnPesos.GetCantidad());
                        
            Console.ReadKey();
            
        }
    }
}
