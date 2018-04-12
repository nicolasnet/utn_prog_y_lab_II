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
        private float cotizRespectoDolar = 1;

        #region Constructores

        private Dolar()
        { 
        }


        public Dolar(double cantidad)
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

        #endregion
    }
}
