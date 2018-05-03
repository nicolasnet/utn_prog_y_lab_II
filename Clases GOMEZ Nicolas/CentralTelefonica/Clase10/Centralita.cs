using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    class Centralita
    {
        #region Atributos

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion



        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }


        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }


        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }


        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion



        #region Constructores

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }


        public Centralita(string nombreEmpresa) 
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion



        #region Metodos
                 
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float resultado = 0;
            float contLocal = 0, contProvincial = 0;
            
            foreach (Llamada llamada in listaDeLlamadas)
            {

                if (llamada is Local)
                {
                    //no entiendo como estan calculando la ganancia.
                    contLocal += llamada.Duracion;
                }
                else if (llamada is Provincial)
                {
                    contProvincial += llamada.Duracion;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    resultado = contLocal;
                    break;

                case Llamada.TipoLlamada.Provincial:
                    resultado = contProvincial;
                    break;

                case Llamada.TipoLlamada.Todas:
                    resultado = contLocal + contProvincial;
                    break;
            }

            return resultado;
        }


        public string Mostrar()
        {
            StringBuilder llamadasInfo = new StringBuilder();

            llamadasInfo.AppendFormat("Razon Social: {0}\n", this.razonSocial);
            llamadasInfo.AppendFormat("Ganancia total: {0}\n", this.GananciasPorTotal);
            llamadasInfo.AppendFormat("Ganancia por llamadas locales: {0}\n", this.GananciasPorLocal);
            llamadasInfo.AppendFormat("Ganancia por llamadas provicniales: {0}\n", this.GananciasPorProvincial);
            llamadasInfo.AppendFormat("\n-Detalles de llamadas: \n");

            foreach(Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    llamadasInfo.AppendFormat(((Local)llamada).Mostrar());
                    llamadasInfo.AppendFormat("\n");
                }
                if (llamada is Provincial) 
                {
                    llamadasInfo.AppendFormat(((Provincial)llamada).Mostrar());
                    llamadasInfo.AppendFormat("\n");
                }

            }
            llamadasInfo.AppendFormat("------------------------------------------------------\n");

            return llamadasInfo.ToString();                        
        }

        
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        
        #endregion



        #region Enumeradores



        #endregion
    }
}
