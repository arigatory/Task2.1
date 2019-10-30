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
            Console.WriteLine("Демонтрация функционала кода:");
            Console.WriteLine();
            Console.WriteLine("Создаем два числа:");
            Complex c1 = new Complex(21, 2);
            Complex c2 = new Complex(5,1);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine($"Разность двух чисел: {c1 - c2}");
            Console.WriteLine($"Сумма двух чисел: {c2 + 5.0}");
            Console.WriteLine($"Произведение: {c1*c2}");
            Console.WriteLine($"Частное: {c1/c2}");
            Console.WriteLine($"Получение double: {(double)c1}");
            Console.WriteLine($"Сравнение на равенство: {c1==c2}");
            
            Console.ReadLine();
        }
    }
}
