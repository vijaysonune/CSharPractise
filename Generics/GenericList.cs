using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericList<T>
    {
        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
