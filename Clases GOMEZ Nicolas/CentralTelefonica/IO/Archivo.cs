using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaAbstracta;
using System.Xml;
using System.IO;
using System.Xml.Serialization;


namespace IO
{
    abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(ruta);

                reader.Close();
            }
            catch (Exception)
            {
                throw new FileNotFoundException();
            }

            return true;
        }
    }
}
