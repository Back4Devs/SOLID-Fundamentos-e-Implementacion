// See https://aka.ms/new-console-template for more information
using SingleResponsibility.PizzaRestaurant.Solucion;

PedidoPizza(TamanoPizza.Pequena, PizzaTipos.Peperonni, TipoTransporte.Motocicleta);

static void PedidoPizza(TamanoPizza tamanoPizza, PizzaTipos pizzaTipo, TipoTransporte tipoTransporte)
{
    PizzaCajero pizzaCajero = new PizzaCajero();
    PizzaCocina pizzaCocina = new PizzaCocina();
    PizzaDelivery pizzaDelivery = new PizzaDelivery();
    pizzaCajero.TomarOrden(tamanoPizza, tipoTransporte);
    var pizza = pizzaCocina.PrepararPizza(pizzaTipo);
    pizzaDelivery.EntregaDomicilio(pizza, tipoTransporte);
}