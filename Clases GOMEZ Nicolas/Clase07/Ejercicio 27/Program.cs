using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {

            //para realizar este ejercicio, 1ro creamos una lista, la cargamos y la ordenamos.
            //Este orden va a depender de lo que uno quiera hacer ya que al cargar en una cola y/o una pila, ya debe
            //estar listo para imprimir, ya las colas y pilas no se ordenan y se vacian una vez usadas (como ser imprimirlas)
            


            /*
            int cant = 20;
            List<int> listaNros = new List<int>();
            //int[] listaNros = new int[cant];
            Random r = new Random();
            int i, j, aux=0;

            for (i = 0; i < cant; i++)
            {
                listaNros.Add(r.Next(-1000, 1000));
                Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
            }


            for (i = 0; i < cant-1; i++)
            {
                for (j = i + 1; j < cant; j++)
                {
                    if(listaNros[i] > listaNros[j])
                    {
                        aux = listaNros[i];
                        listaNros[i] = listaNros[j];
                        listaNros[j] = aux;
                    }
                }                    
            }

            Console.WriteLine("---.---.---.---.---.---.---.---.---.---.---.---.---.---.---.---.");

            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Numeros Negativos: ");

            for (i = 0; i < cant; i++)
            {
                if (listaNros[i] < 0)
                {
                    Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Numeros positivos: ");

            for (i = cant-1; i >= 0 ; i--)
            {
                if (listaNros[i] > 0)
                {
                    Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
                }
            }

            Console.ResetColor();

            //Console.WriteLine("termino la lista");

            Console.ReadKey();
            */

            /*
            int cant = 20;
            //List<int> listaNros = new List<int>();
            Queue<int> listaNros = new Queue<int>();
            //int[] listaNros = new int[cant];
            Random r = new Random();
            int i, j, aux=0;

            
            for (i = 0; i < cant; i++)
            {
                listaNros.Enqueue(r.Next(-1000, 1000));
                //Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
            }
            

            foreach (int numeros in listaNros)
            {
                Console.WriteLine("Numero: {0}", numeros);
            }
            */


            int cant = 20;
            //List<int> listaNros = new List<int>();
            Stack<int> listaNros = new Stack<int>();
            //int[] listaNros = new int[cant];
            Random r = new Random();
            int i, j, aux = 0;


            for (i = 0; i < cant; i++)
            {
                listaNros.Push(r.Next(-1000, 1000));
                //Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
            }


            foreach (int numeros in listaNros)
            {
                Console.WriteLine("Numero: {0}", numeros);
            }


            /*
            for (i = 0; i < cant-1; i++)
            {
                for (j = i + 1; j < cant; j++)
                {
                    if(listaNros[i] > listaNros[j])
                    {
                        aux = listaNros[i];
                        listaNros[i] = listaNros[j];
                        listaNros[j] = aux;
                    }
                }                    
            }
            */
            /*
            listaNros.Sort(Funciones.OrdenarDescendente);


            Console.WriteLine("---.---.---.---.---.---.---.---.---.---.---.---.---.---.---.---.");

            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Numeros Negativos: ");

            for (i = 0; i < cant; i++)
            {
                if (listaNros[i] < 0)
                {
                    Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Numeros positivos: ");

            for (i = cant-1; i >= 0 ; i--)
            {
                if (listaNros[i] > 0)
                {
                    Console.WriteLine("Numero {0}: {1}", i + 1, listaNros[i]);
                }
            }

            Console.ResetColor();

            //Console.WriteLine("termino la lista");
            */




            Console.ReadKey();
        }
    }
}
