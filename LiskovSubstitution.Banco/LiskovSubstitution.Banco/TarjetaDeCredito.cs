using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Banco
{
    public class TarjetaDeCredito : CuentaBancaria
    {
        private double montoCredito = 2000;
        public TarjetaDeCredito(string nombreCliente, int idCliente)
        {
            this.IniciarCuenta(this.montoCredito, nombreCliente, idCliente);
        }
        public override void Depositar(double monto)
        {
            Console.WriteLine("No se puede depositar dinero en esta cuenta");
            throw new NotImplementedException();
        }

        public override void Retirar(double monto)
        {
            if (monto <= this.balance && monto > 0)
            {
                this.balance -= monto;
                Console.WriteLine($"Su transaccion se proceso correctamente, balance actual es de {this.balance}");
            }
            else
            {
                Console.WriteLine("El monto debe ser menor o igual al balance y mayor a 0");
            }
        }

        public void PagarTarjeta()
        {
            double montoUsado = (this.montoCredito - this.balance);
            double montoAPagar = montoUsado + (montoUsado * 0.15);
            Console.WriteLine($"El monto a pagar es de {montoAPagar}");
            this.balance = this.montoCredito;
        }
    }
}
