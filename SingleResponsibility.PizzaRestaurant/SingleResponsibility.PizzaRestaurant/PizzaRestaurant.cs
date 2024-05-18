using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.PizzaRestaurant
{
    public class PizzaRestaurant
    {
        public float Costo { get; set; }
        public int TiempoEntrega { get; set; }
        public void TomarOrden(TamanoPizza tamanoPizza, TipoTransporte tipoTransporte)
        {
            // Calcular el costo de la pizza segun el tamano
            switch (tamanoPizza)
            {
                case TamanoPizza.Pequena:
                    this.Costo = 6.99F;
                    break;
                case TamanoPizza.Mediana:
                    this.Costo = 8.99F;
                    break;
                case TamanoPizza.Grande:
                    this.Costo = 10.99F;
                    break;
                default:
                    break;
            }

            switch (tipoTransporte)
            {
                case TipoTransporte.Motocicleta:
                    this.Costo += 3.50F;
                    break;
                case TipoTransporte.Automovil:
                    this.Costo += 2.30F;
                    break;
                default:
                    break;
            }

            // Cobrar la Pizza
            Console.WriteLine($"El total a pagar es de {Costo}$");
            Console.WriteLine("Gracias por su compra!");
        }

        public Pizza PrepararPizza(PizzaTipos pizzaType)
        {
            Pizza pizza= new Pizza();
            pizza.Ingredientes.Add("Masa");
            pizza.Ingredientes.Add("Salsa de Tomate");
            pizza.Ingredientes.Add("Queso");
            switch (pizzaType)
            {
                case PizzaTipos.Pepperoni:
                    pizza.Tipo = PizzaTipos.Pepperoni.ToString();
                    pizza.Ingredientes.Add("Pepperoni");
                    break;
                case PizzaTipos.PolloBBQ:
                    pizza.Tipo = PizzaTipos.PolloBBQ.ToString();
                    pizza.Ingredientes.Add("Pollo");
                    pizza.Ingredientes.Add("BBQ");
                    break;
                case PizzaTipos.Vegetariana:
                    pizza.Tipo = PizzaTipos.Pepperoni.ToString();
                    pizza.Ingredientes.Add("Tomate");
                    pizza.Ingredientes.Add("Cebolla");
                    pizza.Ingredientes.Add("Aceitunas");
                    break;
                default:
                    break;
            }

            return pizza;
        }

        public void EntregaDomicilio(Pizza pizza, TipoTransporte tipoTransporte)
        {
            if (tipoTransporte == TipoTransporte.Motocicleta)
            {
                this.TiempoEntrega = 30;
                Console.WriteLine($"Entrega de pizza {pizza.Tipo} por {TipoTransporte.Motocicleta.ToString()} en {this.TiempoEntrega} minutos");
            }
            else
            {
                this.TiempoEntrega = 60;
                Console.WriteLine($"Entrega de pizza {pizza.Tipo} por {TipoTransporte.Automovil.ToString()} en {this.TiempoEntrega} minutos");
            }
        }
    }
}
