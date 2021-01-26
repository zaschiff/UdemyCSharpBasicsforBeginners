using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a+b);

            // the following line of code will result in a division of
            // two integers and give an semi-incorrect response. It
            // will drop of the decimal portion of the result
            Console.WriteLine(a/b);

            // to bring back the decimal we need to cast both operands
            // as floats
            Console.WriteLine((float)a / (float)b);

            // operator precedence
            Console.WriteLine(a + b * c);

            // we can change precedence with parenthises ()
            Console.WriteLine((a + b) * c);

            // results of comparison oprators is always a boolean
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine( a != b);
            Console.WriteLine(!(a != b));

            Console.WriteLine( c > b && c > a);
            Console.WriteLine( c > b && c == a);
            Console.WriteLine( c > b || c == a);
            Console.WriteLine(!(c > b || c == a));
        }
    }
}
