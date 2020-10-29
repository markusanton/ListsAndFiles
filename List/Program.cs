using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\data\test.txt";
            List<string> dataForomFile = File.ReadAllLines(filePath).ToList();

            foreach (string line in dataForomFile)
            {
                Console.WriteLine($"Data from: {line}");
            }

            dataForomFile.Add("grapes");
            File.WriteAllLines(filePath, dataForomFile);


        }
    }
}