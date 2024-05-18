using DependencyInversion.Notificaciones.Solucion;

namespace DependencyInversion.Notificaciones
{
    public class NotificacionSMS : INotificacion
    {
        public void EnviarUno(Notificacion notificacion)
        {
            Console.WriteLine("Enviando SMS");
            Console.WriteLine($"Emisor: {notificacion.Emisor} - Receptor: {notificacion.Receptor} - Mensaje: {notificacion.Mensaje}");
        }
    }
}
