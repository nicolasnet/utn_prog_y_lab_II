using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;


        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }


        public string Documentos
        {
            get
            {
                return this.documento;
            }

            set
            {
                if(ValidarDocumentacion(value))
                {
                    this.documento = value;
                }                
            }
        }


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion



        #region Constructores

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        #endregion



        #region Metodos

        public virtual string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Nombre: {0}\n", this.Nombre);
            datos.AppendFormat("Apellido: {0}\n", this.Apellido);
            datos.AppendFormat("Documento: {0}\n", this.Documentos);

            return datos.ToString();
        }


        protected abstract bool ValidarDocumentacion(string doc);


        #endregion








    }
}
