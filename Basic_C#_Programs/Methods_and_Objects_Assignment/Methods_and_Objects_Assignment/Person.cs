using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Person
    {
        //giving the Person class a property of FirstName and a seperate one for LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //SayName method returning FirstName and LastName
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
