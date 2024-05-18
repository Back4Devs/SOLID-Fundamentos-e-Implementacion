using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico.Solucion
{
    public class Mantarraya : Animal, IAnimalAcuatico
    {
        public Mantarraya()
        {
            this.Nombre = "Mantarraya Oceanica gigante";
            this.Habitat = TipoHabitat.AguaSalada;
            this.Dieta = "plancton, peces";
            this.EstadoSalud = "Enferma";
            this.Tipo = TipoAnimal.Oviparo;
            this.TipoComida = TipoComida.Omnivoro;
        }
        public void Comer()
        {
            Console.WriteLine($"Comer {this.Dieta}");
        }

        public void Dormir()
        {
            Console.WriteLine($"{this.Nombre} Duerme");
        }

        public void Nadar()
        {
            Console.WriteLine($"{this.Nombre} Nada");
        }

        public override void Entrenar()
        {
            this.Nadar();
        }
    }
}
