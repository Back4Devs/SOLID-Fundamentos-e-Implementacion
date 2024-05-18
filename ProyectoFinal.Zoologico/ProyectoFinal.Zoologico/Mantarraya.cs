using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico
{
    public class Mantarraya : Animal, IAnimal
    {
        public Mantarraya()
        {
            this.Nombre = "Mantarraya Oceanica gigante";
            this.Habitat = TipoHabitat.HabitatAguaSalada;
            this.Dieta = "plancton, peces";
            this.EstadoSalud = "Enferma";
            this.Tipo = TipoAnimal.Oviparo;
            this.TipoComida = TipoComida.Omnivoro;
        }
        public void Comer()
        {
            Console.WriteLine($"Comer {this.Dieta}");
        }

        public void Correr()
        {
            throw new NotImplementedException();
        }

        public void Dormir()
        {
            Console.WriteLine($"{this.Nombre} Duerme");
        }

        public void Nadar()
        {
            Console.WriteLine($"{this.Nombre} Nada");
        }

        public void Volar()
        {
            throw new NotImplementedException();
        }
    }
}
