using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 17";

            string dibujo = "";
            short gasto = 0;
            int opcion = 0;
            ConsoleColor colorPrincipal = Console.ForegroundColor;
            bool seguir = true;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            do{
                Console.Clear();
                Console.WriteLine("1- Color Azul.");
                Console.WriteLine("2- Color Rojo.");
                Console.WriteLine("3- Salir.");

                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("1- Pintar Azul.");
                            Console.WriteLine("2- Recargar.");
                            Console.WriteLine("3- Salir.");
                            if (int.TryParse(Console.ReadLine(), out opcion))
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        Console.Write("Ingresar cantidad de tinta a gastar: ");
                                        if(short.TryParse(Console.ReadLine(), out gasto))
                                        {
                                            boligrafoAzul.Pintar(gasto, out dibujo);
                                            Console.ForegroundColor = boligrafoAzul.GetColor();
                                            Console.WriteLine(dibujo);
                                            Console.ForegroundColor = colorPrincipal;
                                        }
                                        break;

                                    case 2:
                                        boligrafoAzul.Recargar();
                                        break;

                                    case 3:
                                        break;
                                }
                            }

                            break;

                        case 2:
                            Console.WriteLine("1- Pintar Rojo.");
                            Console.WriteLine("2- Recargar.");
                            Console.WriteLine("3- Salir.");
                            if (int.TryParse(Console.ReadLine(), out opcion))
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        Console.Write("Ingresar cantidad de tinta a gastar: ");
                                        if (short.TryParse(Console.ReadLine(), out gasto))
                                        {
                                            boligrafoRojo.Pintar(gasto, out dibujo);
                                            Console.ForegroundColor = boligrafoRojo.GetColor();
                                            Console.WriteLine(dibujo);
                                            Console.ForegroundColor = colorPrincipal;
                                        }
                                        break;

                                    case 2:
                                        boligrafoRojo.Recargar();
                                        break;

                                    case 3:
                                        break;
                                }
                            }
                            break;

                        case 3:
                            seguir = false;
                            break;
                    }
                }
                Console.ReadKey();
            }while(seguir == true);
            
        }
    }
}
