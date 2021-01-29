using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 9, 2, 14, 6};

            // Length - size of the array
            Console.WriteLine(numbers.Length);

            // Indexof() - returns the index of an element in the arrau
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            // Clear(array, starting index, number of elements to clear) - 
            // sets the desired range of elemetns to their default value.
            Array.Clear(numbers, 0, 2);
            foreach(var num in numbers)
                Console.WriteLine(num);

            // Copy(source array, destination array, number fo elements to copy) -
            //  copies the number of elements starting at index 0 from the source
            //  array to the destination
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach(var n in another)
                Console.WriteLine(n);

            // Sort(array) - sorts the given array
            Array.Sort(numbers);
            foreach(var n in numbers)
                Console.WriteLine(n);

            // Reverse() p reverses the elements in the given array
            Array.Reverse(numbers);
            foreach(var n in numbers)
                Console.WriteLine(n);

        }
    }
}
