using System;
using System.Collections.Generic;

namespace ListsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>();


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a fruit: ");
                fruit.Add(Console.ReadLine());
            }

            #region motetu 
            /*
            foreach(string fruititem in fruit)
            {
                Console.WriteLine($"fruit on the list: {fruititem}");
            }
            */
            #endregion

            fruit.Add("pineapple");

            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"Fruit on the list: {fruititem}");
            }

            int indexpine = fruit.IndexOf("pineapple");

            Console.WriteLine($"Pineapple in on the index {indexpine}");

            fruit[indexpine] = "orange";

            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"Fruit on updated list: {fruititem}");
            }

            fruit.RemoveAt(fruit.Count - 1);

            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"Trimmed fruit list: {fruititem}");
            }



        }
    }
}