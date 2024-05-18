using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico.Solucion
{
    public interface ICuidador
    {
        public void AlimentarAnimal(Animal animal);
        public void LimpiarHabitat(Animal animal);
    }
}
