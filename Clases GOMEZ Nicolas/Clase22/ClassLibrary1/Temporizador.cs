using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibrary1.Ejerc63
{
    public delegate void encargadoTiempo();

    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;
        public event encargadoTiempo EventoTiempo;


        public Temporizador(int intervalo, bool activo)
        {
            this.intervalo = intervalo;
            this.Activo = activo;
        }


        public bool Activo
        {
            get
            {                
                return hilo.IsAlive;
            }
            set
            {
                if (value)
                {
                    hilo = new Thread(Corriendo);
                    if (!(this.hilo.IsAlive))
                    {
                        hilo.Start();
                    }

                }
                if(value == false && this.hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }


        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }


        private void Corriendo()
        {
            while (true)
            {
                
                EventoTiempo.Invoke();
                Thread.Sleep(this.Intervalo);
            }
        }
    }
}
