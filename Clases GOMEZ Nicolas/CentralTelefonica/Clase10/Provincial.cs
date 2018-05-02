using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Provincial : Llamada
    {
        #region Atributos

        protected Franja franjaHoraria;

        #endregion



        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion



        #region Constructor

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base (duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }


        public Provincial(Franja miFranja, Llamada llamada) 
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        #endregion



        #region Metodos

        private float CalcularCosto()
        {
            float valorFranja = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    valorFranja = 0.99f;
                    break;

                case Franja.Franja_2:
                    valorFranja = 1.25f;
                    break;

                case Franja.Franja_3:
                    valorFranja = 0.66f;
                    break;
            }

            return valorFranja * this.duracion;
        }


        public string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder();

            datosLlamada.AppendFormat("Numero Origen: {0}\n", this.nroOrigen);
            datosLlamada.AppendFormat("Numero Destino: {0}\n", this.nroDestino);
            datosLlamada.AppendFormat("Duracion: {0}\n", this.duracion);
            datosLlamada.AppendFormat("Costo Llamada: {0}\n", this.CostoLlamada);
            datosLlamada.AppendFormat("Franja Horaria: {0}", this.franjaHoraria);

            return datosLlamada.ToString();
        }

        #endregion



        #region Enumeradores

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        #endregion
    }
}
