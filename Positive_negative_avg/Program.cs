using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_negative_avg
{
    public class Exercise4
    {
        public static void Main()
        {
            int i, n, sum = 0;
            double avg;

            Console.Write("\n\n");
            Console.Write("Read 10 numbers and calculate sum and average:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
               
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("The Average is : {0}\n", avg);
        }
    }
    //if(check != 0 )
    //        {
    //            i++ ;
    //            if(value >= 0 )
    //            {
    //                positive_count++ ;
    //                sum += value ;
    //            }
    //        }

}
