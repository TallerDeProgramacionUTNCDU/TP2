using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Circulo
{
    private double iRadio;
    private Punto iCentro;
    // -iCentro:Punto;
    public Circulo(double X, double Y, double pRadio)
    {
        iCentro = new Punto(X, Y);
        iRadio = pRadio;

    }
    public Circulo(Punto pCentro, double pRadio)
    {
        iCentro = pCentro;
        iRadio = pRadio;
    }
    public Punto Centro
    {
        get { return this.iCentro; }
        private set { this.iCentro = value; }
    }   
    public double Radio
    {
        get { return this.iRadio; }
        private set { this.iRadio = value; }
    }
    public double Area
    {
        get { return Math.PI * Math.Pow(iRadio, 2); }
    }
    public double Perimetro
    {
        get { return 2 * Math.PI * iRadio; }
    }

}