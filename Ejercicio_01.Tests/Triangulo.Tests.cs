using System.ComponentModel;
using System.Drawing;

namespace Ejercicio_01.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class TrianguloTests
    {
        [TestCase(0, 0, 1, 1, 1, 2)]
        public void TrianguloPerimetro_Success(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
        {
            Punto sut1 = new Punto(p1X, p1Y);
            Punto sut2 = new Punto(p2X, p2Y);
            Punto sut3 = new Punto(p3X, p3Y);
            Triangulo triang = new Triangulo(sut1, sut2, sut3);

            double result = triang.Perimetro;

            Assert.AreEqual(1.41+1+2.24, result, 0.01);
        }

        [TestCase(0, 0, 1, 1, 1, 2)]
        public void TrianguloArea_Success(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
        {
            Punto sut1 = new Punto(p1X, p1Y);
            Punto sut2 = new Punto(p2X, p2Y);
            Punto sut3 = new Punto(p3X, p3Y);
            Triangulo triang = new Triangulo(sut1, sut2, sut3);

            double result = triang.Area;

            Assert.AreEqual(0.50, result, 0.01);
        }

    }
}

