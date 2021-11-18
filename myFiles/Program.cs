using System;
using System.IO;

namespace myFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFilesFromMyList(ReplaceNumbers(GetDataFromFile()));
            updateMyFiles(ReplaceNumbers(GetDataFromFile()));
            
        }

        private static string[] GetDataFromFile()
        {
            string sourceFilePath = $@"C:\Users\opilane\samples\LogItpe21\myFilse.txt";
            string[] dataFromFile = File.ReadAllLines(sourceFilePath);
            return dataFromFile;
        }

        private string[] ReplaceNumbers(string[] sourceArray)
        {
            for(int i = 0; i < sourceArray.Length; i++)
            {
                sourceArray[i] = sourceArray[i].Replace('4', 'a').Replace('3', 'e').Replace('0', 'o').Replace('1', 'i');

            }
            return sourceArray;
        }

        private static void CreateFilesFromMyList(string[] arrayOfNames)
        {
            string rootPath = $@"C:\Users\opilane\samples\LogItpe21";

            for(int i = 0; i < arrayOfNames.Length; i++)
            {
                File.Create($@"{rootPath}\{arrayOfNames[i]}.txt");
            }
        }
        private static void updateMyFiles(string[] updateArray)
        {
            string sourceFilePath = $@"C:\Users\opilane\samples\LogItpe21\myFilse.txt";
            File.WriteAllLines(sourceFilePath, updateArray);
        }
    }
}
