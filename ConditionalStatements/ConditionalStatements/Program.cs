using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of c: ");
            double c = double.Parse(Console.ReadLine());

            double roots = Math.Pow(b, 2) - (4 * a * c);
            switch (roots)
            {
                case > 0:
                    Console.WriteLine("real roots");
                    break;
                case < 0:
                    Console.WriteLine("complex roots");
                    break;
                default:
                    Console.WriteLine("equal roots");
                    break;
            }

            Console.ReadKey();
        }
        void IfStatement2()
        {
            // Assignment 6

            Console.Write("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of c: ");
            double c = double.Parse(Console.ReadLine());

            double roots = Math.Pow(b, 2) - (4 * a * c);

            if (roots > 0)
            {
                Console.Write("real roots");
            }
            else if (roots < 0)
            {
                Console.Write("complex roots");
            }
            else
            {
                Console.Write("equal roots");
            }
        }
        void IfStatement1()
        {
            //Assignment 5
            double a = 1;
            double b = 6;
            double c = 5;
            double roots = Math.Pow(b, 2) - (4 * a * c);

            if (roots > 0)
            {
                Console.Write("real roots");
            }
            else if (roots < 0)
            {
                Console.Write("complex roots");
            }
            else
            {
                Console.Write("equal roots");
            }
        }

        void SwitchStameent1()
        {
            double a = 1;
            double b = 6;
            double c = 5;
            double roots = Math.Pow(b, 2) - (4 * a * c);

            switch (roots)
            {
                case > 0:
                    Console.WriteLine("real roots");
                    break;
                case < 0:
                    Console.WriteLine("complex roots");
                    break;
                default:
                    Console.WriteLine("equal roots");
                    break;
            }
        }
    }
}
