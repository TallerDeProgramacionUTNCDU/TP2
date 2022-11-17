using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al banco nación \n" +
                "Elija una opcion \n" +
                "1- Crear cuenta en pesos y dolares\n" +
                "2- Consultar saldos \n" +
                "3- Debitar \n" +
                "4- Acreditar \n" +
                "5- Cambiar dolares por pesos y viceversa \n" +
                "0- Salir");
                opcion = Console.ReadKey().KeyChar.ToString();

                switch (opcion)
                {
                    case "1":
                        Pantallas.PantallaCrearCuenta();
                        break;
                    case "2":
                        Pantallas.PantallaConsultarSaldos();
                        break;
                    case "3":
                        Pantallas.PantallaDebitar();
                        break;
                    case "4":
                        Pantallas.PantallaAcreditar();
                        break;
                    case "5":
                        Pantallas.PantallaCompraVentaDolares();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción correcta");
                        break;
                }
            }
            while (opcion != "0");

        }
    }
}

