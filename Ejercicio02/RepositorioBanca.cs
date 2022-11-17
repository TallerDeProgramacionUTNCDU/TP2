using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class RepositorioBanca
    {
        private List<Banca> iRepositorioBanca = new List<Banca>();

        public Banca Obtener(double pNumero)
        {

            return iRepositorioBanca.Find(banca => banca.Numero == pNumero);
        }

        public void Agregar(Banca pBanca)
        {
            iRepositorioBanca.Add(pBanca);
        }

    }
}
