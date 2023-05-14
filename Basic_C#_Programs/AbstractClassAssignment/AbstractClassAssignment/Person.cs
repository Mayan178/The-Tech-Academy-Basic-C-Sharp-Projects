using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        //giving the Person class a property of firstName  and a seperate one for lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        //SayName method 
        public abstract void SayName();
    }
}
