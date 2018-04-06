using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        #region Constructores
        public Producto(string marca, string codigo, float precio) 
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        #endregion



        #region Metodos
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }
        

        public string MostrarProducto(Producto p)
        {
            StringBuilder detallesProductos = new StringBuilder();
                       
            detallesProductos.AppendFormat("Codigo de barra: {0} | ", this.codigoDeBarra);
            detallesProductos.AppendFormat("Marca: {0} | ", this.marca);
            detallesProductos.AppendFormat("Precio: {0}", this.precio);

            return detallesProductos.ToString();
        }
        #endregion



        #region Sobrecarga Operadores

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool respuesta = false;

            if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool respuesta = false;

            if (p1.codigoDeBarra != p2.codigoDeBarra || p1.marca != p2.marca)
            {
                respuesta = true;
            }

            return respuesta;
        }


        public static bool operator ==(Producto p, string marca)
        {
            bool respuesta = false;

            if (p.marca == marca)
            {
                respuesta = true;
            }

            return respuesta;
        }


        public static bool operator !=(Producto p, string marca)
        {
            bool respuesta = false;

            if (p.marca != marca)
            {
                respuesta = true;
            }

            return respuesta;
        }
        #endregion


    }
}
