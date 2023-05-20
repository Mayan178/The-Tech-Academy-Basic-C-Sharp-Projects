using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //finding out current date and time
            DateTime currentDate = DateTime.Now;
            //printing the date to the console
            Console.WriteLine(currentDate);
            //asking the user to input a number
            Console.WriteLine("Please, enter a number:");
            //putting code within a try and catch block, to make sure the user enters a number
            try
            {
                //setting x as number entered by the user
                int x = Convert.ToInt32(Console.ReadLine());
                //adding x hours to currentDate
                DateTime futureDate = currentDate.AddHours(x);
                //printing this futureDate out to the console
                Console.WriteLine("In " + x + " hours, the date and time will be " + futureDate);



            }

            catch (Exception ex)
            {
                //show the user what went wrong
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
