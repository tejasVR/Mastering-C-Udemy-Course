﻿using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotFiniteNumberException();
        }

        public Book this[int index]
        {
            get { throw new NotFiniteNumberException();  }
        }
    }

    public class ObjectList
    {
        public void Add(object value)
        {

        }

        public object this[int index]
        {
            get { throw new NotFiniteNumberException();  }
        }
    }
}
