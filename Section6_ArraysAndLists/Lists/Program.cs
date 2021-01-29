using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add(item) - add the one item to the list
            // AddRange(array/list) - add the contents of the passed array/lsit
            //  to the list being called
            var number = new List<int>() {1, 2, 3, 4};
            number.Add(1);
            number.AddRange(new int[3]{5, 6, 7});

            foreach(var num in number)
                Console.WriteLine(num);


            // IndexOF(element) - finds the first element index of the item passed
            // LastIndexOf finds the last mathcing element's index
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + number.IndexOf(1));
            Console.WriteLine("Last index of 1: " + number.LastIndexOf(1));

            // count is the lenght of the list.
            Console.WriteLine("Count: " + number.Count);

            // remove removes the passed in argument form the list
            for(var i = 0; i < number.Count; i++) {
                if (number[i] == 1)
                    number.Remove(number[i]);
            }

            foreach(var num in number)
                Console.WriteLine(num);

            // removes all ements from the list
            number.Clear();
            Console.WriteLine(number.Count);
        }
    }
}
