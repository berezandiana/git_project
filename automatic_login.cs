using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "users.txt";
        string name = null;

        if (File.Exists(fileName))
        {
            Console.WriteLine("User data found.");

            // Read user data from file
            using (StreamReader reader = new StreamReader(fileName))
            {
                name = reader.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("User data not found.");
        }

        // If user data exists, greet user with saved name and skip name input
        if (name != null)
        {
            Console.WriteLine($"Welcome back, {name}!");
        }
        else
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            // Save user data to file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(name);
            }

            Console.WriteLine($"Welcome, {name}!");
        }

        Console.ReadLine();
    }
}
