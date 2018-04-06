using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Estante
    {
        private Producto[] producto;
        private int ubicacionEstante;


        private Estante(int capacidad)
        {
            this.producto = new Producto [capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this (capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetPrductos()
        {
            return this.producto;
        }

        public string MostarEstante(Estante e)
        {
            StringBuilder detalleEstante = new StringBuilder();
            int i = 0;

            detalleEstante.AppendFormat("Ubicacion: {0}\n", this.ubicacionEstante);

            for (i = 0; i < e.producto.Length; i++)
            {
                detalleEstante.AppendFormat(e.producto[i].MostrarProducto(e.producto[i]));
            }

            return detalleEstante.ToString();
        }



        #region Sobrecarga operadores

        public static bool operator ==(Estante e, Producto p)
        {
            bool respuesta = false;
            int i;

            for (i = 0; i < e.producto.Length; i++)
            {
                if (e.producto[i] == p)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }


        public static bool operator !=(Estante e, Producto p)
        {
            bool respuesta = false;
            int i;

            for (i = 0; i < e.producto.Length; i++)
            {
                if (e.producto[i] != p)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }


        public static bool operator +(Estante e, Producto p)
        {
            bool respuesta = false;
            int i;
            /*
            if (e.producto.Contains(null))
            {
                respuesta = true;
            }
            */
       
            for (i = 0; i < e.producto.Length; i++)
            {
                if(object.ReferenceEquals(e.producto[i], null))
                {
                    respuesta = true;
                    break;
                }
            }

            if (respuesta == true)
            {
                //agregar for que busque en el array si el producto ya se encuentra.
            }


            return respuesta;
        }


        #endregion



    }
}
