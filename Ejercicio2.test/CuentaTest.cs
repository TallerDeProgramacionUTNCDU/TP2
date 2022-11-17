using System;
using Xunit;

namespace Ejercicio2.test
{
    public class CuentaTest
    {
        [Fact]
        public void CuentaDebitoTest()
        {
            Cuenta cuenta = new Cuenta(500, new Moneda("1", "Pesos", "$"));
            cuenta.DebitarSaldo(400);
            double resultado = cuenta.Saldo;
            Assert.Equal(100, resultado);
        }

        [Fact]
        public void CuentaCreditoTest()
        {
            Cuenta cuenta = new Cuenta(500, new Moneda("1", "Pesos", "$"));
            cuenta.AcreditarSaldo(400);
            double resultado = cuenta.Saldo;
            Assert.Equal(900, resultado);
        }


        [Fact]
        public void ObtenerEnRepotorioBancaVacioTest()
        {
            RepositorioBanca repositorio = new RepositorioBanca();
            var resultado= repositorio.Obtener(1);
            Assert.Equal(null, resultado);

        }

        [Fact]
        public void ObtenerEnRepotorioBancaTest()
        {
            RepositorioBanca repositorio = new RepositorioBanca(); 
            repositorio.Agregar(new Banca(1, "Santiago"));
            repositorio.Agregar(new Banca(2, "Marcos"));
            var resultado = repositorio.Obtener(1).Titular;

            Assert.Equal("Santiago", resultado);

        }



    }
}
