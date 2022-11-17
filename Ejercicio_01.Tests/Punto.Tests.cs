using System.ComponentModel;
using System.Drawing;

namespace Ejercicio_01.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class PuntoTests
    {
        [TestCase (1,1,3,3)]
        public void DistanciaEntre2Puntos_Success(double p1X, double p1Y, double p2X, double p2Y)
        {
            //ARRANGE
            Punto sut1 = new Punto(p1X, p1Y);
            Punto sut2 = new Punto(p2X, p2Y);

            //ACT
            double result = sut1.CalcularDistanciaDesde(sut2);

            //ASSERT
            Assert.AreEqual(2.83, result,0.01);
            
        }
    }
}