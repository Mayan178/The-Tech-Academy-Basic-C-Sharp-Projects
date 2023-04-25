using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        //ARRAYS
        //// declaring a new array called numArray and stating that it will have 5 elements
        //int[] numArray = new int[5];
        ////setting each element in the array
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// shorter way to create an array
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        ////faster way
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        ////changing item in array
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);

        //LISTS
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        List<string> strList = new List<string>();
        strList.Add("Hello");
        strList.Add("Jesse");
        strList.Remove("Jesse");

        Console.WriteLine(strList[0]);

        Console.ReadLine();
        }
    }
