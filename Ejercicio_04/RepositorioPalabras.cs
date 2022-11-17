using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

public class RepositorioPalabras
{
	public List<string> palabras;
	public RepositorioPalabras()
	{
		string[] total = {"gato","perro","escuela","computadora","insurreccion",                            "smartphone","abducir","rompecabezas","informacion","google",
							"motor","stack","hospital","reciclable","ingenieria",
							"sistemas","civil","electromecanica","universidad","carrera",
							"licenciatura","organizacion","postgrado","taller","programacion",
						"analista","institucion","conmemoracion","proyecto","exposicion",};
		palabras= new List<string>(total);

	}
	public string PalabraAleatoria()
	{
        Random r = new Random();
        int rInt = r.Next(0, 30);
        return palabras.ElementAt(rInt);
    }

}
