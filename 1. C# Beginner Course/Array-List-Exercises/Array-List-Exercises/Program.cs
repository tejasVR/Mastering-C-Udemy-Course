using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var friendNames = new List<string>();
            var input = "";

            Console.WriteLine("Enter the name of your friend who liked your post");
            do
            {

                input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    friendNames.Add(input);
                    continue;
                } else
                {
                    break;
                }

            } while (String.IsNullOrWhiteSpace(input));

            if (friendNames.Count == 1)
            {
                Console.WriteLine(friendNames[0] + " likes your post");
            } else if (friendNames.Count == 2)
            {
                Console.WriteLine(friendNames[0] + " and " + friendNames[1] + " likes your post");
            } else if (friendNames.Count > 2)
            {
                Console.WriteLine(friendNames[0] + ", " + friendNames[1] + ", and " + (friendNames.Count - 2) + " likes your post");

            } else
            {
                Console.WriteLine("Sorry, no one likes your post!");
            }
        }
    }
}
