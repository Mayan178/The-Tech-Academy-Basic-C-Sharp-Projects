using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //using error handling to make sure the user inputs a number and not text
            try
            {
                //asking the user to input a number
                Console.WriteLine("Please enter a number.");
                //storing that number as NumberOne
                int userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Applying some calculations...");

                //now calling on the MathsOps class
                //calling the method adding 50 to the user number
                int AddResult = MathsOps.AddNumbers(userNumber);
                //showing result to the user
                Console.Write(userNumber + " added to 50 is equal to " + AddResult + "\n");


                //calling the method to substract 10 to the user number
                int SubstractResult = MathsOps.SubstractNumbers(userNumber);
                //showing result to the user
                Console.Write(userNumber + " take away 10 is equal to " + SubstractResult + "\n");


                //calling the method multiplying the user number by 30
                int MultiplyResults = MathsOps.MultiplyNumbers(userNumber);
                //showing the user the result
                Console.WriteLine(userNumber + " multiplied by 30 is equal to " + MultiplyResults + "\n");
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number.");
                return;
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
