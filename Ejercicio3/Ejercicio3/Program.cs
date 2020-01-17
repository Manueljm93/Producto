using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        private static int index = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Administrador!");
            Console.ReadKey();
            Console.Clear();

            List<string> menuItems = new List<string>()
            {
                "Carga",
                "Ver listado por tipo",
                "Ver listado completo",
                "Salir",
            };

            List<Carga> cargas = new List<Carga>();
            Console.CursorVisible = false;
            var corte = false;
            while (!corte)
            {
                string selectMenuItem = dibujarMenu(menuItems);
                if (selectMenuItem == "Ver listado por tipo")
                {
                    string buscar;
                    Console.WriteLine("Ingrese el dispositivo a buscar:");
                    buscar = Console.ReadLine();
                    foreach (var carga in cargas)
                    {
                        carga.buscar(buscar);
                    }
                    Console.ReadKey();
                }
                else if (selectMenuItem == "Carga")
                {
                    Carga c = new Carga();
                    cargas.Add(c);
                    Console.WriteLine("Agregar Dispositivo:");
                    c.dispositivo = Console.ReadLine();
                    Console.WriteLine("Agregar Modelo:");
                    c.modelo = Console.ReadLine();
                    Console.WriteLine("Agregar Marca:");
                    c.marca = Console.ReadLine();
                    Console.WriteLine("Agregar Precio:");
                    c.precio = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Carga realizada presione cualquier tecla para volver al menu...");
                    Console.ReadKey();
                }
                else if (selectMenuItem == "Ver listado completo")
                {
                    //cargas = cargas.OrderBy(x => x.precio).ToList();
                    foreach (var carga in cargas)
                    {                        
                        carga.completo();
                    }
                    Console.ReadKey();
                }
                else if (selectMenuItem == "Salir")
                {
                    corte = true;
                }
            }
        }

        private static string dibujarMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    index = 0;
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = items.Count - 1;
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {

                return items[index];
            }
            else
            {
                return "";
            }
            return "";
        }
    }
}

