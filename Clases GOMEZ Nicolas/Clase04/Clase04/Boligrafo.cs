using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;


        public Boligrafo()
        {

        }

        public Boligrafo(short cantTinta, ConsoleColor color)
        {
            SetTinta(cantTinta);
            SetColor(color);
        }


        public ConsoleColor GetColor()
        {
            return color;
        }


        public short GetTinta()
        {
            return tinta;
        }


        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }


        private void SetTinta(short cargaTinta)
        {
            if (this.tinta >= 0 && this.tinta < 100)
            {
                this.tinta += cargaTinta;
                if (this.tinta > 100)
                {
                    this.tinta = cantidadTintaMaxima;
                }
            }
        }


        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }


        public bool Pintar(short gasto, out string dibujo)
        {
            bool respuesta = false;
            int i = 0;

            dibujo = "";

            if (gasto <= this.tinta)
            {
                respuesta = true;
                SetTinta((short)(gasto * -1));
            }
            else
            {
                this.tinta = 0;
            }

            if (respuesta == true)
            {
                for (i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            else
            {
                for (i = 0; i < this.tinta; i++)
                {
                    dibujo += "*";
                }
            }

            return respuesta;

        }
        
    }
}
