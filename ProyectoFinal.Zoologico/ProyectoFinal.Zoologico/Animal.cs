using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico
{
    public class Animal
    {
        public string Nombre { get; set; }
        public TipoAnimal Tipo { get; set; }
        public TipoComida TipoComida { get; set; }
        public TipoHabitat Habitat { get; set; }
        public string EstadoSalud { get; set; }
        public string Dieta { get; set; }
    }
}
