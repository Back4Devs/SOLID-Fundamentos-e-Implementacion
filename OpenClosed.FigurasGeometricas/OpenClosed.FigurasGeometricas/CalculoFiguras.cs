using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.FigurasGeometricas
{
    public class CalculoFiguras
    {
        public double CalcularAreaCirculo(double radio)
        {
            double area = Math.PI * (radio * radio);
            return area;
        }

        public double CalcularPerimetroCirculo(double radio)
        {
            double perimetro = 2 * Math.PI * radio;
            return perimetro;
        }

        public double CalcularAreaCuadrado(double lado)
        {
            double area = lado * lado;
            return area;
        }

        public double CalcularPerimetroCuadrado(double lado)
        {
            double perimetro = 4 * lado;
            return perimetro;
        }

        public double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            double area = (baseTriangulo * altura) / 2;
            return area;
        }

        public double CalcularPerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            double perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }
    }
}
