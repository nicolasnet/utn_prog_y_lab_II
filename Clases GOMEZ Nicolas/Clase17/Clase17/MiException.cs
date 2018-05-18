using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class MiException : Exception
    {
        //string mensajeError;


        public MiException(string mensaje, Exception innerException)
            : base (mensaje, innerException)
        {
            
        }


    }
}
