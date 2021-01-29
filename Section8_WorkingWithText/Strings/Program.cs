using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Zach Schiff ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullName.Split(' ');
            foreach(var i in names)
                Console.WriteLine(i);

            Console.WriteLine(fullName.Replace("Zach", "Zachary"));

            if(String.IsNullOrEmpty(" ")) {
                Console.WriteLine("Invalid");
            }

            if(string.IsNullOrWhiteSpace(" ")) {
                Console.WriteLine("This is a space");
            }
        }
    }
}
