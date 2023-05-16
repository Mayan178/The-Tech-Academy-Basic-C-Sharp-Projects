using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignmentSubmission
{
    public class Employee
    {
        //setting properties for the Employee
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        //use of the == overload operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Equals(employee2))
                return true;
            else
                return false;
        }

        //use of the != overload operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Equals(employee2))
                return false;
            else
                return true;
        }


    }
}