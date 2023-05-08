using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathsOps
    {
        //method to add 50 to the number entered by the user
        public static int AddNumbers(int userNumber)
        {
            int AddResult = userNumber + 50;
            return AddResult;
        }

        //method to substract 10 from the number entered by the user
        public static int SubstractNumbers(int userNumber)
        {
            int SubstractResult = userNumber - 10;
            return SubstractResult;
        }

        //method to multiply the number entered by the user by 30
        public static int MultiplyNumbers(int userNumber)
        {
            int MultiplyResult = userNumber * 30;
            return MultiplyResult;
        }
    }
}
