using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Organizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create new random list, print to screen
            List<int> unsortedList = Randomizer(10);
            Console.WriteLine("Unsorted:");
            unsortedList.ForEach(i => Console.WriteLine(i));
            var sorter = new ShiftHighestSort();
            
            // take the unsorted list and sort the numbers lowest to highest, print to screen
            List<int> sortedList = sorter.Sort(unsortedList);
            Console.WriteLine();
            Console.WriteLine("Sorted:");
            sortedList.ForEach(i => Console.WriteLine(i));
        }

        public static void ShowList(string label, List<int> theList)
        {
            int count = theList.Count;
            if (count > 100)
            {
                count = 300; // Do not show more than 300 numbers
            }
            Console.WriteLine();
            Console.Write(label);
            Console.Write(':');
            for (int index = 0; index < count; index++)
            {
                if (index % 20 == 0) // when index can be divided by 20 exactly, start a new line
                {
                    Console.WriteLine();
                }
                Console.Write(string.Format("{0,3}, ", theList[index]));  // Show each number right aligned within 3 characters, with a comma and a space
            }
            Console.WriteLine();
        }

        public static List<int> Randomizer(int maxNumbers)
        {
            Random rnd = new Random();
            List<int> unsortedList = new List<int>();
            for (int i = 1; i <= maxNumbers; i++)
                unsortedList.Add(rnd.Next(-99, 99));
            return unsortedList;
        }
    }
}

