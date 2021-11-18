using System;
using System.IO;

namespace Createlogitpe21
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string newDirectory = "LogItpe21";

            CreateMyDirectory(newDirectory);

           
        }
        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string directoryFullPath = $@"{rootDirectory}\{myDirectoryName}";
            if (Directory.Exists(directoryFullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {rootDirectory}.");
            }
            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }
        }

    }
}
