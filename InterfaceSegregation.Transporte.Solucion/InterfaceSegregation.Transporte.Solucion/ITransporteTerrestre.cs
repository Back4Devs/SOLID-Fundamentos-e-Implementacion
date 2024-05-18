using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Transporte.Solucion
{
    public interface ITransporteTerrestre : ITransporte
    {
        public void Estacionar();
    }
}
