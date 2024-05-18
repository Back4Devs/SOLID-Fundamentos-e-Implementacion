using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Banco
{
    public abstract class CuentaBancaria
    {
        protected double balance;
        protected readonly int numeroCuenta;
        protected readonly DateTime fechaCreacion;

        public string Nombre { get; private set; }
        public int ID { get; private set; }

        public CuentaBancaria()
        {
            numeroCuenta = new Random().Next(10000,99999);
            this.fechaCreacion = DateTime.Now;
        }

        public void IniciarCuenta(double balanceInicial, string nombreCliente, int idCliente)
        {
            this.balance = balanceInicial;
            this.Nombre = nombreCliente;
            this.ID = idCliente;
        }

        public abstract void Depositar(double monto);
        public abstract void Retirar(double monto);
    }
}
