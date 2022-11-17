using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class LugarEstacionamiento
{
	private String iCodigo;
	private AutoEstacionado iAutoEstacionado;
	public LugarEstacionamiento(String pCodigo)
	{
		iCodigo = pCodigo;
	}
	public String Codigo
		{
		get {return this.iCodigo;}
		set { this.iCodigo = value; }
            }
    public AutoEstacionado AutoEstacionado
    {
        get { return this.iAutoEstacionado; }
        set { this.iAutoEstacionado = value; }
    }

}
