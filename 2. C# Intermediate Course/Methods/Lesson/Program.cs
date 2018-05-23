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
            //var number = int.Parse("abc");  Does not throw an exception

            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
            
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 4));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));

                Console.WriteLine("point is at ({0}, {1})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("point is at ({0}, {1})", point.x, point.y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
