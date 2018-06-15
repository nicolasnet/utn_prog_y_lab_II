using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    public class Caja
    {
        private List<string> filaClientes;


        public Caja()
        {
            this.filaClientes = new List<string>();
        }


        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }


        public void AtenderClientes()
        {

            foreach (string aux in filaClientes)
            {
                Console.WriteLine("Cliente: {0}. Caja: {1}",aux, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }
    }
}
