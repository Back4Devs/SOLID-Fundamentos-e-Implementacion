using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico.Solucion
{
    public abstract class Animal : IAnimal
    {
        public string Nombre { get; set; }
        public TipoAnimal Tipo { get; set; }
        public TipoComida TipoComida { get; set; }
        public TipoHabitat Habitat { get; set; }
        public string EstadoSalud { get; set; }
        public string Dieta { get; set; }

        public void Dormir()
        {
            Console.WriteLine($"{this.Nombre} Duerme");
        }

        public void Comer()
        {
            Console.WriteLine($"{this.Nombre} Come alimentos");
        }

        public abstract void Entrenar();
    }
}
