using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncating
{


    class Program
    {
        static void Main(string[] args)
        {
            /* Downcasting
            Shape shape = new Text();
            Text text = (Text)shape;
            text.FontName = "Google Font Name";
            */


            /* Upcasting
            StreamReader reader = new StreamReader(new MemoryStream());

            var list = new ArrayList();
            list.Add("we can pass any object here");

            var anotherList = new List<Text>();


            Text text = new Text();
            Shape shape = text;

            // Both text and shape are referneces to the same object in memory
            text.Width = 200; 
            shape.Width = 100;

            Console.WriteLine(text.Width);
            */
            

        }
    }
}
