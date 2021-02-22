using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class BookList
    {
        public void Add(Book book)
        {

        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    class Book : Product
    {
        public Book(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public int Id  { get; set; }

        public string Name  { get; set; }
        public int productType { get; set; }
    }

}
