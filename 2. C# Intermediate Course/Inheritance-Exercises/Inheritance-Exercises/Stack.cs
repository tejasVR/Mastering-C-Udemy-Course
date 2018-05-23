using System;
using System.Collections;
using System.Collections.Generic;

namespace Inheritance_Exercises
{
    class Stack
    {
        private readonly List<object> _list;

        public void Push(object obj)
        {
            if (obj != null)
            {
                _list.Add(obj);
                Console.WriteLine("{0} has been added to the list", obj);
            }
            else
                throw new InvalidOperationException("Cannot stored object in list");
        }

        public object Pop()
        {
            var lastInList = _list[_list.Count - 1];

            if (_list.Count > 0)
                _list.RemoveAt(0);
            else
                throw new InvalidOperationException("Cannot pop any more objects from the list");

            return lastInList;

        }

        public void Clear()
        {
            _list.Clear();
            Console.WriteLine("The stack has been cleared");
        }
    }
}
