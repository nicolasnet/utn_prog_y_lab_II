using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }


        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }



        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            float gasto = 0.1f;
            EscrituraWrapper aux = new EscrituraWrapper();

            this.tamanioMina = this.tamanioMina - ( (float)texto.Length * gasto );

            return aux;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Lapiz: \n");
            datos.AppendFormat("Tamanio Mina: {0}\n", ((IAcciones) this).UnidadesDeEscritura);
            datos.AppendFormat("Color Mina: {0}\n", ((IAcciones)this).Color);

            return datos.ToString();
        }

    }
}
