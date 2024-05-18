using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico.Solucion
{
    public class Gorila : Animal, IAnimalTerrestre
    {
        public Gorila() 
        {
            this.Nombre = "Gorila Occidental";
            this.Habitat = TipoHabitat.Bosque;
            this.Dieta = "Frutas Variadas";
            this.EstadoSalud = "Saludable";
            this.Tipo = TipoAnimal.Viviparo;
            this.TipoComida = TipoComida.Herbivoro;
        }

        public void Correr()
        {
            Console.WriteLine($"{this.Nombre} Corre");
        }

        public override void Entrenar()
        {
            this.Correr();
        }
    }
}
