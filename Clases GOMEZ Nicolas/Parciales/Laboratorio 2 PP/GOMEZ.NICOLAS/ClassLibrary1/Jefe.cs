using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Jefe : Persona
    {
        private DateTime fechaIngreso;


        #region Propiedades

        public int Antiguedad
        {
            get
            {
                int dias;

                dias = (DateTime.Today - this.fechaIngreso).Days;

                return dias;
            }
        }

        #endregion



        #region Constructores

        public Jefe(string nombre, string apellido, string documento) 
            : base(nombre, apellido, documento) { }


        public Jefe(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        #endregion



        #region Metodos

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder(base.ExponerDatos());

            datos.AppendFormat("Fecha ingreso: {0}\n", this.fechaIngreso);

            return datos.ToString();
        }


        protected override bool ValidarDocumentacion(string doc)
        {
            bool respuesta = false;

            if (doc.Length == 8)
            {
                respuesta = true;
            }

            return respuesta;
        }

        #endregion
    }
}
