using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.PizzaRestaurant.Solucion
{
    internal class PizzaDelivery
    {
        public int TiempoDelivery { get; set; }
        public void EntregaDomicilio(Pizza pizza, TipoTransporte deliveryType)
        {
            if (deliveryType == TipoTransporte.Motocicleta)
            {
                DeliveryPorMotocicleta(pizza.Tipo);
            }
            else
            {
                DeliveryPorAutomovil(pizza.Tipo);
            }
        }

        private void DeliveryPorMotocicleta(string nombrePizza)
        {
            this.TiempoDelivery = 30;
            Console.WriteLine($"Entrega de pizza {nombrePizza} por {TipoTransporte.Motocicleta.ToString()} en {this.TiempoDelivery} minutos");
        }

        private void DeliveryPorAutomovil(string nombrePizza)
        {
            this.TiempoDelivery = 60;
            Console.WriteLine($"Entrega de pizza {nombrePizza} por {TipoTransporte.Automovil.ToString()} en {this.TiempoDelivery} minutos");
        }
    }
}
