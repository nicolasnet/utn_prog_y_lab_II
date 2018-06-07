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
    public static class ArchivoTexto
    {
        public static bool Guardar(string ruta, string texto)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(string));

                ser.Serialize(writer, texto);

                writer.Close();
            }
            catch (ArgumentException)
            {
                string fallo = "Error en la ruta";
                throw new ArgumentException(fallo);
            }
            catch (FileNotFoundException)
            {
                string fallo = "Error en la ruta";
                throw new FileNotFoundException(fallo);
            }
            catch (DirectoryNotFoundException)
            {
                string fallo = "Error en la ruta";
                throw new DirectoryNotFoundException(fallo);
            }
            catch (IOException)
            {
                string fallo = "Archivo en uso";
                throw new IOException(fallo);
            }
            catch (NotSupportedException)
            {
                string fallo = "La ruta contiene caracteres no aceptados";
                throw new NotSupportedException(fallo);
            }
            catch (System.Security.SecurityException)
            {
                string fallo = "El usuario no tiene los permisos necesarios";
                throw new System.Security.SecurityException(fallo);
            }
            catch (InvalidOperationException)
            {
                string fallo = "Nombre no encontrado";
                throw new InvalidOperationException(fallo);
            }

            return true;
        }



        public static string Leer(string ruta)
        {
            string aux;

            try
            {
                XmlTextReader reader = new XmlTextReader(ruta);
                XmlSerializer ser = new XmlSerializer(typeof(string));

                aux = (string) ser.Deserialize(reader);

                reader.Close();
            }
            catch (ArgumentException)
            {
                string fallo = "Error en la ruta";
                throw new ArgumentException(fallo);
            }
            catch (FileNotFoundException)
            {
                string fallo = "Error en la ruta";
                throw new FileNotFoundException(fallo);
            }
            catch (DirectoryNotFoundException)
            {
                string fallo = "Error en la ruta";
                throw new DirectoryNotFoundException(fallo);
            }
            catch (IOException)
            {
                string fallo = "Archivo en uso";
                throw new IOException(fallo);
            }
            catch (NotSupportedException)
            {
                string fallo = "La ruta contiene caracteres no aceptados";
                throw new NotSupportedException(fallo);
            }
            catch (System.Security.SecurityException)
            {
                string fallo = "El usuario no tiene los permisos necesarios";
                throw new System.Security.SecurityException(fallo);
            }
            catch (InvalidOperationException)
            {
                string fallo = "Nombre no encontrado";
                throw new InvalidOperationException(fallo);
            }

            return aux;
        }


    }
}
