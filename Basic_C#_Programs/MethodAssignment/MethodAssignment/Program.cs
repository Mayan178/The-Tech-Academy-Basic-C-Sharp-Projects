using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user to input 2 numbers (first one being mandatory and second one optional)
           
                //asking the user to input a first number
                Console.WriteLine("Please enter a number.");
                //storing that number as numberOne
                int numberOne = Convert.ToInt32(Console.ReadLine());

                //asking the user to input a second number (optional)
                Console.WriteLine("Please enter a second number, if you wish.");

                //doing some error handling as we don't know if the user has entered a second number
                //trying with 2 numbers
                try
                {
                    //storing that number as numberTwo
                    int numberTwo = Convert.ToInt32(Console.ReadLine());


                    //now calling on the MathsOperations class
                    //calling the method AddTwoNumbers
                    int myResult = MathsOps.AddTwoNumbers(numberOne, numberTwo);
                    //showing result to the user
                    Console.Write(numberOne + " added to " + numberTwo + " is equal to " + myResult + "\n");
                }
                
                // if error thrown, then just one number provided
                catch
                {
                    //now calling on the MathsOperations class
                    //calling the method AddTwoNumbers
                    int myResult = MathsOps.AddTwoNumbers(numberOne);
                    //showing result to the user
                    Console.Write(numberOne + " added to 100 is equal to " + myResult + "\n");

            }


            Console.ReadLine();

        }
    }
}
