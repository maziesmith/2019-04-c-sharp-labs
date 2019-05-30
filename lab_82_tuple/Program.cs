using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_82_tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis();
            Console.WriteLine($"AlsoDoThis = {AlsoDoThis()}");

            int output = AndThis(out string y);

            Console.WriteLine($"AndThis : {output,-10}{y}");

            var output2 = TupleThis();
            Console.WriteLine(output2.Item1);
            Console.WriteLine(output2.Item2);
        }

        static void DoThis() {
            Console.WriteLine("I am doing nothing");
        }

        static int AlsoDoThis()
        {
            return -1;
        }

        static int AndThis(out string y)
        {
            y = "returning this string";
            return -100;
        }

        static (int,string) TupleThis()
        {
            return (22, "and some text");
        }


    }
}
