using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class Calculo
    {

        public Calculo()
        {
            try
            {
                dividir(1, 0);
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
                new Calculo();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("Error", e);
            }
        }


        public static float dividir(float nro1, float nro2) 
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
