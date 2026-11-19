
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first scripture reference
        Reference reference1 = new Reference("John", 3, 16);

        Scripture scripture1 = new Scripture(
            reference1,
            "For God so loved the world, that he gave his only begotten Son."
        );

        // Create a scripture from the Book of Mormon
        Reference reference2 = new Reference("1 Nephi", 3, 7);

        Scripture scripture2 = new Scripture(
            reference2,
            "I will go and do the things which the Lord hath commanded."
        );

        // Verify that the objects were created
        Console.WriteLine("Scripture objects created successfully.");
        Console.WriteLine("The program compiled and ran without errors.");
    }
}
