using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Pesos
    {
        private double cantidad;
        private float cotizRespectoDolar = (float) 17.55;

        #region Constructores

        private Pesos()
        { 
        }


        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public Pesos(double cantidad, float cotizacion)
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
        
        public static implicit operator Pesos(double d)
        {
            Pesos moneda = new Pesos(d);
            return moneda;
        }


        public static explicit operator Euro(Pesos d)
        {
            Euro cambio = new Euro(0);

            cambio = d.cantidad / d.GetCotizacion() / cambio.GetCotizacion();

            return cambio;
        }


        public static explicit operator Dolar(Pesos d)
        {
            Dolar cambio = new Dolar(0);

            cambio = d.cantidad / cambio.GetCotizacion();

            return cambio;
        }

        #endregion
    }
}
