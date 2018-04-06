using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas = 0;


        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador(): this(0)
        {

        }


        public long Sumar(long a, long b)
        {
            long respuesta = 0;

            this.cantidadSumas++;

            respuesta = a + b;

            return respuesta;
        }

        public string Sumar(string a, string b)
        {
            string respuesta = "";

            this.cantidadSumas++;

            respuesta = a + b;

            return respuesta;
        }


        #region Sobrecarga Operadores

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }


        public static long operator +(Sumador s1, Sumador s2)
        {
            long respuesta = 0;

            respuesta = s1.cantidadSumas + s2.cantidadSumas;

            return respuesta;
        }


        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool respuesta = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                respuesta = true;
            }

            return respuesta;
        }

        #endregion

    }
}
