using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_C_to_kelvin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = @"convert celsius to fahrenheit\kelvin";
            Console.WriteLine("enter amount of c elsius to convert:");
            double cels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{cels}celsius in kelvin is {cels + 273}");
            Console.WriteLine();
            Console.WriteLine($"{cels} celsius in fahrenherit is {cels * 9 / 5 + 32}");
            Console.Read();
           
        }
    }
}
