using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First application");

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("finished waiting - hit any key");

            Console.WriteLine("Printing out arguments array");
           
            if(args.Length == 0)
            {
                Console.WriteLine("There are no arguments");
            }
            else
            {
                foreach (string item in args)
                {
                    Console.WriteLine("Your item is - " + item);
                }
            }



            Console.ReadLine();


        }
    }
}
