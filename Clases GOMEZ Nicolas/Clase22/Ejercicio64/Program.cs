using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();            
            Negocio n = new Negocio(c1, c2);

            n.Clientes.Add("Cliente 1");
            n.Clientes.Add("Cliente 2");
            n.Clientes.Add("Cliente 3");
            n.Clientes.Add("Cliente 4");
            n.Clientes.Add("Cliente 5");
            n.Clientes.Add("Cliente 6");
            n.Clientes.Add("Cliente 7");

            Thread hilo1 = new Thread(n.AsignarCaja);

            Thread hiloCaja1 = new Thread(n.Caja1.AtenderClientes);
            Thread hiloCaja2 = new Thread(n.Caja2.AtenderClientes);

            hiloCaja1.Name = "Caja1";
            hiloCaja2.Name = "Caja2";

            hilo1.Start();
            hilo1.Join();
            hiloCaja1.Start();
            hiloCaja2.Start();


        }
    }
}
