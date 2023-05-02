using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // creating a list of integers called myIntegers
        List<int> myIntegers = new List<int>();
        myIntegers.Add(2);
        myIntegers.Add(9);
        myIntegers.Add(13);
        myIntegers.Add(28);
        myIntegers.Add(34);
        myIntegers.Add(87);
        myIntegers.Add(99);
        myIntegers.Add(100);
        myIntegers.Add(112);
        myIntegers.Add(125);
       

        //try block
        try {
            //ask the user to enter a number to divide our numbers by
            Console.WriteLine("Please enter a number by which to divide the numbers in our list:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //loop through each number in our list and divide by number provided by the user
            foreach (int myInteger in myIntegers)
            {
                int newNumber = myInteger / userNumber;
                //show output of division
                Console.WriteLine("The result of " + myInteger + " divided by " + userNumber + " is " + newNumber);
            }
        }
        //catching invalid numbers
        catch (FormatException err1)
        {
            Console.WriteLine("You need to enter a valid number.");
        }

        //catching zero
        catch (DivideByZeroException err2)
        {
            Console.WriteLine("You cannot select zero as a number.");
        }
        //general error handling
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("The program has now finished.");
        }

        Console.ReadLine();

    }
}

