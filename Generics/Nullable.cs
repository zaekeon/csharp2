using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }
        public bool HasValue
        {
            get { return _value != null; }  // return whatever this expression evaluates to.
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);  //if the value doesn't exist then we use the default operator to return whatever the default for that type is.
        }
    }
}
