using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Constraints
{
    // Wertetypen sind in C# nicht nullable
    // Methode, welche Wertetypen nullable macht #

    // where T : struct 

    public class Nullable<T> where T : struct
    {
        private object _value;
        public bool HasValue
        {
            get { return _value != null; }
        }

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }


        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            else
            {
                return default;
            }
        }
    }
}
