using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico.Solucion
{
    public class Entrenador : EmpleadoZoologico, IEntrenador
    {
        public Entrenador(string nombre)
        {
            this.Nombre = nombre;
        }
        public void EntrenarAnimal(Animal animal)
        {
            Console.WriteLine($"Entrenar {animal.Nombre}");
            animal.Entrenar();
        }
    }
}
