using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssgntSub
{
    class MathsOps
    {
        //setting up a void method that takes in 2 integers as parameters (we are setting default values for those 2 integers)
        public static void TakeAwaySixty(int numberOne = 50, int numberTwo = 100)
        {
            //do an operation on the first number
            int myResult = numberOne - 60;
            //display the second number to the screen
            Console.WriteLine("Your second number is " + numberTwo);
            return;
        }
    }
}
