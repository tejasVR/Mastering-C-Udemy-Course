using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 5, 3, 8, 9 };

            // Length

            Console.WriteLine("Length: " + numbers.Length );

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear() <-- sets numbers to zero/false/null

            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Console.WriteLine("Effect of Sort()");
            Array.Sort(numbers);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Console.WriteLine("Effect of Reverse()");
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            Console.WriteLine("Reverse Again!");

            numbers.Reverse();

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
