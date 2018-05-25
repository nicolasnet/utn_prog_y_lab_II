using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Ejercicio52
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;


        public EscrituraWrapper() { }

        public EscrituraWrapper(string texto, ConsoleColor color) 
            : this ()
        {
            this.texto = texto;
            this.color = color;
        }

    }
}
