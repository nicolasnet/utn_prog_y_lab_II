using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empleado : Persona
    {
        private Departamentos departamento;
        private short piso;
        


        #region Propiedades

        public string PisoDepartamento
        {
            get
            {
                StringBuilder dato = new StringBuilder();

                dato.AppendFormat("{0}º{1}", this.piso, this.departamento);

                return dato.ToString();
            }
        }

        #endregion



        #region Constructores

        public Empleado(string nombre, string apellido, string documento, short piso, Departamentos departamento)
            : base(nombre, apellido, documento)
        {
            this.piso = piso;
            this.departamento = departamento;
        }

        #endregion



        #region Metodos

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder(base.ExponerDatos());

            datos.AppendFormat(this.PisoDepartamento);

            return datos.ToString();
        }


        protected override bool ValidarDocumentacion(string doc)
        {
            bool respuesta = false;

            if (doc.Length == 9)
            {
                respuesta = true;
            }

            return respuesta;
        }

        #endregion
    }
}
