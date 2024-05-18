using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.FigurasGeometricas.Solucion
{
    internal class Triangulo : IFiguraGeometrica
    {
        private readonly double lado1;
        private readonly double lado2;
        private readonly double baseTriangulo;
        private readonly double altura;

        public Triangulo(double lado1, double lado2, double baseTriangulo, double altura)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            this.Nombre = "Triangulo";
        }

        public string Nombre { get; }

        public double CalculoArea()
        {
            double area = (baseTriangulo * altura) / 2;
            return area;
        }

        public double CalculoPerimetro()
        {
            double perimetro = lado1 + lado2 + baseTriangulo;
            return perimetro;
        }
    }
}
