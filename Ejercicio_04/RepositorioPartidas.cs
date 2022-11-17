using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
public class RepositorioPartidas
{
	public List<Partida> partidas;
	public RepositorioPartidas()
	{
		partidas = new List<Partida>();
	}
	public int NuevaPartida(string pNombreJugador, string pApellidoJugador, string pPalabra)
	{
		var nuevaP= new Partida(pNombreJugador, pApellidoJugador, DateTime.Now, pPalabra);
        partidas.Add(nuevaP);
        return nuevaP.IDPartida;
	}
	public Partida ObtenerPartidaDesdeId(int pId)
	{
		Partida encontrado= new Partida("","",DateTime.Now,"");
		for (int i = 0; i < partidas.Count; i++)
		{
			if (partidas[i].IDPartida == pId) { encontrado = partidas[i]; }	
		}
		return encontrado;
	}
	public List<string> LetrasCorrectas(Partida pPartida)
	{
		return pPartida.letrasCorrectas;
	}
	public List<string> LetrasIncorrectas(Partida pPartida)
	{
		return pPartida.letrasIncorrectas;
	}
	public void GuardarPartida(Partida pPartida)
	{
		pPartida.FechaFin = DateTime.Now;
	}
    public List<DatosPartida> Ganados5MenorDuracion()
    {
        int i = 0;
        int contador = 0;
		List<DatosPartida> partidaList = new List<DatosPartida>();
        var ordenados = partidas.OrderBy(p => p.Duracion).ToList();
        do
        {
            if (ordenados[i].Winner == true) {
				var nuevoDato = new DatosPartida(ordenados[i].IDPartida, ordenados[i].Palabra, ordenados[i].ApellidoJugador, ordenados[i].NombreJugador, ordenados[i].Winner, ordenados[i].Duracion);
				partidaList.Add(nuevoDato); contador++; }
            i++;
        }
        while ((contador <= 5) & (i < ordenados.Count));
		return partidaList;
    }
}


