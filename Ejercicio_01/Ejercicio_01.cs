/* Ejercicio 01 TP2*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            string opcion;
            do
            {
                Console.Clear();
                opcion = null;
                Console.Write("Ingrese una opción (C para Círculo, T para triángulo o S para salir):");
                opcion = Console.ReadLine();
                switch (opcion) {
                    case "C":
                        Console.Clear();
                        Console.WriteLine("CÍRCULO");
                        Console.Write("Coordenanda X del punto a utilizar:");
                        double pX = Int32.Parse(Console.ReadLine());
                        Console.Write("Coordenanda Y del punto a utilizar:");
                        double pY = Int32.Parse(Console.ReadLine());
                        Console.Write("Radio:");
                        double pRadio = Int32.Parse(Console.ReadLine());
                        double cPerimetro = fachada.ObtenerDatosCirculoPerimetro(pX, pY, pRadio);
                        double cArea = fachada.ObtenerDatosCirculoArea(pX, pY, pRadio);
                        Console.Write("Ingrese 1 para perímetro o 2 para área: ");
                        string subop = Console.ReadLine();
                        switch (subop)
                        {
                            case "1":
                                Console.Write("Perímetro del Círculo: ");
                                Console.WriteLine(cPerimetro);
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.Write("Área del Círculo: ");
                                Console.WriteLine(cArea);
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case "T":
                        Console.Clear();
                        Console.WriteLine("TRIÁNGULO");
                        Console.WriteLine("Ingrese las coordenadas X e Y del Punto 1: ");
                        double pPunto1X = Int32.Parse(Console.ReadLine());
                        double pPunto1Y = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese las coordenadas X e Y del Punto 2: ");
                        double pPunto2X = Int32.Parse(Console.ReadLine());
                        double pPunto2Y = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese las coordenadas X e Y del Punto 3: ");
                        double pPunto3X = Int32.Parse(Console.ReadLine());
                        double pPunto3Y = Int32.Parse(Console.ReadLine());
                        double tPerimetro = fachada.ObtenerDatosTrianguloPerimetro(pPunto1X, pPunto1Y, pPunto2X, pPunto2Y, pPunto3X, pPunto3Y);
                        double tArea = fachada.ObtenerDatosTrianguloArea(pPunto1X, pPunto1Y, pPunto2X, pPunto2Y, pPunto3X, pPunto3Y);
                        Console.Write("Ingrese 1 para perímetro, 2 para área o 3 para distancia entre 2 puntos: ");
                        string subop2 = Console.ReadLine();
                        switch (subop2)
                        {
                            case "1":
                                Console.Write("Perímetro del Triángulo: ");
                                Console.WriteLine(tPerimetro);
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.Write("Área del Círculo: ");
                                Console.WriteLine(tArea);
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Indique que distancia desea conocer");
                                Console.WriteLine("1-Distancia entre Punto 1 y Punto 2");
                                Console.WriteLine("2-Distancia entre Punto 1 y Punto 3");
                                Console.WriteLine("3-Distancia entre Punto 2 y Punto 3");
                                Console.WriteLine("");
                                string subsub = Console.ReadLine();
                                switch (subsub) {
                                    case "1":
                                        Console.Write("Distancia entre Punto 1 y Punto 2: ");
                                        double d12 = fachada.CalcularDistanciaEntre2Puntos(pPunto1X, pPunto1Y, pPunto2X, pPunto2Y);
                                        Console.WriteLine(d12);
                                        Console.ReadLine();
                                        break;
                                    case "2":
                                        Console.Write("Distancia entre Punto 1 y Punto 3: ");
                                        double d13 = fachada.CalcularDistanciaEntre2Puntos(pPunto1X, pPunto1Y, pPunto3X, pPunto3Y);
                                        Console.WriteLine(d13);
                                        Console.ReadLine();
                                        break;
                                    case "3":
                                        Console.Write("Distancia entre Punto 2 y Punto 3: ");
                                        double d23 = fachada.CalcularDistanciaEntre2Puntos(pPunto2X, pPunto2Y, pPunto3X, pPunto3Y);
                                        Console.WriteLine(d23);
                                        Console.ReadLine();
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            while (opcion != "S");
    }
    }
}