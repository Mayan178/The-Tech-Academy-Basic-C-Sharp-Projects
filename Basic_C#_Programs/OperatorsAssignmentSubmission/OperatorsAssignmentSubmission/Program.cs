using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            //setting up a first employee named Michael;
            Employee Michael = new Employee();
            Michael.Id = 1;
            Michael.firstName = "Michael";
            Michael.lastName = "Wilkinson";

            //setting up a second employee named Carole with a different Id to Michael;
            Employee Carole = new Employee();
            Carole.Id = 2;
            Carole.firstName = "Carole";
            Carole.lastName = "Smith";

            //setting up a third employee named MichaelSecond with same Id as Michael;
            Employee MichaelSecond = new Employee();
            MichaelSecond.Id = 1;
            MichaelSecond.firstName = "Michael";
            MichaelSecond.lastName = "Wilkinson";

            //checking if Michael and MichaelSecond have the same Id and showing different message depending upon result
            Console.WriteLine(Michael.Id == MichaelSecond.Id ? "Michael and MichaelSecond have the same Id" : "Michael and MichaelSecond do not have the same Id");
            //checking if Michael and Carole have a different Id and showing different message depending upon result 
            Console.WriteLine(Michael.Id != Carole.Id ? "Michael and Carole have different Ids" : "Michael and Carole have the same Id");


            Console.ReadLine();
        }
    }
}
