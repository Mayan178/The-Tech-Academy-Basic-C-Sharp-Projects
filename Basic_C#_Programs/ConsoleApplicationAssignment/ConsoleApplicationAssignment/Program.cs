using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user to enter a number
            Console.WriteLine("Please enter a number");
            //sets the variable myNumber1 to the value of number entered by user
            int myNumber1 = Convert.ToInt32(Console.ReadLine());
            //times that number by 50 and sets result as variable myTotal1
            int myTotal1 = 50 * myNumber1;
            //writes out result to user
            Console.WriteLine("Your number times 50 is equal to " + myTotal1 + "\n" + "Please enter a different number");
           

            //sets the variable myNumber2 to the value of number entered by user
            int myNumber2 = Convert.ToInt32(Console.ReadLine());
            //adds 25 to that number sets result as variable myTotal2
            int myTotal2 = myNumber2 + 25;
            //writes out result to user
            Console.WriteLine("Your number plus 25 is equal to " + myTotal2 + "\n" + "Please enter a different number");


            //sets the variable myNumber3 to the value of number entered by user
            int myNumber3 = Convert.ToInt32(Console.ReadLine());
            //divides that number by 12.5 and sets result as variable myTotal3
            double myTotal3 = myNumber3 / 12.5;
            ////writes out result to user
            Console.WriteLine("Your number divided by 12.5 is equal to " + myTotal3 + "\n" + "Please enter a different number");
            

            //sets the variable myNumber4 to the value of number entered by user
            int myNumber4 = Convert.ToInt32(Console.ReadLine());
            //checks if user input is greater than 50
            bool myTrueofFalse1 = myNumber4 > 50;
            //writes out result to user
            Console.WriteLine("Is your number greater than 50?: " + myTrueofFalse1 + "\n" + "Please enter a different number");


            //sets the variable myNumber5 to the value of number entered by user
            int myNumber5 = Convert.ToInt32(Console.ReadLine());
            //divides that number by 7 and sets remainder as variable myTotal5
            double myTotal5 = myNumber5 % 7;
            ////writes out result to user
            Console.WriteLine("Once you divide your number by 7, the remainder is " + myTotal5 + "\n" + "Please enter a different number");
            
           
           
            Console.ReadLine();





        }
    }
}
