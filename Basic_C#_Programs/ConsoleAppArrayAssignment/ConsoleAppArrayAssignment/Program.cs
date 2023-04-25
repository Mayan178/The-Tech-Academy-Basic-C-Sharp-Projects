using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
        //CODE FOR THE STRING ARRAY
        //setting a one-dimensional array of strings
        string[] strArray = { "David", "John", "Graham", "Jack" };
        //set boolean value to define later on if the user has found a valid index number
        bool isStrFound = false;

        //do the following until the user has entered a valid index number
        do
        {
            //prompt the user to select an index from the string array
            Console.WriteLine("Please, select an index of the string array, so to see what that index contains:");
            //store user input as userStrInd
            int userStrInd = Convert.ToInt32(Console.ReadLine());
            //if the user input is higher than the length of the array, display error message, otherwise, display answer
            if (userStrInd > strArray.Length-1)
            {
                //write out error message
                Console.WriteLine("Your number is too high. Try again.\n\n");
            }
            //the user's input is valid
            else
            {
                //reset boolean value
                isStrFound = true;
                //write out string at position userStrInd from the string array
                Console.WriteLine("The string at index " + userStrInd + " is " + strArray[userStrInd] + ".\n\n");
            }

        }

        while (!isStrFound);


        //CODE FOR THE INTEGER ARRAY
        //setting a one-dimensional array of integers
        int[] intArray = { 0,5,10,15,20,25,30 };
        //set boolean value to define later on if the user has found a valid index number
        bool isIntFound = false;

        //do the following until the user has entered a valid index number
        do
        {
            //prompt the user to select an index from the integer array
            Console.WriteLine("Please, select an index of the integer array, so to see what that index contains:");
            //store user input as userIntInd
            int userIntInd = Convert.ToInt32(Console.ReadLine());
            //if the user input is higher than the length of the array, display error message, otherwise, display answer
            if (userIntInd > intArray.Length-1)
            {
                //write out error message
                Console.WriteLine("Your number is too high. Try again.\n\n");
            }
            //the user's input is valid
            else
            {
                //reset boolean value
                isIntFound = true;
                //write out string at position userStrInd from the string array
                Console.WriteLine(intArray[userIntInd]);

                Console.WriteLine("The integer at index " + userIntInd + " is " + intArray[userIntInd] + ".\n\n");
            }

        }

        while (!isIntFound);


        //CODE FOR THE LIST OF STRINGS
        //declaring the list of strings
        List<string> myList = new List<string>() {"one","two","three","four","five"};
        //set boolean value to define later on if the user has found a valid index number
        bool isinListFound = false;

        //do the following until the user has entered a valid index number
        do
        {
            //prompt the user to select an index from the integer array
            Console.WriteLine("Please, select an index of the string list, so to see what that index contains:");
            //store user input as userIntInd
            int userListNo= Convert.ToInt32(Console.ReadLine());
            //if the user input is higher than the length of the list, display error message, otherwise, display answer
            if (userListNo > myList.Count-1)
            {
                //write out error message
                Console.WriteLine("Your number is too high. Try again.\n\n");
            }
            //the user's input is valid
            else
            {
                //reset boolean value
                isinListFound = true;
                //write out string at position userStrInd from the string array
                Console.WriteLine(myList[userListNo]);

                Console.WriteLine("The string at index " + userListNo + " is " + myList[userListNo] + ".\n\n");
            }

        }

        while (!isinListFound);


        Console.ReadLine();

        }
    }
