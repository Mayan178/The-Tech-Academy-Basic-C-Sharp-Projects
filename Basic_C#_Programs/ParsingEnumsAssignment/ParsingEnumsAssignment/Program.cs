using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to enter the current day of the week
            Console.WriteLine("Please, enter the current day of the week:");
            //set user input as userDay string variable
            string userDay = Console.ReadLine();
            //using the try/catch block to check value entered against enum DaysofWeek
            try
            {
                //parsing the day entered by the user against our enum (case insensitive)
                DaysofWeek chosenDay = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), userDay,true);
                Console.WriteLine("You entered " + chosenDay);
            }
            //there was an error, return message below
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

                Console.ReadLine();

        }

        //enum for the days of the week
        public enum DaysofWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
