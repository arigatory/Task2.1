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
            Complex c1 = new Complex(-1,-1);
            Complex c2 = new Complex(3,4);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c1.Abs);
            Console.WriteLine(c2.Abs);
            for (int i = 0; i < 10; i++)
            {
                int r = int.Parse(Console.ReadLine());
                int im = int.Parse(Console.ReadLine());
                Complex c = new Complex(r,im);
                Console.WriteLine(c);

            }
            Console.ReadLine();
        }
    }
}
