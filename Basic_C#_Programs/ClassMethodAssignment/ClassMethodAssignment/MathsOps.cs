using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public static class MathsOps
    {
        //setting up a void method that takes in an integer (default being set to 50)
        public static void DividebyTwo(int myNumber = 50)
        {
            //divide user number by 2
            int myResult = myNumber / 2;
            //display the result to the screen
            Console.WriteLine(myResult);
            return;
        }

        //for working out squares
        public static int CalculateShape(int length, out int area)
        {
            int perimeter = length * 4;
            int myarea = length * length;
            area = myarea;
            return perimeter;
        }

        //for working out rectangles...method overloading
        public static int CalculateShape(int shortlen, int longlen, out int area)
        {
            int perimeter = shortlen * 2 + longlen * 2;
            int myarea = shortlen * longlen;
            area = myarea;
            return perimeter;
        }

    }
}
