using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,     // automatically set to 0 if undefined
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            //Console.WriteLine((int)method); // casts method enum to an integer

            var methodID = 3;
            //Console.WriteLine((ShippingMethod)methodID); // casts an integer to an enum string

            var methodName = "Express";
            var shippingMethodNoCast = Enum.Parse(typeof(ShippingMethod), methodName);
            var shippingMethodCast = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine("Without Casting: " + shippingMethodNoCast);

            Console.WriteLine("With Casting : " + shippingMethodCast);


        }
    }
}
