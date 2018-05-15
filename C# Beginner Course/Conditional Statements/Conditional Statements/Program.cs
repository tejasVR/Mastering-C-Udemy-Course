using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{

    class Program
    {
        //static void ImageCheck()
        //{
        //    var imageWidth = 100;
        //    var imageHeight = 200;

        //    if (imageHeight > imageWidth)
        //    {
        //        Console.WriteLine("The image is a portrait!");
        //    }
        //    else if (imageWidth > imageHeight)
        //    {
        //        Console.WriteLine("The image is a landscape");
        //    } else
        //    {
        //        Console.WriteLine("The image is a square");
        //    }
        //}

        static void Main()
        {
            var carSpeed = 93;
            var speedLimit = 65; 

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("You are under the speed limit");
            } else
            {
                float speedDifference = carSpeed - speedLimit;
                var demeritPoints = Math.Floor(speedDifference / 5);

                if(demeritPoints >= 12)
                {
                    Console.WriteLine("Your liscense has been suspended");
                } else
                {
                    Console.WriteLine("You are speeding on the road! You have incurred " + demeritPoints + " demerit points for speeding!");
                }
            }

        }
    }
}
