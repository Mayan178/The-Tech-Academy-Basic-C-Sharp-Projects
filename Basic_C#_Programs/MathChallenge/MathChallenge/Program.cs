using System;


    class Program
    {
        static void Main()
        {
        //setting up the numbers I am going to use to do the following calculations
        int myNumber1 = 35;
        int myNumber2 = 7;

        string myNumber1AsText = myNumber1.ToString();
        string myNumber2AsText = myNumber2.ToString();

        Console.WriteLine("Today, our numbers are: " + myNumber1 + " and " + myNumber2);
        Console.ReadLine();

        //adding myNumber1 and myNumber2 together and print the result
        int sumOf2 = myNumber1 + myNumber2;
        Console.WriteLine(myNumber1AsText + "+" + myNumber2AsText + "=" + sumOf2);
        Console.ReadLine();

        //substracting myNumber2 from myNumber1 and print the result
        int differenceOf2 = myNumber1 - myNumber2;
        Console.WriteLine(myNumber1AsText + "-" + myNumber2AsText + "=" + differenceOf2);
        Console.ReadLine();

        //multiplying myNumber1 and myNumber2 together and print the result
        int multiplyOf2 = myNumber1 * myNumber2;
        Console.WriteLine(myNumber1AsText + "*" + myNumber2AsText + "=" + multiplyOf2);
        Console.ReadLine();

        //dividing myNumber1 by myNumber2 and print the result
        int divideOf2 = myNumber1 / myNumber2;
        Console.WriteLine(myNumber1AsText + "/" + myNumber2AsText + "=" + divideOf2);
        Console.ReadLine();



    }
}

