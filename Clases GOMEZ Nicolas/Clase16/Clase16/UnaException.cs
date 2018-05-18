using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
    public class UnaException : Exception
    {


        public UnaException(string mensaje, Exception innerException)
            : base(mensaje, innerException) 
        {
            throw new MiException("ERROR 2.0", innerException);
        }


    }
}
