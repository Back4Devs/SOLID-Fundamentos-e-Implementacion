using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico
{
    public class Gorila : Animal, IAnimal
    {
        public Gorila() 
        {
            this.Nombre = "Gorila Occidental";
            this.Habitat = TipoHabitat.HabitatBosque;
            this.Dieta = "Frutas Variadas";
            this.EstadoSalud = "Saludable";
            this.Tipo = TipoAnimal.Viviparo;
            this.TipoComida = TipoComida.Herbivoro;
        }

        public void Comer()
        {
            Console.WriteLine($"Comer {this.Dieta}");
        }

        public void Correr()
        {
            Console.WriteLine($"{this.Nombre} Corre");
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
            throw new NotImplementedException();
        }
    }
}
