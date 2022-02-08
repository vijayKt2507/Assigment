using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    class Program
    {
        public static void Fibonacci_Iterative(int index)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < index; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("enter from value:");
          int  index = Convert.ToInt32(Console.ReadLine());
            Fibonacci_Iterative(index);
            Console.ReadLine();
          
        }
    }
}
