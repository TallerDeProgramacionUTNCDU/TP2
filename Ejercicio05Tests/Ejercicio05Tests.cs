using Ejercicio05;
using System;

namespace Ejercicio05Tests.test
{
    [TestFixture]
    public class Ejercicio05Tests
    {
        public void Suma_HappyPath_OK()
        {
            var Complejo1 = new Complejo(4, 8);
            var Complejo2 = new Complejo(3, 6);
            var Suma = Complejo1.Sumar(Complejo2);
            Assert.AreEqual(7, Suma.Real);
            Assert.AreEqual(14, Suma.Imaginario);
        }

        public void Resta_HappyPath_OK()
        {
            var Complejo1 = new Complejo(4, 8);
            var Complejo2 = new Complejo(3, 6);
            var Restar = Complejo1.Restar(Complejo2);
            Assert.AreEqual(1, Restar.Real);
            Assert.AreEqual(2, Restar.Imaginario);
        }
        public void Multiplicacion_HappyPath_OK()
        {
            var Complejo1 = new Complejo(4, 8);
            var Complejo2 = new Complejo(3, 6);
            var Multiplicacion = Complejo1.MultiplicarPor(Complejo2);
            Assert.AreEqual(12, Multiplicacion.Real);
            Assert.AreEqual(48, Multiplicacion.Imaginario);
        }

        public void Division_HappyPath_OK()
        {
            var Complejo1 = new Complejo(12, 8);
            var Complejo2 = new Complejo(3, 4);
            var Division = Complejo1.DividirPor(Complejo2);
            Assert.AreEqual(4, Division.Real);
            Assert.AreEqual(2, Division.Imaginario);
        }

        public void EsIgual_HappyPath_OK()
        {
            var Complejo1 = new Complejo(12, 8);
            var Complejo2 = new Complejo(12, 8);
            var Igual = Complejo1.EsIgual(Complejo2);
            Assert.True(Igual);
        }
        public void EsIgual_HappyPath_False()
        {
            var Complejo1 = new Complejo(12, 8);
            var Complejo2 = new Complejo(4, 9);
            var Igual = Complejo1.EsIgual(Complejo2);
            Assert.False(Igual);
        }

        public void EsIgualExplicit_HappyPath_OK()
        {
            var Complejo1 = new Complejo(12, 8);
            var Igual = Complejo1.EsIgual(12, 8);
            Assert.True(Igual);
        }

        public void EsIgualExplicit_HappyPath_False()
        {
            var Complejo1 = new Complejo(12, 8);
            var Igual = Complejo1.EsIgual(1, 7);
            Assert.False(Igual);
        }

        public void EsImaginario_HappyPath_OK()
        {
            var Complejo1 = new Complejo(12, 4);
            var Imaginario = Complejo1.EsImaginario();
            Assert.True(Imaginario);
        }

        public void EsImaginario_HappyPath_False()
        {
            var Complejo1 = new Complejo(12, 0);
            var Imaginario = Complejo1.EsImaginario();
            Assert.False(Imaginario);
        }

        public void EsReal_HappyPath_OK()
        {
            var Complejo1 = new Complejo(12, 0);
            var Real = Complejo1.EsReal();
            Assert.True(Real);
        }

        public void EsReal_HappyPath_False()
        {
            var Complejo1 = new Complejo(0, 3);
            var Real = Complejo1.EsReal();
            Assert.False(Real);
        }


        public void Magnitud_HappyPath_OK()
        {
            var Complejo1 = new Complejo(5, 10);
            var Magnitud = Complejo1.Magnitud;
            var Esperado = Math.Sqrt(Math.Pow(5, 2) + Math.Pow(10, 2));
            Assert.AreEqual(Esperado, Magnitud);
        }

        public void Conjugado_HappyPath_OK()
        {
            var Complejo1 = new Complejo(5, 10);
            var Conjugado = Complejo1.Conjugado;
            Assert.AreEqual(5, Conjugado.Real);
            Assert.AreEqual(-10, Conjugado.Imaginario);
        }


        public void Argumentos_HappyPath_OK()
        {
            var Real = 5;
            var Imaginario = 10;
            var Complejo1 = new Complejo(Real, Imaginario);
            var ArgumentosRadianes = Complejo1.ArgumentosEnRadianes;
            var ArgumentosGrados = Complejo1.ArgumentosEnGrados;
            var ArgumentoEsperado = Math.Atan(Imaginario / Real);
            Assert.AreEqual(ArgumentoEsperado, ArgumentosRadianes);
            Assert.AreEqual(ArgumentoEsperado * 180 / Math.PI, ArgumentosGrados);
        }
        public void ImaginarioYReal_HappyPath_OK()
        {
            var Complejo1 = new Complejo(5, 10);
            Assert.AreEqual(5, Complejo1.Real);
            Assert.AreEqual(10, Complejo1.Imaginario);
        }



    }
}
