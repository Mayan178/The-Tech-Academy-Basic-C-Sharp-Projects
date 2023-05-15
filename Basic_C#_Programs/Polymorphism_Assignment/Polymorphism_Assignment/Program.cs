using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the Employee and initializing it with a FirstName and LastName
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            //calling on the SayName method from the Employee object
            employee.SayName();

            //using polymorphism
            employee.Quit();

            Console.ReadLine();
        }
    }
}
