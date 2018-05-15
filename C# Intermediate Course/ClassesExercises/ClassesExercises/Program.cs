using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            AskUser();
        }

        public static void AskUser()
        {
            var stopwatch = new StopWatch();
            while (true)
            {
                var input = Console.ReadLine().ToLower().Trim();
                if (String.IsNullOrWhiteSpace(input))
                    Console.WriteLine("Please type 'start' for starting the stopwatch, or 'end' to stop the stopwatch timer");
                else if (input == "start")
                {
                    Console.WriteLine("The stopwatch has started at {0}.", stopwatch.StartTime);
                }
                else if (input == "end")
                {
                    Console.WriteLine("The stopwatch ended at {0}. {1} seconds has elapsed!", stopwatch.EndTime, stopwatch.Result().TotalSeconds);
                }
            }
        }
    }
}
