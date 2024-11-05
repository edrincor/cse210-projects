using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Declaring, Instantiating, and Initializing
        List<int> numbers = new List<int>();
        int sum = 0;

        // Prompting user for number, and adds it to list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        do
        {
        Console.Write("Enter number: ");
        userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        // foreach loop adds each number to sum
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Sorting list and doing calculations
        float average = ((float)sum) / numbers.Count;
        int min = numbers[0];
        int max = numbers.Max();
        foreach (int number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;
            }
        }
        numbers.Sort();

        // Printing 
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");

        // foreach loop prints sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}