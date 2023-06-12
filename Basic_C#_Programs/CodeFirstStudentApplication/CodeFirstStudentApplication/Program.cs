using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstStudentApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create and save a new Student
                //ask the user to enter a firstname
                Console.Write("Enter a firstname:\t");
                var firstName = Console.ReadLine();
                //ask the user to enter a lastname
                Console.Write("Enter a lastname:\t");
                var lastName = Console.ReadLine();
                //ask the user to enter the first line of the address
                Console.Write("Enter the first line of the address:\t");
                var address1 = Console.ReadLine();
                //ask the user to enter the second line of the address
                Console.Write("Enter the second line of the address:\t");
                var address2 = Console.ReadLine();
                //ask the user to enter a city
                Console.Write("Enter the city:\t");
                var city = Console.ReadLine();
                //ask the user to enter a postcode
                Console.Write("Enter the postcode:\t");
                var postcode = Console.ReadLine();
                //setting validDBO to false and checking against this to make sure the user inputs a valid date
                bool validDBO = false;
                //as long as the date of birth entered is invalid, the user will be asked to enter it again and nothing else will happen
                while (!validDBO)
                {
                    //ask the user to enter a date of birth
                    Console.Write("Enter the date of birth:\t");
                    try
                    {
                        //check if valid
                        var dateofBirth = DateTime.Parse(Console.ReadLine());
                        validDBO = true;
                        //ask the user to enter a core subject for the student
                        Console.Write("Enter the core subject:\t");
                        var coreSubject = Console.ReadLine();

                        //now setting up all data for the new student
                        var student = new Student { FirstName = firstName, LastName = lastName, Address1 = address1, Address2 = address2, City = city, PostCode = postcode, DateOfBirth = dateofBirth, CoreSubject = coreSubject };
                        //adding the new student to the database
                        db.Students.Add(student);
                        db.SaveChanges();

                        // Now displaying all students from the database
                        var query = from s in db.Students
                                    orderby s.FirstName
                                    select s;

                        Console.WriteLine("\n\nAll students currently held in the database:");
                        foreach (var item in query)
                        {
                            Console.WriteLine(value: item.FirstName + " " + item.LastName);
                        }

                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();

                    }

                    
                    catch (Exception)
                    {
                        Console.WriteLine("The date you entered is not valid, please enter again.");
                        validDBO = false;
                        
                    }


                }

                
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CoreSubject { get; set; }
        
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
