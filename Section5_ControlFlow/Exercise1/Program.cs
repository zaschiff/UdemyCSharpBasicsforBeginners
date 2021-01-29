using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            //Problem3();
            Problem4();
        }

        static void Problem1(){
            Console.WriteLine("Please enter a number between 1 and 10.");
            byte num = byte.Parse(Console.ReadLine());

            if (num >= 1 && num <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        static void Problem2() {
            Console.WriteLine("Please enter two numbers");
            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine(num1);
            else
                Console.WriteLine(num2);
        }

        static void Problem3() {
            Console.WriteLine("please enter a height and width");
            float height = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());

            if (height > width)
                Console.WriteLine("Image is portrait.");
            else
                Console.WriteLine("Image is landscape.");
        }

        static void Problem4() {
            Console.WriteLine("Enter the speed limit");
            int limit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car.");
            int speed = Int32.Parse(Console.ReadLine());

            if (speed < limit)
                Console.WriteLine("OK");
            else {
                const int kmDemeritPoint = 5;
                int points = (speed - limit) / kmDemeritPoint;
                if (points > 12)
                    Console.WriteLine("License Suspended.");
                else
                    Console.WriteLine(string.Format("You have {0} points.", points));
            }
        }
    }
}
