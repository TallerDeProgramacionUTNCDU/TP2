using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Punto
{
    private double iX;
    private double iY;

    public Punto(double px, double py)
    {
        iX = px;
        iY = py;
    }
    public double X
    {
        get { return this.iX; }
        set { this.iX = value; }
    }
    public double Y
    {
        get { return this.iY; }
        set { this.iY = value; }
    }
    public double CalcularDistanciaDesde(Punto pPunto)
    {
        return Math.Sqrt((Math.Pow((pPunto.X - iX),2) + Math.Pow((pPunto.Y - iY),2)));
    }
}