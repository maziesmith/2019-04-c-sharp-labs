using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_19_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // SAFE CASTING

            int i = 10;
            double d = i;


            // EXPLICIT (DANGEROUS) CASTING
            double dd = 10.79;
            int ii = (int)dd;
            Console.WriteLine(ii);

        }
    }
}
