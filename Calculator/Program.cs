using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simple Calculator that deals with the operand + - / *

            //first number to be used
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToInt32(Console.ReadLine());

            //second number to be used
            Console.WriteLine("Enter second number"  );
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************");

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2) );
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
           
        }
    }
}
