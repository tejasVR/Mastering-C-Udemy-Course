using Classes.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            var result = Calculator.Add(2, 3);
            System.Console.WriteLine("Result : " + result);
        }
    }
}
