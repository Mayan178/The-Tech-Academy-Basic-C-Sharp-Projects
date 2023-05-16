using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the Employee object with a type string
            Employee<string> employee = new Employee<string>();
            //calling upon the things property with type string
            employee.things = new List<string> () { "John Barn", "Jack Dawn", "Elise Grey" };
            //looping through the list and printing things to Console
            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }

            //now instantiating the Employee object with a type int
            Employee<int> employee2 = new Employee<int>();
            //calling upon the things property with type int
            employee2.things = new List<int>() { 1,2,3,4,5 };
            //looping through the list and printing things to Console
            foreach (int thing in employee2.things)
            {
                Console.WriteLine(thing);
            }


            Console.ReadLine();
        }
    }
}
