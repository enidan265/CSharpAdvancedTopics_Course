﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Constraints
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable, new()
    {
        public void DoSomething()
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}



