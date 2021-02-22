using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Nullable<T> where T: struct
    {
       private object _value;

        public Nullable()
        {

        }
        public Nullable(int value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }
        public T GetValue()
        {
            if(HasValue)
            return (T)_value;
            return default(T);
        }
    }
}
