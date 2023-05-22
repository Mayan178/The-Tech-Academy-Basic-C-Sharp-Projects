using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting up a default value of false for validation and a default age of 0
            bool validAge = false;
            int age = 0;
            //as long as validAge is false, do the following
            while (!validAge)
            {
                //ask the user to enter their age
                Console.WriteLine("Please, enter your age: ");
                try
                {
                    //check if valid
                    validAge = int.TryParse(Console.ReadLine(), out age);
                    //make sure the number entered is above 0
                    if (age <= 0 && validAge)
                    {
                        throw new MessageException();
                    }
                }

                catch (MessageException)
                {
                    Console.WriteLine("You entered zero or a negative number");
                    Console.ReadLine();
                    //stops right here!
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please, contact your System Administrator.");
                    Console.ReadLine();
                    //stops right here!
                    return;
                }


            }
            //now work out the year when the user was born, by taking their age away from the current
            var currentDate = DateTime.Now;
            var currentYear = currentDate.Year.ToString();
            var pastDate = currentDate.AddYears(-age);
            var yearBorn = pastDate.Year.ToString();
            //Show user the year when they were born
            Console.WriteLine("You were born in " + yearBorn);
            Console.ReadLine();
        }
    }
}
