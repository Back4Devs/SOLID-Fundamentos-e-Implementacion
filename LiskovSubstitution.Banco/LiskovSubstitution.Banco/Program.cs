// See https://aka.ms/new-console-template for more information
using LiskovSubstitution.Banco;

CuentaAhorros cuentaAhorros = new CuentaAhorros(0, "Mauricio Cespedes", 45678);
cuentaAhorros.Depositar(100);
cuentaAhorros.Retirar(100);
CuentaPlazoFijo cuentaPlazoFijo = new CuentaPlazoFijo(1000, "Boris Mendez", 58993);
cuentaPlazoFijo.Depositar(50);
cuentaPlazoFijo.CerrarPlazoFijo();
//cuentaPlazoFijo.Retirar(100);  //no se puede retirar
TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito("Jaime Vega", 55123);
tarjetaDeCredito.Retirar(500);
tarjetaDeCredito.PagarTarjeta();
//tarjetaDeCredito.Depositar(100); // no se puede depositar