// See https://aka.ms/new-console-template for more information
using SingleResponsibility.PizzaRestaurant;

PedidoPizza(TamanoPizza.Pequena, PizzaTipos.Pepperoni, TipoTransporte.Motocicleta);

static void PedidoPizza(TamanoPizza tamanoPizza, PizzaTipos pizzaTipo, TipoTransporte tipoTransporte)
{
    PizzaRestaurant pizzaRestaurant = new PizzaRestaurant();
    pizzaRestaurant.TomarOrden(tamanoPizza, tipoTransporte);
    var pizza = pizzaRestaurant.PrepararPizza(pizzaTipo);
    pizzaRestaurant.EntregaDomicilio(pizza, tipoTransporte);
}