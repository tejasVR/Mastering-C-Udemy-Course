using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loops

            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Foreach Loops

            //var name = "John Smith";

            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            // While Loops

            //while (true)
            //{
            //    Console.Write("Type your name: "); // writes on the same line (not line break)
            //    var input = Console.ReadLine();

            //    if (!string.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }

            //    break;

            //}

            //var random = new Random();

            //const int passwordLength = 10;

            //var buffer = new char[passwordLength];

            //for(int i = 0; i < passwordLength; i++)
            //{
            //    buffer[i] = (char)random.Next((int)'a', (int)'z')); // picks a number between 97 and 122, and casts that to a character format via ASCII

            //var password = new string(buffer);

            //Console.WriteLine(password);

            // Examples

            //var number = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%3 == 0)
            //    {
            //        number++;
            //    }
            //}

            //Console.WriteLine("There are " + number +" numbers that are divisible by 3 from 1 to 100");

            Console.WriteLine("Please enter some numbers, seperated by commas");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var maxNum = Convert.ToInt32(numbers[0]);

            foreach(var number in numbers)
            {
                if (maxNum < Convert.ToInt32(number))
                {
                    maxNum = Convert.ToInt32(number);
                }
            }

            Console.WriteLine("The maximum number you entered was " + maxNum);

            }

        }
    }

