using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //ASSIGNMENT PART 1
        Console.WriteLine("ASSIGNMENT PART 1:");
        //create a one-dimensional array of strings
        string[] strArray = new string[] { "Apple", "Banana", "Kiwi", "Melon", "Pineapple" };
        //ask the user to input some text
        Console.WriteLine("Please, type in some text:");
        //setting user input as userText variable
        string userText = Console.ReadLine();
        //looping through each element in the array and adding in user input to all elements
        for (int i = 0; i < strArray.Length; i++)
        {
            strArray[i] = strArray[i] + userText;
        }

        //now looping through the updated array and printing out each element, one at a time
        for (int j = 0; j < strArray.Length; j++)
        {
            Console.WriteLine(strArray[j]);
        }

        //ASSIGNMENT PART 2
        Console.WriteLine("\n\nASSIGNMENT PART 2:");
        //writing an infinite loop
        //setting up a variable equal to true
        bool whileValue = true;
        while (whileValue)
        {
            //this will be printed out an indefinite number of times
            Console.WriteLine("Another line printed out!");
            //terminating the infinite loop by changing the value of the whileValue variable to false
            whileValue = false;
        }


        //ASSIGNMENT PART 3
        Console.WriteLine("\n\nASSIGNMENT PART 3:");
        //setting up an array of numbers
        int[] myArray3 = new int[] { 22, 36, 44, 56, 61, 73, 89, 92, 100, 103, 112, 125 };
        //now looping through the array and only returning values if below 100
        for (int k = 0; k < myArray3.Length; k++)
        {
            if (myArray3[k] < 100)
            { Console.WriteLine("Number " + myArray3[k] + " is below 100"); }
        }
        //now looping through the array and only returning values if below or equal to 73
        for (int l = 0; l < myArray3.Length; l++)
        {
            if (myArray3[l] <= 73)
            { Console.WriteLine("Number " + myArray3[l] + " is below or equal to 73"); }
        }


        //ASSIGNMENT PART 4
        Console.WriteLine("\n\nASSIGNMENT PART 4:");
        //setting up a list of strings
        List<string> daysOfWeek = new List<string>();
        //adding elements to the list
        daysOfWeek.Add("monday");
        daysOfWeek.Add("tuesday");
        daysOfWeek.Add("wednesday");
        daysOfWeek.Add("thursday");
        daysOfWeek.Add("friday");
        daysOfWeek.Add("saturday");
        daysOfWeek.Add("sunday");
        //asking the user to pick a day of the week and type it in
        Console.WriteLine("Please, type in a day of the week:");
        //setting user input as daySelected variable
        string daySelected = Console.ReadLine();
        //setting a boolean variable to see if correct data entered
        bool correctInput = true;
        //looping through the items in the list
        foreach (string dayofWeek in daysOfWeek)
        {
            //if the day entered by the user is found, return index (we are converting our strings and user input to lowercase
            if (daySelected.ToLower() == dayofWeek)
            {
                Console.WriteLine("The index for the day you entered is: " + daysOfWeek.IndexOf(daySelected.ToLower()));
                correctInput = true;
                break;
            }

            else
            { correctInput = false; }
        }

        if (!correctInput)
        { Console.WriteLine("The value you entered is not valid."); }


        //ASSIGNMENT PART 5
        Console.WriteLine("\n\nASSIGNMENT PART 5:");
        List<string> myVehicles = new List<string>();
        //adding elements to the list, making sure 2 of the same word is repeated once
        myVehicles.Add("car");
        myVehicles.Add("bicycle");
        myVehicles.Add("scooter");
        myVehicles.Add("motorbike");
        myVehicles.Add("boat");
        myVehicles.Add("airplane");
        myVehicles.Add("helicopter");
        myVehicles.Add("motorbike");

        //asking the user to type in a word to search for in the list
        Console.WriteLine("Please, type word to search for in the list (note that this contains different types of vehicles):");
        //setting user input as searchWord variable
        string searchWord = Console.ReadLine();
        //setting a boolean variable to see if we will display an error message
        bool displayMessage = true;
        //looping through list to find matching word
        //set variable to store index for place in list
        int theIndex = 0;
        foreach (string vehicle in myVehicles)
        {
            //if the word entered by the user is found, return index (we are converting our strings and user input to lowercase
            if (searchWord.ToLower() == vehicle)
            {
                Console.WriteLine("The index for the word you entered is: " + theIndex);
                displayMessage = false;
            }
            theIndex++;
        }
        //display a message if the word is not in the list
        if (displayMessage)
        { Console.WriteLine("The word you entered is not in the list."); }


        //ASSIGNMENT PART 6
        Console.WriteLine("\n\nASSIGNMENT PART 6:");
        List<string> myNames = new List<string>();
        //adding elements to the list, making sure 2 of the same word is repeated once
        myNames.Add("Edward");
        myNames.Add("David");
        myNames.Add("Tim");
        myNames.Add("Oliver");
        myNames.Add("Chris");
        myNames.Add("Daniel");
        myNames.Add("Chris");
        myNames.Add("Jack");
        //set up an empty list to store all names found as we go through the loop
        List<string> namesFound = new List<string>();

        // loop through each element in the list
        foreach (string name in myNames)
        {
            //has the word already been displayed? if so, display message that it is a duplicate
            if (namesFound.Contains(name))
                {
                    Console.WriteLine("Showing the name: " + name + " which is a duplicate"); 
                }
            else
                {
                Console.WriteLine("Showing the name: " + name + " which is unique");
                }
            //add the word to the list of found names
            namesFound.Add(name);
        }

            
            
           


        Console.ReadLine();
    }
}
