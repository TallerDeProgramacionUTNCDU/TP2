using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class AutoEstacionado
{
	private string iPatente;
	private string iCodigoEstacionamiento;
	private DateTime iFechaHoraInicio;
	private DateTime iFechaHoraFin;
	public AutoEstacionado(string pPatente, string pCodigoEstacionamiento, DateTime pFechaHoraInicio)
	{
		iPatente = pPatente;
		iCodigoEstacionamiento = pCodigoEstacionamiento;
		iFechaHoraInicio = pFechaHoraInicio;
	}
    public double CobrarEstacionamiento(DateTime pFechaHoraFin)
    {
        var ts = Math.Abs((pFechaHoraFin - iFechaHoraInicio).TotalHours);
        return ts*200 ; 
    }
    public String Patente
    {
        get { return this.iPatente; }
        private set { this.iPatente = value; }
    }
    public String CodigoEstacionamiento
    {
        get { return this.iCodigoEstacionamiento; }
        private set { this.iCodigoEstacionamiento = value; }
    }
    public DateTime FechaHoraInicio
    {
        get { return this.iFechaHoraInicio; }
        private set { this.iFechaHoraInicio = value; }
    }
    public DateTime FechaHoraFin
    {
        get { return this.iFechaHoraFin; }
        private set { this.iFechaHoraFin = value; }
    }
}
