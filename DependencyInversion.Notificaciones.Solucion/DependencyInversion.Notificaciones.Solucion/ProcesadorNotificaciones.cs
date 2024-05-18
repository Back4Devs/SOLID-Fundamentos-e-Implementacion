using DependencyInversion.Notificaciones.Solucion;
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

        public void EnviarNotificacion(INotificacion notificador, string emisor, string receptor, string mensaje)
        {
            Notificacion notificacion = this.ArmarNotificacion(emisor, receptor, mensaje);
            notificador.EnviarUno(notificacion);
        }
    }
}
