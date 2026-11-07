using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        // Collect numbers until the user enters 0
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine() ?? "0");

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            int largest = numbers[0];

            foreach (int value in numbers)
            {
                sum += value;

                if (value > largest)
                {
                    largest = value;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");

            // Stretch: Find the smallest positive number
            int smallestPositive = int.MaxValue;

            foreach (int value in numbers)
            {
                if (value > 0 && value < smallestPositive)
                {
                    smallestPositive = value;
                }
            }

            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine(
                    $"The smallest positive number is: {smallestPositive}"
                );
            }
            else
            {
                Console.WriteLine("There are no positive numbers.");
            }

            // Stretch: Sort and display the list
            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}