using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.FigurasGeometricas.Solucion
{
    internal class CalculadoraFiguras
    {
        public void CalcularAreaPerimetro(IFiguraGeometrica figuraGeometrica) 
        {
            var area = figuraGeometrica.CalculoArea();
            var perimetro = figuraGeometrica.CalculoPerimetro();

            Console.WriteLine($"{figuraGeometrica.Nombre}: Area = {area} Perimetro = {perimetro}");
        }
    }
}
