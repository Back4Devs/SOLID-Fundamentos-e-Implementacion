using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LiskovSubstitution.Banco
{
    public class CuentaPlazoFijo : CuentaBancaria
    {
        public CuentaPlazoFijo(double balanceInicial, string nombreCliente, int idCliente)
        {
            this.IniciarCuenta(balanceInicial, nombreCliente, idCliente);
        }
        public override void Depositar(double monto)
        {
            if (monto > 0)
            {
                this.balance += monto;
                Console.WriteLine($"Su transaccion se proceso correctamente, balance actual es de {this.balance}");
            }
            else
            {
                Console.WriteLine("Monto debe ser mayor a 0");
            }
        }

        public override void Retirar(double monto)
        {
            Console.WriteLine("No se puede retirar dinero de esta cuenta");
            throw new NotImplementedException();
        }

        public void CerrarPlazoFijo()
        {
            if (this.fechaCreacion.AddMonths(6) < DateTime.Now)
            {
                this.balance += this.balance * 0.1;
                Console.WriteLine($"El plazo fijo ha sido cerrado, se le retorna un monto de {this.balance}");
                this.balance -= this.balance;
            }
            else {
                Console.WriteLine("La cuenta no puede cerrarse hasta terminar el plazo");
            }
        }
    }
}
