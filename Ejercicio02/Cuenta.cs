
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        public Cuenta(Moneda pMoneda)
        {
            this.iSaldo = 0;
            this.iMoneda = pMoneda;
        }

        public Cuenta(double saldoInicial, Moneda pMoneda)
        {
            this.iSaldo = saldoInicial;
            this.iMoneda = pMoneda;
        }
        public double Saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }

        public Boolean DebitarSaldo(double pSaldo)
        {
            if (pSaldo <= this.iSaldo)
            {
                this.iSaldo = this.iSaldo - pSaldo;
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
