using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Euro
    {
        private double cantidad;
        private float cotizRespectoDolar;

        #region Constructores

        private Euro()
        {
            this.cotizRespectoDolar = (float)1.3642;
        }


        public Euro(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }


        public Euro(double cantidad, float cotizacion)
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
        
        public static implicit operator Euro(double d)
        {
            Euro moneda = new Euro(d);
            return moneda;
        }


        public static explicit operator Pesos(Euro d)
        {
            Pesos cambio = new Pesos(0);

            cambio = d.cantidad / d.GetCotizacion() * cambio.GetCotizacion();

            return cambio;
        }


        public static explicit operator Dolar(Euro d)
        {
            Dolar cambio = new Dolar(0);

            cambio = d.cantidad / d.GetCotizacion();

            return cambio;
        }

        #endregion
    }
}
