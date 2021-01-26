using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);

            var number = "1234";
            int i2 = Convert.ToInt32(number);
            Console.WriteLine(i2);

            try
            {
                var number2 = "1234";
                byte b2 = Convert.ToByte(number2);
                Console.WriteLine(b2);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool b3 = Convert.ToBoolean(str);
                Console.WriteLine(b3);
            }
            catch (System.Exception)
            {
                Console.WriteLine("String could not be converted to bool.");
            }
        }
    }
}
