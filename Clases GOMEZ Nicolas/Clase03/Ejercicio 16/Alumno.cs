using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;


        public void CalcularFinal()
        {
            Random r = new Random();

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = r.Next(0, 10);
                //Console.WriteLine(notaFinal);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            if (notaUno >= 4 && notaDos >= 4)
            {
                this.nota1 = notaUno;
                this.nota2 = notaDos;
            }
        }

        public string Mostrar()
        {

            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendFormat("Nombre {0}", this.nombre);
            mostrar.AppendFormat("Apellido {0}", this.apellido);
            mostrar.AppendFormat("Legajo {0}", this.legajo);
            mostrar.AppendFormat("Nota uno {0}", this.nota1);
            mostrar.AppendFormat("Nota dos {0}", this.nota2);
            if (this.notaFinal == -1)
            {
                mostrar.AppendFormat("Alumno desaprobado");
            }
            else
            {
                mostrar.AppendFormat("Nota Final: {0}", this.notaFinal);
            }
            
            return mostrar.ToString();
        }
    }
}
