using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Transporte
{
    public interface ITransporte
    {
        public void Transportar(string puntoA, string puntoB);
        public void Abordar();
    }
}
