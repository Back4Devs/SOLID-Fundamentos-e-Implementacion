using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Notificaciones
{
    public class NotificacionPush
    {
        public void EnviarUno(Notificacion notificacion)
        {
            Console.WriteLine("Enviando notificacion Push");
            Console.WriteLine($"Emisor: {notificacion.Emisor} - Receptor: {notificacion.Receptor} - Mensaje: {notificacion.Mensaje}");
        }
    }
}
