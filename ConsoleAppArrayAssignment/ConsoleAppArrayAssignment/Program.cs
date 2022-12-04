using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Name Array
        string[] nameArray = { "Jack", "Jill", "Dave", "Phil" };
        Console.WriteLine("Please enter a number from 0 to 3\n");
        //User input
        int input = int.Parse(Console.ReadLine());
        //if statment for numbers large then the index amount
        if (input < 3)
        {
            Console.WriteLine("You picked: " + nameArray[input]);
        }
        else
        {
            Console.WriteLine($"{input} is out of range");
        }

        Console.ReadLine();

        //Number Array
        string[] numArray = { "2", "4", "8", "16" };
        Console.WriteLine("Please enter a number from 0 to 3\n");
        //User input
        int input2 = int.Parse(Console.ReadLine());
        //if statment for numbers larger then the index amount
        if (input2 < 3)
        {
            Console.WriteLine("You picked: " + numArray[input2]);
        }
        else
        {
            Console.WriteLine($"{input2} is out of range");
        }

        Console.ReadLine();

        //List
        List<string> intList = new List<string>() { "John", "Jill", "Jake", "Jack" };
        Console.WriteLine("Please enter a number from 0 to 3\n");
        //User input
        int input3 = int.Parse(Console.ReadLine());
        //if statment for numbers large then the index amount
        if (input3 < 3)
        {
            Console.WriteLine("You picked: " + intList[input3]);
        }
        else
        {
            Console.WriteLine($"{input3} is out of range");
        }

        Console.ReadLine();
    }
}

