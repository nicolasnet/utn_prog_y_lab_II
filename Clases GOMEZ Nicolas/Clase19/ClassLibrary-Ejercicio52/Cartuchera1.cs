using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio52
{
    public class Cartuchera1
    {
        // SIN TERMINAR

        List<IAcciones> lista;

        public bool ProbarElementos()
        {
            foreach (IAcciones i in this.lista)
            {
                i.Escribir("0123456789");
            }

            return true;
        }

    }
}
