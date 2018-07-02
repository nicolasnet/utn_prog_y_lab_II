using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class SerializarBinaria : IArchivos<Votacion>
    {
        
        /// <summary>
        /// Levanta del archivo binario el objeto.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        
        public Votacion Leer(string nombre)
        {
            try
            {
                Votacion aux = new Votacion();
                FileStream fs;
                BinaryFormatter ser;

                //Se indica ubicación del archivo binario y el modo.
                fs = new FileStream(nombre, FileMode.Open);

                //Se crea el objeto deserializador.
                ser = new BinaryFormatter();

                //Deserializa el archivo contenido en fs, lo guarda aux.
                aux = (Votacion)ser.Deserialize(fs);

                //Se cierra el objeto fs.
                fs.Close();

                return aux;
            }
            catch (Exception)
            {
                throw new ErrorArchivoException();
            }          

        }

        /// <summary>
        /// Guarda el objeto en archivo binario.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Guardar(string nombre, Votacion objeto)
        {
            try
            {
                FileStream fs;
                BinaryFormatter ser;

                fs = new FileStream(nombre, FileMode.Create);
                ser = new BinaryFormatter();
                ser.Serialize(fs, objeto);
                fs.Close();

                return true;
            }
            catch (Exception)
            {
                throw new ErrorArchivoException();
            }
        }
    }
}
