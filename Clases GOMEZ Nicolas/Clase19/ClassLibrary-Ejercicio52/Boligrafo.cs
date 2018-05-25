using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;


        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }


        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = (float)unidades;
            this.Color = color;
        }



        public EscrituraWrapper Escribir(string texto)
        {
            float gasto = 0.3f;
            EscrituraWrapper aux = new EscrituraWrapper();

            this.tinta = this.tinta - ((float)texto.Length * gasto);

            return aux;
        }

        public bool Recargar(int unidades)
        {
            this.tinta = this.tinta + (float)unidades;

            return true;
        }


        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Boligrafo: \n");
            datos.AppendFormat("Nivel Tinta: {0}\n", this.UnidadesDeEscritura);
            datos.AppendFormat("Color Tinta: {0}\n", this.Color);

            return datos.ToString();
        }

    }
}
