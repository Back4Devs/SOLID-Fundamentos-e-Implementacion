namespace SingleResponsibility.PizzaRestaurant.Solucion
{
    public class PizzaCajero
    {
        public float Costo { get; set; }

        public void TomarOrden(TamanoPizza pizzaSize, TipoTransporte deliveryType)
        {
            CalcularCosto(pizzaSize, deliveryType);
            CobrarPizza();
        }

        private void CalcularCosto(TamanoPizza pizzaSize, TipoTransporte deliveryType)
        {
            float costoPizza = 0;
            float costoEntrega = 0;
            switch (pizzaSize)
            {
                case TamanoPizza.Pequena:
                    costoPizza = 6.99F;
                    break;
                case TamanoPizza.Mediana:
                    costoPizza = 8.99F;
                    break;
                case TamanoPizza.Grande:
                    costoPizza = 10.99F;
                    break;
                default:
                    break;
            }

            switch (deliveryType)
            {
                case TipoTransporte.Motocicleta:
                    costoEntrega = 3.50F;
                    break;
                case TipoTransporte.Automovil:
                    costoEntrega = 2.30F;
                    break;
                default:
                    break;
            }

            this.Costo = costoPizza + costoEntrega;
        }

        private void CobrarPizza()
        {
            Console.WriteLine($"La compra tiene un costo de {this.Costo}$");
            Console.WriteLine("Gracias por su compra!");
        }
    }
}
