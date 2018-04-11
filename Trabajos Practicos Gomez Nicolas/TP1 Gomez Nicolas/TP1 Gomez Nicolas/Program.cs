using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Gomez_Nicolas
{
    class Program
    {
        
        static void Main(string[] args)
        {
                        
            Numero num1 = new Numero("99");
            Numero num2 = new Numero(3);
            Calculadora calculos = new Calculadora();

            Console.WriteLine(calculos.Operar(num1, num2, "*"));

            Console.ReadKey();
                        

        }
    }
}
