using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //showing the title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //asking the user to input a package weight
            Console.WriteLine("Please, enter your package weight:");
            //set user input as variable weight
            int weight = Convert.ToInt32(Console.ReadLine());

            //checking if the weight entered is greater than 50. If so, show error message and stop there
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            // the weight is not greater than 50
            else
            {
                //get user to enter width of package and store in width variable
                Console.WriteLine("Please, enter your package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                // get user to enter height of package and store in height variable
                Console.WriteLine("Please, enter your package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                // get user to enter length of package and store in length variable
                Console.WriteLine("Please, enter your package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                //now work out the total of the dimensions
                int totalDimensions = width + height + length;
                //now if totalDimensions is greater than 50, show error message and stop there 
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                //the package is not too big, work out the quote
                else
                {
                    int packageSize = height * width * length;
                    double resultQuote = packageSize * weight / 100;
                    //show quote to the user
                    Console.WriteLine("Your estimated quote for sending this package is: $" + resultQuote);
                }


            }
            Console.ReadLine();
        }
    }
}
