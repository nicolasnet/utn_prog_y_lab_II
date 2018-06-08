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
        private float costRate;
        private float availity;
        private DateTime modifiedDate;

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

        public float CostRate
        {
            get
            {
                return this.costRate;
            }
            set
            {
                this.costRate = value;
            }
        }



        public Producto() { }


        public Producto(string nombre, float costRate)
            : this()
        {            
            this.Nombre = nombre;
            this.costRate = costRate;
        }


    }
}
