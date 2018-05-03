using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Local : Llamada
    {
        #region Atributos

        protected float costo;

        #endregion



        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion



        #region Constructor

        public Local(string origen, float duracion, string destino, float costo) 
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        public Local(Llamada llamada, float costo) 
            : this (llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        #endregion



        #region Metodos

        private float CalcularCosto()
        {
            float costoTotal = this.duracion * this.costo;
            return costoTotal;
        }


        protected override string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder(base.Mostrar());
                        
            datosLlamada.AppendFormat("Costo Llamada: {0}", this.CostoLlamada);

            return datosLlamada.ToString();
        }


        public override bool Equals(object obj)
        {
            return obj is Local;
        }
                

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
        


        #region Enumeradores



        #endregion

    }
}
