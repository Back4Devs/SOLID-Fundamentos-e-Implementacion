using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico.Solucion
{
    public class Veterinario : EmpleadoZoologico, IVeterinario
    {
        public Veterinario(string nombre)
        {
            this.Nombre = nombre;
        }
        public void AtencionMedica(Animal animal)
        {
            Console.WriteLine($"El animal {animal.Nombre} se encuentra {animal.EstadoSalud}");
            animal.EstadoSalud = "Saludable";
            animal.Dormir();
            Console.WriteLine($"El {animal.Nombre} fue curado");
        }
    }
}
