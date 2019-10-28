using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Complex
    {
        private readonly double epsilon = 1e-4;
        public double Re { get; set; }
        public double Im { get; set; }
        public double Phi { get; set; }
        public double R { get; set; }

        public Complex(double re = 0, double im = 0)
        {
            Re = re;
            Im = im;
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
                if (Math.Abs(Im) -1< epsilon)
                    return Im > 0 ? "i" : "-i";
                else
                    return $"{Im}";
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
    }
}
