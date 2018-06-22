using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Threading;

namespace Entidades
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;



        static InfoHilo()
        {
            randomizer = new Random();
            
        }


        public InfoHilo(int id, IRespuesta<int> callback) 
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(Ejecutar);
            this.hilo.Start();
        }



        private void Ejecutar()
        {
            Thread.Sleep((randomizer.Next(1, 6) * 1000));
            callback.RespuestaHilo(this.id);
        }
    }
}
