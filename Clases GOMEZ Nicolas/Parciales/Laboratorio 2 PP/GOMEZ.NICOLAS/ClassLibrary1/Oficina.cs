using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Oficina
    {
        private Departamentos departamento;
        private List<Empleado> empleados;
        private Jefe jefe;
        private short piso;



        #region Propiedades

        public string PisoDivision
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

        private Oficina()
        {
            this.empleados = new List<Empleado>();
        }


        public Oficina(short piso, Departamentos departamento, Jefe jefe) 
            : this()
        {
            this.piso = piso;
            this.departamento = departamento;
            this.jefe = jefe;
        }


        #endregion



        #region Metodos



        #endregion



        #region Sobrecarga

        public static bool operator ==(Oficina o, Empleado e)
        {
            bool respuesta = false;

            if (o.PisoDivision.CompareTo(e.PisoDepartamento) == 0)
            {
                respuesta = true;
            }

            return respuesta;
        }


        public static bool operator !=(Oficina o, Empleado e)
        {
            bool respuesta = false;

            if (o.PisoDivision.CompareTo(e.PisoDepartamento) != 0)
            {
                respuesta = true;
            }

            return respuesta;
        }


        public static Oficina operator +(Oficina o, Empleado e)
        {
            if (o == e)
            {
                o.empleados.Add(e);
            }

            return o;
        }


        public static explicit operator string(Oficina o)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat(o.PisoDivision);
            datos.AppendFormat(o.jefe.ExponerDatos());

            foreach (Empleado emp in o.empleados)
            {
                datos.AppendFormat(emp.ExponerDatos());
            }

            return datos.ToString();
        }

        #endregion
    }
}
