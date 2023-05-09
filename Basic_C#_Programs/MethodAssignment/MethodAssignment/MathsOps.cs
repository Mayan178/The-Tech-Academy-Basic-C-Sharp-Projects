using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class MathsOps
    {
        //method called when user has entered 2 seperate numbers
        public static int AddTwoNumbers(int numberOne, int numberTwo = 100)
        {
            int myResult = numberOne + numberTwo;
            return myResult;
        }

    }
}
