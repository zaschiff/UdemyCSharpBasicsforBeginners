using System;

namespace ReferenceTypes
{
    public class Person {
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3]{1,2,3};
            var array2 = array1;
            array1[0] = 0;
            Console.WriteLine(string.Format("Array1[0] {0}, Array2[0]: {1}", 
                array1[0], array2[0])); */

            var number = 1;
            Console.WriteLine(number);
            Increment(number);
            Console.WriteLine(number);

            var person = new Person();
            person.age = 11;
            Console.WriteLine(person.age);
            MakeOld(person);
            Console.WriteLine(person.age);


        }

        public static void Increment( int number){
            number += 10;
            Console.WriteLine(number);
        }

        public static void MakeOld(Person person) {
            person.age += 10;
            Console.WriteLine(person.age);
        }
    }
}
