using System.ComponentModel;
using System.Drawing;

namespace Ejercicio_01.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CirculoTests
    {
        [TestCase(1, 1, 10)]
        public void AreaCirculo_Success(double pXCentro, double pYCentro, double pRadio)
        {
            Circulo circ = new Circulo(pXCentro, pYCentro, pRadio);

            double result = circ.Area;

            Assert.AreEqual(314.16, result,0.01);
        }

        [TestCase(1, 1, 10)]
        public void PerimetroCirculo_Success(double pXCentro, double pYCentro, double pRadio)
        {
            Circulo circ = new Circulo(pXCentro, pYCentro, pRadio);

            double result = circ.Perimetro;

            Assert.AreEqual(62.83, result,0.01);
        }
    }
}
