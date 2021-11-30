using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEquation
{
    public class LinEq
    {
        double k;
        double b;
        public double K { get; set; }
        public double B { get; set; }

        public LinEq(double k, double b)
        {
            K = k;
            B = b;
        }

        public void Root()
        {
            Console.WriteLine("x = {0}", (-B) / K);
        }
    }
}

