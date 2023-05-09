using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the MathsOps class if the MathsOps class is not static
            //MathsOps myMaths = new MathsOps();

            //ask the user to enter a number
            Console.WriteLine("Please, enter a number to see what its value divided by 2 is.");

            try
            {
                int theNumber = Convert.ToInt32(Console.ReadLine());
                //now pass this value to the DividebyTwo method
                //if the MathsOps class is not static
                //myMaths.DividebyTwo(theNumber);
                //doing this for static class
                MathsOps.DividebyTwo(theNumber);
            }

            catch
            {
                Console.Write("Please enter a valid number.");
            }

            //ask the user to enter the length of the side of a square
            Console.WriteLine("Please, enter the length of the side of a square so we can do some calculations.");

            try
            {
                int squareLen = Convert.ToInt32(Console.ReadLine());
                //now pass this value to the CalculateShape method
                int perimeter = MathsOps.CalculateShape(squareLen, out int area);
                Console.WriteLine("The square's perimeter is " + perimeter);
                Console.WriteLine("The square's Area is " + area);
            }

            catch
            {
                Console.Write("Please enter a valid number.");
            }

            //ask the user to enter the length of the shorter side of a rectangle
            Console.WriteLine("Please, enter the length of the shorter side of a rectangle.");
            //make sure it is a number
            try
            {
                int rectangleShort = Convert.ToInt32(Console.ReadLine());

                //ask the user to enter the length of the longer side of a rectangle
                Console.WriteLine("Please, enter the length of the longer side of a rectangle.");
                int rectangleLong = Convert.ToInt32(Console.ReadLine());
                //now pass the 2 values to the CalculateShape method
                int perimeter = MathsOps.CalculateShape(rectangleShort, rectangleLong, out int area);
                Console.WriteLine("The rectangle's perimeter is " + perimeter);
                Console.WriteLine("The rectangle's Area is " + area);
                
            }

            catch
            {
                Console.Write("Please enter valid numbers.");
            }

            Console.ReadLine();
        }

       
    }
}
