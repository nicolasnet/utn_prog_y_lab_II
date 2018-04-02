using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConversorBinario
{
    public class Conversor
    {
        /// <summary>
        /// Metodo que convierte un numero binario a un decimal entero.
        /// </summary>
        /// <param name="binario"></param> numero binario ingresado en tipo String.
        /// <returns></returns> retorna el numero entero convertido.
        public static int BinarioEntero(string binario)
        {

            int i;
            int entero = 0;

            for(i=0; i<binario.Length; i++)
            {
                //Console.WriteLine("largo string: {0}", binario.Length);
                //Console.WriteLine("primer numero: {0}", binario[0]);
                entero = entero + (int.Parse(binario[i].ToString()) * (int)Math.Pow(2, binario.Length-(i+1)));
            }
            return entero;
        }

        /// <summary>
        /// Metodo por el cual se convierte un decimal entero a numero binario
        /// </summary>
        /// <param name="entero"></param> valor intero brindado para convertir.
        /// <returns></returns> retorna el numero binario convertido.
        public static string EnteroBinario(int entero)
        {
            string resultado = "";
         
                if (entero != 0 && entero != 1)
                {
                    resultado = resultado + Conversor.EnteroBinario(entero / 2);
                    resultado = resultado + (entero % 2);
                }
                else
                {
                    resultado = resultado + entero;
                }

            return resultado;
            //return Convert.ToString(entero, 2);
        }

    }
}
