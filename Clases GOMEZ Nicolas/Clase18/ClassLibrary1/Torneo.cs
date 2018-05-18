using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Torneo <T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;




        public static bool operator ==(Torneo<T> x, Equipo a)
        {
            bool respuesta = false;

            foreach (Equipo e in x.equipos)
            {
                if (e == a)
                {
                    respuesta = true;
                    break;
                }
            }

            return respuesta;

        }

    }
}
