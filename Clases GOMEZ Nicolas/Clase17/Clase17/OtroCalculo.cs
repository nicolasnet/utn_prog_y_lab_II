using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class OtroCalculo
    {
        public void MetodoInstancia()
        {
            try
            {
                new Calculo(1);
            }
            catch (UnaException u)
            {
                throw new MiException("error 2.0", u);
            }
        }
    }
}
