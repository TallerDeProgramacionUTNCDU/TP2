//Ejercicio 04

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("JUEGO DEL AHORCADO");
                Console.WriteLine("");
                Console.WriteLine("OPCIONES: ");
                Console.WriteLine("     1)_ Iniciar Partida con cantidad estándar de errores(10) ");
                Console.WriteLine("     2)_ Iniciar Partida personalizada con cantidad de errores elegida");
                Console.WriteLine("     3)_ Últimas 5 Partidas con menor duración");
                Console.WriteLine("     0)_ Salir");
                Console.Write("Ingresar opción: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Ingrese su Nombre: ");
                        var nombre= Console.ReadLine();
                        Console.Write("Ingrese su Apellido: ");
                        var apellido = Console.ReadLine();
                        Console.WriteLine("");
                        var partida= fachada.IniciarPartida(nombre,apellido);
                        Console.Clear();
                        Console.WriteLine(fachada.GenerarEspaciosDePalabra(partida));
                        Console.WriteLine("");
                        do
                        { 
                            Console.WriteLine("Errores Disponibles: " +                              fachada.ErroresDisponibles(partida));
                            Console.Write("Letras Acertadas: ");
                            var listaC=fachada.ListadoCorrectas(partida);
                            for (int k = 0; k < listaC.Count; k++)
                            {
                                Console.Write(" - " + listaC.ElementAt(k));
                            }
                            Console.WriteLine("");
                            Console.Write("Letras Incorrectas: ");
                            var listaI= fachada.ListadoIncorrectas(partida);
                            for (int i = 0; i < listaI.Count; i++)
                            {
                                Console.Write(" - " + listaI.ElementAt(i));
                            }
                            Console.WriteLine("");
                            Console.Write("Ingrese una Letra: ");
                            var LETRA= Console.ReadLine();
                            var letra = LETRA.ToLower();
                            var success = fachada.EvaluacionLetraIngresada(partida, letra);
                            Console.Clear();
                            var actualizado=fachada.ActualizarInfoPantalla(partida, letra);
                            Console.WriteLine(actualizado);
                            if (success == true) { Console.WriteLine("LETRA CORRECTA"); }
                            else { Console.WriteLine("LETRA INCORRECTA"); }
                            Console.WriteLine();
                        }
                        while (!fachada.FindePartida(partida));
                        Console.Clear();
                        if (fachada.PartidaGanada(partida) == true) { Console.WriteLine("GANASTE"); Console.ReadLine(); }
                        else {Console.WriteLine("PERDISTE"); Console.ReadLine(); }
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Ingrese su Nombre: ");
                        var nombre2 = Console.ReadLine();
                        Console.Write("Ingrese su Apellido: ");
                        var apellido2 = Console.ReadLine();
                        Console.Write("Ingrese la cantidad máxima de errores: ");
                        int nuevoMax= Int32.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        var partida2 = fachada.IniciarPartida(nombre2, apellido2);
                        fachada.CambiarMaximoErrores(partida2,nuevoMax);
                        Console.Clear();
                        fachada.GenerarEspaciosDePalabra(partida2);
                        Console.WriteLine("");
                        do
                        {
                            Console.WriteLine("Errores Disponibles: " + fachada.ErroresDisponibles(partida2));
                            Console.Write("Letras Acertadas: ");
                            var listadoC=fachada.ListadoCorrectas(partida2);
                            for (int k = 0; k < listadoC.Count; k++)
                            {
                                Console.Write(" - " + listadoC.ElementAt(k));
                            }
                            Console.WriteLine("");
                            Console.Write("Letras Incorrectas: ");
                            var listadoI = fachada.ListadoIncorrectas(partida2);
                            for (int i = 0; i < listadoI.Count; i++)
                            {
                                Console.Write(" - " + listadoI.ElementAt(i));
                            }
                            Console.WriteLine("");
                            Console.Write("Ingrese una Letra: ");
                            var LETRA2 = Console.ReadLine();
                            var letra2 = LETRA2.ToLower();
                            var success = fachada.EvaluacionLetraIngresada(partida2, letra2);
                            Console.Clear();
                            var actualizado = fachada.ActualizarInfoPantalla(partida2, letra2);
                            Console.WriteLine(actualizado);
                            if (success == true) { Console.WriteLine("LETRA CORRECTA"); }
                            else { Console.WriteLine("LETRA INCORRECTA"); }
                            Console.WriteLine();
                        }
                        while (fachada.FindePartida(partida2) == false);
                        Console.Clear();
                        if (fachada.PartidaGanada(partida2) == true) { Console.WriteLine("GANASTE"); Console.ReadLine(); }
                        else { Console.WriteLine("PERDISTE"); Console.ReadLine(); }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("LAS 5 PARTIDAS GANADAS Y DE MENOR DURACION (Nro Partida - Duracion - Nombre y Apellido del Jugador - Palabra)");
                        var lista=fachada.GanadosDeMenorDuracion();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine(lista[i].IdPartidaDato +" "+ lista[i].DuracionDato + " " + lista[i].NombreDato + " " + lista[i].ApellidoDato + " "+ lista[i].PalabraDato);
                        }
                        Console.ReadLine();
                        break;
                }
            }
            while (opcion != "0");
        }
        }
    }

