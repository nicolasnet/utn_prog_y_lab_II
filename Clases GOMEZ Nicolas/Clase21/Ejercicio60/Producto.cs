using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio60
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string prodNumber;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string ProdNumber
        {
            get
            {
                return this.prodNumber;
            }
            set
            {
                this.prodNumber = value;
            }
        }



        public Producto() { }


        public Producto(int id, string nombre, string prodNum)
            : this()
        {
            this.Id = id;
            this.Nombre = nombre;
            this.ProdNumber = prodNum;
        }


    }
}
