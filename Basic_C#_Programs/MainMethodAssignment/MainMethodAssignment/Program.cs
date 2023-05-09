using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user to input an integer, then we multiply that number by 100 and return it to the user
           
            //using error handling to make sure the user inputs a number and not text
            try
            {
                //asking the user to input a number
                Console.WriteLine("Please enter a number.");
                //storing that number as userNumber
                int userNumber = Convert.ToInt32(Console.ReadLine());

                //now calling on the MathsOperations class
                //calling the method CalculateNumbers
                int MultiplyResult = MathsOperations.CalculateNumbers(userNumber);
                //showing result to the user
                Console.Write(userNumber + " multiplied by 100 is equal to " + MultiplyResult + "\n");

                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number.");
                Console.ReadLine();
            }

            
            //asking the user to input a decimal number, then we take away 10 and return the result to the user as an integer
            //using error handling to make sure the user inputs a decimal number and not something else
            try
            {
                //asking the user to input a decimal number
                Console.WriteLine("Please enter a decimal number.");
                //storing that number as userNumberDec
                decimal userNumberDec = decimal.Parse(Console.ReadLine());

                //now calling on the MathsOperations class
                //calling the method CalculateNumbers
                int TakeAwayResult = MathsOperations.CalculateNumbers(userNumberDec);
                //showing result to the user
                Console.Write(userNumberDec + " take away 10 is equal to " + TakeAwayResult + "\n");

                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a decimal number.");
                Console.ReadLine();
            }


            //asking the user to input a number as text, then we add 20 to it and return the result to the user
            //using error handling to make sure the user inputs a string and not something else
            try
            {
                //asking the user to input a number as text
                Console.WriteLine("Please enter a number.");
                //storing that number as userNumberDec
                string userNumberStr = Console.ReadLine();

                //now calling on the MathsOperations class
                //calling the method CalculateNumbers
                int AddingResult = MathsOperations.CalculateNumbers(userNumberStr);
                //showing result to the user
                Console.Write(userNumberStr + " plus 20 is equal to " + AddingResult + "\n");

                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a number.");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
