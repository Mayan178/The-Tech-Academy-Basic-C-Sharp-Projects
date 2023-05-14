using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //the Employee class inherits from the Person class
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
