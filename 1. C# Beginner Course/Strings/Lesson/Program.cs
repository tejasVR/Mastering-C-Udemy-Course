using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Tejas Shroff ";
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'", fullName.ToUpper());
            Console.WriteLine("ToLower : '{0}'", fullName.ToLower());
            Console.WriteLine("First-Last : '{0}'", fullName.ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToInt32(str);

            float price = 29.95f;
            price.ToString(); // "29.95"
            price.ToString("C"); // "$29.95"
            price.ToString("C0"); // $30
        }
    }
}
