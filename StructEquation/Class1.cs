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

        public double B { get; set; }
        public double K
        {
            set
            {
                if (value != 0)
                {
                    k = value;
                }
                else
                {
                    Console.WriteLine("На ноль делить нельзя!");
                }
            }
            get
            {
                return k;
            }
        }

        public LinEq(double k, double b)
        {
            K = k;
            B = b;
        }

        public void Root()
        {
            if (K != 0) Console.WriteLine("x = {0}", (-B) / K);
        }
    }
}

