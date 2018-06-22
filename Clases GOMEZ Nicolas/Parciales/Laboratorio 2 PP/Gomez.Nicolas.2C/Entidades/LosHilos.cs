using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        public delegate void DelegadoAviso(string aux);
        public event DelegadoAviso AvisoFin;

        private int id;
        private List<InfoHilo> misHilos;

        public string Bitacora 
        {
            get
            {
                string aux;
                try
                {
                    string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "bitacora" + ".txt";

                    FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);

                    using (StreamReader sw = new StreamReader(fs))
                    {
                        aux = sw.ReadToEnd();
                    }
                    fs.Close();
                    return aux;
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
            }
            set
            {
                try
                {
                    string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "bitacora" + ".txt";

                    FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);

                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(value);                        
                    }
                    fs.Close();                
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
            }
        }


        public LosHilos()
        {
            this.id = 0;
            misHilos = new List<InfoHilo>();
        }


        static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;
            InfoHilo nHilo = new InfoHilo(hilos.id, hilos);
            hilos.misHilos.Add(nHilo);
            
            return hilos;
        }




        public void RespuestaHilo(int id)
        {
            string mensaje = string.Format("Termino el Hilo {0}", id);
            Bitacora = mensaje;
            AvisoFin.Invoke(mensaje);
        }


        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad > 0)
            {
                for (int i=0; i < cantidad; i++)
                {
                    hilos = AgregarHilo(hilos);
                }
            }
            else
            {
                throw new CantidadInvalidaException();
            }

            return hilos;
        }
    }
}
