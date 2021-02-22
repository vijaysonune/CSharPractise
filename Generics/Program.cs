using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Number has value? "+number.HasValue);
            Console.WriteLine("Number is " + number.GetValue());
            Console.ReadLine();


        }
    }
}
