using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortThreeNumbers
{
    class Program
    {
        public void sortThreeNumbers(int a, int b, int c)
        {
            if ((a >= b)&&(b >= c))
            { 
                Console.WriteLine( a);
                Console.WriteLine(b);

            }
            else if (b<c){
                Console.WriteLine(b);
            }else
            {
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            

            Program p = new Program();
            p.sortThreeNumbers(65, 23, 54);
            //Console.WriteLine(p);
           
          //  p.sortThreeNumbers(12, 32, 23);
            //a.sortThreeNumbers(20, 122, 23);
        }

    }
    

}

    


