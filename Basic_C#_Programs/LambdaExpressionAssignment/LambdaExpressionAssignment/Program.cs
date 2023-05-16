using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //add 10 employees, 2 having Joe as a firstname
            List<Employee> allEmployees = new List<Employee>()
            {
            new Employee() { Id =1, FirstName ="Abby", LastName ="Abba"},
            new Employee() { Id =2, FirstName ="Bertha", LastName ="Bali"},
            new Employee() { Id =3, FirstName ="Joe", LastName ="Davis"},
            new Employee() { Id =4, FirstName ="Debbie", LastName ="Dobbs"},
            new Employee() { Id =5, FirstName ="Ellie", LastName ="Elstrom"},
            new Employee() { Id =6, FirstName ="Frank", LastName ="France"},
            new Employee() { Id =7, FirstName ="Gustave", LastName ="Gaston"},
            new Employee() { Id =8, FirstName ="Henry", LastName ="Hall"},
            new Employee() { Id =9, FirstName ="Joe", LastName ="Jackson"},
            new Employee() { Id =10, FirstName ="Carole", LastName ="Cola"}
            };

            //setting up new list to contain all Joe's
            List<Employee> allJoes = new List<Employee>();
            //using foreach loop finding all Joe's in the list of all employees
            foreach (Employee employee in allEmployees)
            {
                if (employee.FirstName == "Joe")
                { allJoes.Add(employee); }
            }

            //using Lambda expression to return all Joes
            List<Employee> allJoesLambda = allEmployees.Where(e => e.FirstName == "Joe").ToList();

            //using Lambda expression to return all employees with Id greater than 5
            List<Employee> allOver5 = allEmployees.Where(e => e.Id > 5).ToList();

            Console.WriteLine("Finished!");
            Console.ReadLine();
            
        }
    }
}
