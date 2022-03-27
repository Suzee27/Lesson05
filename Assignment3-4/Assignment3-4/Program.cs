using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // Assignment 3
            dynamic y, n;
            dynamic l, s;
            dynamic f, w;

            // y = l - ((f ^ n((s * l / f) + (20 / f) ^ w) / 20));

            // Assignment 4
            int a = 10;
            int b = 20;
            int c = 30;
            bool check;

            check = a == b && c > (a + b - c) && (c - b) == a;

            Console.WriteLine(check);
            Console.ReadKey();
        }
    }
}
