using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace Ejercicio57
{
    public class Persona
    {
        private string nombre;
        private string apellido;


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }


        public Persona() { }


        public Persona(string nombre, string apellido)
            : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(Persona p)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("Datos Personas", Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(Persona));

                ser.Serialize(writer, p);

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


        public static Persona Leer()
        {
            Persona p = new Persona();

            try
            {
                XmlTextReader reader = new XmlTextReader("Datos P");
                XmlSerializer ser = new XmlSerializer(typeof(Persona));

                p = (Persona)ser.Deserialize(reader);

                reader.Close();                

            }
            catch (ArgumentNullException)
            {
                string fallo = "Error en la ruta";
                throw new ArgumentNullException(fallo);
            }
            catch (ArgumentException)
            {
                string fallo = "Error en la ruta";
                throw new ArgumentException(fallo);
            }
            catch (FileNotFoundException)
            {
                string fallo = "Error en la ruta";
                throw new FileNotFoundException (fallo);
            }
            catch(DirectoryNotFoundException)
            {
                string fallo = "Error en la ruta";
                throw new DirectoryNotFoundException(fallo);
            }
            catch(IOException)
            {
                string fallo = "Archivo en uso";
                throw new IOException(fallo);
            }            
            catch(NotSupportedException)
            {
                string fallo = "La ruta contiene caracteres no aceptados";
                throw new NotSupportedException(fallo);
            }
            catch(System.Security.SecurityException)
            {
                string fallo = "El usuario no tiene los permisos necesarios";
                throw new System.Security.SecurityException(fallo);
            }
            catch (InvalidOperationException)
            {
                string fallo = "Nombre no encontrado";
                throw new InvalidOperationException(fallo);
            }

            return p;
        }


        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Nombre: {0} - Apellido: {1}.\n", this.nombre, this.apellido);

            return datos.ToString();
        }



    }
}
