using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE LOOP USING AGE ENTERED BY USER IN ORDER TO SHOW DIFFERENT MESSAGES
            //ask the user to enter their age
            Console.WriteLine("Please, enter your age:");
            //set variable containing value entered by the user
            int age = Convert.ToInt32(Console.ReadLine());
            bool isOfAge = false;

            //we do a while loop as long as isOfAge is false 
            while (!isOfAge)
            {
                switch (age)
                {
                    case 1:
                        Console.WriteLine("You are definitely too young to drink anything else than milk or water!");
                        Console.WriteLine("Please, enter your age:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("You just turned into a teenager!!!");
                        Console.WriteLine("Please, enter your age:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("Not long to go until you are an adult!!!");
                        Console.WriteLine("Please, enter your age:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    // this is the value that sets isOfAge to true
                    case 18:
                        Console.WriteLine("Welcome to adulthood!");
                        isOfAge = true;
                        break;
                    // any other value not previousy mentioned go to the default
                    default:
                        Console.WriteLine("Keep trying!");
                        Console.WriteLine("Please, enter your age:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }


            //DO WHILE LOOP USING USER NUMBER INPUT
            //ask the user to enter a number between 1 and 10
            Console.WriteLine("Please, enter a number between 1 and 10:");
            //set variable containing value entered by the user
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            bool isCorrect = yourNumber == 5;

            //we do a while loop as long as isCorrect is false 
            do
            {
                switch (yourNumber)
                {
                    // the correct value that sets isCorrect to true
                    case 5:
                        Console.WriteLine("You guessed the right number!");
                        isCorrect = true;
                        break;
                    // all other values
                    default:
                        Console.WriteLine("Keep trying!");
                        Console.WriteLine("Please, enter a number between 1 and 10:");
                        yourNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!isCorrect);

            Console.ReadLine();

        }
    }
}
