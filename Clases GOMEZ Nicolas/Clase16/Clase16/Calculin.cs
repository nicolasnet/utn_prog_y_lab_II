using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    class Calculin
    {
        public void MetodoInstancia()
        {
            try
            {
                // al otro constructor
                new Calculo(1);
            }
            catch (UnaException e)
            {
                throw new MiException("error", e);
            }
        }
    }
}
