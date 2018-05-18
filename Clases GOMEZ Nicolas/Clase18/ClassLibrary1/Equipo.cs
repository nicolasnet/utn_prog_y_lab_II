using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;


        public static bool operator ==(Equipo a, Equipo b)
        {
            bool respuesta = false;

            if (a.fechaCreacion == b.fechaCreacion && a.nombre == b.nombre)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }



        public string Ficha()
        {
            StringBuilder ficha = new StringBuilder();

            ficha.AppendFormat("{0} fundado el: {1}", this.nombre, this.fechaCreacion);

            return ficha.ToString();
        }
    }
}
