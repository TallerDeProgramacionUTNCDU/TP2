//Ejercicio 03

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
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
                Console.WriteLine("SISTEMA DE GESTION DE ESTACIONAMIENTOS");
                Console.WriteLine("Listado de lugares disponibles");
                var lista= fachada.LugaresDisponibles();
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.Write(" "+ lista[i].ToString()); ;
                }
                Console.WriteLine("");
                Console.WriteLine("OPCIONES: ");
                Console.WriteLine("     1)_ Ingresar Auto en un lugar del Estacionamiento");
                Console.WriteLine("     2)_ Retirar Auto del Estacionamiento");
                Console.WriteLine("     0)_ Salir");
                Console.Write("Ingresar opción: ");
                opcion = Console.ReadLine();
                switch (opcion) { 
                     case "1":
                        var hayLugaresDisp = fachada.ExistenLugaresDisponibles();
                        if (hayLugaresDisp == true)
                        {
                            Console.Write("Ingrese la patente del auto a estacionar: ");
                            string pPatente = Console.ReadLine();
                            var yaEstacionado = fachada.AutoEstaEstacionado(pPatente);
                            if (yaEstacionado == false)
                            {
                                Console.Write("Ingrese el codigo del estacionamiento deseado: ");
                                string pCodigo = Console.ReadLine();
                                var existeL = fachada.VerificarExisteLugar(pCodigo);
                                if (existeL == true)
                                {
                                   // Console.Write("Ingrese la fecha y hora desde que se estaciona el auto (yyyy-mm-dd hh:mm): ");
                                    //string pSFechaIni = Console.ReadLine();
                                    //DateTime pFechaIni = DateTime.ParseExact(pSFechaIni, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                                    var success=fachada.AgregarAutoAEstacionamiento(pPatente, pCodigo, DateTime.Now);
                                    if (success == true) { Console.WriteLine("AGREGADO EXITOSAMENTE"); Console.ReadLine(); }
                                    else { Console.WriteLine("ERROR AL AGREGAR"); Console.ReadLine(); }
                                }
                                else { Console.WriteLine("NO EXISTE EL LUGAR INGRESADO PORFAVOR INTENTE NUEVAMENTE"); Console.ReadLine(); break; }
                            }
                            else { Console.WriteLine("LA PATENTE INGRESADA YA SE ENCUENTRA ESTACIONADA, INTENTE UNA PATENTE DISTINTA"); Console.ReadLine(); }
                        }
                            else { Console.WriteLine("NO HAY LUGARES DISPONIBLES, RETIRE UN AUTO O AGUARDE A QUE SE DESOCUPE UN LUGAR"); Console.ReadLine();break; }
                        break;
                    case "2":
                            Console.Write("Ingrese la patente del auto a retirar: ");
                            string pRPatente= Console.ReadLine();
                            var estaEstacionado = fachada.AutoEstaEstacionado(pRPatente);
                            if (estaEstacionado == false) {Console.WriteLine("LA PATENTE INGRESADA NO SE ENCUENTRA EN EL ESTACIONAMIENTO INGRESE UNA PATENTE DISTINTA"); Console.ReadLine(); }
                            else {
                            var costo= fachada.CobrarYRetirarAutoDeEstacionamiento(pRPatente);
                            Console.WriteLine("El costo del estacionamiento es de: $" + costo);
                            Console.ReadLine();
                                     }
                        break;
                }
            }
        while (opcion != "0");
        }
    }
}
