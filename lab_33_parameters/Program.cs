using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_33_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(10, "hello world");
            var listOutput = BuildAList(100, 200, 300); // using list
            listOutput.ForEach(item => Console.WriteLine(item));
        }

        static void DoThis(int x, string y)
        {
            Console.WriteLine(x + " " + y);
        }

        static List<int> BuildAList(int x, int y, int z)
        {
            var list = new List<int>();
            list.Add(x);
            list.Add(y);
            list.Add(z);
            return list;
        }

    }
}
