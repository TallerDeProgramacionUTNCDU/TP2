using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Moneda
    {
        private string iCodigoISO;
        private string iNombre;
        private string iSimbolo;

        public Moneda(string pCodigoISO, string pNombre, string pSimbolo) 
        {
            this.iCodigoISO = pCodigoISO;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        public string CodigoISO
        {
            get { return this.iCodigoISO; }
            set { this.CodigoISO = value; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.Nombre = value; }
        }

        public string Simbolo
        {
            get { return this.iSimbolo; }
            set { this.Simbolo = value; }
        }


    }
}
