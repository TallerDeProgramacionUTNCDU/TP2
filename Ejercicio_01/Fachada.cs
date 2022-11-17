using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Fachada
{
    public double ObtenerDatosCirculoPerimetro(double pX, double pY, double pRadio)
    {
        Circulo Circ = new Circulo(pX, pY, pRadio);
        return Circ.Perimetro; }

    public double ObtenerDatosCirculoArea(double pX, double pY, double pRadio)
    {
        Circulo Circ = new Circulo(pX, pY, pRadio);
        return Circ.Area;
    }
    public double ObtenerDatosTrianguloPerimetro(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
    {
        Punto pPunto1 = new Punto(p1X, p1Y);
        Punto pPunto2 = new Punto(p2X, p2Y);
        Punto pPunto3 = new Punto(p3X, p3Y);
        Triangulo Triag = new Triangulo(pPunto1, pPunto2, pPunto3);
        return Triag.Perimetro;
    }
    public double ObtenerDatosTrianguloArea(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
    {
        Punto pPunto1 = new Punto(p1X, p1Y);
        Punto pPunto2 = new Punto(p2X, p2Y);
        Punto pPunto3 = new Punto(p3X, p3Y);
        Triangulo Triag = new Triangulo(pPunto1, pPunto2, pPunto3);
        return Triag.Area;
    }
    public double CalcularDistanciaEntre2Puntos(double p1X, double p1Y, double p2X, double p2Y)
    {
        Punto pPunto1 = new Punto(p1X, p1Y);
        Punto pPunto2 = new Punto(p2X, p2Y);
        return pPunto1.CalcularDistanciaDesde(pPunto2);
    }
}
