using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Fachada
{
    public Repositorio repositorio;
    public Fachada()
    {
        repositorio = new Repositorio();
    }
    public List<String> LugaresDisponibles()
    {
        return repositorio.ListaDeLugares();
    }
    public bool ExistenLugaresDisponibles()
    {
        return repositorio.HayLugaresDisponibles();
    }
    public bool VerificarExisteLugar(string pCodigo)
    {
        return repositorio.ExisteLugar(pCodigo);
    }
    public bool AgregarAutoAEstacionamiento(string pPatente, string pCodigo, DateTime pfechaIni)
    {
       return repositorio.AgregarEstacionamiento(pPatente, pCodigo, pfechaIni);
    }
    public bool AutoEstaEstacionado(string pPatente)
    {
        return repositorio.EstaEstacionado(pPatente);
    }
    public double CobrarYRetirarAutoDeEstacionamiento(string pPatente)
    {
        var auto= repositorio.ObtenerAutoDesdePatente(pPatente);
        return repositorio.RetirarAutoEstacionado(auto, DateTime.Now);
    }

}   
