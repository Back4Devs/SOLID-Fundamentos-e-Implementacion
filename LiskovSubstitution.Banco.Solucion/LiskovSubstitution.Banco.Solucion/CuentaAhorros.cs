using LiskovSubstitution.Banco.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Banco
{
    public class CuentaAhorros : CuentaBancaria, IDepositos, IRetiros
    {
        public CuentaAhorros(double balanceInicial, string nombreCliente, int idCliente)
        {
            this.IniciarCuenta(balanceInicial, nombreCliente, idCliente);
        }
        public void Depositar(double monto)
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

        public void Retirar(double monto)
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
    }
}
