using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Repositorio
{
    private LugarEstacionamiento[] lugares = new LugarEstacionamiento[10];
    public Repositorio()
    {
        for (int i = 0; i < lugares.Length; i++)
        {
            lugares[i] = new LugarEstacionamiento("100" + i);
        }
    }
    public List<String> ListaDeLugares()
    {
        List<String> lugaresDisponibles = new List<String>();
        for (int j = 0; j < lugares.Length; j++)
        {
            if (lugares[j].AutoEstacionado is null)
            {
                lugaresDisponibles.Add(lugares[j].Codigo);
            }
        }
        return lugaresDisponibles;
    }
    public bool HayLugaresDisponibles()
    {
        int ocupados=0;
        for (int z = 0; z < lugares.Length;z++)
        {
            if (lugares[z].AutoEstacionado is not null) { ocupados = ocupados+1; }
        }
        if (lugares.Length > ocupados ) { return true; }
        else { return false; }
    }
    public bool ExisteLugar(string pLugarBuscado)
    {
        if (lugares.Any(x => x.Codigo == pLugarBuscado)) { return true; }
        else { return false; }
    }
    public bool EstaEstacionado(string pPatente)
    {
        var estacionado = false;
        for (int j = 0; j < lugares.Length; j++)
        {
            if (lugares[j].AutoEstacionado is not null && lugares[j].AutoEstacionado.Patente == pPatente)
            { 
                    estacionado = true;
                }
        }
        return estacionado;
    }
    public AutoEstacionado ObtenerAutoDesdePatente(string pPatente)
    {
        AutoEstacionado encontrado = new AutoEstacionado("0000", "AAAA", DateTime.Now);
        for (int j = 0; j < lugares.Length; j++)
        {
            if (lugares[j].AutoEstacionado is not null && lugares[j].AutoEstacionado.Patente == pPatente) {encontrado= lugares[j].AutoEstacionado; }
        }
        return encontrado;
    }
    public bool AgregarEstacionamiento(string pPatente, string pCodigoE, DateTime pFechaHoraIni)
    {
        var exito = false;
        for (int k = 0; k < lugares.Length; k++)
        {
            if (pCodigoE == lugares[k].Codigo)
            {
                var nuevoAutoE = new AutoEstacionado(pPatente, pCodigoE, pFechaHoraIni);
                lugares[k].AutoEstacionado = nuevoAutoE;
                exito = true;
            };
        }
        return exito;
    }
    public double RetirarAutoEstacionado(AutoEstacionado auto, DateTime fechaRetiro)
    {
        for (int k = 0; k < lugares.Length; k++)
        {
            if (lugares[k].AutoEstacionado is not null && lugares[k].AutoEstacionado.Patente == auto.Patente)
            {
                lugares[k].AutoEstacionado = null;
            };
        }
        return (auto.CobrarEstacionamiento(fechaRetiro));
    }

}