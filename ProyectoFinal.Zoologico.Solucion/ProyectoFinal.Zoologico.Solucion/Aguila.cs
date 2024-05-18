using ProyectoFinal.Zoologico.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico.Solucion
{
    public class Aguila : Animal, IAnimalVolador
    {
        public Aguila()
        {
            this.Nombre = "Aguila Real";
            this.Habitat = TipoHabitat.Arido;
            this.Dieta = "liebres";
            this.EstadoSalud = "Herida";
            this.Tipo = TipoAnimal.Oviparo;
            this.TipoComida = TipoComida.Carnivoro;
        }

        public void Comer()
        {
            Console.WriteLine($"Comer {this.Dieta}");
        }

        public void Dormir()
        {
            Console.WriteLine($"{this.Nombre} Duerme");
        }

        public void Volar()
        {
            Console.WriteLine($"{this.Nombre} vuela");
        }

        public override void Entrenar()
        {
            this.Volar();
        }
    }
}
