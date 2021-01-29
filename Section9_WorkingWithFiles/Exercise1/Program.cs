using System;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @".\test.txt";
            Console.WriteLine(Problem1(path));
            Console.WriteLine(Problem2(path));
        }

        static int Problem1(string path) {
            // 1- Write a program that reads a text file and 
            // displays the number of words
            if (File.Exists(path)) {
                var content = File.ReadAllText(path);
                return content.Split(' ').Length;
            }
                return 0;
        }

        static string Problem2(string path) {
            // 2- Write a program that reads a text file and 
            // displays the longest word in the file. 
            int longestIndex = 0;
            var max = 0;
            if (File.Exists(path)) {
                var content = File.ReadAllText(path).Split(' ');
                for (var i = 0; i < content.Length; i++) {
                    if (content[i].Length > max) {
                        longestIndex = i;
                        max = content[i].Length;
                    } else 
                        continue;
                }
                return content[longestIndex];
            } else 
                return "";
            
        }
    }
}
