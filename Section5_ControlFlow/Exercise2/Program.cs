using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment one of the problem methods to see the
            // code run.
            
            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            //Problem5();
        }

        static void Problem1() {
            var count = 0;
            for(var i = 1; i <= 100; i++) {
                if (i % 3 == 0) 
                    count++;
            }
            Console.WriteLine(count);
        }

        static void Problem2() {
            var sum = 0;
            while (true) {
                Console.Write("please enter a number or 'OK' to exit: ");
                var input = Console.ReadLine();
                
                if(input.ToLower() == "ok")
                    break;
                else {
                    var number = Int32.Parse(input);
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }

        static void Problem3() {
            Console.Write("Please enter a number: ");
            var limit = Int32.Parse(Console.ReadLine());
            var factorial = 1;
            for(var i = limit; i > 0; i--) {
                factorial *= i;
            }
            Console.WriteLine(String.Format("{0}! = {1}", limit, factorial));
        }

        static void Problem4() {
            Random r = new Random();
            var ans = r.Next(1, 10);
            Console.WriteLine(ans);
            var tries = 4;
            
            while (true) {
                Console.Write("Please guess the number: ");
                var guess = Int32.Parse(Console.ReadLine());
                tries--;

                if ((guess != ans) && (tries != 0)) {
                    Console.WriteLine("Incorrect Try again");
                    Console.WriteLine(string.Format("You have {0} tries left.", tries));
                } else if ((guess != ans) && (tries == 0)) {
                    Console.WriteLine("You did not guess the magic number sorry.");
                    break;
                } else {
                    Console.WriteLine("Congratulations you guessed the number!");
                    break;
                }
            }
        }

        static void Problem5() {
            Console.Write("Please enter a list of numbers separated by a comma(,): ");
            var separator = new char[] {','};
            var input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[input.Length];
            var max = 0;
            for(var i = 0; i < numbers.Length; i++) {
                numbers[i] = Int32.Parse(input[i]);
            }

            foreach(var num in numbers) {
                if(num > max)
                    max = num;
                else
                    continue;
            }

            Console.WriteLine(max);
        }
    }
}
