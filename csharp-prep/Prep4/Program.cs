using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // creating the list and setting variables
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number here, use 0 to quit. ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
        // Add number to list as long as it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // use foreach to compute sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        // Calculating the average of the list
        // We will not use int here because there has to be decimals in averages
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max of the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}