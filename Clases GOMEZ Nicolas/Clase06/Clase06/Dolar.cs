using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Dolar
    {
        private double cantidad;
        private float cotizRespectoDolar;

        #region Constructores

        private Dolar()
        {
            this.cotizRespectoDolar = 1;
        }


        public Dolar(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }


        public Dolar(double cantidad, float cotizacion)
            : this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        #endregion



        #region Metodos
        
        public double GetCantidad()
        {
            return this.cantidad;
        }


        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        #endregion



        #region Sobrecarga operadores

        public static implicit operator Dolar(double d)
        {
            Dolar moneda = new Dolar(d);
            return moneda;
        }


        public static explicit operator Euro(Dolar d)
        {
            Euro cambio = new Euro(0);

            cambio = d.cantidad / cambio.GetCotizacion();

            return cambio;
        }


        public static explicit operator Pesos(Dolar d)
        {
            Pesos cambio = new Pesos(0);

            cambio = d.cantidad * cambio.GetCotizacion();

            return cambio;
        }



        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar monedaDolar = new Dolar(0);

            monedaDolar = d.GetCantidad() + e.GetCantidad() * e.GetCotizacion();

            return monedaDolar;
        }


        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar monedaDolar = new Dolar(0);

            monedaDolar = d.GetCantidad() + p.GetCantidad() / p.GetCotizacion();

            return monedaDolar;
        }

                
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar monedaDolar = new Dolar(0);

            monedaDolar = d.GetCantidad() - e.GetCantidad() * e.GetCotizacion();

            return monedaDolar;
        }


        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar monedaDolar = new Dolar(0);

            monedaDolar = d.GetCantidad() - p.GetCantidad() / p.GetCotizacion();

            return monedaDolar;
        }


        public static bool operator ==(Dolar d, Euro e)
        {
            bool respuesta = false;

            if (d.GetCantidad() == e.GetCantidad() / e.GetCotizacion())
            {
                respuesta = true;
            }

            return respuesta;
        }


        public static bool operator ==(Dolar d, Pesos p)
        {
            bool respuesta = false;

            if (d.GetCantidad() == p.GetCantidad() * p.GetCotizacion())
            {
                respuesta = true;
            }

            return respuesta;
        }


        public static bool operator ==(Dolar d2, Dolar d2)
        {
            bool respuesta = false;

            if (d2.GetCantidad() == d2.GetCantidad())
            {
                respuesta = true;
            }

            return respuesta;
        }



        #endregion
    }
}
