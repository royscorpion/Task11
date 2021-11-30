using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinEq linear = new LinEq { k = 1, b = 0 };
            linear.Root();
        }
        struct LinEq
        {
            public double k;
            public double b;

            public void Root()
            {
                Console.WriteLine("x = {0}", (-b) / k);
            }
        }
    }
}
