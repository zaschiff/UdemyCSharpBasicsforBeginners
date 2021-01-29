using System;
using System.Collections.Generic;
using System.Text;

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
            // 1. Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //      Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
            //      or "20-19-18-17-16", display a message: "Consecutive"; otherwise, 
            //      display "Not Consecutive".
            Console.Write("PLease enter a list of numbers separated by a hyphen(-): ");
            var input = Console.ReadLine().Split('-');
            var nums = new List<int>();
            foreach(var str in input) {
                nums.Add(Int32.Parse(str));
            }
            var check = nums[0] + 1;
            for( var i = 1; i < nums.Count; i++) {
                if ((i != (nums.Count-1)) && (nums[i] == check)) {
                    check = nums[i] + 1;
                }else if (i == (nums.Count - 1)) {
                    Console.WriteLine("Consecutive");
                    break;
                } else {
                    Console.WriteLine("Non-Consecutive");
                    break;
                }
            }
        }

        static void Problem2() {
            // 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //     If the user simply presses Enter, without supplying an input, exit immediately; 
            //     otherwise, check to see if there are duplicates. If so, display "Duplicate" on 
            //     the console. 
            var numbers = new List<int>();
            Console.Write("Please enter some numbers separated by a hyphen(-): ");
            var input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input)) {
                var strings = input.Split('-');
                foreach( var str  in strings) {
                    numbers.Add(Int32.Parse(str));
                }

                var current = true;

                for (var i = 1;i < numbers.Count; i++) {
                    if (i == (numbers.Count-1)) {
                        current = true;
                        break;
                    } else if (numbers[i] == numbers[i+1]) {
                        current = true;
                        continue;
                    } else {
                        current = false;
                        break;
                    }
                }

                if (!current)
                    Console.WriteLine("Duplicate"); 
            }
        }

        static void Problem3() {
            // 3- Write a program and ask the user to enter a time value in 
            //     the 24-hour time format (e.g. 19:00). A valid time should 
            //     be between 00:00 and 23:59. If the time is valid, display 
            //     "Ok"; otherwise, display "Invalid Time". If the user 
            //     doesn't provide any values, consider it as invalid time.
            Console.Write("Please enter a time in 24-hour format: ");
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input)) {
                try {
                    var time = TimeSpan.Parse(input);
                    Console.WriteLine("OK");
                } catch (Exception) {

                    Console.WriteLine("Invalid Time.");
                }
            } else {
                Console.WriteLine("Invalid Time.");
            }
        }

        static void Problem4() {
            // 4- Write a program and ask the user to enter a few words separated 
            //     by a space. Use the words to create a variable name with 
            //     PascalCase. For example, if the user types: "number of students",
            //     display "NumberOfStudents". Make sure that the program is not 
            //     dependent on the input. So, if the user types "NUMBER OF STUDENTS",
            //     the program should still display "NumberOfStudents". 
            Console.Write("Please enter a few words spearated by a space: ");
            var input = Console.ReadLine().Split(' ');
            for(var i = 0; i < input.Length; i++) {
                input[i] = input[i].ToLower();
            }
            var builder = new StringBuilder();
            
            foreach(var str in input) {
                builder.Append(char.ToUpper(str[0]));
                builder.Append(str.Substring(1));
            }

            Console.WriteLine(builder);
        }

        static void Problem5() {
            // 5- Write a program and ask the user to enter an English word.
            //     Count the number of vowels (a, e, o, u, i) in the word. 
            //     So, if the user enters "inadequate", the program should 
            //     display 6 on the console.
            Console.WriteLine("Please enter a line.");
            Console.Write("> ");
            var input = Console.ReadLine();
            var count = 0;

            foreach(var ch in input) {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
