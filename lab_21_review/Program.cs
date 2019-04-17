﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_21_review
{
    class Program
    {
        static void Main(string[] args)
        {

            // REVIEW OF DAY 2

            // Truth table

            // AND
            Console.WriteLine(1&1);  // true or 1   

            // one & is slower as both sides always checked
            // && faster as second one not always checked 

            Console.WriteLine(true&&false);   // false

            // OR

            Console.WriteLine(false||true);   // true

            // XOR

            Console.WriteLine(true^true);  // false
            Console.WriteLine(true^false);  // true

            // cast
            int i = 7;
            double d = i;  // implicit cast from 7 (int) to double ==> safe cast !! no extra code!!!

            double dd = 1.99;
            int j = (int)dd;   // explicit : lose 0.99

            Console.WriteLine(Math.Round(dd));  // up    ==> also math.floor and math.ceiling 

            Console.WriteLine((int)'j');

            // Box
            object o = i;     // boxing integer inside 'object'
            // unbox
            int jjj = (int)o;

            string x = null;
            int? num1 = null;    // int? is called 'nullable integer'
            int num2 = 0;

            byte b = 255; // highest
            byte bb = 0; // lowest
            byte bbb = 0b10101010;

            char c = 'a';
            // string is array of chars
            string s = "Hello";

            foreach (char cc in s)
            {
                Console.Write(cc);
            }
                
            Console.WriteLine("HI");

            // strings as an array

            // strings also can be viewed as an ARRAY OF CHARACTERS WITH [0] TERMINOLOGY
            string myString = "Some data";
            Console.WriteLine(myString.Length);
            // first char
            Console.WriteLine(myString[0]);
            // second char
            Console.WriteLine(myString[1]);
            // .. last char
            Console.WriteLine(myString[myString.Length-1]);    // 9-1=8

            // winforms

            // wpf form

            var d01 = new DateTime();
            var d02 = DateTime.Now;
            var d03 = DateTime.Today;

            var s01 = new System.Diagnostics.Stopwatch();
            s01.Start();
            s01.Stop();




        }
    }
}
