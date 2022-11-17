using System;

namespace Ejercicio05
{
    class Complejo
    {
        readonly double iReal;
        readonly double iImaginario;

        public Complejo(double pReal, double pImaginario)
        {
            iReal = pReal;
            iImaginario = pImaginario;
        }

        public double Real
        {
            get { return this.iReal; }
        }
        public double Imaginario
        {
            get { return this.iImaginario; }
        }

        public double ArgumentosEnRadianes
        {
            get
            {
                return Math.Atan(iImaginario / iReal);
            }

        }

        public double ArgumentosEnGrados
        {
            get
            {
                return ArgumentosEnRadianes * 180 / Math.PI;
            }
        }

        public Complejo Conjugado
        {
            get
            {
                return new Complejo(iReal, iImaginario * -1);
            }
        }

        public double Magnitud
        {
            get
            {
                return Math.Sqrt(Math.Pow(this.iReal, 2) + Math.Pow(this.iImaginario, 2));
            }

        }

        public bool EsReal()
        {
            return this.iImaginario == 0;
        }
        public bool EsImaginario()
        {
            return this.iImaginario != 0;
        }

        public bool EsIgual(Complejo pComplejo)
        {
            return this.iReal == pComplejo.Real && this.iImaginario == pComplejo.Imaginario;
        }

        public bool EsIgual(double pReal, double pImaginario)
        {
            return this.iReal == pReal && this.iImaginario == pImaginario;
        }

        public Complejo Sumar(Complejo pOtroComplejo)
        {
            double Real = this.iReal + pOtroComplejo.iReal;
            double Imaginario = this.iImaginario + pOtroComplejo.iImaginario;
            return new Complejo(Real, Imaginario);
        }
        public Complejo Restar(Complejo pOtroComplejo)
        {
            double Real = this.iReal - pOtroComplejo.iReal;
            double Imaginario = this.iImaginario - pOtroComplejo.iImaginario;
            return new Complejo(Real, Imaginario);
        }

        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            double Real = this.iReal * pOtroComplejo.iReal;
            double Imaginario = this.iImaginario * pOtroComplejo.iImaginario;
            return new Complejo(Real, Imaginario);
        }
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            double Real = this.iReal / pOtroComplejo.iReal;
            double Imaginario = this.iImaginario / pOtroComplejo.iImaginario;
            return new Complejo(Real, Imaginario);

        }

    }
}