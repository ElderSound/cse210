
using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // The Scripture class hides only words that are still visible.
        // This prevents selecting the same hidden word multiple times.

        // Create a scripture reference from the Book of Mormon
        Reference reference = new Reference("1 Nephi", 3, 7);

        // Create the scripture with its text
        Scripture scripture = new Scripture(
            reference,
            "And it came to pass that I, Nephi, said unto my father: " +
            "I will go and do the things which the Lord hath commanded, " +
            "for I know that the Lord giveth no commandments unto the " +
            "children of men, save he shall prepare a way for them " +
            "that they may accomplish the thing which he commandeth them."
        );

        // Continue until the user quits or all words are hidden
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // End when every word is hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string? input = Console.ReadLine();

            if (input?.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide three random visible words
            scripture.HideRandomWords(3);
        }
    }
}
