using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList(); // boxing happens becuase values are casted into objects
            list.Add(1);
            list.Add("Tejas");

            var anotherList = new List<int>(); // no boxing + type safety creates better software
        }
    }
}
