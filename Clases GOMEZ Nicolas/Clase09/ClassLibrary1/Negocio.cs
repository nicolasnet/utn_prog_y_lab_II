using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        


        #region Propiedades

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                bool respuesta;
                respuesta = this + value;
            }
        }

        #endregion



        #region Constructores

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }


        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }


        #endregion



        #region Metodos



        #endregion



        #region Sobrecarga de Operadores

        public static bool operator +(Negocio n, Cliente c)
        {
            bool respuesta = true;
                                    
            foreach (Cliente este in n.clientes)
            {
                if (este == c)
                {                    
                    respuesta = false;
                    break;
                }                
            }

            if (respuesta == true)
            {
                n.clientes.Enqueue(c);                
            }

            return respuesta;
        }



        public static bool operator ==(Negocio n, Cliente c)
        {
            bool respuesta = false;

            foreach (Cliente este in n.clientes)
            {
                if (este == c)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }



        public static bool operator !=(Negocio n, Cliente c)
        {
            bool respuesta = true;

            foreach (Cliente este in n.clientes)
            {
                if (este == c)
                {
                    respuesta = false;
                    break;
                }
            }
            return respuesta;
        }


        public static bool operator ~(Negocio n)
        {
            bool respuesta = false;

            respuesta = n.caja.Atender(n.Cliente);

            return respuesta;
        }


        #endregion

    }
}
