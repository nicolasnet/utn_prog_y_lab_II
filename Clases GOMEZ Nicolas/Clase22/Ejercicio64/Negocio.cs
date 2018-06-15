﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;


        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }


        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }


        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            this.clientes = new List<string>();
        }


        public void AsignarCaja()
        {
            Console.WriteLine("Asignando Cajas");

            foreach (string c in this.clientes)
            {
                if (Caja1.FilaClientes.Count <= caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(c);
                }
                else
                {
                    caja2.FilaClientes.Add(c);
                }
                Thread.Sleep(1000);                
            }
        }

    }
}
