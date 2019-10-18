using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Complex
    {
        private double re;
        private double im;

        public double Re { get; set; }
        public double Im { get; set; }
        public double Phi { get; set; }
        public double R { get; set; }

        public double Abs
        {
            get { return Math.Sqrt(Re * Re + Im * Im); }
        }
    }
}
