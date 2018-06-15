using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    public delegate void DelegadoString(string a);

    public class Persona
    {
        private string apellido;
        private string nombre;


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



        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }


        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Nombre: {0} - Apellido {1}", this.Nombre, this.Apellido);

            return datos.ToString();
        }


    }
}
