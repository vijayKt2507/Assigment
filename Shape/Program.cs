using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Shape
    {

        private string color;
        private Boolean filled;
        public Shape()
        {
            filled = true;
            color = "green";
        }
        public Boolean isFilled()
        {
            if (filled == true)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        



    }
    class circle : Shape
    {
       double b = 3.15;
        

        public void  AreaOfCircle(int A)
        {
          // A=πr2
        

        }
     }
    class Rectangle:Shape
    {
        public void AreaOfrRectagle(int len,int width)
        {

            int AreaRectagle = len * width;
        }

    }
    class Square
    {
        public void AreaOfSquare(int a)
        {
            int AreaSquare =Convert.ToInt32( Math.Sqrt(a));


        }

    }
    

    }






