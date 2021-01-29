using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            Problem5();
        }

        static void Problem1() {
            var names = new List<string>();

            while (true) {
                Console.Write("Enter a name or press ENTER to finish: ");
                var input = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(input))
                    break; 
                else
                    names.Add(input);             
            }

            switch (names.Count) {
                case 1:
                    Console.WriteLine(string.Format("{0} likes your post.", names[0]));
                    break;
                case 2:
                    Console.WriteLine(string.Format("{0} and {1} like your post.", names[0], names[1]));
                    break;
                default:
                    Console.WriteLine(string.Format("{0}, {1}, and {2} other people like your post.", names[0], names[1], (names.Count - 2)));
                    break;
            }
        }

        static void Problem2() {
            var separator = new char[] {' '};
            Console.Write("Please enter your name: ");
            var input = Console.ReadLine().Split(separator);
            var reversed = new List<string>();
            foreach(var name in input) {
                var temp = "";
                for (var i = (name.Length-1); i >= 0; i--)
                    temp += name[i];
                reversed.Add(temp);
            }
            
            var finalReverse = string.Join(" ", reversed);
            Console.WriteLine(finalReverse);

        }

        static void Problem3() {
            var numbers = new List<int>();
            for(var i = 5; i > 0; i--) {
                Console.Write("Please enter a number: ");
                var input = Int32.Parse(Console.ReadLine());
                while((numbers.Count != 0) && (i != 5) && (numbers.Contains(input))) {
                    Console.Write("Number already entered, please enter a different number: ");
                    input = Int32.Parse(Console.ReadLine());
                }
                numbers.Add(input);
            }

            numbers.Sort();
            foreach(var num in numbers)
                Console.Write(num + " ");
        }

        static void Problem4() {
            string input;
            var numbers = new List<int>();
            var unique = new List<int>();
            do {
                Console.Write("please enter a number or Quit to exit: ");
                input = Console.ReadLine();
                if (input.ToLower() != "quit") {
                    numbers.Add(Int32.Parse(input));
                }
            } while (input.ToLower() != "quit");

            numbers.Sort();
            var check = numbers[0];
            unique.Add(numbers[0]);

            for (var i = 0; i < numbers.Count; i++) {
                if (numbers[i] != check) {
                    check = numbers[i];
                    unique.Add(numbers[i]);
                } else {
                    continue;
                }
            }

            foreach(var number in unique) {
                Console.Write(number + " ");
            }        
        }

        static void Problem5() {
            var sep = new char[] {','};
            var numbers = new List<int>();
            string[] input;
            Console.Write("Please enter a list of comma(,) separated numbers: ");
            input = Console.ReadLine().Split(sep);
            while ((input.Length == 0) || (input.Length < 5)) {
                Console.Write("Invalid list,Please enter a list of comma(,) separated numbers: ");
                input = Console.ReadLine().Split(sep);
            } 

            for(var i = 0; i < input.Length; i++) {
                input[i] = input[i].Trim();
            }
            for (var i = 0; i < input.Length; i++) {
                numbers.Add(Int32.Parse(input[i]));
            }
            numbers.Sort();
            for(var i = 0; i < 3; i++)
                Console.Write(numbers[i] + " ");
        }
    }
}
