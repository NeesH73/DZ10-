using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov12
{
    internal class Complex
    {
        public double Real;
        public double Imaginary;
        public static Complex operator +(Complex c1, Complex c2)
        {
            double real = c1.Real + c2.Real;
            double imaginary = c1.Imaginary + c2.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            double real = c1.Real - c2.Real;
            double imaginary = c1.Imaginary - c2.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            double real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new Complex(real, imaginary);
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.Real != c2.Real || c1.Imaginary != c2.Imaginary;
        }

        public override string ToString()
        {
            if (Imaginary >= 0)
                return $"{Real} + {Imaginary}i";
            else
                return $"{Real} - {Imaginary*(-1)}i";
        }
        

        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
    }
}
