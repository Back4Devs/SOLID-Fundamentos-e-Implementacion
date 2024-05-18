using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.PizzaRestaurant.Solucion
{
    public class PizzaCocina
    {
        public Pizza PrepararPizza(PizzaTipos pizzaType)
        {
            Pizza pizza = new Pizza();
            switch (pizzaType)
            {
                case PizzaTipos.Peperonni:
                    pizza = PrepararPizzaPepperoni();
                    break;
                case PizzaTipos.PolloBBQ:
                    pizza = PrepararPizzaPolloBBQ();
                    break;
                case PizzaTipos.Vegetariana:
                    pizza = PrepararPizzaVegetariana();
                    break;
                default:
                    break;
            }

            return pizza;
        }

        private Pizza PrepararPizzaPepperoni()
        {
            Pizza pizza = new Pizza();
            pizza.Tipo = PizzaTipos.Peperonni.ToString();
            this.AgregarIngredientesBase(pizza);
            pizza.Ingredientes.Add("Pepperoni");
            return pizza;
        }

        private Pizza PrepararPizzaPolloBBQ()
        {
            Pizza pizza = new Pizza();
            pizza.Tipo = PizzaTipos.PolloBBQ.ToString();
            this.AgregarIngredientesBase(pizza);
            pizza.Ingredientes.Add("Pollo");
            pizza.Ingredientes.Add("BBQ");
            return pizza;
        }

        private Pizza PrepararPizzaVegetariana()
        {
            Pizza pizza = new Pizza();
            pizza.Tipo = PizzaTipos.Peperonni.ToString();
            this.AgregarIngredientesBase(pizza);
            pizza.Ingredientes.Add("Tomate");
            pizza.Ingredientes.Add("Cebolla");
            pizza.Ingredientes.Add("Aceitunas");
            return pizza;
        }

        private void AgregarIngredientesBase(Pizza pizza)
        {
            pizza.Ingredientes.Add("Masa");
            pizza.Ingredientes.Add("Salsa de Tomate");
            pizza.Ingredientes.Add("Queso");
        }
    }
}
