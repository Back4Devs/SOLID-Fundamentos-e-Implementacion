using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Notificaciones
{
    public class ProcesadorNotificaciones
    {
        private Notificacion ArmarNotificacion(string emisor, string receptor, string mensaje)
        {
            Notificacion notificacion = new Notificacion(emisor, receptor, mensaje);
            return notificacion;
        }

        public void EnviarSMS(NotificacionSMS notificacionSMS, string emisor, string receptor, string mensaje)
        {
            Notificacion notificacion = this.ArmarNotificacion(emisor, receptor, mensaje);
            notificacionSMS.EnviarUno(notificacion);
        }

        public void EnviarEmail(NotificacionEmail notificacionEmail, string emisor, string receptor, string mensaje)
        {
            Notificacion notificacion = this.ArmarNotificacion(emisor, receptor, mensaje);
            notificacionEmail.EnviarUno(notificacion);
        }
        public void EnviarNotificacionPush(NotificacionPush notificacionPush, string emisor, string receptor, string mensaje)
        {
            Notificacion notificacion = this.ArmarNotificacion(emisor, receptor, mensaje);
            notificacionPush.EnviarUno(notificacion);
        }
    }
}
