using System.Data;
using System.Globalization;

namespace Ejercicio_04.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class RepositorioPartidasTests
    { 
        [TestCase("Pablo", "Suárez", "ingenieria")]
        public void NuevaPartida_Success(string pNombreJugador, string pApellidoJugador, string pPalabra)
        {
            var repositorio = new RepositorioPartidas();
            var nuevaP = repositorio.NuevaPartida(pNombreJugador, pApellidoJugador, pPalabra);
            var nPartida = repositorio.ObtenerPartidaDesdeId(nuevaP);

            Assert.AreEqual(nPartida.NombreJugador, pNombreJugador);
            Assert.AreEqual(nPartida.ApellidoJugador, pApellidoJugador);
            Assert.AreEqual(nPartida.Palabra, pPalabra);
        }

        [TestCase("Pablo", "Suárez", "ingenieria", "g", "h")]
        public void AccionesEvaluacion_Success(string pNombreJugador, string pApellidoJugador, string pPalabra, string pLetraCorrecta, string pLetraIncorrecta)
        {
            var repositorio = new RepositorioPartidas();
            var nuevaP = repositorio.NuevaPartida(pNombreJugador, pApellidoJugador, pPalabra);
            var nPartida = repositorio.ObtenerPartidaDesdeId(nuevaP);

            nPartida.AccionesEvaluacion(pLetraCorrecta);
            nPartida.AccionesEvaluacion(pLetraIncorrecta);

            Assert.AreEqual(nPartida.LetrasCorrectas, 1);
            Assert.AreEqual(nPartida.MaxMistakes, 9);
        }
        [TestCase("Pablo", "Suárez", "ingenieria")]
        public void GuardarPartida_Success(string pNombreJugador, string pApellidoJugador, string pPalabra)
        {
            var repositorio = new RepositorioPartidas();
            var nuevaP = repositorio.NuevaPartida(pNombreJugador, pApellidoJugador, pPalabra);
            var nPartida = repositorio.ObtenerPartidaDesdeId(nuevaP);

            repositorio.GuardarPartida(nPartida);

            Assert.AreEqual(repositorio.partidas.Count, 1);
        }

        [TestCase("Pablo", "Suárez", "ingenieria", "Julio", "Pereira", "electromecanica")]
        public void Ganados5MenorDuracion_Success(string pNombreJugador1, string pApellidoJugador1, string pPalabra1, string pNombreJugador2, string pApellidoJugador2, string pPalabra2)
        {
            var repositorio = new RepositorioPartidas();
            var nuevaP1 = repositorio.NuevaPartida(pNombreJugador1, pApellidoJugador1, pPalabra1);
            var nPartida1 = repositorio.ObtenerPartidaDesdeId(nuevaP1);
            var nuevaP2 = repositorio.NuevaPartida(pNombreJugador2, pApellidoJugador2, pPalabra2);
            var nPartida2 = repositorio.ObtenerPartidaDesdeId(nuevaP2);
            nPartida1.Winner = true;
            nPartida2.Winner = false;


            var lista = repositorio.Ganados5MenorDuracion();

            Assert.AreEqual(lista.Count,1);
        }

    }
}