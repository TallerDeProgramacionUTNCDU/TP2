using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class Partida
{
    public List<string> letrasCorrectas;
    public List<string> letrasIncorrectas;
    private int iIDPartida;
    public string iPalabra;
    public string iPalabraEnEjecucion;
	private string iNombreJugador;
	private string iApellidoJugador;
	private DateTime iFechaInicio;
	public DateTime iFechaFin;
	private bool iWinner;
    public TimeSpan iDuracion;
    public int iMaxMistakes;
    public int iLetrasCorrectas;
	public Partida(string pNombreJugador, string pApellidoJugador,DateTime pFechaInicio, string pPalabra)
	{
		iNombreJugador = pNombreJugador;
		iApellidoJugador = pApellidoJugador;
		iFechaInicio = pFechaInicio;
        iMaxMistakes = 10;
        Random rnd = new Random();
        int num = rnd.Next();
        iIDPartida = num;
        iLetrasCorrectas = 0;
        iPalabra = pPalabra;
        letrasCorrectas = new List<string>();
        letrasIncorrectas = new List<string>();
    }
    public string EspaciosPalabra()
    {
        for (int i = 0; i < Palabra.Length; i++)
        {
            PalabraEnEjecucion = PalabraEnEjecucion + "_";
        }
        return PalabraEnEjecucion;
    }
    public bool FinPartida()
    {
        if ((MaxMistakes == 0) | (iLetrasCorrectas == Palabra.Length)) { return true; }
        else { return false; }
    }
    public bool Ganador()
    {
        if (MaxMistakes == 0) { Winner = false; }
        else { Winner = true; }
        return Winner;
    }
    public bool AccionesEvaluacion(string pLetra)
    {
        bool exito = false;
        if (Palabra.Contains(pLetra))
        {
            var cantidad = Palabra.Count(f => f == (pLetra.ToCharArray()[0]));
            for (int i = 0; i < cantidad; i++)
            {
                IncrementarLetrasCorrectas();
                letrasCorrectas.Add(pLetra);
            }
            exito = true;
        }
        else {DecrementarContadorMistakes();letrasIncorrectas.Add(pLetra);exito = false; }
        return exito;
    }
    public string UpdateStatusGame(string pLetra)
    {
        string temporal = "";
        string enEjecucion = "";
        for (int i = 0; i < Palabra.Length; i++)
        {
            enEjecucion = (Palabra[i]).ToString();
            if ((String.Equals(enEjecucion, pLetra)) == true)
            {
                temporal = temporal + pLetra;
            }
            else { temporal = temporal + PalabraEnEjecucion[i]; }
        }
        PalabraEnEjecucion = temporal;
        return PalabraEnEjecucion;
    }
    public void ChangeMaxMistakes(int pMaxMistakes)
    {
        MaxMistakes = pMaxMistakes;
    }
    public void IncrementarLetrasCorrectas()
    {
        iLetrasCorrectas = iLetrasCorrectas + 1;
    }
    public void DecrementarContadorMistakes()
    {
        MaxMistakes = MaxMistakes - 1;
    }
    public int IDPartida
    {
        get { return this.iIDPartida; }
        set { this.iIDPartida = value; }
    }
    public string NombreJugador
    {
        get { return this.iNombreJugador; }
        set { this.iNombreJugador = value; }
    }
    public int LetrasCorrectas
    {
        get { return this.iLetrasCorrectas; }
        set { this.iLetrasCorrectas = value; }
    }
    public string ApellidoJugador
    {
        get { return this.iApellidoJugador; }
        set { this.iApellidoJugador = value; }
    }
    public string Palabra
    {
        get { return this.iPalabra; }
        set { this.iPalabra = value; }
    }
    public string PalabraEnEjecucion
    {
        get { return this.iPalabraEnEjecucion; }
        set { this.iPalabraEnEjecucion = value; }
    }
    public DateTime FechaInicio
    {
        get { return this.iFechaInicio; }
        private set { this.iFechaInicio = value; }
    }
    public DateTime FechaFin
    {
        get { return this.iFechaFin; }
        set { this.iFechaFin = value; }
    }
    public bool Winner
    {
        get { return this.iWinner; }
        set { this.iWinner = value; }
    }
    public TimeSpan Duracion
    {
        get { return iDuracion = iFechaFin - iFechaInicio; }
    }
    public int MaxMistakes
    {
        get { return this.iMaxMistakes; }
        set { this.iMaxMistakes = value; }
    }
}

