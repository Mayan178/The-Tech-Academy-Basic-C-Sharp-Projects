using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathsOperations
    {
        //method to multiply number supplied by the user by 100
        public static int CalculateNumbers(int userNumber)
        {
            int MultiplyResult = userNumber * 100;
            return MultiplyResult;
        }

        //method to substract 10 to a decimal number provided by the user
        public static int CalculateNumbers(decimal userNumberDec)
        {
            decimal SubstractResult = userNumberDec - 10;
            int newSubstractResult = Convert.ToInt32(SubstractResult);
            return newSubstractResult;
        }

        //method to add 20 to one provided by the user as a string
        public static int CalculateNumbers(string userNumberStr)
        {
            int userNumberasInt = Convert.ToInt32(userNumberStr);

            int AddResult = userNumberasInt + 20;
            return AddResult;
        }

    }
}
