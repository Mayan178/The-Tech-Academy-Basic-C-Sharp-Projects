using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the Employee and initializing it with a FirstName and LastName
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //calling on the SayName method which is with the Person class, but as Employee is inheriting from Person, we can call it from the Employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}
