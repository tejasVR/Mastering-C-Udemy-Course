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
            var customer = new Customer(9, "Tejas");

            var order = new Order();
            customer.Orders.Add(order);

        }
    }
}
