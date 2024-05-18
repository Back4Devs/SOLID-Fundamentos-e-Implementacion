using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Notificaciones.Solucion
{
    public interface INotificacion
    {
        public void EnviarUno(Notificacion notificacion);
    }
}
