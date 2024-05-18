using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.FigurasGeometricas.Solucion
{
    internal class Circulo : IFiguraGeometrica
    {
        private readonly double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
            this.Nombre = "Circulo";
        }

        public string Nombre { get; }

        public double CalculoArea()
        {
            double area = Math.PI * (radio * radio);
            return area;
        }

        public double CalculoPerimetro()
        {
            double perimetro = 2 * Math.PI * radio;
            return perimetro;
        }
    }
}
