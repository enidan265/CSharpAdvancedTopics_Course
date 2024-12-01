using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Models;

namespace Generics;

//List ohne Generic
public class BookList
{
    public void Add(Book book)
    {
        throw new NotImplementedException(); 
    }

    public Book this[int index]
    {
        get { throw new NotImplementedException(); }
    }
}


//List mit Generic
public class GenericList<T>
{
    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public T this[int index] 
    {
        get { throw new NotImplementedException(); }
    }
}

public class GenericDictionary<TKey, TValue>
{
    public void Add(TKey key, TValue value)
    {
        throw new NotImplementedException();
    }
}
