using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string worldVariable = "World";
            
            Console.WriteLine("Hello, " + worldVariable + "!");

            // Data types

            char grade = 'S';
            int score = 10;
            // float, double, decimal. From least accurate to most.
            double pi = 3.1416;
            bool isValid = true;

            Console.WriteLine(grade);
            Console.WriteLine(score);
            Console.WriteLine(pi);
            Console.WriteLine(isValid);
            Console.WriteLine(worldVariable.Length);

            Console.ReadLine();
        }
    }
}
