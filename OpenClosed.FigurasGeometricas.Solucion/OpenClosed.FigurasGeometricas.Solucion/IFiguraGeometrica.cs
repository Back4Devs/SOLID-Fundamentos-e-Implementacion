using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.FigurasGeometricas.Solucion
{
    internal interface IFiguraGeometrica
    {
        public string Nombre { get; }
        double CalculoArea();
        double CalculoPerimetro();
    }
}
