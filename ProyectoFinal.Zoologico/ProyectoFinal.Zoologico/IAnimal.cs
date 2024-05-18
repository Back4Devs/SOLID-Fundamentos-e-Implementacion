using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Zoologico
{
    public interface IAnimal
    {
        public void Volar();
        public void Correr();
        public void Nadar();
        public void Comer();
        public void Dormir();
    }
}
