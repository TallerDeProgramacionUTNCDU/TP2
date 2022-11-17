using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

public class Triangulo
{
    private Punto iPunto1;
    private Punto iPunto2;
    private Punto iPunto3;

    public Triangulo (Punto pPunto1, Punto pPunto2, Punto pPunto3)
    {
        iPunto1 = pPunto1;
        iPunto2 = pPunto2;
        iPunto3 = pPunto3;
    }
    public Punto Punto1
    {
        get { return this.iPunto1; }
        private set { this.iPunto1 = value; }
    }

    public Punto Punto2
    {
        get { return this.iPunto2; }
        private set { this.iPunto2 = value; }
    }

    public Punto Punto3
    {
        get { return this.iPunto3; }
        private set { this.iPunto3 = value; }
    }
    public double Area
    {
        //return iPunto2.CalcularDistanciaDesde(iPunto1) * (Math.Sqrt(Math.Pow(iPunto3.CalcularDistanciaDesde(iPunto1), 2) - Math.Pow((iPunto2.CalcularDistanciaDesde(iPunto1) / 2), 2))) / 2;

        get { return Math.Sqrt(
            ((iPunto2.CalcularDistanciaDesde(iPunto1) + iPunto3.CalcularDistanciaDesde(iPunto1) + iPunto2.CalcularDistanciaDesde(iPunto3))/2) * (((iPunto2.CalcularDistanciaDesde(iPunto1) + iPunto3.CalcularDistanciaDesde(iPunto1) + iPunto2.CalcularDistanciaDesde(iPunto3))/2)-(iPunto2.CalcularDistanciaDesde(iPunto1))) * (((iPunto2.CalcularDistanciaDesde(iPunto1) + iPunto3.CalcularDistanciaDesde(iPunto1) + iPunto2.CalcularDistanciaDesde(iPunto3))/2)-(iPunto3.CalcularDistanciaDesde(iPunto1))) * (((iPunto2.CalcularDistanciaDesde(iPunto1) + iPunto3.CalcularDistanciaDesde(iPunto1) + iPunto2.CalcularDistanciaDesde(iPunto3))/2)-(iPunto2.CalcularDistanciaDesde(iPunto3))));
            }
        }
     public double Perimetro
    {
    get { return iPunto2.CalcularDistanciaDesde(iPunto1) + iPunto3.CalcularDistanciaDesde(iPunto1) + iPunto2.CalcularDistanciaDesde(iPunto3); }
    }

}