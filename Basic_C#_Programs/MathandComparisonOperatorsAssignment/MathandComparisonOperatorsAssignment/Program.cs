using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints out title
            Console.WriteLine("Anonymous Income Comparison Program\r");

            //section for person 1
            Console.WriteLine("Person 1\r");
            //asking the user to input hourly rate for person 1
            Console.WriteLine("Hourly Rate?\r");
            int person1Hourly = Convert.ToInt32(Console.ReadLine());
            //asking the user to input hours worked per week
            Console.WriteLine("Hours worked per week?\r");
            int person1WeeklyHours = Convert.ToInt32(Console.ReadLine());

            //section for person 2
            Console.WriteLine("Person 2\r");
            //asking the user to input hourly rate for person 2
            Console.WriteLine("Hourly Rate?\r");
            int person2Hourly = Convert.ToInt32(Console.ReadLine());
            //asking the user to input hours worked per week
            Console.WriteLine("Hours worked per week?\r");
            int person2WeeklyHours = Convert.ToInt32(Console.ReadLine());


            //annual salary of person 1
            Console.WriteLine("Annual salary of Person 1:\r");
            //calculating the yearly salary based on weekly, times 52 weeks
            int person1Yearly = person1Hourly * person1WeeklyHours * 52;
            Console.WriteLine(person1Yearly);

            //annual salary of person 2
            Console.WriteLine("Annual salary of Person 2:\r");
            //calculating the yearly salary based on weekly, times 52 weeks
            int person2Yearly = person2Hourly * person2WeeklyHours * 52;
            Console.WriteLine(person2Yearly);

            //find out if person 1 is earning more than person 2
            Console.WriteLine("Person 1 makes more money than Person 2: ");
            bool person1morethanperson2 = person1Yearly > person2Yearly;
            Console.WriteLine(person1morethanperson2);

            Console.ReadLine();

        }
    }
}
