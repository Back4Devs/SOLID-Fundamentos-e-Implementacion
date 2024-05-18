using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Notificaciones
{
    public class NotificacionSMS
    {
        public void EnviarUno(Notificacion notificacion)
        {
            Console.WriteLine("Enviando SMS");
            Console.WriteLine($"Emisor: {notificacion.Emisor} - Receptor: {notificacion.Receptor} - Mensaje: {notificacion.Mensaje}");
        }
    }
}
