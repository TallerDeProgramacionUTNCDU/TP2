using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Pantallas
    {
        public static void PantallaCrearCuenta()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su numero de DNI: ");
            double dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre: ");
            string nombreTitular = Console.ReadLine();
            Fachada.CrearBanca(dni, nombreTitular);
            Console.WriteLine("Cuenta creada con éxito!! ");
            Console.ReadKey();
        }

        public static void PantallaConsultarSaldos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su numero de DNI: ");
            double dni = Convert.ToInt32(Console.ReadLine());
            if (Fachada.Existe(dni))
            {
                double saldoPesos = Fachada.MostrarSaldoPesos(dni);
                double saldoDolares = Fachada.MostrarSaldoDolares(dni);
                Console.WriteLine("Su saldo en pesos es de: $" + saldoPesos);
                Console.WriteLine("Su saldo en dólares es de: " + saldoDolares);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El DNI: " + Convert.ToString(dni) + " no está asociado a ninguna cuenta");
                Console.ReadKey();
            }
        }

        public static void PantallaDebitar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su numero de DNI: ");
            double dni = Convert.ToInt32(Console.ReadLine());
            if (Fachada.Existe(dni))
            {
                Console.WriteLine("1- Debito en pesos ");
                Console.WriteLine("2- Debito en dólares ");
                Console.WriteLine("0- Salir ");
                string opcion = Console.ReadKey().KeyChar.ToString();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el monto a debitar: ");
                        double montoPesos = Convert.ToInt32(Console.ReadLine());
                        if (Fachada.DebitoPesos(dni, montoPesos))
                        {
                            double nuevoSaldoPesos = Fachada.MostrarSaldoPesos(dni);
                            Console.WriteLine("Saldo debitado \n" +
                                "Su nuevo saldo en pesos es de: " + nuevoSaldoPesos);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para debitar");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el monto a debitar: ");
                        double montoDolares = Convert.ToInt32(Console.ReadLine());
                        if (Fachada.DebitoDolares(dni, montoDolares))
                        {
                            double nuevoSaldoDolares = Fachada.MostrarSaldoDolares(dni);
                            Console.WriteLine("Saldo debitado \n" +
                                "Su nuevo saldo en dolares es de: " + nuevoSaldoDolares);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para debitar");
                            Console.ReadKey();
                        }
                        break;

                    case "0":
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion válida: ");
                        break;
                }
            }

            else
            {
                Console.WriteLine("El DNI: " + Convert.ToString(dni) + " no está asociado a ninguna cuenta");
                Console.ReadKey();
            }


        }

        public static void PantallaAcreditar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su numero de DNI: ");
            double dni = Convert.ToInt32(Console.ReadLine());

            if (Fachada.Existe(dni))
            {
                Console.WriteLine("1- Acreditar en pesos ");
                Console.WriteLine("2- Acreditar en dólares ");
                Console.WriteLine("0- Salir ");
                string opcion = Console.ReadKey().KeyChar.ToString();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el monto a acreditar: ");
                        double montoPesos = Convert.ToInt32(Console.ReadLine());
                        Fachada.CreditoPesos(dni, montoPesos);
                        double nuevoSaldoPesos = Fachada.MostrarSaldoPesos(dni);
                        Console.WriteLine("Saldo acreditado \n" +
                            "Su nuevo saldo en pesos es de: " + nuevoSaldoPesos);
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el monto a acreditar: ");
                        double montoDolares = Convert.ToInt32(Console.ReadLine());
                        Fachada.CreditoDolar(dni, montoDolares);
                        double nuevoSaldoDolares = Fachada.MostrarSaldoDolares(dni);
                        Console.WriteLine("Saldo acreditado \n" +
                             "Su nuevo saldo en dolares es de: " + nuevoSaldoDolares);
                        Console.ReadKey();
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion válida: ");
                        break;
                }
            }

            else
            {
                Console.WriteLine("El DNI: " + Convert.ToString(dni) + " no está asociado a ninguna cuenta");
                Console.ReadKey();
            }
        }

        public static void PantallaCompraVentaDolares()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su numero de DNI: ");
            double dni = Convert.ToInt32(Console.ReadLine());
            if (Fachada.Existe(dni))
            {
                Console.WriteLine("Precio actual del dolar Compra/Venta: "+ Fachada.DOLAR+ " pesos argentinos");
                Console.WriteLine("1- Comprar dolares ");
                Console.WriteLine("2- Vender dolares ");
                Console.WriteLine("0- Salir ");
                string opcion = Console.ReadKey().KeyChar.ToString();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese la cantidad de dolares que desea comprar");
                        double montoCompra = Convert.ToInt32(Console.ReadLine());
                        if (Fachada.ComprarDolares(dni, montoCompra))
                        {
                            double nuevoSaldoPesos = Fachada.MostrarSaldoPesos(dni);
                            double nuevoSaldoDolares = Fachada.MostrarSaldoDolares(dni);
                            Console.WriteLine("Su compra fue realizada con éxito \n" +
                                "Su nuevo saldo en pesos es de: " + nuevoSaldoPesos + "\n" +
                                "Su nuevo saldo en dolares es de: " + nuevoSaldoDolares);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para realizar la compra.");
                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        Console.WriteLine("Ingrese la cantidad de dolares que desea vender");
                        double montoVenta = Convert.ToInt32(Console.ReadLine());
                        if (Fachada.VenderDolares(dni, montoVenta))
                        {
                            double nuevoSaldoPesos = Fachada.MostrarSaldoPesos(dni);
                            double nuevoSaldoDolares = Fachada.MostrarSaldoDolares(dni);
                            Console.WriteLine("Su compra fue realizada con éxito \n" +
                                "Su nuevo saldo en pesos es de: " + nuevoSaldoPesos + "\n" +
                                "Su nuevo saldo en dolares es de: " + nuevoSaldoDolares);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para realizar la venta.");
                            Console.ReadKey();
                        }
                        break;
                }
            }

            else
            {
                Console.WriteLine("El DNI: "+Convert.ToString(dni)+" no está asociado a ninguna cuenta");
                Console.ReadKey();
            }
        }
    }






















    }

