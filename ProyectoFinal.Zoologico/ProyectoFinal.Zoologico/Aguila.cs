using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico
{
    public class Aguila : Animal, IAnimal
    {
        public Aguila()
        {
            this.Nombre = "Aguila Real";
            this.Habitat = TipoHabitat.HabitatArido;
            this.Dieta = "liebres";
            this.EstadoSalud = "Herida";
            this.Tipo = TipoAnimal.Oviparo;
            this.TipoComida = TipoComida.Carnivoro;
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
            throw new NotImplementedException();
        }

        public void Volar()
        {
            Console.WriteLine($"{this.Nombre} vuela");
        }
    }
}
