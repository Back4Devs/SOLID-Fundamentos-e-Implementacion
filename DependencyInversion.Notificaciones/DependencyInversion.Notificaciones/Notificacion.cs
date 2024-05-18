using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Notificaciones
{
    public class Notificacion
    {
        public string Emisor { get; set; }
        public string Receptor { get; set; }
        public string Mensaje { get; set; }

        public Notificacion(string emisor, string receptor, string mensaje) 
        {
            this.Emisor = emisor;
            this.Receptor = receptor;
            this.Mensaje = mensaje;
        }
    }
}
