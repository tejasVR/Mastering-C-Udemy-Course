using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 6, 7, 8 });

            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            var index = numbers.IndexOf(1);
            var indexLast = numbers.LastIndexOf(1);

            Console.WriteLine("The index of 1: " + index);
            Console.WriteLine("Last index of 1: " + indexLast);

            Console.WriteLine("Count: " + numbers.Count);

            numbers.Remove(1); //only removes the first occurence of the item 

        }
    }
}
