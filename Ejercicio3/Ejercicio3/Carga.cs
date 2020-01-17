using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class Carga
    {
        public string dispositivo { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public decimal precio { get; set; }

        public void buscar(string valor)
        {
            if (valor == this.dispositivo)
            {
                Console.WriteLine("Dispositivo: " + this.dispositivo + "\nMarca: " + this.marca + "\nModelo: " + this.modelo);
                Console.WriteLine("Presione cualquier tecla para volver al menu...");
            }
        }

        public void completo()
        {
            Console.WriteLine("Dispositivos: " + this.dispositivo + "\nModelo: " + this.modelo + "\nMarca: " + this.marca + "\nPrecio " + "$" + this.precio + "\n");
        }
    }
}
