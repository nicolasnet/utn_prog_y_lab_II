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


        public Torneo ()
        {
            equipos = new List<T>();
        }


        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }



        public string JugarPartido
        {
            get
            {
                Random equipoAleatoreo1 = new Random();
                int j;
                int i;
                i = equipoAleatoreo1.Next(0, this.equipos.Count);
                
                do
                {
                    System.Threading.Thread.Sleep(10);
                    Random equipoAleatoreo2 = new Random();
                    j = equipoAleatoreo2.Next(0, this.equipos.Count);

                } while (i == j);


                return CalcularPartido(this.equipos[i], this.equipos[j]);
            }
        }
        


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


        public static bool operator !=(Torneo<T> x, Equipo a)
        {
            return !(x == a);
        }


        public static Torneo<T> operator +(Torneo<T> x, T a)
        {            
            if (x != a)
            {
                x.equipos.Add(a);
            }         

            return x;
        }



        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendFormat("Nombre del Torneo: {0}\n", nombre);
            mostrar.AppendFormat("\nEquipos inscriptos: \n");

            foreach (Equipo e in this.equipos)
            {
                mostrar.AppendFormat(e.Ficha());
                mostrar.AppendLine();
            }

            return mostrar.ToString();
        }


        private string CalcularPartido(T a, T b)
        {
            StringBuilder calculo = new StringBuilder();
            Random goles1 = new Random();
            System.Threading.Thread.Sleep(10);
            Random goles2 = new Random();
            int j = goles1.Next(0, 10);
            System.Threading.Thread.Sleep(10);
            int i = goles2.Next(0, 10);

            calculo.AppendFormat("\n{0} {1}  -  {2} {3}\n", a.nombre, i, j, b.nombre);

            return calculo.ToString();
        }
    }
}
