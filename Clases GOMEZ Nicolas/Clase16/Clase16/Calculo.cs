using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    class Calculo
    {
        public Calculo()
        {
            try
            {
                // metodo estático
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }
        public Calculo(int i)
        {
            try
            {
                // al otro constructor
                new Calculo();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("error", e);
            }
        }
        public static float division(float nro1, float nro2)
        {
                if (nro2 != 0)
                {
                    return nro1 / nro2;
                }
                else
                {
                    throw new DivideByZeroException();
                    
                }           
        }
    }
}
