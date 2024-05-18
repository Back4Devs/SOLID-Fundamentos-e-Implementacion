﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Transporte
{
    public class AutomovilTransportePublico : ITransporte
    {
        private int cantidadPasajeros;
        public AutomovilTransportePublico(int cantidadPasajeros)
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
            throw new NotImplementedException();
        }

        public void Despegar()
        {
            throw new NotImplementedException();
        }

        public void Estacionar()
        {
            Console.WriteLine("Ha llegado a su destino Estacionando el vehiculo en la parada indicada");
        }

        public void Transportar(string puntoA, string puntoB)
        {
            Console.WriteLine($"Transportando por tierra de {puntoA} a {puntoB}");
            Console.WriteLine("Tiempo estimado: 5 horas");
        }
    }
}
