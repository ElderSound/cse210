
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // The program asks for confirmation before loading a file
        // when there are existing journal entries, helping prevent
        // accidental loss of unsaved work.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine() ?? "";

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
                Console.WriteLine("Entry added successfully.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine() ?? "";

                if (!File.Exists(filename))
                {
                    Console.WriteLine("File not found.");
                }
                else
                {
                    bool shouldLoad = true;

                    if (journal._entries.Count > 0)
                    {
                        Console.Write(
                            "Loading will replace current entries. Continue? (y/n): "
                        );

                        string confirmation = Console.ReadLine() ?? "";
                        shouldLoad = confirmation.ToLower() == "y";
                    }

                    if (shouldLoad)
                    {
                        journal.LoadFromFile(filename);
                        Console.WriteLine("Journal loaded successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Loading cancelled.");
                    }
                }
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine() ?? "";

                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
