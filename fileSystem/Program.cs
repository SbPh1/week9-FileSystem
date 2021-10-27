using System;
using System.IO;

namespace fileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\Monkey\samples";
            Console.WriteLine("Enter directory name:");
            string userDirectory = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootdirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);

            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userDirectory} already exists in {rootdirectory}");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userDirectory} has been created.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}
