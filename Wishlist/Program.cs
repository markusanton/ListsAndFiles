using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Wishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\data\wishlist.txt";
            List<string> dataForomFile = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter wish: ");
                string userInput = Console.ReadLine();
                dataForomFile.Add(userInput);
                File.WriteAllLines(filePath, dataForomFile);
            }
        }
    }
}
