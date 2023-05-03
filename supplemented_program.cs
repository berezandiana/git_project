using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Git!");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Welcome, {name}!");

        Console.Write("Do you want to save your name for future use? (Y/N) ");
        string answer = Console.ReadLine();

        if (answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("name.txt"))
                {
                    writer.WriteLine(name);
                }
                Console.WriteLine("Name saved to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        Console.ReadLine();
    }
}
