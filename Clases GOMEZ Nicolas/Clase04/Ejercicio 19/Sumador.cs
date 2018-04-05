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


    }
}
