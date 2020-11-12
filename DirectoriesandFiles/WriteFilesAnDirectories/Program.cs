using System;
using System.IO;

namespace WriteFilesAnDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePath();
        }

        public static void WriteFilePath()
        {
            string filePath = @"C:\Users\opilane\samples\Files.txt";
            string directorypath = @"C:\Users\opilane\samples";

            string[] files = Directory.GetFiles(directorypath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(filePath, files);

        }



    }
}
