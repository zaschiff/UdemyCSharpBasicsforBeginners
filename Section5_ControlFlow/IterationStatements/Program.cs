using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment this code block to see a demo on for loops
            /* 
            for(var i = 1; i <= 10; i++) {
                if (i % 2 == 0) 
                    Console.WriteLine(i);
            }

            for (var i = 10; i >= 1; i--) {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
             */

            // Uncomment this code block to see a demo on the
            // foreach loop
            /* 
            var name = "John Smith";
            for(var i = 0; i < name.Length; i++) {
                Console.WriteLine(name[i]);
            }

             foreach (var letter in name) {
                Console.WriteLine(letter);
            }

            var numbers = new int[]{1,2,3,4};

            foreach(var num in numbers) {
                Console.WriteLine(num);
            }
            */

            // uncomment the code to see a demo of a while loop
            /* 
            var i = 0;
            while(i <= 10) {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            } 
            */

            while(true) { // this creates an infiinite loop and will need a break statement
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                
                // if(String.IsNullOrWhiteSpace(input))
                //     break; // this statement breaks the loop and stops loop execution
                // Console.WriteLine("@echo: " + input);

                if(!String.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine("@echo: " + input);
                    continue; // this statment skips to the next iteration of the loop
                }

                break;
            }
             
        }
    }
}
