using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Clase18
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("FIFA");

            EquipoFutbol equipo1 = new EquipoFutbol("San Lorenzo", DateTime.Parse("01/11/1980"));
            //Console.WriteLine(equipo1.Ficha());
            //Console.ReadKey();

            EquipoFutbol equipo2 = new EquipoFutbol("Independiente", DateTime.Today);
            EquipoFutbol equipo3 = new EquipoFutbol("River", DateTime.Today);

            EquipoBasquet equipo4 = new EquipoBasquet("Boca", DateTime.Today);
            EquipoBasquet equipo5 = new EquipoBasquet("Lanus", DateTime.Today);
            EquipoBasquet equipo6 = new EquipoBasquet("Estudiantes", DateTime.Today);


            torneoBasquet = torneoBasquet + equipo4;
            torneoBasquet = torneoBasquet + equipo5;
            torneoBasquet = torneoBasquet + equipo6;
            
            torneoFutbol = torneoFutbol + equipo1;
            torneoFutbol = torneoFutbol + equipo2;
            torneoFutbol = torneoFutbol + equipo3;


            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());


            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);


            Console.ReadKey();

        }
    }
}
