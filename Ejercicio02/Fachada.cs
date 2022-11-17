
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Fachada
    {
        private static RepositorioBanca repositorio = new RepositorioBanca();
        public const double DOLAR = 280;

        private Fachada() { }

        public static void CrearBanca(double dni, string nombreTitular)
        {
            Banca banca = new Banca(dni, nombreTitular);
            repositorio.Agregar(banca);
        }

        public static double MostrarSaldoPesos(double dni)
        {
            Banca banca = repositorio.Obtener(dni);
            return banca.CuentaEnPesos.Saldo;
        }

        public static double MostrarSaldoDolares(double dni)
        {
            Banca banca = repositorio.Obtener(dni);
            return banca.CuentaEnDolares.Saldo;
        }

        public static Boolean DebitoPesos(double dni, double cantidadPlata)
        {
            Banca banca = repositorio.Obtener(dni);
            return banca.CuentaEnPesos.DebitarSaldo(cantidadPlata);
        }

        public static Boolean DebitoDolares(double dni, double cantidadPlata)
        {
            Banca banca = repositorio.Obtener(dni);
            return banca.CuentaEnDolares.DebitarSaldo(cantidadPlata);
        }

        public static void CreditoPesos(double dni, double cantidadPlata)
        {
            Banca banca = repositorio.Obtener(dni);
            banca.CuentaEnPesos.AcreditarSaldo(cantidadPlata);
        }

        public static void CreditoDolar(double dni, double cantidadPlata)
        {
            Banca banca = repositorio.Obtener(dni);
            banca.CuentaEnDolares.AcreditarSaldo(cantidadPlata);
        }

        public static Boolean ComprarDolares(double dni, double cantidadDolares)
        {
            if (Fachada.DebitoPesos(dni, cantidadDolares * DOLAR))
            {
                Fachada.CreditoDolar(dni, cantidadDolares);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean VenderDolares(double dni, double cantidadDolares)
        {
            if (Fachada.DebitoDolares(dni, cantidadDolares))
            {
                Fachada.CreditoPesos(dni, cantidadDolares * DOLAR);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean Existe(double dni)
        {
            if (repositorio.Obtener(dni) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
