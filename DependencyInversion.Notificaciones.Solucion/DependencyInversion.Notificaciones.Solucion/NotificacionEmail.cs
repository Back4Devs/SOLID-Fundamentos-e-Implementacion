using DependencyInversion.Notificaciones.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Notificaciones
{
    public class NotificacionEmail : INotificacion
    {
        public void EnviarUno(Notificacion notificacion)
        {
            Console.WriteLine("Enviando Email");
            Console.WriteLine($"Emisor: {notificacion.Emisor} - Receptor: {notificacion.Receptor} - Mensaje: {notificacion.Mensaje}");
        }
    }
}
