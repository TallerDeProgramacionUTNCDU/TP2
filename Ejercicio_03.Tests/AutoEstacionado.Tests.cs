using System.Globalization;
using System.Net.WebSockets;

namespace Ejercicio_03.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AutoEstacionadoTests
    {
        [TestCase("2022-09-20 13:00", "2022-09-20 14:00")]
        public void CobrarEstacionamiento_Success(string fechaInicio,string fechaFin)
        {
            var fechaI = DateTime.ParseExact(fechaInicio, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            var fechaF = DateTime.ParseExact(fechaFin, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            AutoEstacionado autoE = new AutoEstacionado("AAA", "1000", fechaI);

            double result = autoE.CobrarEstacionamiento(fechaF);

            Assert.AreEqual(200, result, 0.01);
        }
    }
}