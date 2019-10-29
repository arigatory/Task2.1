using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1,2);
            Complex c2 = new Complex(3,4);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine(c1+c2);
            Complex c3 = new Complex(2, 0);
            Complex c4 = new Complex(3);
            Console.WriteLine(c3*c4);

            Console.ReadLine();
        }
    }
}
