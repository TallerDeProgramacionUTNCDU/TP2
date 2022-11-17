using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Fachada
{
	public RepositorioPartidas repoPartidas;
	public RepositorioPalabras repoPalabras;
	public Fachada()
	{
		repoPartidas = new RepositorioPartidas();
		repoPalabras = new RepositorioPalabras();
	}
	public int IniciarPartida(string pNombreJugador, string pApellidoJugador)
	{
		var pPalabra = repoPalabras.PalabraAleatoria();
		return repoPartidas.NuevaPartida(pNombreJugador, pApellidoJugador, pPalabra);
    }
    public void CambiarMaximoErrores(int pID,int nuevoMax)
	{
        var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
        partidaE.ChangeMaxMistakes(nuevoMax);
	}
	public int ErroresDisponibles(int pID)
	{
		var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
		return partidaE.MaxMistakes;
    }
	public List<string> ListadoCorrectas(int pID)
	{
		var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
		return partidaE.letrasCorrectas;
	}
    public List<string> ListadoIncorrectas(int pID)
    {
        var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
        return partidaE.letrasIncorrectas;
    }
	public bool EvaluacionLetraIngresada(int pID, string pLetra)
	{
        var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
		return partidaE.AccionesEvaluacion(pLetra);
	}
	public bool PartidaGanada(int pID)
	{
        var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
        return partidaE.Ganador();
	}
	public bool FindePartida(int pID)
	{
        var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
        if ((partidaE.FinPartida()) == true) { repoPartidas.GuardarPartida(partidaE); }
        return partidaE.FinPartida();
    }
	public string GenerarEspaciosDePalabra(int pID)
	{
        var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
        return partidaE.EspaciosPalabra();
	}
	public string ActualizarInfoPantalla(int pID,string pLetra)
	{
        var partidaE = repoPartidas.ObtenerPartidaDesdeId(pID);
        return partidaE.UpdateStatusGame(pLetra);  
	}
    public List<DatosPartida> GanadosDeMenorDuracion()
    {
		return repoPartidas.Ganados5MenorDuracion();
    }
}

