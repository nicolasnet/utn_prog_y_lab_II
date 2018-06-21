using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

                
        protected override bool ValidarArchivo(string ruta)
        {
            return base.ValidarArchivo(ruta);
        }
    }
}
