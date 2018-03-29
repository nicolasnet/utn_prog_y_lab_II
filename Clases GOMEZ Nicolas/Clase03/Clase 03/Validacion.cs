using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Validacion
    {
        /// <summary>
        /// Validacion de numero entero entre un valor minimo y un valor maximo
        /// </summary>
        /// <param name="valor"></param> valor a analizar
        /// <param name="min"></param> limite inferior para realizar la validacion.
        /// <param name="max"></param> limite superior para realizar la validacion.
        /// <returns></returns> true: si el valor dado corresponde con los limites brindados.
        ///                     false: si el valor no corresponde.
        public static bool  Validar(int valor, int min, int max)
        {
            bool respuesta = false;

            if (valor <= max && valor >= min)
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
