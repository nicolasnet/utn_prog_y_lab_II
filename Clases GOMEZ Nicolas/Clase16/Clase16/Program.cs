using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    public class Program
    {
        static void Main(string[] args)
        {
            int nro1 = 10;
            int nro2 = 0;
            float resultado;

            try
            {
                resultado = nro1 / nro2;
            }
            catch(DivideByZeroException e)
            {
                throw e;
               //Console.WriteLine(e.Message);
               //Console.WriteLine("");
            }






        }
    }
}
