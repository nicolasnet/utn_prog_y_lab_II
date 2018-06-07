using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            string nombreArchivo;
            string extencion = ".txt";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            try
            {               
                /*
                Console.WriteLine("1ro escribir nombre de archivo, luego el texto deseado");

                nombreArchivo = Console.ReadLine();

                texto = Console.ReadLine();

                ruta = ruta + "\\" + nombreArchivo + extencion;

                ArchivoTexto.Guardar(ruta, texto);
                */

                nombreArchivo = "buen";

                ruta = ruta + "\\" + nombreArchivo + extencion;

                texto = ArchivoTexto.Leer(ruta);

                Console.WriteLine(texto);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                nombreArchivo = DateTime.Now.ToString();
                ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ruta = ruta + "\\" + nombreArchivo + extencion;
                ArchivoTexto.Guardar(ruta, e.Message);
                Console.ReadKey();
            }
        }
    }
}
