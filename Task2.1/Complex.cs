using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Complex
    {
        private static readonly double epsilon = 1e-4;
        public double Re { get; set; }
        public double Im { get; set; }

        public double Arg
        {
            get { return Math.Atan2(Im, Re); }
        }

        public double Radius
        {
            get { return Abs; }
        }

        public Complex(double re = 0, double im = 0)
        {
            Re = re;
            Im = im;
        }

        public static Complex CreateByRadiusAndArgument(double radius, double angle)
        {
            return new Complex(radius * Math.Cos((angle)), radius * Math.Sin(angle));
        }

        public override string ToString()
        {
            string res = "";
            if (Math.Abs(Re) < epsilon && Math.Abs(Im) < epsilon)
            {
                res = "0";
            }
            else if (Math.Abs(Re) < epsilon)
            {
                if (Math.Abs(Im) - 1 < epsilon)
                    return Im > 0 ? "i" : "-i";
                else
                    return $"{Im:0.##}i";
            }
            else if (Math.Abs(Im) < epsilon)
            {
                res += $"{Re:0.##;-0.##;0}";
            }
            else
            {
                res += $"{Re:0.##} ";
                if (Im < 0)
                    res += (Math.Abs(Im) - 1 < epsilon) ? $"- i" : $"- {Math.Abs(Im):0.##}i";
                else
                    res += (Math.Abs(Im) - 1 < epsilon) ? $"+ i" : $"+ {Im:0.##}i";
            }

            return res;
        }

        public double Abs
        {
            get { return Math.Sqrt(Re * Re + Im * Im); }
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Re - c2.Re, c1.Im - c2.Im);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c1.Im * c2.Re);
        }

        public static Complex Reciprocal(Complex c)
        {
            double rScr = c.Re * c.Re + c.Im * c.Im;
            return new Complex(c.Re / rScr, -c.Im / rScr);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            return c1 * Complex.Reciprocal(c2);
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1?.Equals(c2) ?? c2 is null;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex c)
            {
                return Math.Abs(Re - c.Re) < epsilon && Math.Abs(Im - c.Im) < epsilon;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Re.GetHashCode() ^ Im.GetHashCode();
        }

        public static Complex operator -(Complex c)
        {
            return c is null ? null : new Complex(-c.Re,-c.Im);
        }

        public static explicit operator double(Complex C)
        {
            return C?.Radius ?? double.NaN;
        }

        public static implicit operator Complex(double d)
        {
            return new Complex(d);
        }
    }
}
