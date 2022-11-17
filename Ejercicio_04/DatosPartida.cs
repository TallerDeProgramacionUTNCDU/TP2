using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
public class DatosPartida
{
	private int iIdPartidaDato;
	private string iPalabraDato;
	private string iApellidoDato;
	private string iNombreDato;
	private bool iGanadoDato;
    private TimeSpan iDuracionDato;
    public DatosPartida(int iIdPartidaDato, string iPalabraDato, string iApellidoDato, string iNombreDato, bool iGanadoDato, TimeSpan iDuracionDato)
	{
		this.iIdPartidaDato = iIdPartidaDato;
		this.iPalabraDato = iPalabraDato;
		this.iApellidoDato = iApellidoDato;
		this.iNombreDato = iNombreDato;
		this.iGanadoDato = iGanadoDato;
		this.iDuracionDato = iDuracionDato;
	}
    public int IdPartidaDato
    {
        get { return this.iIdPartidaDato; }
        set { this.iIdPartidaDato = value; }

    }
    public string PalabraDato
    {
        get { return this.iPalabraDato; }
        set { this.iPalabraDato = value; }
    }
    public string ApellidoDato
    {
        get { return this.iApellidoDato; }
        set { this.iApellidoDato = value; }
    }
    public string NombreDato
    {
        get { return this.iNombreDato; }
        set { this.iNombreDato = value; }
    }
    public bool GanadoDato
    {
        get { return this.iGanadoDato; }
        set { this.iGanadoDato = value; }
    }
    public TimeSpan DuracionDato
    {
        get { return this.iDuracionDato; }
        set { this.iDuracionDato = value; }
    }
}
