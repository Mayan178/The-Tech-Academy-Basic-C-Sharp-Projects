using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //form title
            Console.WriteLine("Car Insurance Application");
            //asking for age
            Console.WriteLine("What is your age?");
            //taking user input and saving it as yourAge variable
            int yourAge = Convert.ToInt32(Console.ReadLine());

            //asking for DUI and letting the user know to use "yes" or "no" as an answer
            Console.WriteLine("Have you ever had a DUI? (yes or no)");
            //saving the user's answer as variable DUIStatus
            string DUIStatus = Console.ReadLine();
            //setting new DUIboolean variable to be true or false, depending on answer given by user. If equal to "yes!, then true
            bool DUIboolean = DUIStatus == "yes";

            Console.WriteLine("How many speeding tickets do you have?");
            // setting yourTickets variable to be user input
            int yourTickets = Convert.ToInt32(Console.ReadLine());

            //now using all variables in order to determine if the user qualifies for insurance.
            bool insuranceQualified = yourAge > 15 && DUIboolean != true && yourTickets <= 3;
            //print out result. If true, they qualify, if false, they don't.
            Console.WriteLine("Do you qualify for car insurance?\n"+ insuranceQualified);

            Console.ReadLine();

        }
    }
}
