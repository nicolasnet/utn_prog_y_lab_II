using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibrary1
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;


        #region Propiedades
        /// <summary>
        /// Propiedad encargada de incrementar en 1 al atributo numeroActual y luego retornarlo.
        /// </summary>
        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        #endregion



        #region Constructores

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
            :this()
        {
            this.puesto = puesto;
        }

        
        #endregion

        

        #region Metodos

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(4000);
            return true;
        }

        #endregion



        #region Sobrecarga de Operadores



        #endregion



        public enum Puesto
        {
            caja1,
            caja2,
        }





        


    }
}
