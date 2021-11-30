using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructEquation;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения вида 0 = kx+b");
            Console.Write("Введите коэффициент k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            LinearEquation linear = new LinearEquation(k, b);
            linear.Root();
            Console.ReadKey();

        }
    }
}
