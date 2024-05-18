using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Transporte
{
    public class Avion : ITransporte
    {
        private int cantidadPasajeros;
        public Avion(int cantidadPasajeros) 
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public void Abordar()
        {
            Console.WriteLine("Abordaje de Pasajeros");
            Console.WriteLine($"El maximo de pasajeros es {this.cantidadPasajeros}");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando en el aeropuerto de destino");
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando del aeropuerto de origen");
        }

        public void Estacionar()
        {
            throw new NotImplementedException();
        }

        public void Transportar(string puntoA, string puntoB)
        {
            Console.WriteLine($"Transportando por aire de {puntoA} a {puntoB}");
            Console.WriteLine("Tiempo estimado: 1 hora");
        }
    }
}
