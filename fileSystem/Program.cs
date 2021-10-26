using System;
using System.IO;

namespace fileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\Monkey\samples";
            string userDirectory = "wishList";

            string newDirectoryFullPath = @$"{rootdirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}
