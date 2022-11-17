
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Banca
    {
        private Cuenta iCuentaEnDolares;
        private Cuenta iCuentaEnPesos;


        public Banca(double pNumero, string pTitular)
        {
            this.Titular = pTitular;
            this.Numero = pNumero;
            this.CuentaEnDolares = new Cuenta(new Moneda("1", "Dolares", "USD"));
            this.CuentaEnPesos = new Cuenta(new Moneda("2", "Pesos", "$"));
        }
        public Cuenta CuentaEnPesos
        {
            get { return this.iCuentaEnPesos; }
            set { this.iCuentaEnPesos = value; }
        }

        public Cuenta CuentaEnDolares
        {
            get { return this.iCuentaEnDolares; }
            set { this.iCuentaEnDolares = value; }
        }

        public string Titular
        {
            get;
            private set;
        }

        public double Numero
        {
            get;
            private set;
        }




    }


}
