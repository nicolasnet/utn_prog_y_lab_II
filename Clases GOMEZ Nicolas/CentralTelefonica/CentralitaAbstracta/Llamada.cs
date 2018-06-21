using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstracta
{
    public abstract class Llamada
    {
        #region Atributos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion



        #region Propiedades

        public abstract float CostoLlamada
        {
            get;
        }


        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }


        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }


        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion



        #region Constructor

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion



        #region Metodos

        protected virtual string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder();

            datosLlamada.AppendFormat("Numero Origen: {0}\n", this.nroOrigen);
            datosLlamada.AppendFormat("Numero Destino: {0}\n", this.nroDestino);
            datosLlamada.AppendFormat("Duracion: {0}", this.duracion);

            return datosLlamada.ToString();
        }


        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = llamada1.duracion.CompareTo(llamada2.duracion);

            return retorno;
        }

        #endregion



        #region Sobrecarga

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool respuesta = false;

            if (l1.Equals(l2))
            {
                if(l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }


        public static bool operator !=(Llamada l1, Llamada l2)
        {
            bool respuesta = false;

            if (l1.Equals(l2))
            {
                if (l1.nroDestino != l2.nroDestino || l1.nroOrigen != l2.nroOrigen)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        #endregion



        #region Enumeradores

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }

        #endregion


    }
}
