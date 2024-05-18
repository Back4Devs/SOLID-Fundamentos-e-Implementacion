using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.FigurasGeometricas.Solucion
{
    internal class Cuadrado : IFiguraGeometrica
    {
        private readonly double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
            this.Nombre = "Cuadrado";
        }

        public string Nombre { get; }

        public double CalculoArea()
        {
            double area = lado * lado;
            return area;
        }

        public double CalculoPerimetro()
        {
            double perimetro = 4 * lado;
            return perimetro;
        }
    }
}
